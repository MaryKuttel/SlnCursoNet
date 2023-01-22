using Entidades.Herencia.PersonaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades.PersonaHerencia
{
    public class ClienteIndividuo : Persona
    {
        public string CUIT { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string email, string telefono, string direccion, string cuit) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
        }

       public string PropiedadesCliente()
        {
            return "Los datos del cliente son: " + "\n\nNombre: " + Nombre + "\nApellido: " + Apellido + "\nCUIT: " + CUIT + "\nEmail: " + Email + "\nTelefono: " + Telefono + "\nDireccion: " + Direccion;
        }
    }
}
