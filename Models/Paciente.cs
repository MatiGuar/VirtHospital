using System;
using VirtualHosp.Clases;
using VirtualHosp.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace VirtualHosp.Models
{
    public class Paciente : Usuario
    {
        

        [Required(ErrorMessage = "Historial Medico es requerido")]
        [Display(Name = "Historial Medico:")]
        public string HistorialMedico { get; set; }

        [Required(ErrorMessage = "Medicamentos es requerido")]
        [Display(Name = "Medicamentos:")]
        public string Medicamentos { get; set; }

        [Required(ErrorMessage = "Antecedentes Medicos es requerido")]
        [Display(Name = "Antecedentes Medicos:")]
        public string AntecedentesMedicos { get; set; }

        [Required(ErrorMessage = "Seleccione un plan médico")]
        [Display(Name = "Plan Médico:")]
        public PlanMedico PlanMedico { get; set; }



       private List<Medico> cartilla = new List<Medico>();
       private List<Consulta> turnos = new List<Consulta>();





        public void CrearTurnoVirtual(string nombreMedico, float horario)
          {
              turnos.Add(elegirMedico(nombreMedico).AltaConsulta(horario));

             // Console.WriteLine("Turno con el profesional" + nombreMedico + "generado con exito");
          }

          private Medico elegirMedico(String nombreMedico)
          {
              return cartilla.Find(medico => medico.Nombre == nombreMedico);
          }

    }
}
