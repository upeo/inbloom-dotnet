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
	public class GetGradesData : ServiceBase
	{
		#region Get Methods

		/// <summary>
		///     Gets Grade Book Entries details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetGradeBookEntries(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets Grade Book Entries details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradeBookEntrieById(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries/{0}", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets Grade Book Entries custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradeBookEntrieCustom(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries/{0}/custom", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates Grade Book Entries  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public string PostGradebookEntries(string accessToken, string Data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		///     Updates Grade Book Entries  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public string PutGradebookEntries(string accessToken, string Data, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries/{0}/custom", gradeId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		///     Deletes Grade Book Entries  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public string DeleteGradebookEntries(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradebookEntries/{0}", gradeId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		/// <summary>
		///     Gets Grade details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetGrades(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/grades");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grade custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradeCustom(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/grades/{0}/custom", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grading period details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetGradingPeriods(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grades within the grading periods.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradingPeriodGrades(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}/grades", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets report cards within the grading periods.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradingPeriodReportCards(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}/reportCards", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grading periods by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradingPeriodById(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grading periods custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="gradeId"></param>
		/// <returns></returns>
		public JArray GetGradingPeriodCustom(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}/custom", gradeId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods gradingPeriods

		public string PostGradingPeriods(string accessToken, string Data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, Data);
		}

		public string PutGradingPeriods(string accessToken, string Data, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}/custom", gradeId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, Data);
		}


		public string DeleteGradingPeriods(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/gradingPeriods/{0}", gradeId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods grades

		/// <summary>
		///     Creates Grade details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostGrades(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/grades");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates Grade details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutGrades(string accessToken, string data, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/grades/{0}/custom", gradeId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes Grade details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteGrades(string accessToken, string gradeId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/grades/{0}", gradeId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}