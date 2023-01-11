using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre
{
    public class Moto:Tierra
    {
        public Moto(int ruedas, int capacidad, int cilindraje, string color) : base(ruedas, capacidad)
        {
            Cilindraje = cilindraje;
            Color = color;
        }
        public int Cilindraje { get; set; } //110 250 etc
        public string Color { get; set; } 
    }
}
