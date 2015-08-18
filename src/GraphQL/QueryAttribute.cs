using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL
{
    [AttributeUsage(AttributeTargets.Method)]
    public class QueryAttribute : Attribute
    {
        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAttribute" /> class.
        /// </summary>
        public QueryAttribute(string description)
        {

        }
    }
}
