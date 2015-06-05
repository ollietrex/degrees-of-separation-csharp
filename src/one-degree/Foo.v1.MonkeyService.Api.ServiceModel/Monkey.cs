using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;

namespace Foo.v1.MonkeyService.Api.ServiceModel
{
    /// <summary>
    /// The request to load all of the monkeys from the persistent storage
    /// </summary>
    [Route("/monkeys", "GET")]
    [DataContract]
    public class GetMonkeys : IReturn<GetMonkeysResponse>
    {
        
    }

    /// <summary>
    /// The response for the request to load all monkeys
    /// </summary>
    [DataContract]
    public class GetMonkeysResponse
    {
        /// <summary>
        /// Gets or sets the monkeys.
        /// </summary>
        /// <value>
        /// The monkeys.
        /// </value>
        [DataMember]
        public List<Types.Monkey> Monkeys { get; set; }

        /// <summary>
        /// Gets or sets the response status.
        /// </summary>
        /// <value>
        /// The response status.
        /// </value>
        [DataMember]
        public IResponseStatus ResponseStatus { get; set; }
    }

}
