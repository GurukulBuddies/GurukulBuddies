using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Gurukul.Web.Areas.Category.ViewModels;

namespace Gurukul.Web.Areas.Category.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Category/Department/

        public ActionResult Index()
        {

            // *** 
            // *** Getting WebApi's URL 
            // ***
            string gurukulWebApiUrl = ConfigurationManager.AppSettings["GurukulWebApiUrl"];

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(gurukulWebApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("Department").Result;
          var a = response.Content.ReadAsAsync<List<Department>>().Result;

            return View();
        }

    }
}
