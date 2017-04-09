using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto nuevoProducto;
        Almacen nuevoAlmacen = new Almacen();
        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtCosto.Text);
            nuevoProducto = new Producto(codigo, nombre, cantidad, costo);
            nuevoAlmacen.agregarProducto(nuevoProducto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto productoBuscado = nuevoAlmacen.buscarProducto(Convert.ToInt16(txtCodigo.Text));
            if (productoBuscado == null)
            {

            }
            else
                txtReporte.Text = productoBuscado.ToString();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = nuevoAlmacen.reporte();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtCosto.Text);
            nuevoProducto = new Producto(codigo, nombre, cantidad, costo);
            nuevoAlmacen.insertarProducto(int.Parse(txtInsertar.Text),nuevoProducto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nuevoAlmacen.eliminarProducto(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
