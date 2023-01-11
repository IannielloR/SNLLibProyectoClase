using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre
{
    public class Camion:Tierra
    {
        public Camion(int ruedas, int capacidad, double largo, double pesoTotal) : base(ruedas, capacidad)
        {
            Largo = largo;
            PesoTotal = pesoTotal; 
        }
        public double Largo { get; set; }
        public double PesoTotal { get; set; }
    }
}
