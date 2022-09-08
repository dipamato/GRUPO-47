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
        public SignoVital signoVital {get;set;}

        public SignosVitalesModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void OnGet()
        {
        }
    }
}
