using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        //private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // AgregarPaciente();
            
        }

        /*private static void  AgregarPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Andrea",
                Apellidos="Alvarez Meza",
                NumeroTelefono="8954632",
                Genero= Genero.Femenino,
                Direccion="Calle 2 con carrera 19",
                Longitud= 3.0525F,
                Latitud=6.25f,
                Ciudad="Bogota",
                FechaNacimiento=new DateTime(2001,10,8)
            };

            //_repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            //var paciente =_repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Ciudad);
        }*/
    }
}
