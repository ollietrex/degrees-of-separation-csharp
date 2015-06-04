using Foo.v1.MonkeyService.Database.IRepository;
using Foo.v1.MonkeyService.Database.Repository;
using Funq;
using ServiceStack;
using ServiceStack.Logging;

namespace Foo.v1.MonkeyService.Api.Tests
{
    /// <summary>
    /// The test host for the api tests
    /// </summary>
    public class AppHost : AppHostHttpListenerSmartPoolBase
    {
        public AppHost() : base("Testing Monkey Service", typeof (ServiceInterface.MonkeyService).Assembly)
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
