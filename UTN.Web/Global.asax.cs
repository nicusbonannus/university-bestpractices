using System.Web.Mvc;
using System.Web.Routing;
using UTN.Data;
using UTN.Web.App_Start;

namespace UTN.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(new UniversitySeedData());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Bootstrapper.Run();

        }
    }
}
