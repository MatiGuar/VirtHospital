using System;
using VirtualHosp.Clases;
using VirtualHosp.Enums;
using System.Collections.Generic;

namespace VirtualHosp.Models
{
    public class Paciente : Usuario
    {
        private string HistorialMedico;
        private string Medicamentos;
        private string AntecedentesMedicos;

        private List<Consulta> turnos;
        private PlanMedico planMedico;
        private List<Medico> cartilla;

        public Paciente(string historial, string meds, string antecedentes, PlanMedico plan)
            : base()
        {
            cartilla = new List<Medico>();
            turnos = new List<Consulta>();
            HistorialMedico = historial;
            Medicamentos = meds;
            AntecedentesMedicos = antecedentes;
            planMedico = plan;
        }

        public void CrearTurnoVirtual(string nombreMedico, float horario)
        {
            turnos.Add(elegirMedico(nombreMedico).AltaConsulta(horario));
            Console.WriteLine("Turno con el profesional" + nombreMedico + "generado con exito");
        }

        private Medico elegirMedico(String nombreMedico)
        {
            return cartilla.Find(medico => medico.Nombre == nombreMedico);
        }

    }
}
