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
	public class GetParentsData : ServiceBase
	{
		/// <summary>
		///     Gets parents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetParents(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets parents details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="parentsId"></param>
		/// <returns></returns>
		public JArray GetParentById(string accessToken, string parentsId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}", parentsId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets parents custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="parentsId"></param>
		/// <returns></returns>
		public JArray GetParentCustom(string accessToken, string parentsId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}/custom", parentsId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets student parent associations within the parents.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="parentsId"></param>
		/// <returns></returns>
		public JArray GetParentStudentParentAssociations(string accessToken, string parentsId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}/studentParentAssociations", parentsId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets student details in student parent associations within the parents.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="parentsId"></param>
		/// <returns></returns>
		public JArray GetParentStudentParentAssociationStudents(string accessToken, string parentsId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}/studentParentAssociations/students", parentsId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region Create/Update/Delete

		/// <summary>
		///     Creates parents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostParents(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates parents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutParents(string accessToken, string data, string parentId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}/custom", parentId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes parents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteParents(string accessToken, string parentId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/parents/{0}", parentId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}