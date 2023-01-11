using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibProyectoClase.Models.Bases;

namespace LibProyectoClase.Models
{
    public class Auto:Tierra
    {   
        public Auto(int ruedas, int capacidad, string color) :base(ruedas, capacidad) 
        {
            Color = color;
        }
        public string Color { get; set; }
    }
}
