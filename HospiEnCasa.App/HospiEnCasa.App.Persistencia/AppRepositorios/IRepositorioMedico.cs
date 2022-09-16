using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        Medico AddMedico(Medico medico); // Crear Medico
        IEnumerable<Medico> GetAllMedicos(); // Consulta General Hacia la tabla Pacientes
        Medico GetMedico(int idMedico); //Consulta individual de Pacientes
        Medico UpdateMedico (Medico medico); //Actualizacionde paciente
        void DeleteMedico(int idMedico);//Eliminación de Medico;
        List<SelectListItem> ConsultarNombresMedico();
        Medico ConsultarMedicoxNombre(string Nombre);
        Medico GetMedicoxCodigo(string codigo);

        

    }
}