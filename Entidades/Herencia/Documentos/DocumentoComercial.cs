using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Herencia.Documentos
{
    public abstract class DocumentoComercial
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }

        public DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;

        }
        public virtual string PropiedadesDocumentoComercial()
        {
            return "Los datos del Documento son: " + "\n\nNumero: " + Numero + "\nFecha: " + Fecha + "\nCliente: " + Cliente + "\nDireccion: " + Direccion + "\nCondicionIVA: " + CondicionIVA + "\nCondicionVenta: " + CondicionVenta + "\nDetalle: " + Detalle + "\nTotal: " + Total;
        }
    }
}
