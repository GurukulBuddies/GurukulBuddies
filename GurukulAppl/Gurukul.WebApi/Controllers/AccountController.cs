using Gurukul.Entity;
using Gurukul.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;

namespace Gurukul.WebApi.Controllers
{
    public class AccountController : ApiController
    {
        private EFDbContext _db = null;
        private CommonControllerInternal commonInternal = null;

        public User_Profile PutUser([FromBody]User_Profile model)
        {
            commonInternal = new CommonControllerInternal();
            _db=commonInternal.GetConnection(_db);
            var user = _db.User_Profile.FirstOrDefault(u => u.UserName.Equals(model.UserName));

            if (user == null || (model.Password != user.Password)) return null;
            return user;
        }
    }
}
