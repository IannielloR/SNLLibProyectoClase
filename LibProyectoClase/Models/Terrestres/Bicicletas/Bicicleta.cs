using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre
{
    public class Bicicleta:Tierra
    {
        public Bicicleta(int ruedas, int capacidad, bool guardaBarros, double peso) : base(ruedas, capacidad)
        {
            GuardaBarros = guardaBarros;
            Peso = peso;
        }
        public bool GuardaBarros { get; set; }
        public double Peso { get; set; }
    }
}
