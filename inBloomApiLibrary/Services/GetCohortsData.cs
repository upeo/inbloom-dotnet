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
	/// <summary>
	/// Cohorts Service
	/// </summary>
	public class GetCohortsData : ServiceBase
	{
		/// <summary>
		/// Gets cohorts details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetCohorts(string accessToken)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets cohorts custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortCustom(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/custom", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets cohorts by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortById(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets staff cohort associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortStaffCohortAssociations(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/staffCohortAssociations", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets staff details within the staff cohort associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortStaffCohortAssociationStaff(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/staffCohortAssociations/staff", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets student cohort associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortStudentCohortAssociations(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/studentCohortAssociations", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets student details within the student cohort associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public JArray GetCohortStudentCohortAssociationStudents(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/studentCohortAssociations/students", cohortsId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Creates cohorts details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostCohorts(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Updates cohorts details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public string PutCohorts(string accessToken, string data, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}/custom", cohortsId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Deletes cohorts details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="cohortsId"></param>
		/// <returns></returns>
		public string DeleteCohorts(string accessToken, string cohortsId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/cohorts/{0}", cohortsId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}
	}
}
