using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico:IRepositorioMedico
    {
        private readonly AppContext _appContext=new AppContext();

        public  Medico AddMedico(Medico medico){
            var medicoAdicionado=_appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        public IEnumerable<Medico> GetAllMedicos()
        {
           return _appContext.Medicos;
        }

        public Medico GetMedico(int idMedico)
        {
           return _appContext.Medicos.FirstOrDefault(p=>p.Id==idMedico);
        }
         public Medico GetMedicoxCodigo(string codigo)
        {
           return _appContext.Medicos.FirstOrDefault(p=>p.Codigo==codigo);
        }
        public Medico UpdateMedico (Medico medico){
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(p=>p.Id==medico.Id);
            if(medicoEncontrado!=null)
            {
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.Genero=medico.Genero;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.Codigo=medico.Codigo;
                medicoEncontrado.RegistroRethus=medico.RegistroRethus;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }

        public void DeleteMedico(int idMedico)
        {
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(p=>p.Id==idMedico);
            if(medicoEncontrado!=null){
                _appContext.Medicos.Remove(medicoEncontrado);
                _appContext.SaveChanges();
            }
        }

        public List<SelectListItem> ConsultarNombresMedico()
        {
           return _appContext.Medicos.Select(m=> new SelectListItem{
                Value=(m.Nombre+" "+m.Apellidos).ToString(),
                Text=(m.Nombre+" "+m.Apellidos+"-"+m.Especialidad+" "+m.Codigo)
            }).ToList();
        }

        public Medico ConsultarMedicoxNombre(string Nombre)
        {
           return _appContext.Medicos.FirstOrDefault(m=>m.Nombre==Nombre);
        }
    }
}