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
	///     Competency Level Descriptor Service
	/// </summary>
	public class CompetencyLevelDescriptorDataService : ServiceBase
	{
		#region CompetencyLevelDescriptorTypes CRUD

		/// <summary>
		///     Creates competency level descriptor types  details.
		/// </summary>
		public string PostCompetencyLevelDescriptorTypes(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Gets competency level descriptor types.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptorTypes(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets competency level descriptor types by id.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <param name="competencyId"></param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptorTypeById(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes/{0}", competencyId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets competency level descriptor types custom details.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <param name="competencyId"></param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptorTypeCustom(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes/{0}/custom", competencyId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Updates competency level descriptor types  details.
		/// </summary>
		public string PutCompetencyLevelDescriptorTypes(string accessToken, string data, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes/{0}/custom", competencyId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes competency level descriptor types details.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <param name="competencyId"></param>
		/// <returns></returns>
		public string DeleteCompetencyLevelDescriptorTypes(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptorTypes/{0}", competencyId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region CompetencyLevelDescriptor CRUD

		/// <summary>
		///     Creates competency level descriptor details.
		/// </summary>
		/// <param name="accessToken">Access token given by the athentication</param>
		/// <returns></returns>
		public string PostCompetencyLevelDescriptor(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Gets competency level descriptor details.
		/// </summary>
		/// <param name="accessToken">Access token given by the athentication</param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptor(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets competency level descriptor by id.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <param name="competencyId">Competency id</param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptorById(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor/{0}", competencyId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets competency level descriptor custom details.
		/// </summary>
		/// <param name="accessToken">Access Token Given by the athentication</param>
		/// <param name="competencyId">competency id</param>
		/// <returns></returns>
		public JArray GetCompetencyLevelDescriptorCustom(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor/{0}/custom", competencyId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Updates competency level descriptor details.
		/// </summary>
		/// <param name="accessToken">Access token given by the athentication</param>
		/// <returns></returns>
		public string PutCompetencyLevelDescriptor(string accessToken, string data, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor/{0}/custom", competencyId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes competency level descriptor details.
		/// </summary>
		/// <param name="accessToken">Access token given by the athentication</param>
		/// <returns></returns>
		public string DeleteCompetencyLevelDescriptor(string accessToken, string competencyId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/competencyLevelDescriptor/{0}", competencyId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}