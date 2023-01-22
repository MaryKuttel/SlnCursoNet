using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public string Proovedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal PrecioBruto
        {
            get { return (PrecioCosto + (Convert.ToDecimal(this.Margen))); }
        }
        public decimal PrecioVenta
        {
            get { return (PrecioCosto + (Convert.ToDecimal(1 + this.IVA))); }
        }
        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double IVA, string proovedor, string categoria, string subcategoria)
        {

            Nombre= nombre;
            Descripcion= descripcion;
            PrecioCosto= precioCosto;
            Margen= margen;
            this.IVA= IVA;
            Proovedor= proovedor;
            Categoria= categoria;
            SubCategoria= subcategoria;
        }

        public string PropiedadesProducto()
        {
            return "Los datos del Producto son: " + "\n\nNombre: " + Nombre + "\nDescripcion: " + Descripcion + "\nPrecioCosto: " + PrecioCosto + "\nMargen: " + Margen + "\nIVA: " + IVA + "\nProovedor: " + Proovedor + "\nCategoria: " + Categoria + "\nSubcategoria: " + SubCategoria + "\nPrecio Bruto: " + PrecioBruto + "\nPrecio Venta: " + PrecioVenta;
        }


    }

}
