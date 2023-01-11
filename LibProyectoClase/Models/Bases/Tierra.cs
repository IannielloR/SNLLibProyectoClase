using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Bases
{
    public abstract class Tierra
    {
        public Tierra(int ruedas, int capacidad) 
        {
            Capacidad = capacidad;
            Ruedas = ruedas;
        }
        public int Ruedas { get; set; }
        public int Capacidad { get; set; }
    }
}
