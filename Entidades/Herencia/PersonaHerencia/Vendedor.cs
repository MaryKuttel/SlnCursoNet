using Entidades.Herencia.PersonaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades.PersonaHerencia
{
    public class Vendedor : Persona
    {

        public string DNI { get; set; }

        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dni) : base(nombre, apellido, email, telefono, direccion)
        {           
            DNI= dni;
        }

        public override string PropiedadesPersona()
        {
            return base.PropiedadesPersona() + "\nDNI: " + DNI;
        }
    }
}
