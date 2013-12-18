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
using System.Threading.Tasks;

namespace inBloomApiLibrary
{
	public class SectionDataService : ServiceBase
    {

        #region Syncronous GET Methods

        /// <summary>
		///     Gets sections details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="userId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSections(string accessToken, string userId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections", userId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets section custom details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionCustom(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/custom", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets section  details by id.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionById(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets Student section associations details within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionStudentAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

        /// <summary>
        ///     Gets students details in student section associations within the sections.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <returns></returns>
        public JArray GetSectionStudentAssociationStudentList(string accessToken, string sectionId)
        {
            string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations/students", sectionId);
            return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
        }

        /// <summary>
        ///      Gets students details in student section associations within the sections.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <param name="limit">Max number of sections to return(optional)</param>
        /// <param name="offset">Starting position of result set(optional)</param>
        /// <param name="views">View name (optional)</param>
        /// <returns></returns>
        public JArray GetSectionStudentAssociationStudentList(string accessToken, string sectionId, int? limit, int? offset, string views)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations/students", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            if (!string.IsNullOrEmpty(views)) { apiEndPoint = apiEndPoint.AddQuery("views", views); }
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
        }

        
        /// <summary>
		///     Gets teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets teachers in teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociationTeacherList(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations/teachers", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

        #endregion

        #region Asyncronous GET Methods


        /// <summary>
        ///     Gets sections details asyncronously.
        /// </summary>
        /// <param name="accessToken">Access token has to send</param>
        /// <param name="userId">User id  has to send</param>
        /// <returns>Gets Sections Data</returns>
        public async Task<JArray> GetSectionsAsync(string accessToken, string userId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections", userId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }


        /// <summary>
        ///     Gets section custom details asyncronously.
        /// </summary>
        /// <param name="accessToken">Access token has to send</param>
        /// <param name="sectionId">User id  has to send</param>
        /// <returns>Gets Sections Data</returns>
        public async Task<JArray> GetSectionCustomAsync(string accessToken, string sectionId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/custom", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }


        /// <summary>
        ///     Gets section  details by id.
        /// </summary>
        /// <param name="accessToken">Access token has to send</param>
        /// <param name="sectionId">User id  has to send</param>
        /// <returns>Gets Sections Data</returns>
        public async Task<JArray> GetSectionByIdAsync(string accessToken, string sectionId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }




        /// <summary>
        ///     Gets Student section associations details within the sections.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <returns></returns>
        public async Task<JArray> GetSectionStudentAssociationsAsync(string accessToken, string sectionId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }



        /// <summary>
        ///     Gets teacher section associations within the sections.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <returns></returns>
        public async Task<JArray> GetSectionTeacherAssociationsAsync(string accessToken, string sectionId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken));
        }

        
        /// <summary>
        ///     Gets students details in student section associations within the sections asynchronously.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <param name="limit">Max number of sections to return(optional)</param>
        /// <param name="offset">Starting position of result set(optional)</param>
        /// <param name="views">View name (optional)</param>
        /// <returns></returns>
        public async Task<JArray> GetSectionStudentAssociationStudentListAsync(string accessToken, string sectionId, int? limit, int? offset, string views)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations/students", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            if (!string.IsNullOrEmpty(views)) { apiEndPoint = apiEndPoint.AddQuery("views", views); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }


        /// <summary>
        ///     Gets teachers in teacher section associations within the sections.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sectionId"></param>
        /// <param name="limit">Max number of sections to return(optional)</param>
        /// <param name="offset">Starting position of result set(optional)</param>
        /// <returns></returns>
        public async Task<JArray> GetSectionTeacherAssociationTeacherListAsync(string accessToken, string sectionId, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations/teachers", sectionId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return (await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken));
        }



        #endregion

        #region Create/Update/Delete Methods

        /// <summary>
		///     Creates sections details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostSections(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
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
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/custom", sectionId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes sectins details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public string DeleteSections(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}", sectionId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}