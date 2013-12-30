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
using System.Diagnostics;
using System;
using System.Threading.Tasks;

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

        public async Task<ActionResult> IndexAsync(int? limit, int? offset)
        {
            ViewBag.Title = "Classes";
            var sectionService = new SectionDataService();
            var sections = await sectionService.GetSectionsAsync(SessionInfo.Current.AccessToken, SessionInfo.Current.UserId, limit, offset)
                                                .ContinueWith(t => new SectionListViewModel { Sections = t.Result });
            return View("Index", sections);
        }

        public ActionResult GetStudents(string sectionId, int? limit, int? offset, string view)
        {
            if (string.IsNullOrEmpty(sectionId))
            {
                return RedirectToAction("Index");
            }
            try
            {
                var sectionService = new SectionDataService();
                dynamic studentsData = sectionService.GetSectionStudentAssociationStudentList(SessionInfo.Current.AccessToken, sectionId, limit, offset, view);
                return View("GetStudents", studentsData);
            }
            catch(Exception ex)
            {
                Trace.TraceError(ex.Message);
                ViewBag.Error = ex.Message;
                return Content("No students found");
            }
        }

        [AsyncTimeout(120000)]
        [HandleError(ExceptionType = typeof(TimeoutException))]
        public async Task<ActionResult> GetStudentsAsync(string sectionId, int? limit, int? offset, string view)
        {
            if (string.IsNullOrEmpty(sectionId))
            {
                return RedirectToAction("IndexAsync");
            }
            
            try
            {
                var sectionService = new SectionDataService();
                return View("GetStudents", await sectionService.GetSectionStudentAssociationStudentListAsync(SessionInfo.Current.AccessToken, sectionId, limit, offset, view));
            }
            catch(Exception ex)
            {
                Trace.TraceError(ex.Message);
                ViewBag.Error = ex.Message;
                return Content("No students found");
            }
        }

    }
}