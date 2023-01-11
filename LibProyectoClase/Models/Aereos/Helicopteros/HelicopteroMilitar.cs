using LibProyectoClase.Models.Aereo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereos.Helicopteros
{
    public class HelicopteroMilitar:Helicoptero
    {
        public HelicopteroMilitar(double distancia, double altura, int helices, int pasajeros, int misiles, int radares) : base(distancia, altura, helices, pasajeros)
        {
            Misiles = misiles;
            Radarares = radares;
        }
        public int Misiles { get; set; }
        public int Radarares { get; set; }

    }
}
