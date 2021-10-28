using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Abierto : Lugar
    {

        private static int ultimoID = 1;

        private int id;
        private static double precioButaca;
        private double costoMantenimiento;

        public static double PrecioButacas { get => precioButaca; set => precioButaca = value; }
        public double CostoMantenimiento { get => costoMantenimiento; set => costoMantenimiento = value; }

        public static double GetValorButacas() {
            return precioButaca;
        }


        public Abierto(string nombre, double dimensiones, Actividad actividad, double precioButaca, double costoMantenimiento)
        {
            id = ultimoID;
            ultimoID++;

            Nombre = nombre;
            Dimensiones = dimensiones;
            PrecioButacas = precioButaca;
            CostoMantenimiento = costoMantenimiento;
        }
        public double CalcularCosto()
        {
            double precioFinal = 0;
            if(Dimensiones> 1)
            {
                precioFinal = Actividad.PrecioBase * 0.10;
            }
            return precioFinal;
        }
    }
}
