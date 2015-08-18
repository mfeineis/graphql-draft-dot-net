using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Should;

namespace GraphQL.Tests.StarWars.Cases
{
    public class BasicQueryTests
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicQueryTests" /> class.
        /// </summary>
        public BasicQueryTests()
        {
        }

        public interface IDocument
        {
        }

        public interface IDocumentBuilder 
        {
            IDocument Build(string request);
        }

        public interface IDocumentWriter
        {
            string Write(IDocument document);
        }

        public void IdentifiesR2AsTheHero(IDocumentBuilder builder, IDocumentWriter writer)
        {
            // Assign
            var query = @"
                query HeroNameQuery {
                    hero {
                        name
                    }
                }
            ";
            var expected =
@"{
    hero: {
        name: 'R2-D2'
    }
}";
            // Act
            var doc = builder.Build(query);
            var result = writer.Write(doc);

            // Assert
            result.ShouldEqual(expected);
        }
    }
}
