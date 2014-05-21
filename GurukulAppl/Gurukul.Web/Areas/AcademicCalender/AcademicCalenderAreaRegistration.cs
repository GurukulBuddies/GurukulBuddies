using System.Web.Mvc;

namespace Gurukul.Web.Areas.AcademicCalender
{
    public class AcademicCalenderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AcademicCalender";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AcademicCalender_default",
                "AcademicCalender/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
