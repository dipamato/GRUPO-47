using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext=new AppContext();
       
        public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        public Paciente GetPacienteTel(string NumeroTelefono)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.NumeroTelefono== NumeroTelefono);
        }
        public Paciente UpdatePaciente(Paciente paciente)
       
        {
            var pacienteEncontrado = _appContext.Pacientes.SingleOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if(pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        // Metodos CRUD para los signos Vitales

        public SignoVital AdicionarSigno(SignoVital signoVital)
        {
            var signoAdicionado =_appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return signoAdicionado.Entity;
        }
    }

}