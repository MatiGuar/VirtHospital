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
        private string Nombre;
        private List<Consulta> turnos;
        private Especialidades especialidad;



        public Medico(int numero, string nombre, Especialidades esp)
        {
            turnos = new List<Consulta>();
            NumeroMatricula = numero;
            Nombre = nombre;
            especialidad = esp;
        }

        public string GetNombre()
        {
            return Nombre;
        }


        public void AltaConsulta(float horario)
        {
            new Consulta(horario);

        }



    }
}
