using Foo.v1.MonkeyService.Database.IRepository;
using Foo.v1.MonkeyService.Database.Repository;
using Funq;
using ServiceStack;
using ServiceStack.Logging;

namespace Foo.v1.MonkeyService.Web
{
    /// <summary>
    /// The application host container for the setup of the service stack service
    /// </summary>
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppHost"/> class.
        /// </summary>
        public AppHost() : base("Foo v1 Monkey Service", typeof(Api.ServiceInterface.MonkeyService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            LogManager.LogFactory = new DebugLogFactory();

            //Register the dependancy injection

            container.RegisterAutoWiredAs<MonkeyRepository, IMonkeyRepository>().ReusedWithin(ReuseScope.Container);
            container.RegisterAutoWiredAs<Business.Service.MonkeyService, Business.IService.IMonkeyService>().ReusedWithin(ReuseScope.Container);
        }
    }
}
