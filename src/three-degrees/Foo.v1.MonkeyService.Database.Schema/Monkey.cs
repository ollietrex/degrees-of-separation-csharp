using System;
using ServiceStack.DataAnnotations;

namespace Foo.v1.MonkeyService.Database.Schema
{
    /// <summary>
    /// The database representation of a monkey
    /// </summary>
    [Alias("Monkey")]
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
        public int MonkeyId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Alias("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        [Alias("Dob")]
        public DateTime DateOfBirth { get; set; }

    }
}
