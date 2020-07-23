using System.Collections.Generic;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public interface IContatoRepository
    {
        List<Contato> ObterTodosOsContatos();
        List<Contato> FiltrarContatos(int idCliente, string nomeContato);
    }
}