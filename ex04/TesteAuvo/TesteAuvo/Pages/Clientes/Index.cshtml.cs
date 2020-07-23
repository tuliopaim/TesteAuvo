using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TesteAuvo.Models;
using TesteAuvo.Services;

namespace TesteAuvo.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly IClienteRepository clienteRepository;

        public List<Cliente> Clientes { get; set; }

        public IndexModel(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public void OnGet()
        {
            Clientes = clienteRepository.ObtenhaTodosOsClientes();
        }
    }
}