using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Camion
{
    public class CamionCarga:Camion
    {
        public CamionCarga(int ruedas, int capacidad, double largo, double pesoTotal, int trailers, double alturaMaxima) : base(ruedas, capacidad, largo, pesoTotal)
        {
            Trailers = trailers;
            AlturaMaxima = alturaMaxima;
        }
        public int Trailers { get; set; }
        public double AlturaMaxima { get; set; }
    }
}
