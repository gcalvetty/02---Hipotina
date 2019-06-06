using System.Web.Mvc;

namespace Hipotina.ERP.WebMVC.Areas.RecursosHumanos
{
    public class RecursosHumanosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "RecursosHumanos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "RecursosHumanos_default",
                "RecursosHumanos/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}