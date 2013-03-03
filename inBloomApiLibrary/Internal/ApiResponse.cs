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

using System.Net;
using Newtonsoft.Json.Linq;

namespace inBloomApiLibrary
{
	public class ApiResponse
	{
		public ApiResponse()
		{
			ResponseString = string.Empty;
			ResponseObject = null;
			ErrorMessage = string.Empty;
		}

		/// <summary>
		/// Gets the Http Status Code
		/// </summary>
		public HttpStatusCode StatusCode { get; internal set; }

		/// <summary>
		/// Gets the error message
		/// </summary>
		public string ErrorMessage { get; internal set; }

		/// <summary>
		/// Gets the response object
		/// </summary>
		public JArray ResponseObject { get; internal set; }

		/// <summary>
		/// Gets the response string
		/// </summary>
		public string ResponseString { get; internal set; }
	}
}
