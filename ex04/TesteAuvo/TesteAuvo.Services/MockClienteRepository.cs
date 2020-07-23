using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public class MockClienteRepository : IClienteRepository
    {
        private readonly List<Cliente> clientes;
        public MockClienteRepository()
        {
            clientes = ObtenhaTodosOsClientes();
        }

        public Cliente ObtenhaCliente(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> ObtenhaTodosOsClientes()
        {
            return new List<Cliente>
            {
                new Cliente
                {
                    Nome = "Sigma Sistemas",
                    Telefone = "(62)3254-4578",
                    Email = "sigmasistemas@sigma.com.br",
                    Endereco = "Rua Itumbiara, 55. Cidade Jardim, CEP: 74691300, Goiania - GO",
                    Segmento = "Informatica",
                    CpfCnpj = "145752487",
                    Id = 4572,
                    CodigoExterno = null
                }
            };
        }
    }
}
