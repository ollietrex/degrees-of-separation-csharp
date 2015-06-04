using System.Collections.Generic;
using System.Linq;
using Foo.v1.MonkeyService.Api.ServiceModel.Types;
using Foo.v1.MonkeyService.Business.IService;
using Foo.v1.MonkeyService.Database.IRepository;
using ServiceStack;

namespace Foo.v1.MonkeyService.Business.Service
{
    /// <summary>
    /// The concrete implementation of the monkey service
    /// </summary>
    public class MonkeyService : IMonkeyService
    {
        /// <summary>
        /// The _monkey repository
        /// </summary>
        private readonly IMonkeyRepository _monkeyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="MonkeyService"/> class.
        /// </summary>
        /// <param name="monkeyRepository">The monkey repository.</param>
        public MonkeyService(IMonkeyRepository monkeyRepository)
        {
            _monkeyRepository = monkeyRepository;
        }


        /// <summary>
        /// Gets all monkeys from the persistent storage
        /// </summary>
        /// <returns></returns>
        public List<Monkey> GetAll()
        {
            var dbItems = _monkeyRepository.GetAll();
            return dbItems.Select(m => m.ConvertTo<Monkey>()).ToList();
        }
    }
}
