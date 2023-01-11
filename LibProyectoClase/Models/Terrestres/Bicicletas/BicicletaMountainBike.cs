using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Bici
{
    public class BicicletaMountainBike:Bicicleta
    {
        public BicicletaMountainBike(int ruedas, int capacidad, bool guardaBarros, string peso, string velocidad, bool suspension) : base(ruedas, capacidad, guardaBarros, peso)
        {
            Velocidad = velocidad;
            Suspension = suspension;
        }

        public string Velocidad { get; set; }
        public bool Suspension{ get; set; }

    }
}
