using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAuvo.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
