using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente(Paciente paciente); // Crear Paciente
        IEnumerable<Paciente> GetAllPacientes(); // Consulta General Hacia la tabla Pacientes
        Paciente GetPaciente(int idPaciente); //Consulta individual de Pacientes
        Paciente UpdatePaciente (Paciente paciente); //Actualizacionde paciente
        void DeletePaciente(int idPaciente);//Eliminación de Paciente;
        Paciente GetPacienteTel(string NumeroTelefono);

        SignoVital AdicionarSigno(SignoVital signoVital);

    }
}