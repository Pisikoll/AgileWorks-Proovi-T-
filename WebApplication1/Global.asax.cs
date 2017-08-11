using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IAppeal laheKoht = new Appeal() {
                kirjeldus = "Lahe Leht",
                lahendamiseT2htAeg = DateTime.Parse("10.07.2017 14:40:59")
            };
            Appeals.AadAppeal(laheKoht);

            IAppeal p88rdumine = new Appeal() {
                kirjeldus = "Uus pöördumine",
                lahendamiseT2htAeg = DateTime.Parse("5.06.2017 18:38:32")
            };
            Appeals.AadAppeal(p88rdumine);

            IAppeal aegumata = new Appeal() {
                kirjeldus = "Uus pöördumine",
                lahendamiseT2htAeg = DateTime.Parse("5.06.2018 18:38:32")
            };
            Appeals.AadAppeal(aegumata);
        }
    }
}
