using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereo
{
    public class Helicoptero:Aire
    {
        public Helicoptero(double distancia, double altura, int helices, int pasajeros) : base(distancia, altura)
        {
            Helices = helices;
            Pasajeros = pasajeros
        }
        public int Helices { get; set; }
        public int Pasajeros { get; set; }
    }
}
