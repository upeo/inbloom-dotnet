﻿/*
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
	public class GetSessionsData : ServiceBase
	{
		#region Retrieve Methods

		/// <summary>
		///     Gets sessions details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetSessions(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets sessions custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		public JArray GetSessionCustom(string accessToken, string userId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}/custom", userId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets sessions details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public JArray GetSessionById(string accessToken, string sessionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}", sessionId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets course offerings within the sessions.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public JArray GetSessionCourseOfferings(string accessToken, string sessionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}/courseOfferings", sessionId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets courses in course offerings within the sessions.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public JArray GetSessionCourseOfferingCourses(string accessToken, string sessionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}/courseOfferings/courses", sessionId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates Sessions
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostSessions(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates sesstions
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public string PutSessions(string accessToken, string data, string sessionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}/custom", sessionId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes sessions
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public string DeleteSessions(string accessToken, string sessionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sessions/{0}", sessionId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}