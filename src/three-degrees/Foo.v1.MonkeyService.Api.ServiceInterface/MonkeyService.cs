using Foo.v1.MonkeyService.Api.ServiceModel;
using Foo.v1.MonkeyService.Business.IService;
using ServiceStack;

namespace Foo.v1.MonkeyService.Api.ServiceInterface
{
    /// <summary>
    /// The public interface for the money service
    /// </summary>
    public class MonkeyService : Service
    {
        /// <summary>
        /// The _monkey service
        /// </summary>
        private readonly IMonkeyService _monkeyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MonkeyService"/> class.
        /// </summary>
        /// <param name="monkeyService">The monkey service.</param>
        public MonkeyService(IMonkeyService monkeyService)
        {
            _monkeyService = monkeyService;
        }

        /// <summary>
        /// Gets the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public object Get(GetMonkeys request)
        {
            return new GetMonkeysResponse
            {
                Monkeys = _monkeyService.GetAll()
            };
        }

    }
}
