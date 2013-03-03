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
	/// Course Data Service
	/// </summary>
	public class GetCoursesData : ServiceBase
	{
		#region courseOfferings CRUD

		/// <summary>
		///  Creates course offerings  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostCourseOfferings(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Gets courses offerings details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetCourseOfferings(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets course offering by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseOfferingId"></param>
		/// <returns></returns>
		public JArray GetCourseOfferingById(string accessToken, string courseOfferingId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}", courseOfferingId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///  Gets course offerings within the courses  
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseIdCourseOfferings(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/courseOfferings", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets courses within the course offerings.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseOfferingCourses(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}/courses", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets sessions within the course offerings.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseOfferingSessions(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}/sessions", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets course offerings custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseOfferingCustom(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}/custom", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///  Updates course offerings  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public string PutCourseOfferings(string accessToken, string data, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}/custom", courseId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///  Deletes course offerings  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public string DeleteCourseOfferings(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseOfferings/{0}", courseId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		/// <summary>
		/// Gets course details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetCourses(string accessToken)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets sesstions details in course offerings within the course.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseIdCourseOfferingSessions(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/courseOfferings/sessions", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///  Gets course transcripts within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscripts(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/courseTranscripts", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets students details in course transcripts within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscriptStudents(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/courseTranscripts/students", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets student parent associations within the course.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseStudentParentAssociations(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/studentParentAssociations", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets students details in student parent associations within the course.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseStudentParentAssociationStudents(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/studentParentAssociations/students", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		#region courses CRUD

		public string PostCourses(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		/// Gets course custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCustom(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/custom", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		/// Gets course custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseById(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		public string PutCourses(string accessToken, string data, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}/custom", courseId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		public string DeleteCourses(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courses/{0}", courseId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region courseTranscripts CRUD

		public string PostCourseTranscripts(string accessToken, string data)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		public string PutCourseTranscripts(string accessToken, string data, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}/custom", courseId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Gets course transcripts within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscripts(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts");
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets course transcripts within the course by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscriptById(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets course transcript custom details within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscriptCustom(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}/custom", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets course in course transcripts within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseCourseTranscriptCourses(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}/courses", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		/// <summary>
		///     Gets students in course transcripts within the courses.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public JArray GetCourseTranscriptStudents(string accessToken, string courseId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}/students", courseId);
			return CommonData.CallApi(accessToken, apiEndPoint);
		}

		public string DeleteCourseTranscripts(string accessToken, string courseId)
		{
			var apiEndPoint = String.Format(CommonData.BaseUrl + "/courseTranscripts/{0}", courseId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}
