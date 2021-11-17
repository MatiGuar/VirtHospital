using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualHosp.Models
{


    public class Consulta
    {

        private const float DuracionConsulta = 30;
        private float _horarioInicio;
        private float tiempoConsulta;
        private float _horarioFinal;


        public Consulta(float horario)
        {
            _horarioInicio = horario;
            tiempoConsulta = DuracionConsulta;
            _horarioFinal = _horarioInicio + DuracionConsulta;
        }



    }
}
