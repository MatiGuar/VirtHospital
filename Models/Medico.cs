using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualHosp.Clases;
using System.Diagnostics;
using System.Collections.Generic;
using VirtualHosp.Enums;

namespace VirtualHosp.Models
{

    public class Medico : Usuario
    {
        private int NumeroMatricula;
        private List<Consulta> Turnos;
        private Especialidades Especialidad;



        public Medico(int numero, Especialidades especialidad)
        {
            Turnos = new List<Consulta>();
            NumeroMatricula = numero;
            Especialidad = espececialidad;
        }


        public void AltaConsulta(float horario)
        {
            new Consulta(horario);

        }



    }
}
