using System;
using System.Collections.Generic;
using Foo.v1.MonkeyService.Database.IRepository;
using Foo.v1.MonkeyService.Database.Schema;

namespace Foo.v1.MonkeyService.Database.Repository
{
    /// <summary>
    /// The concrete implementation of the monkey repository interface
    /// </summary>
    public class MonkeyRepository : IMonkeyRepository
    {

        /// <summary>
        /// Gets all monkeys from the persistent storage
        /// </summary>
        /// <returns></returns>
        public List<Monkey> GetAll()
        {
            //TODO: Add some in memory or SQL lite persistence
            return new List<Monkey>
            {
                new Monkey { MonkeyId = 1, Name = "Monkey one", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey two", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey three", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey four", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey five", DateOfBirth = DateTime.Now},
            };
        }
    }
}
