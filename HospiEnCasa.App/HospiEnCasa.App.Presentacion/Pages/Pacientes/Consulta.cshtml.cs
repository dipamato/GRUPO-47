using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospienCasa.App.Presentacion.Pages
{
    public class ConsultaModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> listaPacientes{get;set;}

        public ConsultaModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet(int pacienteId)
        {
            listaPacientes=new List<Paciente>();
            listaPacientes =_repoPaciente.GetAllPacientes();
            _repoPaciente.DeletePaciente(pacienteId);
            
        }
    }
}
