namespace Foo.v1.MonkeyService.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The application start up where we init the app host container for service stack
        /// </summary>
        protected void Application_Start()
        {
            new AppHost().Init();
        }
    }
}
