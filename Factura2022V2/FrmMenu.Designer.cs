namespace Factura2022V2
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.ListarUsuariosToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.UsuariosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.ListarProductosToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.ListarProductosToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.ListarUsuariosToolStripEx.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.ListarProductosToolStripEx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem2;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(853, 120);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.ListarUsuariosToolStripEx);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Usuarios";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(68, 30);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Usuarios";
            // 
            // ListarUsuariosToolStripEx
            // 
            this.ListarUsuariosToolStripEx.AutoSize = false;
            this.ListarUsuariosToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.ListarUsuariosToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ListarUsuariosToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ListarUsuariosToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ListarUsuariosToolStripEx.Image = null;
            this.ListarUsuariosToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripButton});
            this.ListarUsuariosToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.ListarUsuariosToolStripEx.Name = "ListarUsuariosToolStripEx";
            this.ListarUsuariosToolStripEx.Office12Mode = false;
            this.ListarUsuariosToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ListarUsuariosToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarUsuariosToolStripEx.Size = new System.Drawing.Size(152, 54);
            this.ListarUsuariosToolStripEx.TabIndex = 0;
            this.ListarUsuariosToolStripEx.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripEx1_ItemClicked);
            // 
            // UsuariosToolStripButton
            // 
            this.UsuariosToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStripButton.Image = global::Factura2022V2.Properties.Resources.user;
            this.UsuariosToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsuariosToolStripButton.Name = "UsuariosToolStripButton";
            this.UsuariosToolStripButton.Size = new System.Drawing.Size(129, 37);
            this.UsuariosToolStripButton.Text = "Lista de usuarios";
            // 
            // toolStripTabItem2
            // 
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.Controls.Add(this.ListarProductosToolStripEx);
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 3;
            this.toolStripTabItem2.Panel.Text = "Productos";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(75, 30);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "Productos";
            // 
            // ListarProductosToolStripEx
            // 
            this.ListarProductosToolStripEx.AutoSize = false;
            this.ListarProductosToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.ListarProductosToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ListarProductosToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ListarProductosToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ListarProductosToolStripEx.Image = null;
            this.ListarProductosToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListarProductosToolStripButton});
            this.ListarProductosToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.ListarProductosToolStripEx.Name = "ListarProductosToolStripEx";
            this.ListarProductosToolStripEx.Office12Mode = false;
            this.ListarProductosToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ListarProductosToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarProductosToolStripEx.Size = new System.Drawing.Size(155, 54);
            this.ListarProductosToolStripEx.TabIndex = 0;
            // 
            // ListarProductosToolStripButton
            // 
            this.ListarProductosToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarProductosToolStripButton.Image = global::Factura2022V2.Properties.Resources.cubes;
            this.ListarProductosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListarProductosToolStripButton.Name = "ListarProductosToolStripButton";
            this.ListarProductosToolStripButton.Size = new System.Drawing.Size(126, 37);
            this.ListarProductosToolStripButton.Text = "Listar productos";
            this.ListarProductosToolStripButton.Click += new System.EventHandler(this.ListarProductosToolStripButton_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 517);
            this.Controls.Add(this.ribbonControlAdv1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.ListarUsuariosToolStripEx.ResumeLayout(false);
            this.ListarUsuariosToolStripEx.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.ListarProductosToolStripEx.ResumeLayout(false);
            this.ListarProductosToolStripEx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx ListarUsuariosToolStripEx;
        private System.Windows.Forms.ToolStripButton UsuariosToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx ListarProductosToolStripEx;
        private System.Windows.Forms.ToolStripButton ListarProductosToolStripButton;
    }
}