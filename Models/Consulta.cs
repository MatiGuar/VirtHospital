﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualHosp.Models
{


    public class Consulta
    {

        private float HorarioInicio;
        private float TiempoConsulta;
        private float HorarioFinal;
        


        public Consulta(float horario, float duracionConsulta)
        {
            HorarioInicio = horario;
            TiempoConsulta = duracionConsulta;
            HorarioFinal = HorarioInicio + TiempoConsulta;
        }



    }
}
