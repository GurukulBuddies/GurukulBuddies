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
        private EFDbContext _db = null;
        private CommonControllerInternal commonInternal = null;

        // GET api/values
        public IEnumerable<Department> GetDepartments()
        {
            commonInternal = new CommonControllerInternal();
            _db = commonInternal.GetConnection(_db);
            var depart = _db.Departments.ToList();
            return depart;
        }
    }
}