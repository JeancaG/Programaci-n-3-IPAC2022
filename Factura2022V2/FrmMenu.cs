using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Factura2022V2
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        FrmUsuarios frmUsuarios;
        FrmProducto frmProductros;
        private void toolStripEx1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (frmUsuarios == null)
            {
                frmUsuarios = new FrmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }
            else
            {
                frmUsuarios.Activate();
            }
        }

        private void ListarProductosToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProductros == null)
            {
                frmProductros = new FrmProducto();
                frmProductros.MdiParent = this;
                frmProductros.Show();
            }
            else
            {
                frmProductros.Activate();
            }
        }
    }
}
