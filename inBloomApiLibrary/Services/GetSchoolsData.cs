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
	public class GetSchoolsData : ServiceBase
	{
		/// <summary>
		///     Gets schools details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetSchools(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets schools custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolCustom(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/custom", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets sections within the schools.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolSections(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/sections", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student school associations within the schools.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolStudentSchoolAssociations(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/studentSchoolAssociations", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students in student school associations within the schools.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolStudentSchoolAssociationStudents(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/studentSchoolAssociations/students", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets teacher school associations within the schools.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolTeacherSchoolAssociations(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/teacherSchoolAssociations", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets teachers in teacher school associations within the schools.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public JArray GetSchoolTeacherSchoolAssociationTeachers(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/teacherSchoolAssociations/teachers", schoolId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates Schools details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostSchools(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates Schools details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="Data"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public string PutSchools(string accessToken, string Data, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}/custom", schoolId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		///     Deletes Schools details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="schoolId"></param>
		/// <returns></returns>
		public string DeleteSchools(string accessToken, string schoolId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/schools/{0}", schoolId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}