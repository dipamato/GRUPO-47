using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class Edicion1Model : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioMedico _repoMedico;
        [BindProperty]
        public Paciente paciente { get; set; }
        public Genero genero { get; set; }
        public Medico Medico { get; set; }
        public List<SelectListItem> nombresMedico { get; set; }

        public Edicion1Model(IRepositorioPaciente repoPaciente, IRepositorioMedico repoMedico)
        {
            _repoPaciente = repoPaciente;
            _repoMedico = repoMedico;

        }
        public void OnGet()
        {
            paciente = new Paciente();
            genero = new Genero();
            nombresMedico = _repoMedico.ConsultarNombresMedico();
        }


        public async Task<IActionResult> OnPost()
        {
            string dato = Request.Form["nombres"];
            Console.WriteLine(dato);
            paciente = _repoPaciente.GetPacienteTel(paciente.NumeroTelefono);
            nombresMedico = _repoMedico.ConsultarNombresMedico();
            if (paciente == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            string dato = Request.Form["nombres"];
            Console.WriteLine(dato);
            var r=dato.Split(" ");
            var x =r.Length;
            Console.WriteLine(r[x-1]);
            Medico=_repoMedico.GetMedicoxCodigo(r[x-1]);
            paciente.Medico=Medico;
            paciente = _repoPaciente.UpdatePaciente(paciente);
            if (paciente == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Pacientes/Consulta");
            
        }

    }
}

