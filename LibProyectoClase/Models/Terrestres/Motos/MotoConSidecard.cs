using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Moto
{
    public class MotoConSidecard:Tierra
    {
        public MotoConSidecard(int ruedas, int capacidad, int cilindraje, string color, int pasajeros, int modelo) : base(ruedas, capacidad, cilindraje, color)
        {
            Pasajeros = pasajeros;
            Modelo = modelo;
        }
        public int Pasajeros { get; set; } // algunas llevan dos
        public int Modelo { get; set; }
    }
}
