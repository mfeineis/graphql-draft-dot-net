using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Tests.StarWars
{
    public class StarWarsSchema : Schema
    {
        [Query("Retrieves a human by id.")]
        public Human Human(string id)
        {
            throw new NotImplementedException();
        }

        [Query("Retrieves a droid by id.")]
        public Droid Droid(string id)
        {
            throw new NotImplementedException();
        }

        [Query("Retrieves a single hero.")]
        public StarWarsCharacter Hero()
        {
            return new Droid
            {
                Id = 3,
                Name = "R2-D2",
                PrimaryFunction = "Astromech",
                Friends = new StarWarsCharacter[] { new Human { Name = "Luke Skywalker" }, new Droid { Name = "C3PO" } },
            };
        }
    }
}
