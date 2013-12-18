using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace inBloomApiLibrary.Tests
{
    [TestClass]
    public class StudentDataServiceTests
    {
              
        private readonly string student1 = "0116eeeb13ffe310b00f7985e8015dfe39202c5d_id";
        private readonly string student2 = "07262f8296b654e0a8ad3b7abaeec4831509a0ac_id";
        private readonly string student3 = "9962f653a75b707b678b4db2eed016392b4c00a5_id";
        private readonly string student4 = "7f7aa4e8fd659d73c0f581265e0714c3ab4d93e9_id";

        [TestMethod]
        public void GetStudentsAsync_BasicTest()
        {
            StudentDataService srv = new StudentDataService();
            Task<JArray> task = srv.GetStudentsAsync(TestProperties.AccessToken, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;
            Debug.WriteLine(firstStudent.ToString());

            // verify we got an id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

        [TestMethod]
        public void GetStudentByIdAsync_BasicTest()
        {
            StudentDataService srv = new StudentDataService();
            Task<JArray> task = srv.GetStudentByIdAsync(TestProperties.AccessToken, student1);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;
            Debug.WriteLine(firstStudent.ToString());

            // verify we got an id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

        [TestMethod]
        public void GetStudentAttendancesAsync_BasicTest()
        {
            
            StudentDataService srv = new StudentDataService();
            Task<JArray> task = srv.GetStudentAttendancesAsync(TestProperties.AccessToken, student3, null);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;
            Debug.WriteLine(firstStudent.ToString());

            // verify we got an id back
            JToken id = firstStudent.SelectToken("studentId", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

        [TestMethod]
        public void GetStudentReportCardsAsync_BasicTest()
        {
            //TODO: need student with report card data

            StudentDataService srv = new StudentDataService();
            Task<JArray> task = srv.GetStudentReportCardsAsync(TestProperties.AccessToken, student4);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;
            Debug.WriteLine(firstStudent.ToString());

            // verify we got an id back
            JToken id = firstStudent.SelectToken("studentId", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }
    }
}
