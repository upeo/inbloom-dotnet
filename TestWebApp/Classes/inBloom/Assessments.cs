/*
 * Copyright 2012-2013 inBloom, Inc. and its affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
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
using System.Web.Script.Serialization;

namespace Upeo.inBloomApiLibrary.TestWebApp.Classes
{
	public class Assessments
	{
		#region Properties

		public string Nomenclature { get; set; }

		public string AcademicSubject { get; set; }

		public string AssessmentFamilyHierarchyName { get; set; }

		public string RevisionDate { get; set; }

		public string EntityType { get; set; }

		public string GradeLevelAssessed { get; set; }

		public string AssessmentTitle { get; set; }

		public int MaxRawScore { get; set; }

		public int Version { get; set; }

		public string AssessmentForm { get; set; }

		public string ContentStandard { get; set; }

		public string AssessmentCategory { get; set; }

		public string LowestGradeLevelAssessed { get; set; }

		#endregion

		public String ObjectToJson(Assessments assessment)
		{
			return new JavaScriptSerializer().Serialize(assessment);
		}
	}
}