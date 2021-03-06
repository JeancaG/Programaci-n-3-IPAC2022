using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Factura2022
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioAD usuarioAD = new UsuarioAD(); 
            Usuario usuario =  new Usuario();

            usuario = usuarioAD.Login(UsuarioTextBox.Text, ClaveTextBox.Text);

            if(usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }else if(!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario inactivo");
                return;
            }
            FrmUsuarios frmUsuarios =  new FrmUsuarios();
            frmUsuarios.Show();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
