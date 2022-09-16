using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class SignosVitalesModel : PageModel
    {
        
        private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public SignoVital signoVital {get;set;}
        public Paciente paciente {get;set;}

        public SignosVitalesModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void OnGet()
        {
            paciente=new Paciente();
        }

        public async Task<IActionResult> OnPost (int pacienteId)
        {
            paciente = _repoPaciente.GetPaciente(pacienteId);
            if(paciente!=null)
            {
                if(paciente.SignosVitales==null){
                    paciente.SignosVitales= new List<SignoVital>();
                    paciente.SignosVitales.Add(signoVital);
                }
                else{
                    paciente.SignosVitales.Add(signoVital);
                }
                _repoPaciente.UpdatePaciente(paciente);
                return Page();
            }
            return RedirectToPage("/Error");
        }
    }
}
