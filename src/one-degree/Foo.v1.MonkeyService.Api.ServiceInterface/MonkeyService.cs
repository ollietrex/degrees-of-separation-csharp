using System;
using System.Collections.Generic;
using Foo.v1.MonkeyService.Api.ServiceModel;
using Foo.v1.MonkeyService.Api.ServiceModel.Types;
using ServiceStack;

namespace Foo.v1.MonkeyService.Api.ServiceInterface
{
    /// <summary>
    /// The public interface for the money service
    /// </summary>
    public class MonkeyService : Service
    {

        /// <summary>
        /// Gets the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public object Get(GetMonkeys request)
        {

            //TODO: Add some in memory or SQL lite persistence
            var monkeys = new List<Monkey>
            {
                new Monkey { MonkeyId = 1, Name = "Monkey one", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey two", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey three", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey four", DateOfBirth = DateTime.Now},
                new Monkey { MonkeyId = 1, Name = "Monkey five", DateOfBirth = DateTime.Now},
            };

            return new GetMonkeysResponse
            {
                Monkeys = monkeys
            };
        }

    }
}
