using System;
using VirtualHosp.Clases;

namespace VirtualHosp.Models
{
    public class Administrador : Usuario
    {

        public void AltaMedico(int numeroMatricula)
        {
            Medico m = new Medico(numeroMatricula);

            Console.WriteLine("Creaste un medico con el numero de matricula " + numeroMatricula);
        }


    }
}
