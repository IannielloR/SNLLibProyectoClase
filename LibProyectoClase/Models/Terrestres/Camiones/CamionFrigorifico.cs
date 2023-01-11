using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Camion
{
    public class CamionFrigorifico:Camion
    {
        public CamionFrigorifico(int ruedas, int capacidad, double largo, double pesoTotal, int frioMaximo, double tiempoDeFrio) : base(ruedas, capacidad, largo, pesoTotal)
        {
            FrioMaximo = frioMaximo;
            TiempoDeFrio = tiempoDeFrio;
        }
        public int FrioMaximo { get; set; }
        public double TiempoDeFrio { get; set; }

    }
}
