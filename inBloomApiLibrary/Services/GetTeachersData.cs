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
	public class GetTeachersData : ServiceBase
	{
		#region Teachers

		/// <summary>
		///     Gets teachers details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetTeachers(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teachers custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherCustom(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/custom", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher school associations within the teachers.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherTeacherSchoolAssociations(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/teacherSchoolAssociations", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets schools in teacher school associations within the teachers.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherTeacherSchoolAssociationSchools(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/teacherSchoolAssociations/schools", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher section associations within the teachers.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherTeacherSectionAssociations(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/teacherSectionAssociations", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets sections in teacher section associations within the teachers.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherTeacherSectionAssociationSections(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/teacherSectionAssociations/sections", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates teachers Details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public string PostTeachers(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates teachers Details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public string PutTeachers(string accessToken, string data, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}/custom", teacherId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes teachers Details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public string DeleteTeachers(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teachers/{0}", teacherId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region teacherSchoolAssociations

		/// <summary>
		///     Gets teacher school associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetTeacherSchoolAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher school associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSchoolAssociationCustom(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}/custom", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher school associations by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSchoolAssociationById(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets schools within the teacher school associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSchoolAssociationSchools(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}/schools", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teachers within the teacher school associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSchoolAssociationTeachers(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}/teachers", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates teacher school associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostTeacherSchoolAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates teacher school associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutTeacherSchoolAssociations(string accessToken, string data, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}/custom", teacherId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes teacher school associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteTeacherSchoolAssociations(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSchoolAssociations/{0}", teacherId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region teacherSectionAssociations

		/// <summary>
		///     Gets teacher section associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetTeacherSectionAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher section associations custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSectionAssociationCustom(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}/custom", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teacher section associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSectionAssociationById(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets sections within the teacher section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSectionAssociationSections(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}/sections", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets teachers within the teacher section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public JArray GetTeacherSectionAssociationTeachers(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}/teachers", teacherId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates teacher section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PostTeacherSectionAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates teacher section associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string PutTeacherSectionAssociations(string accessToken, string data, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}/custom", teacherId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes teacher section associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public string DeleteTeacherSectionAssociations(string accessToken, string teacherId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/teacherSectionAssociations/{0}", teacherId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion
	}
}