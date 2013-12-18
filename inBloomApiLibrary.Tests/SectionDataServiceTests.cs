using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace inBloomApiLibrary.Tests
{
    [TestClass]
    public class SectionDataServiceTests
    {

        private readonly string accessToken = "t-214d81e2-e0ed-43ce-9340-78e36b16b8d4";
        
        private readonly string section1 = "1002a07e1d2b86d6aedacd3c15e2ba877bf52450_id";
        private readonly string section2 = "46f335697cabc9f2f98246bffb992dced78ef100_id";

        #region Synchronous method tests

        [TestMethod]
        public void GetSectionStudentAssociationStudentList_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = "1002a07e1d2b86d6aedacd3c15e2ba877bf52450_id";
            JArray result = srv.GetSectionStudentAssociationStudentList(accessToken, sectionId, null, null, null);
            
            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;
            
            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
            
        }


        [TestMethod]
        public void GetSectionStudentAssociationStudentList_GradebookViewTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = "1002a07e1d2b86d6aedacd3c15e2ba877bf52450_id";
            string view = "gradebook";
            
            JArray result = srv.GetSectionStudentAssociationStudentList(accessToken, sectionId, null, null, view);
           
            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;

            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }
        
        #endregion

        #region Asynchronous method tests

        [TestMethod]
        public void GetSectionStudentAssociationStudentListAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section1;
            Task<JArray> task = srv.GetSectionStudentAssociationStudentListAsync(accessToken, sectionId, null, null, null);
            task.Wait();
            JArray result = task.Result;
            
            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;

            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        }

        [TestMethod]
        public void GetSectionStudentAssociationStudentListAsync_GradebookViewTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section1;
            string view = "gradebook";
            Task<JArray> task = srv.GetSectionStudentAssociationStudentListAsync(accessToken, sectionId, null, null, view);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;

            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }


        [TestMethod]
        public void GetSectionStudentAssociationStudentListAsync_GradebookViewWithLimitAndOffsetTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            string view = "gradebook";
            int limit = 12;
            int offset = 2;
            Task<JArray> task = srv.GetSectionStudentAssociationStudentListAsync(accessToken, sectionId, limit, offset, view);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;

            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

        [TestMethod]
        public void GetSectionStudentAssociationStudentListAsync_GradebookViewWithHighLimitTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            string view = "gradebook";
            int limit = 120;
            int offset = 0;
            Task<JArray> task = srv.GetSectionStudentAssociationStudentListAsync(accessToken, sectionId, limit, offset, view);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstStudent = result.First;

            // verify we got a student id back
            JToken id = firstStudent.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

        [TestMethod]
        public void GetSectionTeacherAssociationTeacherListAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            Task<JArray> task = srv.GetSectionTeacherAssociationTeacherListAsync(accessToken, sectionId, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstTeacher = result.First;
            Debug.WriteLine(firstTeacher.ToString());

            // verify we got a teacher id back
            JToken id = firstTeacher.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        }


        [TestMethod]
        public void GetSectionsAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            Task<JArray> task = srv.GetSectionsAsync(accessToken, sectionId, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstSection = result.First;
            Debug.WriteLine(firstSection.ToString());

            // verify we got an id back
            JToken id = firstSection.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        }

        //[TestMethod]
        //public void GetSectionCustomAsync_BasicTest()
        //{
        //    SectionDataService srv = new SectionDataService();
        //    string sectionId = section2; //todo: need a sectionId with "custom"
        //    Task<JArray> task = srv.GetSectionCustomAsync(accessToken, sectionId, 0, 0);
        //    task.Wait();
        //    JArray result = task.Result;

        //    // make sure we have results
        //    Assert.IsTrue(result.HasValues);

        //    // get the first student in the result set
        //    JToken firstSection = result.First;
        //    Debug.WriteLine(firstSection.ToString());

        //    // verify we got an id back
        //    JToken id = firstSection.SelectToken("id", false);
        //    Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        //}

        [TestMethod]
        public void GetSectionByIdAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            Task<JArray> task = srv.GetSectionByIdAsync(accessToken, sectionId, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstSection = result.First;
            Debug.WriteLine(firstSection.ToString());

            // verify we got an id back
            JToken id = firstSection.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        }

        [TestMethod]
        public void GetSectionStudentAssociationsAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            Task<JArray> task = srv.GetSectionStudentAssociationsAsync(accessToken, sectionId, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstSection = result.First;
            Debug.WriteLine(firstSection.ToString());

            // verify we got an id back
            JToken id = firstSection.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

        }


        [TestMethod]
        public void GetSectionTeacherAssociationsAsync_BasicTest()
        {
            SectionDataService srv = new SectionDataService();
            string sectionId = section2;
            Task<JArray> task = srv.GetSectionTeacherAssociationsAsync(accessToken, sectionId, 0, 0);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken firstSection = result.First;
            Debug.WriteLine(firstSection.ToString());

            // verify we got an id back
            JToken id = firstSection.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }


        #endregion

    }
}
