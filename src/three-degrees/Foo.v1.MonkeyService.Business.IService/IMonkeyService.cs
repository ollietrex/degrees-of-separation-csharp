using System.Collections.Generic;
using Foo.v1.MonkeyService.Api.ServiceModel.Types;

namespace Foo.v1.MonkeyService.Business.IService
{
    /// <summary>
    /// The interface for the buisness management of the monkeys from the persistent storage
    /// </summary>
    public interface IMonkeyService
    {
        /// <summary>
        /// Gets all monkeys from the persistent storage
        /// </summary>
        /// <returns></returns>
        List<Monkey> GetAll();
    }
}
