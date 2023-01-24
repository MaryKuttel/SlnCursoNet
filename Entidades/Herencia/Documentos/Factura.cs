
using Entidades.Herencia.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades.Documentos
{
    public class Factura : DocumentoComercial
    {

        public string Tipo { get; set; }



        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total, string tipo) : base (numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
           
        }

        public override string PropiedadesDocumentoComercial()
        {
            return base.PropiedadesDocumentoComercial() + "\nTipo: " + Tipo;
        }
    }
}
