using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using Gurukul.Web.Models;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Gurukul.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private string gurukulWebApiUrl = null;
        private readonly HttpContextBase httpContext;
        private AccountControllerInternal accountInternal;
        private HttpResponseMessage response;
        private HttpClient client;
        public AccountController()
        {
             gurukulWebApiUrl = ConfigurationManager.AppSettings["GurukulWebApiUrl"];
             accountInternal = new AccountControllerInternal(httpContext);
             client = new HttpClient();
        }
        // *** 
        // *** Getting WebApi's URL 
        // ***
        

        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User_Profile model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                model.Password = null;
                model.UserName = null;
                return View(model);
            }

            // need to add controller and method name based on changes to routing in WebApiConfig.cs
            response = client.PutAsJsonAsync<User_Profile>(gurukulWebApiUrl + @"/Account/" + @"/PutUser", model).Result;

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var user = response.Content.ReadAsAsync<User_Profile>().Result;

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid Login");
                return View();
            }

            accountInternal.SignIn(user.UserName, false); //findout if login cookie needed.

            accountInternal.CurrentUser = user;
           
            return RedirectToAction("Index", "Home");
        }

        //
        // POST: /Account/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            accountInternal.SignOut();
            if (HttpContext.Session != null) HttpContext.Session.RemoveAll();

            return RedirectToAction("Login", "Account");
        }

       

    }
}
