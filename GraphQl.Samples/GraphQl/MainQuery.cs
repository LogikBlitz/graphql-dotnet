using GraphQL.Types;

namespace GraphQl.Samples.GraphQl
{
    /// <summary>
    /// This is a partial because you might want to combine business domains, that historicly could be separated
    /// by a number of webservices into one GraphQl Service, because the domains are actually interconnected.
    /// By making a MainQuery that is partial you can define domains where each has a Query that is a partial of MainQuery.
    /// There can only be one Query in a Graph and by doing it this way you can separate the code a bit making your 
    /// setup a bit cleaner.
    /// It is a bit overkill in regards to the sample, but i have chosen this approach since it is my experience
    /// that wanting to embed multiple domains into a single graph is a logical next step.
    /// </summary>
    public partial class MainQuery : ObjectGraphType
    {
        public MainQuery()
        {
            Name = "Query";

            //initialize any partial domain queries that belongs to this MainQuery
            InitStarWarsDomain();
        }
    }
}