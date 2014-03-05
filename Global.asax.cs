 

using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using Komiks.Core.Data;
using Komiks.Services.Infrastructure;
using Komiks.Web.App_Start;


namespace Komiks.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
           // DependencyConfigure.Initialize();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Bootstrapper.Initialise();
    
        }

      
    }
}