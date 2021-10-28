using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Compra
    {
        private static int ultimoID = 1;

        private int id;
        private Enum actividad;
        private int cantidadEntradas;
        private Usuario usuarios;
        private DateTime fechaHora;
        private Estados estado;
        private double precioFinal;


        public int Id { get => id; set => id = value; }
        public Enum Actividad { get => actividad; set => actividad = value; }
        public int CantidadEntradas { get => cantidadEntradas; set => cantidadEntradas = value; }
        public Usuario Usuarios { get => usuarios; set => usuarios = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public Estados Estado  { get => estado; set => estado = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }


        public Compra(Enum actividad, int cantidadEntradas, Usuario usuarios, DateTime fechaHora, Estados estado, double precioFinal)
        {
            id = ultimoID;
            ultimoID++;
            
            Actividad = actividad;
            CantidadEntradas = cantidadEntradas;
            Usuarios = usuarios;
            FechaHora = fechaHora;
            Estado = estado;
            PrecioFinal = precioFinal;
        }

        public enum Estados
        {
            activa,
            cancelada
        }

    }
}
