using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class FormularioPModel : PageModel
    {
        [BindProperty]
        public Paciente Paciente{get;set;}

        private readonly IRepositorioPaciente _repoPaciente;
        public FormularioPModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoPaciente.AddPaciente(Paciente);
            return RedirectToPage("/Index");
        }
    }
}
