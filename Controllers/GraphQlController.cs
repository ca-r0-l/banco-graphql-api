using GraphQL;
using GraphQL.Types;
using BancoGraphql.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BancoGraphql.Queries;

namespace BancoGraphql.Controllers
{
    [Route(Startup.GraphQlPath)]
    public class GraphQlController: Controller
    {
        private readonly BancoService bancoService;

        public GraphQlController(BancoService bancoService)
        {
            this.bancoService = bancoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var schema = new Schema { Query = new BancoQuery(bancoService) };
            var result = await new DocumentExecuter().ExecuteAsync(
                x => {
                    x.Schema = schema;
                    x.Query = query.Query;
                    x.Inputs = query.Variables;
                }
            );

            if (result.Errors?.Count > 0) { return BadRequest(); }

            return Ok(result.Data);
        }
    }
}