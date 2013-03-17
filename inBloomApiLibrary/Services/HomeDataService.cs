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
using Newtonsoft.Json.Linq;

namespace inBloomApiLibrary
{
	public class HomeDataService : ServiceBase
	{
		/// <summary>
		///     Gets Home links
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetHome(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/home");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     this function is used to logout the user
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string LogOut(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.ApiUrl + "/rest/system/session/logout");
			return ApiHelper.CallApiWithParameter(accessToken, apiEndPoint);
		}
	}
}
