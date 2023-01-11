using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Camion
{
    public class CamionFlete:Tierra
    {
        public CamionFlete(int ruedas, int capacidad, double largo, double pesoTotal, double distanciaMaxima, bool interciudades) : base(ruedas, capacidad, largo, pesoTotal)
        {
            DistanciaMaxima = distanciaMaxima;
            Interciudades = interciudades;
        }

        public double DistanciaMaxima { get; set; }
        public bool Interciudades { get; set; }
    }
}
