using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Actividad
    {
        private static int ultimoID = 1;

        private int id;
        private string nombre;
        private string descripcion;
        private DateTime fechaHora;
        private EdadesMinimas edadMinima;
        private static double precioBase;
        private int meGustas;
        private Categoria categoriaActividad;
        

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public EdadesMinimas EdadMinima { get => edadMinima; set => edadMinima = value; }
        public static double PrecioBase { get => precioBase; set => precioBase = value; }
        public int MeGustas { get => meGustas; set => meGustas = value; }
        public Categoria CategoriaActividad { get => categoriaActividad; set => categoriaActividad = value; }

        public enum EdadesMinimas
        {
            P,
            C13,
            C16,
            C18
        }

        public Actividad(string nombre, string descripcion, DateTime fechaHora, EdadesMinimas edadMinima, double precioBase, int meGustas, Categoria categoriaActividad)
        {
            Id = ultimoID;
            ultimoID++;

            Nombre = nombre;
            Descripcion = descripcion;
            FechaHora = fechaHora;
            EdadMinima = edadMinima;
            PrecioBase = precioBase;
            MeGustas = meGustas;
            CategoriaActividad = categoriaActividad;
        }

        public override string ToString()
        {
            return $"ID: {id} | Nombre: {nombre} | Descripción: {descripcion} | Fecha: {fechaHora.ToShortDateString()} | Edad mínima: {edadMinima} | Me gustas: {meGustas} | Categoría: {categoriaActividad.NombreCategoria}";
            //return $"ID: {id} | Nombre: {nombre} | Descripción: {descripcion} | Fecha: {fechaHora.ToShortDateString()} | Edad mínima: {edadMinima} | Precio base: {precioBase} | Me gustas: {meGustas} | Categoría: {categoriaActividad.NombreCategoria}";
        }

    }
}

