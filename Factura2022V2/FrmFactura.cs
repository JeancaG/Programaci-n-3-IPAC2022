using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Factura2022V2
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        ProductoAD productoAD = new ProductoAD();
        Factura factura = new Factura();
        Producto producto;

        List<DetalleFactura> detalleFacturaLista = new List<DetalleFactura>();
        decimal subTotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalAPagar = decimal.Zero;

        private void FrmFactura_Load(object sender, System.EventArgs e)
        {
            DetalleDataGridView1.DataSource = detalleFacturaLista;
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoAD.GetProductoPorCodigo(CodigoProductoTextBox.Text);
                DescripcionTextBox.Text = producto.Descripcion;
                CantidadTextBox.Focus();
            }
            else
            {
                producto = null;
                DescripcionTextBox.Clear();
                CantidadTextBox.Clear();
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                DetalleFactura detalleFactura = new DetalleFactura();
                detalleFactura.CodigoProducto = producto.Codigo;
                detalleFactura.Descripcion = producto.Descripcion;
                detalleFactura.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                detalleFactura.Precio = producto.Precio;
                detalleFactura.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);

                subTotal += detalleFactura.Total;
                isv = subTotal * 0.15M;

                totalAPagar = subTotal + isv;

                detalleFacturaLista.Add(detalleFactura);
                DetalleDataGridView1.DataSource = null;
                DetalleDataGridView1.DataSource = detalleFacturaLista;
            }
            else
            {
               
            }
        }
    }
}
