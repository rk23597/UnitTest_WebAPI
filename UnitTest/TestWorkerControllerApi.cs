using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using UnitTest_WebApi.Models;

namespace UnitTest
{
    class TestWorkerControllerApi
    {
          
        List<worker> workers = new List<worker>();

        public TestWorkerControllerApi(List<worker> workers) => this.workers = workers;
        public List<worker> GetWorkers() => workers;

        public worker GetWorkersById(int id)
        {
            //remember that find is usually try to find the data in primary key
            worker product = workers.Where(w=>w.WORKER_ID==id).FirstOrDefault();

            return product;
        }




    }
}
