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

        FrmUsuarios frmUsuarios = null;
        FrmProducto frmProductros = null;
        FrmFactura frmFactura = null;
        private void toolStripEx1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (frmUsuarios == null)
            {
                frmUsuarios = new FrmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.FormClosed += FrmUsuarios_FormClosed;
                frmUsuarios.Show();
            }
            else
            {
                frmUsuarios.Activate();
            }
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUsuarios = null;
        }

        private void ListarProductosToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProductros == null)
            {
                frmProductros = new FrmProducto();
                frmProductros.MdiParent = this;
                frmProductros.FormClosed += FrmProductros_FormClosed;
                frmProductros.Show();
            }
            else
            {
                frmProductros.Activate();
            }
        }

        private void FrmProductros_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductros = null;
        }

        private void NuevaFacturaToolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmFactura == null)
            {
                frmFactura = new FrmFactura();
                frmFactura.MdiParent = this;
                frmFactura.FormClosed += FrmFactura_FormClosed;
                frmFactura.Show();
            }
            else
            {
                frmFactura.Activate();
            }
        }

        private void FrmFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFactura = null;
        }
    }
}
