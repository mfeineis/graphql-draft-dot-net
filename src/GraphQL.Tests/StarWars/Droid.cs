using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Tests.StarWars
{
    public class Droid : StarWarsCharacter
    {
        public string PrimaryFunction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Droid" /> class.
        /// </summary>
        public Droid()
        {
        }
    }
}
