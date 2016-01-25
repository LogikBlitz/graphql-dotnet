using System.ComponentModel;

namespace GraphQl.Samples.Models
{
    public class GraphQlQuery
    {
        [Description("The actual graphql query")]
        public string Query { get; set; }

        [Description("Variables as a graphql formatted string")]
        public string Variables { get; set; }
    }
}