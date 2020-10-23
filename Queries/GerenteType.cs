using BancoGraphql.Entities;
using GraphQL.Types;

namespace BancoGraphql.Queries
{
    public class GerenteType : ObjectGraphType<Gerente>
    {
        public GerenteType()
        {
            Field(x => x.ID).Description("Id do gerente");
            Field(x => x.Nome).Description("Nome do gerente");
            Field(x => x.Cpf).Description("Cpf do gerente");
            Field(x => x.Agencia).Description("Agência do gerente");
        }
    }
}