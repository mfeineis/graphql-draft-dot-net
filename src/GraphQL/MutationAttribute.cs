using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MutationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutationAttribute" /> class.
        /// </summary>
        public MutationAttribute()
        {
        }
    }
}
