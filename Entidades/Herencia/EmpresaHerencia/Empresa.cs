using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Herencia.EmpresaHerencia
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Empresa(string nombre, string cuit, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cuit;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string PropiedadesEmpresa()
        {
            return "Los datos de la Empresa son: " + "\n\nNombre: " + Nombre + "\nCUIT: " + CUIT + "\nContacto: " + Contacto + "\nEmail: " + Email + "\nTelefono: " + Telefono + "\nDireccion: " + Direccion;
        }
    }
}
