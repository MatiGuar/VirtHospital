using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualHosp.Clases;
using System.Diagnostics;
using VirtualHosp.Enums;

namespace VirtualHosp.Models
{

    public class Medico : Usuario
    {
        

        [Required(ErrorMessage = "Especialidad requerida")]
        [Display(Name = "Especialidad")]
        public Especialidades Especialidad { get; set; }
        
       

        [Required(ErrorMessage = "Numero De Matricula requerido")]
        [Display(Name = "Numero De Matricula")]
        public int NumeroMatricula { get; set; }

        private List<Consulta> Turnos = new List<Consulta>();

       
        public Consulta AltaConsulta(float horario)
        {
            Consulta c = new Consulta(horario);
            Turnos.Add(c);
            return c;
            
        }



    }
}
