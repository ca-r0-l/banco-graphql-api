using System.Collections.Generic;
using System.Linq;
using BancoGraphql.Entities;

namespace BancoGraphql.Services
{
    public class BancoService
    {
        private readonly List<Banco> Bancos = new List<Banco>();

        public BancoService()
        {
            Endereco endereco = new Endereco(
                1,
                "Rua 1",
                191,
                "SBC",
                "SP",
                "05545-121"
            );
            
            Endereco endereco2 = new Endereco(
                2,
                "Rua Alpha",
                5455,
                "SBC",
                "SP",
                "05545-565"
            );

            List<Agencia> agencias = new List<Agencia>() {
                new Agencia(
                    1,
                    1234,
                    endereco.ID
                ),
                new Agencia(
                    2,
                    4578,
                    endereco2.ID
                )
            };

            List<Gerente> gerentes = new List<Gerente>() {
                new Gerente(
                    1,
                    "Joana Magalhães",
                    "123456789",
                    agencias[0].ID
                ),
                new Gerente(
                    2,
                    "Anna Julia",
                    "123456789",
                    agencias[1].ID
                )
            };

            List<Produto> produtos = new List<Produto>() {
                new Produto(
                    1,
                    "CDI",
                    454.01
                )
            };

            Bancos.Add(new Banco(
                1,
                agencias,
                gerentes,
                produtos
            ));
        }

        public List<Banco> GetAllBancos()
        {
            return this.Bancos;
        }

        public Banco GetBancoById(int id)
        {
            return this.Bancos.Where(banco => banco.ID == id).FirstOrDefault<Banco>();
        }
        public List<Produto> GetAllProdutosByBancoID(int id)
        {
            return this.Bancos.Where(banco => banco.ID == id).FirstOrDefault<Banco>().Produtos;
        }
    }
}