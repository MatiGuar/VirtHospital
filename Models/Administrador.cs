using System;
using VirtualHosp.Clases;
using VirtualHosp.Enums;

namespace VirtualHosp.Models
{
    public class Administrador : Usuario
    {

        public void AltaMedico(int numeroMatricula, Especialidades especialidad)
        {
            Medico m = new Medico(numeroMatricula, especialidad);

            Console.WriteLine("Creaste un medico con el numero de matricula " + numeroMatricula);
        }


    }
}
