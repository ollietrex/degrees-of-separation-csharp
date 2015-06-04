using System.Collections.Generic;
using Foo.v1.MonkeyService.Database.Schema;

namespace Foo.v1.MonkeyService.Database.IRepository
{
    /// <summary>
    /// The interface for the persistence of monkeys to the persistent storage
    /// </summary>
    public interface IMonkeyRepository
    {
        /// <summary>
        /// Gets all monkeys from the persistent storage
        /// </summary>
        /// <returns></returns>
        List<Monkey> GetAll();
    }
}
