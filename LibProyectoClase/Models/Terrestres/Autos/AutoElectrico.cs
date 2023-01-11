using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Auto
{
    public class AutoElectrico:Tierra
    {
        public AutoElectrico(int ruedas, int capacidad, string color, string bateriaDuracion, string voltaje) : base(ruedas, capacidad, color)
        {
            BateriaDuracion = bateriaDuracion;
            Voltaje = voltaje;
        }

        public string BateriaDuracion { get; set; }
        public string Voltaje { get; set; }
    }
}
