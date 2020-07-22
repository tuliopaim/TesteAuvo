using System;
using System.Collections.Generic;
using System.Text;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public class MockContatoRepository : IContatoRepository
    {
        public List<Contato> ObterTodosOsContatosDoCliente(int idCliente)
        {
            return new List<Contato>
            {
                new Contato
                {
                    Nome = "Túlio Paim",
                    Cargo = "Desenvolvedor",
                    Email = "tutpaim@gmail.com",
                    Telefone = "(62)99660-8151"
                },
                new Contato
                {
                    Nome = "Fulano",
                    Cargo = "Desenvolvedor",
                    Email = "fulano@gmail.com",
                    Telefone = "(62)99999-9999"
                },
                new Contato
                {
                    Nome = "Ciclano",
                    Cargo = "Gerente",
                    Email = "ciclano@gmail.com",
                    Telefone = "(62)88888-8888"
                }
            };
        }

    }
}
