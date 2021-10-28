using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Sistema
    {
        // Creacion de atributos y propiedades
        #region Atributos y Properties
        private List<Lugar> lugares = new List<Lugar>();
        private List<Abierto> abiertos = new List<Abierto>();
        private List<Cerrado> cerrados = new List<Cerrado>();
        private List<Categoria> categorias = new List<Categoria>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Compra> compras = new List<Compra>();
        private List<Actividad> actividades = new List<Actividad>();

        public List<Abierto> GetAbiertos() { return abiertos; }
        public List<Cerrado> GetCerrados() { return cerrados; }
        public List<Categoria> GetCategorias() { return categorias; }
        public List<Usuario> GetUsuarios() { return usuarios; }
        public List<Compra> GetCompras() { return compras; }
        public List<Actividad> GetActividades() { return actividades; }

        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }
        #endregion

        // Instanciación de los métodos de alta
        #region Metodos de Alta
        public Actividad AltaActividad(string nombre, string descripcion, DateTime fechaHora, Actividad.EdadesMinimas edadMinima, double precioBase, int meGustas, Categoria categoria)
        {
            Actividad nuevaActividad = null;

            if (nombre != "" && descripcion != "" && fechaHora > DateTime.Now && precioBase >= 0 && meGustas >= 0)
            {
                nuevaActividad = new Actividad(nombre, descripcion, fechaHora, edadMinima, precioBase, meGustas, categoria);
                actividades.Add(nuevaActividad);
            }
            return nuevaActividad;
        }

        public List<Lugar> getLugares()
        { List<Lugar> lugares = new List<Lugar>();
   
            foreach (Lugar l in lugares)
            {
                lugares.Add(l);
                    
            }
                return lugares;
        }
        public Abierto AltaAbierto(string nombre, double dimensiones, Actividad actividad, double precioButacas, double costoMantenimiento)
        {
            Abierto nuevaAltaAbierto = null;

            if (nombre != "" && dimensiones >= 0 && precioButacas >= 0 && costoMantenimiento >= 0)
            {
                nuevaAltaAbierto = new Abierto(nombre, dimensiones, actividad, precioButacas, costoMantenimiento);
                abiertos.Add(nuevaAltaAbierto);
               
            }
            return nuevaAltaAbierto;
        }

        public Cerrado AltaCerrado(string nombre, double dimensiones, Actividad actividad, bool accesibilidad, int aforoMaximoActividad)
        {
            Cerrado nuevaAltaCerrado = null;

            if (nombre != "" && dimensiones >= 0 && aforoMaximoActividad >= 0)
            {
                nuevaAltaCerrado = new Cerrado(nombre, dimensiones, actividad, accesibilidad, aforoMaximoActividad);
                cerrados.Add(nuevaAltaCerrado);
            }
            return nuevaAltaCerrado;
        }

        public Categoria AltaCategoria(Categoria.NombreCategorias nombreCategoria, string descripcion)
        {
            Categoria nuevaCategoria = null;

            if (descripcion != "")
            {
                nuevaCategoria = new Categoria(nombreCategoria, descripcion);
                categorias.Add(nuevaCategoria);
            }
            return nuevaCategoria;
        }
        #endregion

        #region MetodosRequerimientos
        public List<Abierto> NuevoPrecioButacasLugaresAbiertos(double nuevoPrecio)
        {
            List<Abierto> retorno = new List<Abierto>();

            foreach (Abierto a in abiertos)
            {
                if (Abierto.GetValorButacas() != nuevoPrecio && nuevoPrecio >= 0)
                {
                    Abierto.PrecioButacas = nuevoPrecio;
                    retorno.Add(a);
                }
            }
            return retorno;
        }

        public bool CambiarAforoMax(int aforoMaximo)
        {
            return Cerrado.FijarValorAforoMaximo(aforoMaximo);
        }

        public int GetValorAforoMaximo()
        {
            return Cerrado.GetValorAforoMaximo();
        }

        public double GetPrecioButacas() {
            return Abierto.GetValorButacas();
        }

        public List<Actividad> ActividadesCategoriasEntre(DateTime f1, DateTime f2, Categoria.NombreCategorias nombreCategoria)
        {
            List<Actividad> actividadesDeCategoriaDada = new List<Actividad>();

            foreach(Actividad a in GetActividades())
            {
                if(nombreCategoria.ToString() == a.CategoriaActividad.NombreCategoria.ToString() && (a.FechaHora<f2 && a.FechaHora > f1))
                {
                    actividadesDeCategoriaDada.Add(a);
                }
            }
            return actividadesDeCategoriaDada;
        }
        #endregion

        // Precarga de los datos
        #region Precarga de datos
        public void PrecargaDatos()
        {
            Categoria categoria1 = AltaCategoria(Categoria.NombreCategorias.Cine, "Sala de Cine");
            Categoria categoria2 = AltaCategoria(Categoria.NombreCategorias.Concierto, "Sala de Concierto");
            Categoria categoria3 = AltaCategoria(Categoria.NombreCategorias.Feria_Gastronomica, "Feria Gastronómica");
            Categoria categoria4 = AltaCategoria(Categoria.NombreCategorias.Teatro, "Sala de Teatro");
            Categoria categoria5 = AltaCategoria(Categoria.NombreCategorias.Otros, "Otros");

            Actividad actividad1 = AltaActividad("Actividad 1", "Descripcion Actividad 1", DateTime.Parse("17-07-2031"), Actividad.EdadesMinimas.C18, 5500, 230, categoria1);
            Actividad actividad2 = AltaActividad("Actividad 2", "Descripcion Actividad 2", DateTime.Parse("01-12-2022"), Actividad.EdadesMinimas.C13, 420.99, 15, categoria2);
            Actividad actividad3 = AltaActividad("Actividad 3", "Descripcion Actividad 3", DateTime.Parse("12-10-2023"), Actividad.EdadesMinimas.C16, 1350, 298, categoria3);
            Actividad actividad4 = AltaActividad("Actividad 4", "Descripcion Actividad 4", DateTime.Parse("23-03-2024"), Actividad.EdadesMinimas.P, 10200, 1000, categoria4);
            Actividad actividad5 = AltaActividad("Actividad 5", "Descripcion Actividad 5", DateTime.Parse("20-03-2025"), Actividad.EdadesMinimas.C16, 10200, 1000, categoria5);
            Actividad actividad6 = AltaActividad("Actividad 6", "Descripcion Actividad 6", DateTime.Parse("10-02-2023"), Actividad.EdadesMinimas.C18, 5500, 230, categoria5);
            Actividad actividad7 = AltaActividad("Actividad 7", "Descripcion Actividad 7", DateTime.Parse("12-09-2025"), Actividad.EdadesMinimas.C13, 420.99, 15, categoria4);
            Actividad actividad8 = AltaActividad("Actividad 8", "Descripcion Actividad 8", DateTime.Parse("02-07-2027"), Actividad.EdadesMinimas.C16, 1350, 298, categoria3);
            Actividad actividad9 = AltaActividad("Actividad 9", "Descripcion Actividad 9", DateTime.Parse("25-03-2024"), Actividad.EdadesMinimas.P, 10200, 1000, categoria2);
            Actividad actividad10 = AltaActividad("Actividad 10","Descripcion Actividad 10", DateTime.Parse("20-07-2025"), Actividad.EdadesMinimas.C16, 9000, 1500, categoria1);

            Abierto abierto1 = AltaAbierto("Abierto1", 15238, actividad1, 500, 23.5);
            Abierto abierto2 = AltaAbierto("Abierto2", 9999.99, actividad2, 500, 1502);
            Abierto abierto3 = AltaAbierto("Abierto3", 5569, actividad3, 500, 159.159);
            Abierto abierto4 = AltaAbierto("Abierto4", 8001, actividad4, 500, 2000);
            Abierto abierto5 = AltaAbierto("Abierto5", 10256.78, actividad5, 500, 320.20);

            Cerrado cerrado1 = AltaCerrado("cerrado1", 55.7, actividad6, true, Cerrado.GetValorAforoMaximo());
            Cerrado cerrado2 = AltaCerrado("cerrado2", 102.10, actividad7, false, Cerrado.GetValorAforoMaximo());
            Cerrado cerrado3 = AltaCerrado("cerrado3", 259.56, actividad8, true, Cerrado.GetValorAforoMaximo());
            Cerrado cerrado4 = AltaCerrado("cerrado4", 1500, actividad9, false, Cerrado.GetValorAforoMaximo());
            Cerrado cerrado5 = AltaCerrado("cerrado5", 780, actividad10, true, Cerrado.GetValorAforoMaximo());
        }
        #endregion
    }
}




