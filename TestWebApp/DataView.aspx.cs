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
using System.Web.UI;
using Newtonsoft.Json.Linq;
using Upeo.inBloomApiLibrary.TestWebApp.Classes;
using inBloomApiLibrary;

namespace Upeo.inBloomApiLibrary.TestWebApp
{
	public partial class DataView : Page
	{
		#region Declare Services

		private readonly AssessmentDataService _assessementsService = new AssessmentDataService();
		private readonly AttendanceDataService _attendanceService = new AttendanceDataService();
		private readonly CohortDataService _cohortsService = new CohortDataService();
		private readonly CompetencyLevelDescriptorDataService _competencyLevelDescriptorDataServiceService = new CompetencyLevelDescriptorDataService();
		private readonly CourseDataService _courseDataService = new CourseDataService();
		private readonly DisciplineDataService _disciplineService = new DisciplineDataService();
		private readonly EducationOrganizationDataService _educationOrganizationDataService = new EducationOrganizationDataService();
		private readonly GradeDataService _gradeService = new GradeDataService();
		private readonly HomeDataService _homeService = new HomeDataService();
		private readonly LearningObjectiveDataService _learningObjectiveDataService = new LearningObjectiveDataService();
		private readonly ParentDataService _parentService = new ParentDataService();
		private readonly ProgramDataService _programService = new ProgramDataService();
		private readonly ReportCardDataService _reportCardDataService = new ReportCardDataService();
		private readonly SchoolDataService _schoolService = new SchoolDataService();
		private readonly SectionDataService _sectionService = new SectionDataService();
		private readonly SessionDataService _sessionService = new SessionDataService();
		private readonly StaffDataService _staffService = new StaffDataService();
		private readonly StudentDataService _studentService = new StudentDataService();
		private readonly TeacherDataService _teacherService = new TeacherDataService();

		#endregion

		#region Accessors

	    private string AccessToken
		{
            get
			{
				return Session["access_token"].ToString();
			}
        }
		
		private string UserId
		{
            get
			{
                return Session["user_ID"].ToString();
			}
        }
		
		#endregion

	    protected void Page_Load(object sender, EventArgs e)
		{
			#region API Methods

			// GetAssessments(); // -- done
			//GetAssessmentslearningObjective(); // -- done
			//GetAssessmentslearningStandards(); // -- done
			//GetAssessmentsstudentAssessments(); // -- done
			//GetAssessmentsstudentAssessmentsStudents(); // -- done
			//GetAssessmentsCustom(); // -- Done but page not found

			//GetAttendances(); // -- done
			//GetAttendancesCustom(); // // -- Done but page not found

			//GetCohorts(); //-- done          no data
			//GetCohortsByID();
			//GetCohortsCustom();
			//GetCohortsStaffCohortAssociations(();
			//GetCohortsStaffCohortAssociationsStaff();
			//GetCohortsStudentCohortAssociations();
			//GetCohortsStudentCohortAssociationsStudents();

			//GetCompetencyLevelDescriptor(); // --done no data
			//GetCompetencyLevelDescriptorByID();
			//GetCompetencyLevelDescriptorCustom();

			//GetCompetencyLevelDescriptorTypes(); //-- done but page not found
			//GetCompetencyLevelDescriptorTypesByID();
			//GetCompetencyLevelDescriptorTypesCustom();

			//GetCoursesOfferings() //-- done
			//GetCoursesOfferingsWithID(); // -- done
			//GetCoursesOfferingsCourses();  // -- done
			//GetCoursesOfferingsSessions(); // -- done
			//GetCoursesOfferingsCustom();

			GetCourses(); //-- done
			//GetCoursesIDCoursesOfferings(); // -- done
			//GetCoursesIDCoursesOfferingsSessions(); // -- done
			//GetCoursesCourseTranscripts(); // -- done but no data
			//GetCoursesCourseTranscriptsStudents();
			//GetCoursesstudentParentAssociations(); //-- done no data
			//GetCoursesstudentParentAssociationsStudents();
			//GetCoursesCustom();

			//GetCoursescourseTranscripts();
			//GetCoursescourseTranscriptsByID();
			//GetCoursescourseTranscriptsCourses();
			//GetCoursescourseTranscriptsCustom();
			//GetCoursesCourseTranscriptsStudents();

			//GetDisciplineActions();  // -- done
			//GetDisciplineActionsByID();
			//GetDisciplineActionsCustom();
			//GetDisciplineIncidents(); // done no data
			//GetDisciplineIncidentsByID();
			//GetDisciplineIncidentsStudentDiscpIndtAssociations();
			//GetDisciplineIncidentsStudentDiscpIndtAssoStudents();
			//GetDisciplineIncidentsCustom();


			//GetEducationOrganizations(); //-- done
			//GetEducationOrganizationsByID();//-- done
			//GetEduOrgStaffEduOrgAssociations(); //-- done
			//GetEduOrgStaffEduOrgAssociationsByStaff();  //-- done
			//GetEducationOrganizationsCustom(); //-- page not fount

			//GetGradebookEntries();  // -- done
			//GetGradebookEntriesByID();
			//GetGradebookEntriesCustom();
			//GetGrades(); //-- done
			//GetGradesCustom();  //-- page not found

			//GetGradingPeriods();  //-- done
			//GetGradingPeriodsByID();  //-- done
			//GetGradingPeriodsCustom(); //-- page not found
			//GetGradingPeriodsGrades();  //-- done
			//GetGradingPeriodsReportCards();  //-- done

			//GetHome(); // ---pending

			//GetLearningObjectives(); //-- done
			//GetLearningObjectivesByID();  // -- done
			//GetLearningObjectivesCustom(); // not fount
			//GetLearningObjChildLearningObjectives();
			//GetLearningObjLearningStandards();
			//GetLearningObjParentLearningObjectives();
			//GetLearningObjStudentCompetencies();

			//GetLearningStandards(); //-- done
			//GetLearningStandardsByID(); //-- done
			//GetLearningStandardsCustom();

			//GetParents(); // -- done
			//GetParentsByID(); //-- done
			//GetParentsCustom(); // done page not fount
			//GetParentsStudentParentAssociations(); //-- done
			//GetParentsstudentParentAssociationsStudents();  //--done

			//GetPrograms();  // -- done but no data
			//GetProgramsByID();
			//GetProgramsCustom();
			//GetProgramsStaffProgramAssociations();
			//GetProgramsStaffProgramAssociationsStaff();
			//GetProgramsStudentProgramAssociations();
			//GetProgramsStudentProgramAssociationsStudents();

			//GetReportCards(); //-- done
			//GetReportCardsCustom(); // -- done but page not fount

			//GetSchools(); // done
			//GetSchoolsCustom(); // done but page not  found
			//GetSchoolsSections(); // -- done
			//GetSchoolsStudentSchoolAssociations(); // -- done
			//GetSchoolsStudentSchoolAssociationsStudents(); //-- done
			//GetSchoolsTeacherSchoolAssociations(); // -- done
			//GetSchoolsTeacherSchoolAssociationsTeachers(); //-- done            

			//GetSections(); //-- done
			//GetSectionsCustom(); //-- Pending
			//GetSectionsStudentAssociation(); //-- done
			//GetSectionsStudentAssociationStudentsList(); //-- done
			//GetSecTeacherAssociations(); //-- done
			//GetSecTeacherAssociationsTeacherList(); //-- done 

			//GetSessions(); -- done 
			//GetSessionsCustom(); // -- Pending
			//GetSessionsForID(); //-- Done
			//GetSessionsCoursesOfferings(); // -- done
			//GetSessionsCoursesOfferingsCourses(); //-- done

			//GetStaff(); //-- done no data
			//GetStaffCustom(); //-- done
			//GetStaffStaffCohortAssociations();
			//GetStaffStaffCohortAssociationsCohorts();
			//GetStaffStaffEducationOrgAssignmentAssociations();
			//GetStaffStaffEducationOrgAssignmentAssociationsEduOrgs();
			//GetStaffStaffProgramAssociations();
			//GetStaffStaffProgramAssociationsPrograms();            

			//GetStaffCohortAssociations();  // -- done  but No data
			//GetStaffCohortAssociationsByID();
			//GetStaffCohortAssociationsCohorts();
			//GetStaffCohortAssociationsCustom();
			//GetStaffCohortAssociationsStaff();

			//GetStaffEducationOrgAssignmentAssociations();  // -- done but No data
			//GetStaffEducationOrgAssignmentAssociationsByID();
			//GetStaffEducationOrgAssignmentAssociationsCustom();
			//GetStaffEducationOrgAssignmentAssociationsEduOrgs();
			//GetStaffEducationOrgAssignmentAssociationsStaff();            

			//GetStaffProgramAssociations();// -- done but no data
			//GetStaffProgramAssociationsByID();
			//GetStaffProgramAssociationsByProgramID();
			//GetStaffProgramAssociationsCustom();
			//GetStaffProgramAssociationsPrograms();
			//GetStaffProgramAssociationsStaff();

			//GetStudentAcademicRecords(); //-- done
			//GetStudentAcademicRecordsByID(); -- done
			//GetStudentAcademicRecordsCustom();

			//GetStudentAssessments(); //-- done
			//GetStudentAssessmentsAssessments(); // -- DONE
			//GetStudentAssessmentsByID(); //-- done
			//GetStudentAssessmentsCustom();
			//GetStudentAssessmentsStudents(); //-- done

			//GetStudentCohortAssociations(); //-- done but no data
			//GetStudentCohortAssociationsByID();
			//GetStudentCohortAssociationsCohorts();
			//GetStudentCohortAssociationsCustom();
			//GetStudentCohortAssociationsStudents();

			//GetStudentCompetencies(); //-- done but no data
			//GetStudentCompetenciesByID();
			//GetStudentCompetenciesCustom();
			//GetStudentCompetenciesReportCards();

			//GetStudentCompetencyObjectives(); //-- done
			//GetStudentCompetencyObjectivesByID(); // -- done
			//GetStudentCompetencyObjectivesCustom();

			//GetStudentDisciplineIncidentAssociations();  // -- done but no data
			//GetStudentDisciplineIncidentAssociationsByID();
			//GetStudentDisciplineIncidentAssociationsCustom();
			//GetStudentDisciplineIncidentAssociationsDisciplineIncidents();
			//GetStudentDisciplineIncidentAssociationsStudents();

			//GetStudentGradebookEntries();   // -- done but no data
			//GetStudentGradebookEntriesByID();
			//GetStudentGradebookEntriesCustom();

			//GetStudentParentAssociations(); // -- done
			//GetStudentParentAssociationsByID();  // -- done
			//GetStudentParentAssociationsCustom(); 
			//GetStudentParentAssociationsParents();  // -- done
			//GetStudentParentAssociationsStudents();  // -- done

			//GetStudentProgramAssociations(); //-- done but no data
			//GetStudentProgramAssociationsByProgramID();
			//GetStudentProgramAssociationsByID();
			//GetStudentProgramAssociationsCustom();
			//GetStudentProgramAssociationsPrograms();
			//GetStudentProgramAssociationsStudents();


			//GetStudents(); //-- done
			//GetStudentsCustom(); //-- daone but page not found
			// GetStudentsAttendances(); //-- done
			//GetStudentsCourseTranscripts();  // done, no data
			//GetStudentsCourseTranscriptsCourses();
			//GetStudentsReportCards(); // -- DONE
			//GetStudentsStudentAssessments();  //-- done
			//GetStudentsStudentAssessmentsAssessments(); //-- done
			//GetStudentsStudentCohortAssociations(); //-- done
			//GetStudentsStudentCohortAssociationsCohorts(); //-- done but page not found
			//GetStudentsStudentDisciplineIncidentAssociations(); //-- done no data
			//GetStudentsStudentDiscpIncdAssoDisciplineIncidents(); //-- done no data
			//GetStudentsStudentParentAssociations(); //-- done
			//GetStudentsStudentParentAssociationsParents(); //-- done
			// GetStudentsStudentProgramAssociations(); //-- done
			// GetStudentsStudentProgramAssociationsPrograms(); //-- done
			//GetStudentsStudentSchoolAssociations(); //-- done
			//GetStudentsStudentSchoolAssociationsSchools();   //-- done         
			//GetStudentsStudentSectionAssociations();       //-- done
			//GetStudentsStudentSectionAssociationsSections(); //-- done


			//GetStudentSchoolAssociations();  //-- done
			// GetStudentSchoolAssociationsById();  //-- done
			// GetStudentSchoolAssociationsCustom();  //-- done page not found
			//GetStudentSchoolAssociationsSchools();  //-- done
			//GetStudentSchoolAssociationsStudents();  //-- done

			//GetStudentSectionAssociations(); //-- done
			//GetStudentSectionAssociationsById(); //-- done
			//GetStudentSectionAssociationsCustom(); //-- done page not found
			//GetStudentSectionAssociationsGrades(); //-- done
			//GetStudentSectionAssociationsSections(); //-- done
			//GetStudentSectionAssociationsStudentCompetencies(); //-- done
			// GetStudentSectionAssociationsStudents(); //-- done

			//GetTeachers(); //-- done
			//GetTeachersCustom(); //-- done
			//GetTeachersTeacherSchoolAssociations(); //-- done
			//GetTeachersTeacherSchoolAssociationsSchools(); //-- done
			//GetTeachersTeacherSectionAssociations(); //-- done
			//GetTeachersTeacherSectionAssociationsSections(); //-- done


			// GetTeacherSchoolAssociations(); //-- done
			//GetTeacherSchoolAssociationsById(); //-- done
			//GetTeacherSchoolAssociationsCustom(); //-- done
			//GetTeacherSchoolAssociationsSchools(); //-- done
			//GetTeacherSchoolAssociationsTeachers(); //-- done

			//GetTeacherSectionAssociations(); //-- done
			//GetTeacherSectionAssociationsById(); //-- done
			//GetTeacherSectionAssociationsCustom(); //-- done
			//GetTeacherSectionAssociationsSections(); //-- done
			//GetTeacherSectionAssociationsTeachers(); //-- done

			#endregion

			#region CRUD Methods

			// cudAssessments();
			// cudAttendance();

			#endregion
		}

		#region Get Methods

		private void GetSections()
		{
			// System.Web.HttpContext.Current.Response.Redirect(" mypage.aspx");
			sectionsGridView.DataSource = _sectionService.GetSections(AccessToken, UserId);
			sectionsGridView.DataBind();
		}

		private void GetSectionsCustom()
		{
			JArray lst = _sectionService.GetSections(AccessToken, UserId);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sectionService.GetSectionCustom(AccessToken, UserId);
				sectionsGridView.DataBind();
			}
		}

		private void GetSectionsStudentAssociation()
		{
			JArray lst = _sectionService.GetSections(AccessToken, UserId);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sectionService.GetSectionStudentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSectionsStudentAssociationStudentsList()
		{
			JArray lst = _sectionService.GetSections(AccessToken, UserId);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sectionService.GetSectionStudentAssociationStudentList(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSectionTeacherAssociations()
		{
			JArray lst = _sectionService.GetSections(AccessToken, UserId);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sectionService.GetSectionTeacherAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSecTeacherAssociationsTeacherList()
		{
			JArray lst = _sectionService.GetSections(AccessToken, UserId);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sectionService.GetSectionTeacherAssociationTeacherList(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSessions()
		{
			sectionsGridView.DataSource = _sessionService.GetSessions(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetSessionsCustom()
		{
			JArray lst = _sessionService.GetSessions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sessionService.GetSessionCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSessionsForID()
		{
			JArray lst = _sessionService.GetSessions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sessionService.GetSessionById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSessionsCoursesOfferings()
		{
			JArray lst = _sessionService.GetSessions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sessionService.GetSessionCourseOfferings(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSessionsCoursesOfferingsCourses()
		{
			JArray lst = _sessionService.GetSessions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _sessionService.GetSessionCourseOfferingCourses(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAssessments()
		{
			sectionsGridView.DataSource = _assessementsService.GetAssessments(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetAssessmentslearningObjective()
		{
			JArray lst = _assessementsService.GetAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _assessementsService.GetAssessmentLearningObjective(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAssessmentslearningStandards()
		{
			JArray lst = _assessementsService.GetAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _assessementsService.GetAssessmentLearningStandards(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAssessmentsstudentAssessments()
		{
			JArray lst = _assessementsService.GetAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _assessementsService.GetAssessmentStudentAssessments(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAssessmentsstudentAssessmentsStudents()
		{
			JArray lst = _assessementsService.GetAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _assessementsService.GetAssessmentStudentAssessments(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAssessmentsCustom()
		{
			JArray lst = _assessementsService.GetAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _assessementsService.GetAssessmentCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetAttendances()
		{
			sectionsGridView.DataSource = _attendanceService.GetAttendances(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetAttendancesCustom()
		{
			JArray lst = _attendanceService.GetAttendances(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _attendanceService.GetAttendanceCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohorts()
		{
			sectionsGridView.DataSource = _cohortsService.GetCohorts(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCohortsCustom()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohortsByID()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohortsStaffCohortAssociations()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortStaffCohortAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohortsStaffCohortAssociationsStaff()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortStaffCohortAssociationStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohortsStudentCohortAssociations()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortStudentCohortAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCohortsStudentCohortAssociationsStudents()
		{
			JArray lst = _cohortsService.GetCohorts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _cohortsService.GetCohortStudentCohortAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCompetencyLevelDescriptor()
		{
			sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptor(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCompetencyLevelDescriptorByID()
		{
			JArray lst = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptor(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCompetencyLevelDescriptorCustom()
		{
			JArray lst = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptor(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCompetencyLevelDescriptorTypes()
		{
			sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorTypes(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCompetencyLevelDescriptorTypesByID()
		{
			JArray lst = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorTypes(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorTypeById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCompetencyLevelDescriptorTypesCustom()
		{
			JArray lst = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorTypes(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _competencyLevelDescriptorDataServiceService.GetCompetencyLevelDescriptorTypeCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesOfferings()
		{
			sectionsGridView.DataSource = _courseDataService.GetCourseOfferings(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCoursesOfferingsWithID()
		{
			JArray lst = _courseDataService.GetCourseOfferings(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseOfferingById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesOfferingsCourses()
		{
			JArray lst = _courseDataService.GetCourseOfferings(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseOfferingCourses(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesOfferingsSessions()
		{
			JArray lst = _courseDataService.GetCourseOfferings(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseOfferingSessions(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesOfferingsCustom()
		{
			JArray lst = _courseDataService.GetCourseOfferings(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseOfferingCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCourses()
		{
			sectionsGridView.DataSource = _courseDataService.GetCourses(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCoursesIDCoursesOfferings()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseIdCourseOfferings(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesIDCoursesOfferingsSessions()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseIdCourseOfferingSessions(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesCourseTranscripts()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscripts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesCourseTranscriptsStudents()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscriptStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesCustom()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesstudentParentAssociations()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscripts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursesstudentParentAssociationsStudents()
		{
			JArray lst = _courseDataService.GetCourses(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseStudentParentAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursescourseTranscripts()
		{
			sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscripts(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetCoursescourseTranscriptsCustom()
		{
			JArray lst = _courseDataService.GetCourseCourseTranscripts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscriptCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursescourseTranscriptsByID()
		{
			JArray lst = _courseDataService.GetCourseCourseTranscripts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscriptById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCoursescourseTranscriptsCourses()
		{
			JArray lst = _courseDataService.GetCourseCourseTranscripts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseCourseTranscriptCourses(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetCourseTranscriptsStudents()
		{
			JArray lst = _courseDataService.GetCourseCourseTranscripts(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _courseDataService.GetCourseTranscriptStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineActions()
		{
			sectionsGridView.DataSource = _disciplineService.GetDisciplineActions(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetDisciplineActionsByID()
		{
			JArray lst = _disciplineService.GetDisciplineActions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineActionById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineActionsCustom()
		{
			JArray lst = _disciplineService.GetDisciplineActions(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineActionCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineIncidents()
		{
			sectionsGridView.DataSource = _disciplineService.GetDisciplineIncidents(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetDisciplineIncidentsByID()
		{
			JArray lst = _disciplineService.GetDisciplineIncidents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineIncidentById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineIncidentsCustom()
		{
			JArray lst = _disciplineService.GetDisciplineIncidents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineIncidentCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineIncidentsStudentDiscpIndtAssociations()
		{
			JArray lst = _disciplineService.GetDisciplineIncidents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineIncidentStudentDisciplineIncidentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetDisciplineIncidentsStudentDiscpIndtAssoStudents()
		{
			JArray lst = _disciplineService.GetDisciplineIncidents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _disciplineService.GetDisciplineIncidentStudentDisciplineIncidentAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetEducationOrganizations()
		{
			sectionsGridView.DataSource = _educationOrganizationDataService.GetEducationOrganizations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetEducationOrganizationsByID()
		{
			JArray lst = _educationOrganizationDataService.GetEducationOrganizations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _educationOrganizationDataService.GetEducationOrganizationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetEduOrgStaffEduOrgAssociations()
		{
			JArray lst = _educationOrganizationDataService.GetEducationOrganizations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _educationOrganizationDataService.GetEducationOrganizationStaffEducationOrganizationAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetEduOrgStaffEduOrgAssociationsByStaff()
		{
			JArray lst = _educationOrganizationDataService.GetEducationOrganizations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _educationOrganizationDataService.GetEducationOrganizationStaffEducationOrganizationAssociationByStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetEducationOrganizationsCustom()
		{
			JArray lst = _educationOrganizationDataService.GetEducationOrganizations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _educationOrganizationDataService.GetEducationOrganizationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradebookEntries()
		{
			sectionsGridView.DataSource = _gradeService.GetGradeBookEntries(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetGradebookEntriesByID()
		{
			JArray lst = _gradeService.GetGradeBookEntries(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradeBookEntrieById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradebookEntriesCustom()
		{
			JArray lst = _gradeService.GetGradeBookEntries(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradeBookEntrieCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGrades()
		{
			sectionsGridView.DataSource = _gradeService.GetGrades(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetGradesCustom()
		{
			JArray lst = _gradeService.GetGrades(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradeCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradingPeriods()
		{
			sectionsGridView.DataSource = _gradeService.GetGradingPeriods(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetGradingPeriodsByID()
		{
			JArray lst = _gradeService.GetGradingPeriods(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradingPeriodById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradingPeriodsCustom()
		{
			JArray lst = _gradeService.GetGradingPeriods(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradingPeriodCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradingPeriodsGrades()
		{
			JArray lst = _gradeService.GetGradingPeriods(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradingPeriodGrades(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetGradingPeriodsReportCards()
		{
			JArray lst = _gradeService.GetGradingPeriods(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _gradeService.GetGradingPeriodReportCards(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetHome()
		{
			JArray lst = _homeService.GetHome(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
			}
			//sectionsGridView.DataSource = 
			//sectionsGridView.DataBind();
		}

		// GetLearningObjectives

		private void GetLearningObjectives()
		{
			sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetLearningObjectivesByID()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningObjectivesCustom()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningObjLearningStandards()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveLearningStandards(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningObjParentLearningObjectives()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveParentLearningObjectives(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningObjStudentCompetencies()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveStudentCompetencies(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningObjChildLearningObjectives()
		{
			JArray lst = _learningObjectiveDataService.GetLearningObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningObjectiveChildLearningObjectives(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningStandards()
		{
			sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningStandards(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetLearningStandardsByID()
		{
			JArray lst = _learningObjectiveDataService.GetLearningStandards(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningStandardById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetLearningStandardsCustom()
		{
			JArray lst = _learningObjectiveDataService.GetLearningStandards(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _learningObjectiveDataService.GetLearningStandardCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetParents()
		{
			sectionsGridView.DataSource = _parentService.GetParents(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetParentsByID()
		{
			JArray lst = _parentService.GetParents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _parentService.GetParentById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetParentsCustom()
		{
			JArray lst = _parentService.GetParents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _parentService.GetParentCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetParentsStudentParentAssociations()
		{
			JArray lst = _parentService.GetParents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _parentService.GetParentStudentParentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetParentsstudentParentAssociationsStudents()
		{
			JArray lst = _parentService.GetParents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _parentService.GetParentStudentParentAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetPrograms()
		{
			sectionsGridView.DataSource = _programService.GetPrograms(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetProgramsByID()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetProgramsCustom()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetProgramsStaffProgramAssociations()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramStaffProgramAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetProgramsStaffProgramAssociationsStaff()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramStaffProgramAssociationStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetProgramsStudentProgramAssociations()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramStudentProgramAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetProgramsStudentProgramAssociationsStudents()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _programService.GetProgramStudentProgramAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetReportCards()
		{
			sectionsGridView.DataSource = _reportCardDataService.GetReportCards(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetReportCardsCustom()
		{
			JArray lst = _reportCardDataService.GetReportCards(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _reportCardDataService.GetReportCardCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchools()
		{
			sectionsGridView.DataSource = _schoolService.GetSchools(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetSchoolsCustom()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchoolsSections()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolSections(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchoolsStudentSchoolAssociations()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolStudentSchoolAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchoolsStudentSchoolAssociationsStudents()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolStudentSchoolAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchoolsTeacherSchoolAssociations()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolTeacherSchoolAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetSchoolsTeacherSchoolAssociationsTeachers()
		{
			JArray lst = _schoolService.GetSchools(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _schoolService.GetSchoolTeacherSchoolAssociationTeachers(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaff()
		{
			sectionsGridView.DataSource = _staffService.GetStaff(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStaffCustom()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffCohortAssociations()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffCohortAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffCohortAssociationsCohorts()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffCohortAssociationCohorts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffEducationOrgAssignmentAssociations()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffEducationOrganizationAssignmentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffEducationOrgAssignmentAssociationsEduOrgs()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffEducationOrganizationAssignmentAssociationEducationOrganizations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffProgramAssociations()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffProgramAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffStaffProgramAssociationsPrograms()
		{
			JArray lst = _staffService.GetStaff(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffStaffProgramAssociationPrograms(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}


		private void GetStaffCohortAssociations()
		{
			sectionsGridView.DataSource = _staffService.GetStaffCohortAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStaffCohortAssociationsByID()
		{
			JArray lst = _staffService.GetStaffCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffCohortAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffCohortAssociationsCohorts()
		{
			JArray lst = _staffService.GetStaffCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffCohortAssociationCohorts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffCohortAssociationsStaff()
		{
			JArray lst = _staffService.GetStaffCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffCohortAssociationStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffCohortAssociationsCustom()
		{
			JArray lst = _staffService.GetStaffCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffCohortAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffEducationOrgAssignmentAssociations()
		{
			sectionsGridView.DataSource = _staffService.GetStaffEducationOrganizationAssignmentAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStaffEducationOrgAssignmentAssociationsByID()
		{
			JArray lst = _staffService.GetStaffEducationOrganizationAssignmentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffEducationOrganizationAssignmentAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffEducationOrgAssignmentAssociationsCustom()
		{
			JArray lst = _staffService.GetStaffEducationOrganizationAssignmentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffEducationOrganizationAssignmentAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffEducationOrgAssignmentAssociationsEduOrgs()
		{
			JArray lst = _staffService.GetStaffEducationOrganizationAssignmentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffEducationOrganizationAssignmentAssociationEducationOrganizations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffEducationOrgAssignmentAssociationsStaff()
		{
			JArray lst = _staffService.GetStaffEducationOrganizationAssignmentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffEducationOrganizationAssignmentAssociationStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffProgramAssociations()
		{
			sectionsGridView.DataSource = _staffService.GetStaffProgramAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStaffProgramAssociationsByID()
		{
			JArray lst = _staffService.GetStaffProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffProgramAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffProgramAssociationsByProgramID()
		{
			JArray lst = _programService.GetPrograms(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffProgramAssociationByProgramId(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffProgramAssociationsCustom()
		{
			JArray lst = _staffService.GetStaffProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffProgramAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffProgramAssociationsPrograms()
		{
			JArray lst = _staffService.GetStaffProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffProgramAssociationPrograms(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStaffProgramAssociationsStaff()
		{
			JArray lst = _staffService.GetStaffProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _staffService.GetStaffProgramAssociationStaff(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAcademicRecords()
		{
			sectionsGridView.DataSource = _studentService.GetStudentAcademicRecords(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentAcademicRecordsByID()
		{
			JArray lst = _studentService.GetStudentAcademicRecords(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAcademicRecordById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAcademicRecordsCustom()
		{
			JArray lst = _studentService.GetStudentAcademicRecords(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAcademicRecordCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAssessments()
		{
			sectionsGridView.DataSource = _studentService.GetStudentAssessments(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentAssessmentsAssessments()
		{
			JArray lst = _studentService.GetStudentAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAssessmentAssessments(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAssessmentsByID()
		{
			JArray lst = _studentService.GetStudentAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAssessmentById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAssessmentsCustom()
		{
			JArray lst = _studentService.GetStudentAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAssessmentCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentAssessmentsStudents()
		{
			JArray lst = _studentService.GetStudentAssessments(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAssessmentStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCohortAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentCohortAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentCohortAssociationsByID()
		{
			JArray lst = _studentService.GetStudentCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCohortAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCohortAssociationsCohorts()
		{
			JArray lst = _studentService.GetStudentCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCohortAssociationCohorts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCohortAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCohortAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCohortAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentCohortAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCohortAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCompetencies()
		{
			sectionsGridView.DataSource = _studentService.GetStudentCompetencies(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentCompetenciesByID()
		{
			JArray lst = _studentService.GetStudentCompetencies(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCompetenciesById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCompetenciesReportCards()
		{
			JArray lst = _studentService.GetStudentCompetencies(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCompetenciesReportCards(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCompetenciesCustom()
		{
			JArray lst = _studentService.GetStudentCompetencies(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCompetenciesCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCompetencyObjectives()
		{
			sectionsGridView.DataSource = _studentService.GetStudentCompetencyObjectives(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentCompetencyObjectivesByID()
		{
			JArray lst = _studentService.GetStudentCompetencyObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCompetencyObjectiveById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentCompetencyObjectivesCustom()
		{
			JArray lst = _studentService.GetStudentCompetencyObjectives(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCompetencyObjectiveCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentDisciplineIncidentAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentDisciplineIncidentAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentDisciplineIncidentAssociationsByID()
		{
			JArray lst = _studentService.GetStudentDisciplineIncidentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentDisciplineIncidentAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentDisciplineIncidentAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentDisciplineIncidentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentDisciplineIncidentAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentDisciplineIncidentAssociationsDisciplineIncidents()
		{
			JArray lst = _studentService.GetStudentDisciplineIncidentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentDisciplineIncidentAssociationDisciplineIncidents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentDisciplineIncidentAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentDisciplineIncidentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentDisciplineIncidentAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentGradebookEntries()
		{
			sectionsGridView.DataSource = _studentService.GetStudentGradeBookEntries(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentGradebookEntriesByID()
		{
			JArray lst = _studentService.GetStudentGradeBookEntries(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentGradeBookEntriesById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentGradebookEntriesCustom()
		{
			JArray lst = _studentService.GetStudentGradeBookEntries(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentGradeBookEntriesCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentParentAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentParentAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentParentAssociationsByID()
		{
			JArray lst = _studentService.GetStudentParentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentParentAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentParentAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentParentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentParentAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentParentAssociationsParents()
		{
			JArray lst = _studentService.GetStudentParentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentParentAssociationParents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentParentAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentParentAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentParentAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentProgramAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentProgramAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentProgramAssociationsByProgramID()
		{
			JArray lst = _studentService.GetStudentProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentProgramAssociationByProgramId(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentProgramAssociationsByID()
		{
			JArray lst = _studentService.GetStudentProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentProgramAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentProgramAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentProgramAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentProgramAssociationsPrograms()
		{
			JArray lst = _studentService.GetStudentProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentProgramAssociationPrograms(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentProgramAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentProgramAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentProgramAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		//GetStudents
		private void GetStudents()
		{
			sectionsGridView.DataSource = _studentService.GetStudents(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentsCustom()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsAttendances()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentAttendances(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsCourseTranscripts()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCourseTranscripts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsCourseTranscriptsCourses()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentCourseTranscriptCourses(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsReportCards()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentReportCards(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentAssessments()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentAssessments(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentAssessmentsAssessments()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentAssessmentAssessments(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentCohortAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentCohortAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentCohortAssociationsCohorts()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentCohortAssociationCohorts(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentDisciplineIncidentAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentDisciplineIncidentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentDiscpIncdAssoDisciplineIncidents()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentDisciplineIncidentAssociationDisciplineIncidents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentParentAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentParentAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentParentAssociationsParents()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentParentAssociationParents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentProgramAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentProgramAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentProgramAssociationsPrograms()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentProgramAssociationPrograms(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentSchoolAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentSchoolAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentSchoolAssociationsSchools()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentSchoolAssociationSchools(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentSectionAssociations()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentSectionAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentsStudentSectionAssociationsSections()
		{
			JArray lst = _studentService.GetStudents(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentStudentSectionAssociationSections(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}


		private void GetStudentSchoolAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentSchoolAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentSchoolAssociationsById()
		{
			JArray lst = _studentService.GetStudentSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSchoolAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSchoolAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSchoolAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSchoolAssociationsSchools()
		{
			JArray lst = _studentService.GetStudentSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSchoolAssociationSchools(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSchoolAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSchoolAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		//GetStudentSectionAssociations

		private void GetStudentSectionAssociations()
		{
			sectionsGridView.DataSource = _studentService.GetStudentSectionAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetStudentSectionAssociationsById()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSectionAssociationsCustom()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSectionAssociationsGrades()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationGrades(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSectionAssociationsSections()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationSections(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSectionAssociationsStudentCompetencies()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationStudentCompetencies(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetStudentSectionAssociationsStudents()
		{
			JArray lst = _studentService.GetStudentSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _studentService.GetStudentSectionAssociationStudents(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeachers()
		{
			sectionsGridView.DataSource = _teacherService.GetTeachers(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetTeachersCustom()
		{
			JArray lst = _teacherService.GetTeachers(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeachersTeacherSchoolAssociations()
		{
			JArray lst = _teacherService.GetTeachers(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherTeacherSchoolAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeachersTeacherSchoolAssociationsSchools()
		{
			JArray lst = _teacherService.GetTeachers(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherTeacherSchoolAssociationSchools(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeachersTeacherSectionAssociations()
		{
			JArray lst = _teacherService.GetTeachers(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherTeacherSectionAssociations(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeachersTeacherSectionAssociationsSections()
		{
			JArray lst = _teacherService.GetTeachers(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherTeacherSectionAssociationSections(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSchoolAssociations()
		{
			sectionsGridView.DataSource = _teacherService.GetTeacherSchoolAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetTeacherSchoolAssociationsCustom()
		{
			JArray lst = _teacherService.GetTeacherSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSchoolAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSchoolAssociationsById()
		{
			JArray lst = _teacherService.GetTeacherSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSchoolAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSchoolAssociationsSchools()
		{
			JArray lst = _teacherService.GetTeacherSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSchoolAssociationSchools(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSchoolAssociationsTeachers()
		{
			JArray lst = _teacherService.GetTeacherSchoolAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSchoolAssociationTeachers(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSectionAssociations()
		{
			sectionsGridView.DataSource = _teacherService.GetTeacherSectionAssociations(AccessToken);
			sectionsGridView.DataBind();
		}

		private void GetTeacherSectionAssociationsCustom()
		{
			JArray lst = _teacherService.GetTeacherSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSectionAssociationCustom(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSectionAssociationsById()
		{
			JArray lst = _teacherService.GetTeacherSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSectionAssociationById(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSectionAssociationsSections()
		{
			JArray lst = _teacherService.GetTeacherSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSectionAssociationSections(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		private void GetTeacherSectionAssociationsTeachers()
		{
			JArray lst = _teacherService.GetTeacherSectionAssociations(AccessToken);
			if (lst.Count > 0)
			{
				JToken obj = lst[0];
				sectionsGridView.DataSource = _teacherService.GetTeacherSectionAssociationTeachers(AccessToken, obj["id"].ToString());
				sectionsGridView.DataBind();
			}
		}

		#endregion

		#region Create Update and Delete

		private void cudAssessments()
		{
			var Assess = new Assessments();
			Assess.Nomenclature = "test";
			Assess.AcademicSubject = "test";
			Assess.AssessmentFamilyHierarchyName = "test";
			Assess.RevisionDate = "2013-02-07";
			Assess.EntityType = "tset";
			Assess.GradeLevelAssessed = "test";
			Assess.AssessmentTitle = "test";
			Assess.MaxRawScore = 101;
			Assess.Version = 1;
			//Assess.Id = "c203fb85940d1a48470d82c3c5987ad16d7d9335_id";
			Assess.AssessmentForm = "test";
			Assess.ContentStandard = "test";
			Assess.AssessmentCategory = "test";
			Assess.LowestGradeLevelAssessed = "test";

			string AssessData = Assess.ObjectToJson(Assess);

			//string cResult = clsAssessment.PostAssessments(AccessToken, AssessData);
			//string uResult = clsAssessment.PutAssessments(AccessToken, AssessData, "c203fb85940d1a48470d82c3c5987ad16d7d9334_id");

			string dResult = _assessementsService.DeleteAssessments(AccessToken, "c203fb85940d1a48470d82c3c5987ad16d7d9334_id");
			// GetAssessments();
		}

		private void cudAttendance()
		{
			var atten = new Attendance();
			// atten.Id = "";
			atten.SchoolId = "1";
			atten.StudentId = "2";
			atten.EntityType = "attendance";
			string AttenData = atten.ObjectToJson(atten);

			//string cResult = clsAttendance.PostAttendance(AccessToken, AttenData);
			//string uResult = clsAttendance.PutAttendance(AccessToken, AttenData, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
			string dResult = _attendanceService.DeleteAttendance(AccessToken, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
		}

		private void cudCohorts()
		{
			////Attendance atten = new Attendance();
			////// atten.Id = "";
			////atten.SchoolId = "1";
			////atten.StudentId = "2";
			////atten.EntityType = "attendance";
			////string AttenData = atten.ObjectToJson(atten);

			//////string cResult = clsAttendance.PostAttendance(AccessToken, AttenData);
			//////string uResult = clsAttendance.PutAttendance(AccessToken, AttenData, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
			////string dResult = clsAttendance.DeleteAttendance(AccessToken, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
		}

		private void cudCourses()
		{
			//Courses Course = new Courses();
			//Course.Id = "";
			//Course.SchoolId = "1";
			//Course.StudentId = "2";
			//Course.EntityType = "attendance";
			//string AttenData = Course.ObjectToJson(Course);

			////string cResult = clsAttendance.PostAttendance(AccessToken, AttenData);
			////string uResult = clsAttendance.PutAttendance(AccessToken, AttenData, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
			//string dResult = clsCourse.DeleteCourses(AccessToken, "bafce7c94b6f5f09f120d7c3bdf5695f778c765e_id");
		}

		#endregion
	}
}