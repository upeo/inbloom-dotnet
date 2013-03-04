/*
 * Copyright 2013 Upeo, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this software except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Configuration;
using System.Net;
using NLog;
using Newtonsoft.Json.Linq;

namespace inBloomApiLibrary
{
	/// <summary>
	/// OAuth Functionality
	/// </summary>
	public class OAuth
	{
		private readonly CommonData _commonData = new CommonData();
		private readonly Logger _logger = LogManager.GetCurrentClassLogger();

		#region inBloom API Settings

		private string _clientId = ConfigurationManager.AppSettings.Get("inBloomApiClientId");
		private string _clientSecret = ConfigurationManager.AppSettings.Get("inBloomApiClientSecret");
		private string _redirectUrl = ConfigurationManager.AppSettings.Get("inBloomApiRedirectUrl");

		#endregion

		#region Helper Methods to change inBloom API Settings

		/// <summary>
		/// Set the client ID
		/// </summary>
		/// <param name="clientId"></param>
		public void SetClientId(string clientId)
		{
			_clientId = clientId;
		}

		/// <summary>
		/// Set the client secret
		/// </summary>
		/// <param name="clientSecret"></param>
		public void SetClientSecret(string clientSecret)
		{
			_clientSecret = clientSecret;
		}

		/// <summary>
		/// Set the redirect URL
		/// </summary>
		/// <param name="redirectUrl"></param>
		public void SetRedirectUrl(string redirectUrl)
		{
			_redirectUrl = redirectUrl;
		}

		#endregion

		#region OAuth Data Accessors

		public string AccessToken { get; private set; }
		public string UserFullName { get; private set; }
		public string UserSLIRoles { get; private set; }
		public string UserId { get; private set; }

		#endregion

		/// <summary>
		/// Gets the URL to which users should be redirected for login
		/// </summary>
		public string GetAuthorizationUrl()
		{
			return string.Format(_commonData.ApiUrl + "/oauth/authorize?client_id={0}&redirect_uri={1}", _clientId, _redirectUrl);
		}

		/// <summary>
		/// This function is used to check authentication of the user and gives access to api's.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="code"></param>
		/// <returns></returns>
		public string CallAuthorization(string accessToken, string code)
		{
			// We already have an access token in session
			if (!string.IsNullOrEmpty(accessToken))
				return "OAuthSuccess";

			// We get a code back from the first leg of OAuth process.  If we don't have one, let's get it.
			// Here the user will log into the SLC.  This page will be called back with the code to do second leg of OAuth.
			if (string.IsNullOrEmpty(code))
				return GetAuthorizationUrl();

			try
			{
				// Construct API call to validate code
				string sessionUrl = string.Format(_commonData.ApiUrl + "/oauth/token?client_id={0}&client_secret={1}&grant_type=authorization_code&redirect_uri={2}&code={3}", _clientId, _clientSecret, _redirectUrl, code);

				// Initialise REST Client
				var restClient = new WebClient();
				restClient.Headers.Add("Content-Type", "application/vnd.slc+json");
				restClient.Headers.Add("Accept", "application/vnd.slc+json");

				// Call authorization endpoint
				string result = restClient.DownloadString(sessionUrl);

				// Convert response into a JSON object
				var response = JObject.Parse(result);
				var accessToken1 = (string)response["access_token"];

				// If we have a valid token, it'll be 38 chars long.  Let's add it to session if so.
				if (accessToken1.Length == 38)
				{
					// Session.Add("access_token", access_token);
					AccessToken = accessToken1;

					var apiEndPoint = _commonData.ApiUrl + "/rest/system/session/check";
					var request = ApiClient.Request(apiEndPoint, AccessToken, RequestType.JsonObject);

					if (request.ResponseObject != null)
					{
						JArray userInfo = request.ResponseObject;
						if (userInfo.Count == 1)
						{
							UserFullName = userInfo[0]["full_name"].ToString();
							UserSLIRoles = userInfo[0]["sliRoles"].ToString();
						}
					}

					apiEndPoint = _commonData.ApiUrl + "/rest/v1.1/home";
					request = ApiClient.Request(apiEndPoint, AccessToken, RequestType.JsonObject);

					if (request.ResponseObject != null)
					{
						JArray userInfo = request.ResponseObject;

						foreach (JObject obj in (JArray)userInfo[0]["links"])
						{
							if ((string)obj["rel"] == "self")
							{
								var link = (string)obj["href"];
								var id = link.Substring(link.Length - 43);

								UserId = id;
							}
						}
					}

					// Redirect to app main page.
					return "OAuthSuccess";
				}
			}
			catch (Exception ex)
			{
				_logger.ErrorException("Error doing OAuth login: " + ex.Message, ex);
				throw;
			}

			return null;
		}
	}
}
