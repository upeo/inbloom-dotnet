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
	public class GetEducationOrganizationsData : ServiceBase
	{
		#region Read Methods

		/// <summary>
		/// Gets education organizations details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetEducationOrganizations(string accessToken)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets education organizations by id
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public JArray GetEducationOrganizationById(string accessToken, string educationId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}", educationId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets staff Education Organization Assignment Associations within the education organizations
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public JArray GetEducationOrganizationStaffEducationOrganizationAssociations(string accessToken, string educationId)
		{
			var apiEndPoint =
				String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}/staffEducationOrgAssignmentAssociations",
							  educationId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///  Gets staff details in staff Education Organization Assignment Associations within the education organizations
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public JArray GetEducationOrganizationStaffEducationOrganizationAssociationByStaff(string accessToken,
																						   string educationId)
		{
			var apiEndPoint =
				String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}/staffEducationOrgAssignmentAssociations/staff",
							  educationId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		/// Gets education organizations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public JArray GetEducationOrganizationCustom(string accessToken, string educationId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}/custom", educationId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		/// Creates education organizations  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public string PostEducationOrganizations(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Updates education organizations  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public string PutEducationOrganizations(string accessToken, string data, string educationId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}/custom", educationId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Deletes education organizations  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="educationId"></param>
		/// <returns></returns>
		public string DeleteEducationOrganizations(string accessToken, string educationId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/educationOrganizations/{0}", educationId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}
