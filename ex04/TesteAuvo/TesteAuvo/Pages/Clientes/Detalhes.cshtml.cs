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
    public class DetalhesModel : PageModel
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IContatoRepository contatoRepository;

        public Cliente Cliente { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BuscaStr { get; set; }

        public DetalhesModel(IClienteRepository clienteRepository,
            IContatoRepository contatoRepository)
        {
            this.clienteRepository = clienteRepository;
            this.contatoRepository = contatoRepository;
        }

        public IActionResult OnGet(int id)
        {
            Cliente = clienteRepository.ObtenhaCliente(id);
            if(Cliente == null)
            {
                return NotFound();
            }

            Cliente.Contatos = contatoRepository.FiltrarContatos(id);

            return Page();
        }



    }
}