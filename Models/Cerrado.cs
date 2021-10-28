using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Cerrado : Lugar
    {
        private static int ultimoID = 1;
        private static int aforoMaximoActividad = 0;

        private int id;
        private bool accesibilidad;

        public bool Accesibilidad { get => accesibilidad; set => accesibilidad = value; }

        // Metodo utilizado para fijar el nuevo valor del aforo maximo.
        public static bool FijarValorAforoMaximo(int aforoMaximo)
        {
            bool ret = false;

            if (aforoMaximo >= 0 && aforoMaximo <= 100)
            {
                aforoMaximoActividad = aforoMaximo;
                ret = true;
            }
            return ret;
        }

        public static int GetValorAforoMaximo()
        {
            return aforoMaximoActividad;
        }

        public Cerrado(string nombre, double dimensiones, Actividad actividad, bool accesibilidad, int aforoMaximoActividad)
        {
            id = ultimoID;
            ultimoID++;
            Accesibilidad = accesibilidad;
        }

        public double CalcularCosto()
        {
            double precioFinal = 0;
             if(GetValorAforoMaximo() < (aforoMaximoActividad / 2))
            {
                precioFinal = Actividad.PrecioBase * 0.30;
            
            }
             else if(GetValorAforoMaximo() > (aforoMaximoActividad / 2) || GetValorAforoMaximo() < (aforoMaximoActividad / 0.70){
                precioFinal = Actividad.PrecioBase * 0.15;
            }
            return precioFinal;
        }
    }
}
