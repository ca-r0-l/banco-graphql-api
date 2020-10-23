using BancoGraphql.Entities;
using GraphQL.Types;

namespace BancoGraphql.Queries
{
    public class ProdutoType : ObjectGraphType<Produto>
    {
        public ProdutoType()
        {
            Field(x => x.ID).Description("Id do produto");
            Field(x => x.Nome).Description("Nome do produto");
            Field(x => x.Valor).Description("Valor do produto");
        }
    }
}