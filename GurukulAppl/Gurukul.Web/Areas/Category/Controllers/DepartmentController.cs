using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Gurukul.Web.Areas.Category.ViewModels;
using Gurukul.Web.Controllers;

namespace Gurukul.Web.Areas.Category.Controllers
{
    public class DepartmentController : Controller
    {
        private string gurukulWebApiUrl = null;
        private readonly HttpContextBase httpContext;
        private AccountControllerInternal accountInternal;
        private HttpResponseMessage response;
        private static HttpRequestMessage request;
        private HttpClient client;
        public DepartmentController()
        {
             gurukulWebApiUrl = ConfigurationManager.AppSettings["GurukulWebApiUrl"];
             accountInternal = new AccountControllerInternal(httpContext);
             client = new HttpClient();
        }
        //
        // GET: /Category/Department/

        public ActionResult Index()
        {

            request = new HttpRequestMessage(HttpMethod.Get, gurukulWebApiUrl + @"/Department/" + @"/GetDepartments");
            response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            List<Department> departments = response.Content.ReadAsAsync<List<Department>>().Result;

            return View();
        }

    }
}
