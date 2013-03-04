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
	public class GetLearningObjectivesData : ServiceBase
	{
		/// <summary>
		///     Gets Learning Objectives details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetLearningObjectives(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning objective by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveById(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning objective custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveCustom(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/custom", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets child learning objectives within the learning objective.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveChildLearningObjectives(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/childLearningObjectives", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning standards within the learning objective.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveLearningStandards(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/learningStandards", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets parent learning objectives within the learning objective.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveParentLearningObjectives(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/parentLearningObjectives", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets student competencies within the  learning objective.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningObjectiveStudentCompetencies(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/studentCompetencies", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning standards details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetLearningStandards(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning standards details by id.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningStandardById(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards/{0}", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets learning standards custom details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public JArray GetLearningStandardCustom(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards/{0}/custom", learningId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete learningStandards

		/// <summary>
		///     Creates learning standards  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public string PostLearningStandards(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates learning standards  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public string PutLearningStandards(string accessToken, string Data, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards/{0}/custom", learningId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, Data);
		}

		/// <summary>
		///     Deletes learning standards  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="learningId"></param>
		/// <returns></returns>
		public string DeleteLearningStandards(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningStandards/{0}", learningId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion

		#region Create/Update/Delete learningObjectives

		public string PostLearningObjectives(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		public string PutLearningObjectives(string accessToken, string data, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}/custom", learningId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		public string DeleteLearningObjectives(string accessToken, string learningId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/learningObjectives/{0}", learningId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}