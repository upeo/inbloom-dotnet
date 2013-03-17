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
	public class AssessmentDataService : ServiceBase
	{
		#region POST

		/// <summary>
		///     Post the assessment details.
		/// </summary>
		public string PostAssessments(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates assessments details.
		/// </summary>
		public string PutAssessments(string accessToken, string data, string assessmentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/custom", assessmentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes assessments details.
		/// </summary>
		public string DeleteAssessments(string accessToken, string assessmentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}", assessmentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		/// <summary>
		///     Gets assessments details.
		/// </summary>
		public JArray GetAssessments(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets assessments learning objective details.
		/// </summary>
		public JArray GetAssessmentLearningObjective(string accessToken, string assessmentsId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/learningObjectives", assessmentsId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets assessments learning standards.
		/// </summary>
		public JArray GetAssessmentLearningStandards(string accessToken, string assessmentsId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/learningStandards", assessmentsId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student assessments details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="assessmentsId"></param>
		/// <returns></returns>
		public JArray GetAssessmentStudentAssessments(string accessToken, string assessmentsId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/studentAssessments", assessmentsId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students details within the student assessments.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="assessmentsId"></param>
		/// <returns></returns>
		public JArray GetAssessmentStudentAssessmentsStudents(string accessToken, string assessmentsId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/studentAssessments/students", assessmentsId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets assessments custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="assessmentsId"></param>
		/// <returns></returns>
		public JArray GetAssessmentCustom(string accessToken, string assessmentsId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/assessments/{0}/custom", assessmentsId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}
	}
}