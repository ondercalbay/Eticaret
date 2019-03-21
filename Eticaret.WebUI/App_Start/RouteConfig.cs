using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Eticaret.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "UrunKategori",
              url: "Urunler/{Kategori}",
              defaults: new { controller = "Urunler", action = "Index", Kategori = UrlParameter.Optional },
              namespaces: new[] { "Eticaret.WebUI.Controllers" }
          );

            routes.MapRoute(
              name: "Kategori",
              url: "Kategoriler/{Kategori}",
              defaults: new { controller = "Kategoriler", action = "Index", Kategori = UrlParameter.Optional },
              namespaces: new[] { "Eticaret.WebUI.Controllers" }
          );

            routes.MapRoute(
            name: "Home",
            url: "{action}",
            defaults: new { controller = "Home", action = "Index" },
            namespaces: new[] { "Eticaret.WebUI.Controllers" }
        );

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "Eticaret.WebUI.Controllers" }
          );








        }
    }
}
