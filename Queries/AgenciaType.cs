using BancoGraphql.Entities;
using GraphQL.Types;

namespace BancoGraphql.Queries
{
    public class AgenciaType : ObjectGraphType<Agencia>
    {
        public AgenciaType()
        {
            Field(x => x.ID).Description("Id da agência");
            Field(x => x.Numero).Description("Número da agência");
            Field(x => x.Endereco).Description("Endereço da agência");
        }
    }
}