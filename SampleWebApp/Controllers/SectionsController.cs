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

using System.Text;
using System.Web.Mvc;
using SampleWebApp.Components;
using SampleWebApp.Components.Attributes;
using SampleWebApp.Models;
using inBloomApiLibrary;

namespace SampleWebApp.Controllers
{
    [RequiresAuthentication]
    [SelectedNavigation("sections")]
    public class SectionsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Classes";

            var sectionService = new SectionDataService();
            dynamic sections = sectionService.GetSections(SessionInfo.Current.AccessToken, SessionInfo.Current.UserId);

            var model = new SectionListViewModel {Sections = sections};

            return View(model);
        }

        public ActionResult GetStudents(string sectionId)
        {
            var sectionService = new SectionDataService();

            var sb = new StringBuilder();
            sb.Append("<ul>");

            dynamic studentsData = sectionService.GetSectionStudentAssociationStudentList(SessionInfo.Current.AccessToken, sectionId);

            foreach (var student in studentsData)
            {
                sb.AppendFormat("<li>{0} {1}</li>", student.name.firstName, student.name.lastSurname);
            }

            sb.Append("</ul>");

            return Content(sb.ToString());
        }
    }
}