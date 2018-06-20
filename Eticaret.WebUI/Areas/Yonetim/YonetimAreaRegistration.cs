﻿using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim
{
    public class YonetimAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Yonetim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Yonetim_default",
                "Yonetim/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Eticaret.WebUI.Areas.Yonetim.Controllers" }
            );
        }
    }
}