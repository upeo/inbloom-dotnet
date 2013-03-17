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
	public class StaffDataService : ServiceBase
	{
		/// <summary>
		///     Gets staff details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStaff(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffCustom(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/custom", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff cohort associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffCohortAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffCohortAssociations", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets cohorts in staff cohort associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffCohortAssociationCohorts(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffCohortAssociations/cohorts", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff education organization assignment associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffEducationOrganizationAssignmentAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffEducationOrgAssignmentAssociations", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets education organizations in staff education organization assignment associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffEducationOrganizationAssignmentAssociationEducationOrganizations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffEducationOrgAssignmentAssociations/educationOrganizations", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffProgramAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffProgramAssociations", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets programs in staff program associations within the staff.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffStaffProgramAssociationPrograms(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/staffProgramAssociations/programs", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStaffCohortAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff cohort associations custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffCohortAssociationCustom(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff cohort associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffCohortAssociationById(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets cohorts details within the staff cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffCohortAssociationCohorts(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}/cohorts", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff details within the staff cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffCohortAssociationStaff(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}/staff", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff education organization assignment associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStaffEducationOrganizationAssignmentAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff education organization assignment associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffEducationOrganizationAssignmentAssociationCustom(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff education organization assignment associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffEducationOrganizationAssignmentAssociationById(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets education organizations within the staff education organization assignment associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffEducationOrganizationAssignmentAssociationEducationOrganizations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}/educationOrganizations", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff details within the staff education organization assignment associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffEducationOrganizationAssignmentAssociationStaff(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}/staff", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociationCustom(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations details by program id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociationByProgramId(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociationById(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets programs within the staff program associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociationPrograms(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}/programs", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff within the staff program associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public JArray GetStaffProgramAssociationStaff(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}/staff", staffId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates staff program associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStaffProgramAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  staff program associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string PutStaffProgramAssociations(string accessToken, string data, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  staff program associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string DeleteStaffProgramAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffProgramAssociations/{0}", staffId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates staff Education Organization Assignment Associations dettails.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStaffEducationOrgAssignmentAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates staff Education Organization Assignment Associations dettails.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string PutStaffEducationOrgAssignmentAssociations(string accessToken, string data, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes staff Education Organization Assignment Associations dettails.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string DeleteStaffEducationOrgAssignmentAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffEducationOrgAssignmentAssociations/{0}", staffId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates  staff Cohort Associations details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStaffCohortAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates staff Cohort Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string PutStaffCohortAssociations(string accessToken, string data, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}/custom", staffId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes staff Cohort Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="staffId"></param>
		/// <returns></returns>
		public string DeleteStaffCohortAssociations(string accessToken, string staffId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staffCohortAssociations/{0}", staffId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates staff details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStaff(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates Staff Details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public string Putstaff(string accessToken, string data, string sessionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}/custom", sessionId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes staff details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sessionId"></param>
		/// <returns></returns>
		public string Deletestaff(string accessToken, string sessionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/staff/{0}", sessionId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}