using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Tests
{
    public class CustomFixieConvention : Fixie.Convention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFixieConvention" /> class.
        /// </summary>
        public CustomFixieConvention()
        {
            this.Classes.NameEndsWith("Tests");
        }
    }
}
