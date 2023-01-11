using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Bici
{
    public class BicicletaCarrera:Tierra
    {
        public BicicletaCarrera(int ruedas, int capacidad, bool guardaBarros, string peso, string velocidad, string corredor) : base(ruedas, capacidad, guardaBarros, peso)
        {
            Velocidad = velocidad;
            Corredor = corredor;
        }

        public string Velocidad { get; set; }
        public string Corredor{ get; set; }

    }
}
