using System;
using System.Runtime.Serialization;

namespace Foo.v1.MonkeyService.Api.ServiceModel.Types
{
    /// <summary>
    /// The poco class for the JSON handling of monkeys
    /// </summary>
    [DataContract]
    public class Monkey
    {
        /// <summary>
        /// Gets or sets the monkey identifier.
        /// </summary>
        /// <value>
        /// The monkey identifier.
        /// </value>
        [DataMember]
        public int MonkeyId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
