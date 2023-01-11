using LibProyectoClase.Models.Aereo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibProyectoClase.Models.Aereos.Helicopteros
{
    public class HelicopteroGrua : Helicoptero
    {
        public HelicopteroGrua(double distancia, double altura, int helices, int pasajeros, double pesoSoportado, double tiempoDeAcople) : base(distancia, altura, helices, pasajeros)
        {
            PesoSoportado = pesoSoportado;
            TiempoDeAcople = tiempoDeAcople;
        }
        public double PesoSoportado { get; set; }
        public double TiempoDeAcople { get; set; }
    }
}
