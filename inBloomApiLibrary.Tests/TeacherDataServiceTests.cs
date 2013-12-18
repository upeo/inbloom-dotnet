using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace inBloomApiLibrary.Tests
{
    [TestClass]
    public class TeacherDataServiceTests
    {

        private readonly string teacher1 = "3a7cd49bf0ee278341a603349981e6e85c6cda67_id";


        [TestMethod]
        public void GetTeachersAsync_BasicTest()
        {
            TeacherDataService srv = new TeacherDataService();
            Task<JArray> task = srv.GetTeachersAsync(TestProperties.AccessToken, 0, 0);
            task.Wait();

            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken first = result.First;
            Debug.WriteLine(first.ToString());

            // verify we got an id back
            JToken id = first.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));

            Assert.IsNotNull(null);
            
        }


        [TestMethod]
        public void GetTeacherByIdAsync_BasicTest()
        {
            TeacherDataService srv = new TeacherDataService();
            Task<JArray> task = srv.GetTeacherByIdAsync(TestProperties.AccessToken, teacher1);
            task.Wait();
            JArray result = task.Result;

            // make sure we have results
            Assert.IsTrue(result.HasValues);

            // get the first student in the result set
            JToken first = result.First;
            Debug.WriteLine(first.ToString());

            // verify we got an id back
            JToken id = first.SelectToken("id", false);
            Assert.IsTrue(!string.IsNullOrEmpty(id.ToString()));
        }

    }
}
