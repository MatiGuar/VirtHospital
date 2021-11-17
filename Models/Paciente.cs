using System;
using VirtualHosp.Clases;

namespace VirtualHosp.Models
{
    public class Paciente : Usuario
    {
        private string HistorialMedico;
        private string Medicamentos;
        private string AntecedentesMedicos;        

        public Paciente(string historial, string meds, string antecedentes)
        {

            HistorialMedico = historial;
            Medicamentos = meds;
            AntecedentesMedicos = antecedentes;

        }



        public void CrearTurnoVirtual()
        {
            Console.WriteLine("Creaste tu consulta");
        }




    }
}
