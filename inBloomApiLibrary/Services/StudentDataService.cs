﻿/*
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
using inBloomApiLibrary;
using System.Diagnostics;
using System.Threading.Tasks;

namespace inBloomApiLibrary
{
	public class StudentDataService : ServiceBase
	{
        /// <summary>
        /// Default "limit" parameter for api calls. Set to "0" to return all rows. If not supplied, server api limit is 50.
        /// </summary>
        //private readonly string defaultRowLimt = "0"; 

		#region StudentAcademicRecords

		/// <summary>
		///     Gets student academic records details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentAcademicRecords(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student academic records custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAcademicRecordCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student academic records details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAcademicRecordById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Academic Records details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentAcademicRecords(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates student Academic Records details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentAcademicRecords(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes student Academic Records details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentAcademicRecords(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAcademicRecords/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentAssessments

		/// <summary>
		///     Gets student assessments details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentAssessments(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student assessments custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAssessmentCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student assessments details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAssessmentById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets assessments within the student assessments.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAssessmentAssessments(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}/assessments", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student assessments.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAssessmentStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Assessments details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentAssessments(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates student Assessments details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentAssessments(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes student Assessments details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentAssessments(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentAssessments/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region StudentCohortAssociations

		/// <summary>
		///     Gets student cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentCohortAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student cohort associations custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCohortAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student cohort associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCohortAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets cohorts within the student cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCohortAssociationCohorts(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}/cohorts", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student cohort associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCohortAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Cohort Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentCohortAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates student Cohort Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentCohortAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes student Cohort Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentCohortAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCohortAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentCompetencies

		/// <summary>
		///     Gets student competencies details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentCompetencies(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competencies custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCompetenciesCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competencies details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCompetenciesById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets report cards within the student competencies.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCompetenciesReportCards(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies/{0}/reportCards", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Competencies details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentCompetencies(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Competencies details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentCompetencies(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Competencies details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentCompetencies(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencies/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentCompetencyObjectives

		/// <summary>
		///     Gets student competency objectives details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentCompetencyObjectives(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competency objectives custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCompetencyObjectiveCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competency objectives details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCompetencyObjectiveById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Competency Objectives details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentCompetencyObjectives(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Competency Objectives details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentCompetencyObjectives(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Competency Objectives details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentCompetencyObjectives(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentCompetencyObjectives/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentDisciplineIncidentAssociations

		/// <summary>
		///     Gets student discipline incident associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentDisciplineIncidentAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student discipline incident associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentDisciplineIncidentAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student discipline incident associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentDisciplineIncidentAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets discipline incidents within the student discipline incident associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentDisciplineIncidentAssociationDisciplineIncidents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}/disciplineIncidents", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student discipline incident associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentDisciplineIncidentAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Discipline Incident Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentDisciplineIncidentAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates student Discipline Incident Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentDisciplineIncidentAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes student Discipline Incident Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentDisciplineIncidentAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentDisciplineIncidentAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentGradebookEntries

		/// <summary>
		///     Gets student grade book entries details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentGradeBookEntries(string accessToken)
		{
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/studentGradebookEntries");
			return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
		}

        /// <summary>
        ///     Gets student grade book entries details.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public JArray GetStudentGradeBookEntries(string accessToken, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/studentGradebookEntries");
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
        }

		/// <summary>
		///     Gets student grade book entries custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentGradeBookEntriesCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentGradebookEntries/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student grade book entries details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentGradeBookEntriesById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentGradebookEntries/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Gradebook Entries details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentGradebookEntries(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentGradebookEntries");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Gradebook Entries details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentGradebookEntries(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentGradebookEntries/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Gradebook Entries details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentGradebookEntries(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentGradebookEntries/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentParentAssociations

		/// <summary>
		///     Gets student parent associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentParentAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student parent associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentParentAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student parent associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentParentAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets parents within the student parent associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentParentAssociationParents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}/parents", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student parent associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentParentAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Parent Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentParentAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Parent Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentParentAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Parent Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentParentAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentParentAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentProgramAssociations

		/// <summary>
		///     Gets student program associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student program associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student program associations details by program id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociationByProgramId(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student program associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets programs within the student program associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociationPrograms(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}/programs", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student program associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentProgramAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates  student Program Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentProgramAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Program Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentProgramAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Program Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentProgramAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentProgramAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region Students
		
		/// <summary>
		///     Get student by ID
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
        public JArray GetStudents(string accessToken)
		{
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/students");
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
		}

        /// <summary>
        ///     Gets students details.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public JArray GetStudents(string accessToken, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/students");
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
        }

		/// <summary>
		///     Gets students custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets attendances within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentAttendances(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/attendances", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets course transcripts within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
        [System.Obsolete]
		public JArray GetStudentCourseTranscripts(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/courseTranscripts", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets courses in course transcripts within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
        [System.Obsolete]
		public JArray GetStudentCourseTranscriptCourses(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/courseTranscripts/courses", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets report cards within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentReportCards(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/reportCards", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student assessments within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentAssessments(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentAssessments", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets assessments in student assessments within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentAssessmentAssessments(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentAssessments/assessments", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student cohort associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentCohortAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentCohortAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets cohorts in student cohort associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentCohortAssociationCohorts(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentCohortAssociations/cohorts", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student discipline incident associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentDisciplineIncidentAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentDisciplineIncidentAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets discipline incidents in student discipline incident associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentDisciplineIncidentAssociationDisciplineIncidents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentDisciplineIncidentAssociations/disciplineIncidents", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student parent associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentParentAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentParentAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets parents in student parent associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentParentAssociationParents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentParentAssociations/parents", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student program associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentProgramAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentProgramAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets programs in student program associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentProgramAssociationPrograms(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentProgramAssociations/programs", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student school associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentSchoolAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSchoolAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets schools in student school associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentSchoolAssociationSchools(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSchoolAssociations/schools", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student section associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentSectionAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSectionAssociations", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

        /// <summary>
        ///     Gets student section associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public JArray GetStudentStudentSectionAssociations(string accessToken, string studentId, string views)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSectionAssociations", studentId));
            if (!string.IsNullOrEmpty(views)) { apiEndPoint = apiEndPoint.AddQuery("views", views); }
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
        }


		/// <summary>
		///     Gets sections in student section associations within the students.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentStudentSectionAssociationSections(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSectionAssociations/sections", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates Students details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudents(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  Students details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudents(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  Students details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/students/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

        #region Students Async

        /// <summary>
        ///     Get student by ID
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentByIdAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets students details.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentsAsync(string accessToken, int? limit, int? offset)
        {
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/students");
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
            return await ApiHelper.CallApiForGetAsync(apiEndPoint.ToString(), accessToken);
        }

        /// <summary>
        ///     Gets attendances within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentAttendancesAsync(string accessToken, string studentId, int? limit)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/attendances", studentId));
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }
                
        /// <summary>
        ///     Gets students custom  details.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentCustomAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/custom", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets report cards within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentReportCardsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/reportCards", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student assessments within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentAssessmentsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentAssessments", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets assessments in student assessments within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentAssessmentAssessmentsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentAssessments/assessments", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student cohort associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentCohortAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentCohortAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets cohorts in student cohort associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentCohortAssociationCohortsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentCohortAssociations/cohorts", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student discipline incident associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentDisciplineIncidentAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentDisciplineIncidentAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets discipline incidents in student discipline incident associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentDisciplineIncidentAssociationDisciplineIncidentsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentDisciplineIncidentAssociations/disciplineIncidents", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student parent associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentParentAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentParentAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student program associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentProgramAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentProgramAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets programs in student program associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentProgramAssociationProgramsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentProgramAssociations/programs", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student school associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentSchoolAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSchoolAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets schools in student school associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentSchoolAssociationSchoolsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSchoolAssociations/schools", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets student section associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentSectionAssociationsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSectionAssociations", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        /// <summary>
        ///     Gets sections in student section associations within the students.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<JArray> GetStudentStudentSectionAssociationSectionsAsync(string accessToken, string studentId)
        {
            Uri apiEndPoint = new Uri(String.Format(ApiHelper.BaseUrl + "/students/{0}/studentSectionAssociations/sections", studentId));
            return await ApiHelper.CallApiForGetAsync(apiEndPoint, accessToken);
        }

        #endregion
        
        #region studentSchoolAssociations

        /// <summary>
		///     Gets student school associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentSchoolAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student school associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSchoolAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student school associations custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSchoolAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets schools within the student school associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSchoolAssociationSchools(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}/schools", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student school associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSchoolAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student School Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentSchoolAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates student School Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentSchoolAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes student School Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentSchoolAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSchoolAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion

		#region studentSectionAssociations

		/// <summary>
		///     Gets student section associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociations(string accessToken)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations");
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

        /// <summary>
        ///     Gets student section associations details.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public JArray GetStudentSectionAssociations(string accessToken, int? limit, int? offset, string views)
        {
            Uri apiEndPoint = new Uri(ApiHelper.BaseUrl + "/studentSectionAssociations");
            if (limit != null) { apiEndPoint = apiEndPoint.AddQuery("limit", limit.ToString()); }
            if (offset != null) { apiEndPoint = apiEndPoint.AddQuery("offset", offset.ToString()); }
	        if (!string.IsNullOrEmpty(views)) { apiEndPoint = apiEndPoint.AddQuery("views", views); }
            return ApiHelper.CallApiForGet(apiEndPoint.ToString(), accessToken);
        }

		/// <summary>
		///     Gets student section associations details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationById(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student section associations custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationCustom(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets grades within the student section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationGrades(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/grades", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets sections within the student section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationSections(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/sections", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competencies within the student section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationStudentCompetencies(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/studentCompetencies", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students within the student section associations.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public JArray GetStudentSectionAssociationStudents(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/students", studentId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates student Section Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostStudentSectionAssociations(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates  student Section Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string PutStudentSectionAssociations(string accessToken, string data, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}/custom", studentId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes  student Section Associations details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="studentId"></param>
		/// <returns></returns>
		public string DeleteStudentSectionAssociations(string accessToken, string studentId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/studentSectionAssociations/{0}", studentId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#endregion
	}
}