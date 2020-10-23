using BancoGraphql.Entities;
using GraphQL.Types;

namespace BancoGraphql.Queries
{
    public class BancoType : ObjectGraphType<Banco>
    {
        public BancoType()
        {
            Field(x => x.ID).Description("Id do banco");
            Field(x => x.Produtos, type: typeof(ListGraphType<ProdutoType>)).Description("Produtos");
            Field(x => x.Gerentes, type: typeof(ListGraphType<GerenteType>)).Description("Gerentes");
            Field(x => x.Agencias, type: typeof(ListGraphType<AgenciaType>)).Description("Agências");
        }
    }
}