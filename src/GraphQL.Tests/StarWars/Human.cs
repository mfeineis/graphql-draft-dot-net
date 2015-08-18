using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Tests.StarWars
{
    public class Human : StarWarsCharacter
    {
        public string HomePlanet { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Human" /> class.
        /// </summary>
        public Human()
        {
        }
    }
}
