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
        private int NumeroMatricula;
        private List<Consulta> Turnos;
        private Especialidades Especialidad;



        public Medico(int numero, Especialidades especialidad)
            : base ()
        {
            Turnos = new List<Consulta>();
            NumeroMatricula = numero;
            Especialidad = especialidad;
        }


        public Consulta AltaConsulta(float horario)
        {
            Consulta c = new Consulta(horario);
            Turnos.Add(c);
            return c;
            
        }



    }
}
