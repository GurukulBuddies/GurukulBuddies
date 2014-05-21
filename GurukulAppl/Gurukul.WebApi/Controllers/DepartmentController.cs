using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gurukul.Entity.Domain;
using Gurukul.Entity;
using System.Configuration;

namespace Gurukul.WebApi.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET api/values
        public IEnumerable<Department> GetDepartments()
        {
            var _db=new EFDbContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
           var depart= _db.Departments.ToList();
           return depart;
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