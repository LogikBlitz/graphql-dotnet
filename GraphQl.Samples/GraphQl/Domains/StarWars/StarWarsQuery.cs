using GraphQl.Samples.GraphQl.Domains.StarWars.GraphTypes;
using GraphQl.Samples.GraphQl.Domains.StarWars.Models;
using GraphQL.Types;


// ReSharper disable once CheckNamespace
namespace GraphQl.Samples.GraphQl
{
    public partial class MainQuery
    {
        private void InitStarWarsDomain()
        {
            Field<HelloType>("sayHello",
                arguments: new QueryArguments(
                    new QueryArgument[]
                    {
                        new QueryArgument<NonNullGraphType<StringGraphType>>
                        {
                            Name = "name",
                            Description = "Your Name",
                            DefaultValue = "NO_NAME_PROVIDED"
                        }
                    }),
                resolve: context => SayHello((string) context.Arguments["name"]));
        }

        private Hello SayHello(string name)
        {
            return new Hello {Greeting = $"Hello {name}. This is GraphQl for NET that greets you"};

        }
    }
}