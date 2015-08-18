using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class NotNullAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullAttribute" /> class.
        /// </summary>
        public NotNullAttribute()
        {
        }
    }
}
