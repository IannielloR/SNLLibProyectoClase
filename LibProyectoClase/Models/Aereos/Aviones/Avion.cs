using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibProyectoClase.Models.Bases;

namespace LibProyectoClase.Models.Aereos.Aviones
{
    public class Avion:Aire
    {
        public Avion(double distancia, double altura, double largo, int capacidad) :base(distancia, altura) {
            Largo = largo;
            Capacidad = Capacidad;
        }
        public double Largo { get; set; }
        public int Capacidad { get; set; }
    }
}
