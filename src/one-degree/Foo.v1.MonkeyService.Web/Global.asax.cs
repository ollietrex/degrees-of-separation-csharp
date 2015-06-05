using System.Web;

namespace Foo.v1.MonkeyService.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            new AppHost().Init();
        }
    }
}
