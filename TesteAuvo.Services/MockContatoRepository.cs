using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public class MockContatoRepository : IContatoRepository
    {
        private List<Contato> contatos;
        public MockContatoRepository()
        {
            contatos = ObterTodosOsContatos();
        }

        public List<Contato> ObterTodosOsContatos()
        {
            return new List<Contato>
            {
                new Contato
                {
                    Id = 1234,
                    IdCliente = 4572,
                    Nome = "Túlio Paim",
                    Cargo = "Desenvolvedor",
                    Email = "tutpaim@gmail.com",
                    Telefone = "(62)99660-8151"
                },
                new Contato
                {
                    Id = 1235,
                    IdCliente = 4572,
                    Nome = "Fulano",
                    Cargo = "Desenvolvedor",
                    Email = "fulano@gmail.com",
                    Telefone = "(62)99999-9999"
                },
                new Contato
                {
                    Id = 1236,
                    IdCliente = 4572,
                    Nome = "Ciclano",
                    Cargo = "Gerente",
                    Email = "ciclano@gmail.com",
                    Telefone = "(62)88888-8888"
                }
            };
        }

        public List<Contato> FiltrarContatos(int idCliente, string nomeContato)
        {
            var contatosDoCliente = contatos.Where(c => c.IdCliente == idCliente).ToList();

            if(string.IsNullOrEmpty(nomeContato))
                return contatosDoCliente;

            return contatos.Where(c => c.Nome.Contains(nomeContato)).ToList();            
        }


    }
}
