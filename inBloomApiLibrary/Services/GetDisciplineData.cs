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
	public class GetDisciplineData : ServiceBase
	{
		#region disciplineActions CRUD

		/// <summary>
		/// Creates discipline action  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public string PostDisciplineActions(string accessToken, string Data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		/// Gets discipline actions details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetDisciplineActions(string accessToken)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets descipline action details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineActionById(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions/{0}", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets discipline action custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineActionCustom(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions/{0}/custom", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Updates discipline action  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public string PutDisciplineActions(string accessToken, string Data, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions/{0}/custom", disciplineId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		/// Deletes discipline action  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public string DeleteDisciplineActions(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineActions/{0}", disciplineId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region disciplineIncidents CRUD

		/// <summary>
		/// Creates discipline incidents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostDisciplineIncidents(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Gets discipline incidents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetDisciplineIncidents(string accessToken)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///  Gets discipline incidents details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineIncidentById(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///  Gets discipline incident custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineIncidentCustom(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}/custom", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets student discipline incident associations within the  discipline incidents.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineIncidentStudentDisciplineIncidentAssociations(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}/studentDisciplineIncidentAssociations", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets students details in student discipline incident associations within the discipline incidents.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="disciplineId"></param>
		/// <returns></returns>
		public JArray GetDisciplineIncidentStudentDisciplineIncidentAssociationStudents(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}/studentDisciplineIncidentAssociations/students", disciplineId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Updates discipline incidents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutDisciplineIncidents(string accessToken, string data, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}/custom", disciplineId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Deletes discipline incidents details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteDisciplineIncidents(string accessToken, string disciplineId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/disciplineIncidents/{0}", disciplineId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}
