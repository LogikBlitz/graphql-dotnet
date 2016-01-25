using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GraphQL.Types;

namespace GraphQl.Samples.GraphQl
{
    public class GraphQlSchema : Schema
    {
        public GraphQlSchema()
        {
            Query = new MainQuery();
            
        }
    }
}