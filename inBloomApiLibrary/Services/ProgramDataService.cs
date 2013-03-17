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
	public class ProgramDataService : ServiceBase
	{
		/// <summary>
		///     Gets program details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetPrograms(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets programs details by id
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramById(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets program custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramCustom(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/custom", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets staff program associations within the programs.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramStaffProgramAssociations(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/staffProgramAssociations", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student details in staff program associations within the programs.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramStaffProgramAssociationStaff(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/staffProgramAssociations/staff", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student program associations within the programs.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramStudentProgramAssociations(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/studentProgramAssociations", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students details in student program associations within the programs.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="programId"></param>
		/// <returns></returns>
		public JArray GetProgramStudentProgramAssociationStudents(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/studentProgramAssociations/students", programId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates program details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostPrograms(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates program details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutPrograms(string accessToken, string data, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}/custom", programId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes program details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeletePrograms(string accessToken, string programId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/programs/{0}", programId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}