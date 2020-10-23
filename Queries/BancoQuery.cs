using BancoGraphql.Services;
using GraphQL.Types;

namespace BancoGraphql.Queries
{
    public class BancoQuery : ObjectGraphType
    {
        public BancoQuery(BancoService bancoService)
        {
            Field<BancoType>(
                name: "banco",
                arguments: new QueryArguments (new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    int id = (int)context.Arguments["id"];
                    return bancoService.GetBancoById(id);
                }
            );

            Field<ListGraphType<BancoType>>(
                name: "GetAllBancos",
                resolve: context => { return bancoService.GetAllBancos(); }
            );
        }
    }
}