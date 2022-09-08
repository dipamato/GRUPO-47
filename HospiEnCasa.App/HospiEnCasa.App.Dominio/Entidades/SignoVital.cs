using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales del Paciente
    /// </summary>   
    public class SignoVital 
    {
        
        // Identificador único de cada signo vital
        public int Id { get; set; }
        /// Fecha y hora en que se realizó la toma del signo vital 
        [Required]
        public DateTime FechaHora  { get; set; }
         /// Valor numérico del sifno vital  
          [Required]
        public float Valor {get;set;}
        /// Tipo de Signo vital medido
         [Required]
        public TipoSigno Signo { get; set; }
    }
}