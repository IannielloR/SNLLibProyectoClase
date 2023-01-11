using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereo
{
    public class Zeppelin:Aire
    {
        public Zeppelin(double distancia, double altura, double velocidad, int publicidades) : base(distancia, altura)
        {
            Velocidad = velocidad;
            Publicidades = publicidades
        }
        public double Velocidad { get; set; }
        public int Publicidades { get; set; } //cantiodad de publicidades
    }
}
