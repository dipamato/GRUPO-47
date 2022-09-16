using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Pages
{
    public class RegistroMedicoModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        [BindProperty]
        public Medico medico{get;set;}
        public RegistroMedicoModel(IRepositorioMedico repoMedico)
        {
            _repoMedico=repoMedico;
        }
        public void OnGet()
        {
            medico=new Medico();
        }

        public async Task<IActionResult> OnPost()
        {
            medico= _repoMedico.AddMedico(medico);
            if (medico!=null)
            {
                return RedirectToPage("/Index");
            }
            return RedirectToPage("/Error");
        }
    }
}
