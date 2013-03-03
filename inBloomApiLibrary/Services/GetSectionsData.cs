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
	public class GetSectionsData : ServiceBase
	{
		/// <summary>
		///     Gets sections details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="userId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSections(string accessToken, string userId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections", userId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets section custom details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionCustom(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/custom", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets section  details by id.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionById(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets Student section associations details within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionStudentAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/studentSectionAssociations", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets students details in student section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionStudentAssociationStudentList(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/studentSectionAssociations/students", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/teacherSectionAssociations", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teachers in teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociationTeacherList(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/teacherSectionAssociations/teachers", sectionId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates sections details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostSections(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Update sections details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public string PutSections(string accessToken, string data, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}/custom", sectionId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes sectins details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public string DeleteSections(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/sections/{0}", sectionId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}