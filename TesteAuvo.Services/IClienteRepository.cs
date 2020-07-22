using System;
using System.Collections.Generic;
using System.Text;
using TesteAuvo.Models;

namespace TesteAuvo.Services
{
    public interface IClienteRepository
    {
        List<Cliente> ObtenhaTodosOsClientes();


    }
}
