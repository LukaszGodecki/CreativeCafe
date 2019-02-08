using CreativeCafe.CodeBase.DataLayer;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CreativeCafe.Controllers
{
  [AllowAnonymous]
  public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
          string cs = "nic";
          try
          {
            int zero = 0;
            int result = 5 / zero;
          }
          catch (DivideByZeroException ex)
          {
            Logger loggerFile = LogManager.GetLogger("fileLogger");
            loggerFile.Error(ex, "Whoops!");
            Logger loggerWeb = LogManager.GetLogger("databaseLogger");
            loggerWeb.Error(ex, "Whoops!");
            cs = "Test OK";
          }
          return new string[] { "value1", "value2", cs };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
