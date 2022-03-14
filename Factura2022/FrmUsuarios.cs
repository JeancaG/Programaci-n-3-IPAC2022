using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura2022
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioAD usuarioAD = new UsuarioAD();
        string operacion = string.Empty;
        Usuario user = new Usuario();

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void HabilitarControless()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ClaveTextBox.Enabled = true;
            comboBox1.Enabled = true;
            checkBox1.Enabled = true;

            NuevoButton.Enabled = true; 
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
        }


        private void ListarUsuarios()
        {
            UsuariosDataGridView.DataSource = usuarioAD.ListarUsuarios();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControless();
            operacion = "Nuevo";
        }

        private void CodigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            user.Codigo = CodigoTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Clave = ClaveTextBox.Text;
            user.Rol = comboBox1.Text;
            user.EstaActivo = checkBox1.Checked;

            bool inserto = usuarioAD.InsertarUsuario(user);

            if (inserto)
            {
                MessageBox.Show("Usuario Creado");
            }
            else
            {
                MessageBox.Show("El susuario no se ha podido crear");
            }

        }
    }
}
