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
	public class GetReportCardsData : ServiceBase
	{
		/// <summary>
		///     Gets report cards details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <returns></returns>
		public JArray GetReportCards(string accessToken)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/reportCards");
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets report card custom  details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="reportId"></param>
		/// <returns></returns>
		public JArray GetReportCardCustom(string accessToken, string reportId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/reportCards/{0}/custom", reportId);
			return CommonData.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates Report cards details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostReportCards(string accessToken, string data)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/reportCards");
			return CommonData.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Updates Report cards details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="reportId"></param>
		/// <returns></returns>
		public string PutReportCards(string accessToken, string data, string reportId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/reportCards/{0}/custom", reportId);
			return CommonData.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes Report cards details.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="reportId"></param>
		/// <returns></returns>
		public string DeleteReportCards(string accessToken, string reportId)
		{
			string apiEndPoint = String.Format(CommonData.BaseUrl + "/reportCards/{0}", reportId);
			return CommonData.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}