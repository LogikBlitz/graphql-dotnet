using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GraphQL.Types;

namespace GraphQl.Samples.GraphQl.Domains.StarWars.GraphTypes
{
    public class HelloType : ObjectGraphType
    {
        public HelloType()
        {
            Name = "Hello";
            Description = "Let me greet you hello";
            Field<StringGraphType>("greeting", "This is the only greeting you are going to get");
        }
    }
}