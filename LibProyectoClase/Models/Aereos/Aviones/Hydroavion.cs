using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereos.Aviones
{
    public class Hydroavion:Avion
    {
        public Hydroavion(double distancia, double altura, int capacidad, double largo, double cantidadDeAgua, double tiempoDeCarga) : base(distancia, altura, largo, capacidad)
        {
            CantidadDeAgua = cantidadDeAgua;
            TiempoDeCarga = tiempoDeCarga;
        }
        public double CantidadDeAgua { get; set; }
        public double TiempoDeCarga { get; set; }
    }
}
