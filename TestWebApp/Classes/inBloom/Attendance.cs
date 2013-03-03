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
	public class Attendance
	{
		#region Properties

		public string Id { get; set; }

		public string StudentId { get; set; }

		public string SchoolId { get; set; }

		public string EntityType { get; set; }

		#endregion

		public String ObjectToJson(Attendance assessment)
		{
			return new JavaScriptSerializer().Serialize(assessment);
		}
	}
}