using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_WebApi.Models;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ReturnAllWorkersInfo()
        {
            //arrange  -- setup the test data
            var testworker = GetAllWorkes();
            var controller = new TestWorkerControllerApi(testworker);
            
            // act -- perform the actual
            var result = controller.GetWorkers() as List<worker>;

            //assert  -- verify the result
            Assert.AreEqual(testworker.Count, result.Count);

        }

        [TestMethod]
        public void ReturnById() {

            var testworker = GetAllWorkes();
            var controller = new TestWorkerControllerApi(testworker);

            var result = controller.GetWorkersById(1);
            Assert.AreEqual(1, result.WORKER_ID);
        }

        private List<worker> GetAllWorkes()
        {
            var testWorker = new List<worker>();
            testWorker.Add(new worker { WORKER_ID=1,FIRST_NAME="Rakesh"});
            testWorker.Add(new worker { FIRST_NAME = "Pankaj" });
            testWorker.Add(new worker { FIRST_NAME = "Rekha" });
            return testWorker;
        }
    }
}
