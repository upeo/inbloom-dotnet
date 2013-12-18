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

using System.Linq;
using System.Web.Mvc;
using SampleWebApp.Components;
using SampleWebApp.Components.Attributes;
using SampleWebApp.Models;
using inBloomApiLibrary;
using System.Threading.Tasks;

namespace SampleWebApp.Controllers
{
    [RequiresAuthentication]
    [SelectedNavigation("students")]
    public class StudentsController : Controller
    {
        private readonly StudentDataService _studentDataService = new StudentDataService();

        public ActionResult Index(int? limit, int? offset)
        {
            ViewBag.Title = "Students";

            var students = _studentDataService.GetStudents(SessionInfo.Current.AccessToken, limit, offset);
            var model = new StudentListViewModel {Students = students};

            return View(model);
        }

        public ActionResult Detail(string studentId)
        {
            ViewBag.Title = "Student Detail";

            var student = _studentDataService.GetStudentById(SessionInfo.Current.AccessToken, studentId).FirstOrDefault();
            var model = new StudentDetailViewModel {Student = student};

            return View(model);
        }

        public async Task<ActionResult> DetailAsync(string studentId)
        {
            ViewBag.Title = "Student Detail";
            var student = await _studentDataService.GetStudentByIdAsync(SessionInfo.Current.AccessToken, studentId)
                                                    .ContinueWith( t => new StudentDetailViewModel{ Student = t.Result.FirstOrDefault() });
            
            return View("Detail", student);
        }

    }
}