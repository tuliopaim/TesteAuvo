using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAuvo.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Segmento { get; set; }
        public string CpfCnpj { get; set; }
        public string CodigoExterno { get; set; }
        public string Imagem { get; set; }

        public List<Contato> Contatos{ get; set; }
    }
}
