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
    public class Edicion1Model : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public Paciente paciente{get;set;}
        public Genero genero {get;set;}

        public Edicion1Model(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
            paciente=new Paciente();
            genero=new Genero();
        }

        public async Task<IActionResult> OnPost()
        {
            paciente=_repoPaciente.GetPacienteTel(paciente.NumeroTelefono);
            if(paciente==null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            paciente=_repoPaciente.UpdatePaciente(paciente);
            if(paciente==null){
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Pacientes/Consulta");
        }
    }
}
