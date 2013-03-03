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
using System.Net;
using NLog;
using Newtonsoft.Json.Linq;

namespace inBloomApiLibrary
{
	/// <summary>
	/// API Client used for executing API requests and getting the response
	/// </summary>
	public static class ApiClient
	{
		private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

		#region Private Helper Methods

		private static ExtendedWebClient GetExtendedWebClient(string accessToken, RequestType requestType)
		{
			var restClient = new ExtendedWebClient();

			string bearerToken = string.Format("bearer {0}", accessToken);

			restClient.Headers.Add("Authorization", bearerToken);

			if (requestType == RequestType.Xml)
			{
				restClient.Headers.Add("Content-Type", "application/vnd.slc+json");
				restClient.Headers.Add("Accept", "application/vnd.slc+xml");
			}
			else
			{
				restClient.Headers.Add("Content-Type", "application/vnd.slc+json");
				restClient.Headers.Add("Accept", "application/vnd.slc+json");
			}

			return restClient;
		}

		private static ApiResponse GetApiResponse(string response, RequestType requestType, HttpStatusCode statusCode)
		{
			var apiResponse = new ApiResponse();

			// If result doesn't come back as an array, let's make it an array for JArray
			if (response.StartsWith("{"))
				response = String.Format("[{0}]", response);

			if (response != string.Empty)
			{
				switch (requestType)
				{
					case RequestType.JsonObject:
						JArray jsonResponse = JArray.Parse(response);
						apiResponse.ResponseObject = jsonResponse;
						break;

					case RequestType.Json:
					case RequestType.Xml:
						apiResponse.ResponseString = response;
						break;
				}
			}

			apiResponse.StatusCode = statusCode;

			return apiResponse;
		}

		#endregion

		#region Request/Post Methods

		/// <summary>
		/// Executes a request against the API and gets the result as a JSON
		/// </summary>
		public static ApiResponse Request(string apiEndpoint, string accessToken, RequestType requestType = RequestType.JsonObject)
		{
			try
			{
				var restClient = GetExtendedWebClient(accessToken, requestType);
				string response = restClient.DownloadString(apiEndpoint);
				return GetApiResponse(response, requestType, restClient.StatusCode);
			}
			catch (Exception ex)
			{
				_logger.WarnException("Error requesting API Endpoint: " + apiEndpoint, ex);
				throw;
			}
		}

		/// <summary>
		/// Executes a POST against the inBloom API
		/// </summary>
		public static ApiResponse Post(string apiEndpoint, string accessToken, string data, RequestType requestType = RequestType.JsonObject)
		{
			try
			{
				var restClient = GetExtendedWebClient(accessToken, requestType);
				string response = restClient.UploadString(apiEndpoint, "POST", data);
				return GetApiResponse(response, requestType, restClient.StatusCode);
			}
			catch (Exception ex)
			{
				_logger.WarnException("Error posting to API Endpoint: " + apiEndpoint, ex);
				throw;
			}
		}

		#endregion
	}
}