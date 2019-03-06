using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitTest_WebApi.Models;

namespace UnitTest_WebApi.Controllers
{
    public class WorkerController : ApiController
    {

        //this is use used to create the object which helps us to connect with database
        WorkerServiceContex db =new WorkerServiceContex();

      
        public IQueryable<worker> GetWorkers() => db.workers;

        //public IHttpActionResult GetWorkersById(int id)
        //{
        //    //remember that find is usually try to find the data in primary key
        //    worker product = db.workers.Find(id);

        //    return Ok(product);
        //}


        public IHttpActionResult GetWorkersById(int id) => Ok(db.workers.Find(id));
    }
}
