using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Moto
{
    public class MotoMel:Tierra
    {
        public MotoMel(int ruedas, int capacidad, int cilindraje, string color, string modelo, bool nueva) : base(ruedas, capacidad, cilindraje, color)
        {
            Modelo = modelo;
            Nueva = nueva;
        }
        public string Modelo { get; set; }
        public bool Nueva { get; set; }
    }
}
