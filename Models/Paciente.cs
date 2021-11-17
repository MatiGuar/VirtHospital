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

        private PlanMedico planMedico;
        private List<Medico> cartilla;

        public Paciente(string historial, string meds, string antecedentes, PlanMedico plan)
        {
            cartilla = new List<Medico>();
            HistorialMedico = historial;
            Medicamentos = meds;
            AntecedentesMedicos = antecedentes;
            planMedico = plan;

        }

        public void CrearTurnoVirtual(string nombreMedico, float horario)
        {
            elegirMedico(nombreMedico).AltaConsulta(horario);
        }

        private Medico elegirMedico(String nombreMedico)
        {
            return cartilla.Find(medico => medico.Nombre == nombreMedico);
        }

    }
}
