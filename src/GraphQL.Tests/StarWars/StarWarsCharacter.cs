using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Tests.StarWars
{
    public abstract class StarWarsCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StarWarsCharacter[] Friends { get; set; }
        public int[] AppearsIn { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarWarsCharacter" /> class.
        /// </summary>
        public StarWarsCharacter()
        {
        }
    }
}
