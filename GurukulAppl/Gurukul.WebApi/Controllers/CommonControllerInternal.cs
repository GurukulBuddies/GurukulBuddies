using Gurukul.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Gurukul.WebApi.Controllers
{
    public class CommonControllerInternal
    {
        public EFDbContext GetConnection(EFDbContext _db)
        {
            return new EFDbContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}