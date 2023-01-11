using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Bici
{
    public class Triciclo:Bicicleta
    {
        public Triciclo(int ruedas, int capacidad, bool guardaBarros, string peso, bool timbre, double kilosCarga) : base(ruedas, capacidad, guardaBarros, peso)
        {
            Timbre = timbre;
            KilosCarga = kilosCarga;
        }
        public bool Timbre { get; set; }
        public double KilosCarga { get; set; }
    }
}
