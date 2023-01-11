using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Auto
{
    public class AutoFormula1:Tierra
    {
        public AutoFormula1(int ruedas, int capacidad, string color, string velocidadMaxima, string equipo) : base(ruedas, capacidad, color)
        {
            VelocidadMaxima = velocidadMaxima;
            Equipo = equipo;
        }
        public string VelocidadMaxima { get; set; }
        public string Equipo { get; set; }
    }
}
