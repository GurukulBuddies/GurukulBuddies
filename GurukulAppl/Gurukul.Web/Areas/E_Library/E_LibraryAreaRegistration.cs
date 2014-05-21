using System.Web.Mvc;

namespace Gurukul.Web.Areas.E_Library
{
    public class E_LibraryAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "E_Library";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "E_Library_default",
                "E_Library/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
