using Gurukul.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Gurukul.Web.Controllers
{
    public class AccountControllerInternal
    {
        private readonly HttpContextBase httpContext;
        private const string CurrentUserKey = "CurrentUser";

        public AccountControllerInternal(HttpContextBase httpContext)
        {
            this.httpContext = httpContext;
        }

        public User_Profile CurrentUser
        {
            get
            {
                if (httpContext.Session != null) return httpContext.Session[CurrentUserKey] as User_Profile;
                return null;
            }
            set { HttpContext.Current.Session[CurrentUserKey] = value; }
        }

        public void SignIn(string userName, bool createPersistentCookie)
        {

            //TBD: Add roles to Signin later on.
            var authTicket = new FormsAuthenticationTicket(
                1,
                userName,  //user id
                DateTime.Now,
                DateTime.Now.AddDays(30),  //TBD expiry verify the days
                createPersistentCookie,
                "",
                FormsAuthentication.FormsCookiePath);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));

            if (authTicket.IsPersistent)
            {
                cookie.Expires = authTicket.Expiration;
            }

            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public void SignOut()
        {
            //remove the login cookie.
            FormsAuthentication.SignOut();
        }
    }
}