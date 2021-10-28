using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Categoria
    {
        private NombreCategorias nombreCategorias;
        private static string descripcion;

        public NombreCategorias NombreCategoria { get => nombreCategorias; set => nombreCategorias = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public enum NombreCategorias
        {
            Cine,
            Teatro,
            Concierto,
            Feria_Gastronomica,
            Otros
        }

        public Categoria(NombreCategorias nombreCategoria, string descripcion)
        {
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}
