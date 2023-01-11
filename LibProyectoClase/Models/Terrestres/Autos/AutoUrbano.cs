using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Auto
{
    public class AutoUrbano:Auto
    {
        public AutoUrbano(int ruedas, int capacidad, string color, string marca, string usado) : base(ruedas, capacidad, color)
        {
            Marca = marca;
            Usado = usado;
        }
        public string Marca { get; set; }
        public bool Usado { get; set; }
    }
}
