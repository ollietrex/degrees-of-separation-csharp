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
        }
    }
}
