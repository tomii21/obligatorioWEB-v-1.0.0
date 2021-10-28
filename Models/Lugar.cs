using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public abstract class Lugar
    {
        private string nombre;
        private double dimensiones;
       
        public string Nombre { get => nombre; set => nombre = value; }
        public double Dimensiones { get => dimensiones; set => dimensiones = value; }

    }
}
