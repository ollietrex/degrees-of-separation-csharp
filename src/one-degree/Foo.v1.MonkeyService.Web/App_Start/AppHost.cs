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
        public AppHost()
            : base("Foo v1 Monkey Service", typeof(Api.ServiceInterface.MonkeyService).Assembly)
        {
        }

        /// <summary>
        /// Configures the specified container.
        /// </summary>
        /// <param name="container">The container.</param>
        public override void Configure(Container container)
        {
            LogManager.LogFactory = new DebugLogFactory();
        }
    }
}
