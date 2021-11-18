using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualHosp.Models
{


    public class Consulta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Debe ingresar un horario")]
        [Display(Name = "Horario:")]
        public float HorarioInicio { get; set; }

        

        [Required]
        [Display(Name = "Horario finalizacion:")]
        public float HorarioFinal { get; set; }



    }
}
