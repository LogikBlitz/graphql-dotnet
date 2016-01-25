using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GraphQl.Samples.GraphQl;
using GraphQl.Samples.Models;
using GraphQL;
using GraphQL.Types;

namespace GraphQl.Samples.Controllers
{
    [RoutePrefix("api/graphql")]
    public class StarWarsController : ApiController
    {
        /// <summary>
        /// Query the system using graphql queries.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [Route("query"), HttpPost, AllowAnonymous]
        [ResponseType(typeof (ExecutionResult))]
        public async Task<IHttpActionResult> Query(GraphQlQuery query)
        {
            var input = query.Variables?.ToInputs();

            var responseModel = await Execute(new GraphQlSchema(), null, query.Query, inputs: input);
            return Ok(responseModel);
        }

        private async Task<ExecutionResult> Execute(
            ISchema schema,
            object rootObject,
            string query,
            string operationName = null,
            Inputs inputs = null)
        {
            var executer = new DocumentExecuter();

            return await executer.ExecuteAsync(schema, rootObject, query, operationName, inputs);
        }
    }
}