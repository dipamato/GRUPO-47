using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class EdicionModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public Paciente paciente{get;set;}
        public EdicionModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        } [Authorize]
        public void OnGet(int pacienteId)
        {
            paciente = _repoPaciente.GetPaciente(pacienteId);

        }
       
        public async Task<IActionResult> OnPost()
        {
            
            paciente= _repoPaciente.UpdatePaciente(paciente);
            if(paciente==null){
                return RedirectToPage("./NotFound");
            }
            return RedirectToPage ("/Pacientes/Consulta");
        }
    }
}
