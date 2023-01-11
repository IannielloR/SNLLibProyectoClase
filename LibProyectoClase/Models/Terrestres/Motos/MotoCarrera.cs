using LibProyectoClase.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Terrestre.Moto
{
    public class MotoCarrera:Moto
    {
        public MotoCarrera(int ruedas, int capacidad, int cilindraje, string color, double velocidadMaxima, string categoria) : base(ruedas, capacidad, cilindraje, color)
        {
            VelocidadMaxima = velocidadMaxima;
            Categoria = categoria;
        }

        public double VelocidadMaxima { get; set; }
        public string Categoria { get; set; }

    }
}
