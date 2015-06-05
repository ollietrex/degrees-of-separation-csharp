using System;
using System.Runtime.Serialization;
using ServiceStack.DataAnnotations;

namespace Foo.v1.MonkeyService.Api.ServiceModel.Types
{
    /// <summary>
    /// The poco class for the JSON handling of monkeys
    /// </summary>
    [Alias("Monkey")]
    [DataContract]
    public class Monkey
    {
        /// <summary>
        /// Gets or sets the monkey identifier.
        /// </summary>
        /// <value>
        /// The monkey identifier.
        /// </value>
        [AutoIncrement]
        [PrimaryKey]
        [Alias("MonkeyId")]
        [DataMember]
        public int MonkeyId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Alias("Name")]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        [Alias("Dob")]
        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
