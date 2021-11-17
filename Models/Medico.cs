using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualHosp.Clases;
using System.Diagnostics;

namespace VirtualHosp.Models
{
  
    public class Medico : Usuario
    {
        private int numero;

     

        public Medico(int numeroMatricula)
        {
            this.numero = numeroMatricula;
        }
        

        public void AltaConsulta()
        {
            Console.WriteLine("Aceptaste la consulta");
        }


        
    }
}
