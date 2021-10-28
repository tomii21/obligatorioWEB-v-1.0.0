using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Usuario
    {
        private static int ultimoID = 1;

        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private DateTime fechaNacimiento;
        private string nombreUsuario;
        private string contraseña;
        private string rol;
        private List<Compra> compras;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public List<Compra> Compras { get => compras; set => compras = value; }


        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento, List<Compra> compras)
        {
            id = ultimoID;
            ultimoID++;

            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Compras = compras;
        }
    }
}
