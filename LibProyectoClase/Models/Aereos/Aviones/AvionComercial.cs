using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereos.Aviones
{
    public class AvionComercial:Avion
    {
        public AvionComercial(double distancia, double altura, int capacidad, double largo, int escalas,  double peso) : base(distancia, altura, largo, capacidad)
        {
            Escalas = escalas;
            Peso = peso;
        }

        public int Escalas { get; set; }
        public double Peso { get; set; }
    }
}
