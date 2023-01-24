using Entidades.Herencia.EmpresaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;
using WindowsApp.Entidades.Documentos;
using WindowsApp.Entidades.PersonaHerencia;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto("Samsung S20", "Telefono Celular Liberado", (decimal)20.4, 10.5, 11.45, "Javier", "Celular", "Samsung");

            MessageBox.Show(producto.PropiedadesProducto());
        }

        private void bttnVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("Maria", "Kuttel", "mariakuttel@gmail.com", "33442211","123delacallefalsa", "42246234");

            MessageBox.Show(vendedor.PropiedadesPersona());

        }

        private void bttnEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa("CelularesJaimito", "2235511", "celujaime.com","CeluJaime@celujaime.com", "44455332", "123delacallesuperfalsa");

            MessageBox.Show(empresa.PropiedadesEmpresa());

        }

        private void bttnFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("22351", DateTime.Today, "Javier", "342calledellabor", "Si Posee", "Si Posee", "Factura detallada", (decimal)31.5, "Virtual");

            MessageBox.Show(factura.PropiedadesDocumentoComercial());

        }
    }
}
