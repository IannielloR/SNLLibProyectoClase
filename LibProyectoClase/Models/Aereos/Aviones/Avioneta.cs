using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereos.Aviones
{
    internal class Avioneta:Avion
    {
        public Avioneta(double distancia, double altura, int capacidad, double largo, int motores, int velocidad) : base(distancia, altura, largo, capacidad)
        {
            Motores = motores;
            Velocidad = Velocidad;
        }

        public int Motores { get; set; } //cantidad de motores
        public int Velocidad { get; set; }
    }
}
