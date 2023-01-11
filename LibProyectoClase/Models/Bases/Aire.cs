using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Bases
{
    public abstract class Aire
    {
        public Aire(double distancia, double altura) 
        { 
            Distancia = distancia;
            Altura = altura;
        }
        public double Distancia { get; set; }
        public double Altura { get; set;}
    }
}
