using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Factura2022V2
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductoAD productoAD = new ProductoAD();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;   
            ExistenciTextBox.Enabled = true;
            BuscarImagenButton.Enabled = true;

            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciTextBox.Enabled = false;
            BuscarImagenButton.Enabled = false;

            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false ;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciTextBox.Clear();
            ImagenPictureBox.Image = null;

         
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el codigo");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripcion");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un Precio");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciTextBox, "Ingrese un Precio");
                    CodigoTextBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencia = Convert.ToInt32(ExistenciTextBox.Text);

                if(ImagenPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    producto.Imagen = ms.GetBuffer();
                }
              

                if (operacion == "Nuevo")
                {
                    bool inserto = productoAD.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
                else if(operacion == "Modificar")
                {
                    bool modifico = productoAD.ModificarProducto(producto);
                    
                    if (modifico)
                    {
                        MessageBox.Show("Producto modificado correctamente");
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                    }
                    else
                    {
                        MessageBox.Show("Producto no se pudo modificar");
                    }
                }
            }
            catch (Exception)
            {
            }
            

        }

        private void BuscarImagenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ImagenPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ProductoDataGridView.DataSource = productoAD.ListarProductos();
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PrecioTextBox, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ExistenciTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }      
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductoDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ProductoDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ProductoDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                PrecioTextBox.Text = ProductoDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciTextBox.Text = ProductoDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                var temporal =  productoAD.SeleccionarImagen(ProductoDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if(temporal.Length > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(temporal);
                    ImagenPictureBox.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                {
                    ImagenPictureBox.Image =  null;
                }
                HabilitarControles();
                CodigoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(ProductoDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = productoAD.EliminarProducto(CodigoTextBox.Text = ProductoDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

