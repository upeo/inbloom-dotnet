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
	public class AttendanceDataService : ServiceBase
	{
		/// <summary>
		///     Gets Student Attendance Details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetAttendances(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/attendances");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets Student Attendance Custom Details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="attendanceId"></param>
		/// <returns></returns>
		public JArray GetAttendanceCustom(string accessToken, string attendanceId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/attendances/{0}/custom", attendanceId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Creates Student Attendance Details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostAttendance(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/attendances");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates Student Attendance Details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutAttendance(string accessToken, string data, string attendanceId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/attendances/{0}/custom", attendanceId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes Student Attendance Details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteAttendance(string accessToken, string attendanceId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/attendances/{0}/custom", attendanceId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}
	}
}