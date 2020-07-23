using System.Collections.Generic;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public interface IContatoRepository
    {
        List<Contato> ObtenhaTodosOsContatos();
        Contato ObtenhaContato(int id);
        List<Contato> FiltrarContatos(int idCliente, string nomeContato);
        Contato AtualizarContato(Contato contatoAtualizado);
    }
}