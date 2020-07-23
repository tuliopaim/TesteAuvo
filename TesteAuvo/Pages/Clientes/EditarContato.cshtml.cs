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
    public class EditarContatoModel : PageModel
    {
        private readonly IContatoRepository contatoRepository;

        [BindProperty]
        public Contato Contato { get; set; }
        public EditarContatoModel(IContatoRepository contatoRepository)
        {
            this.contatoRepository = contatoRepository;
        }

        public IActionResult OnGet(int id)
        {
            Contato = contatoRepository.ObtenhaContato(id);

            if(Contato == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(Contato contato)
        {
            Contato = contatoRepository.AtualizarContato(contato);

            return RedirectToPage("/Clientes/Detalhes", new { id = Contato.IdCliente });
        }

    }
}