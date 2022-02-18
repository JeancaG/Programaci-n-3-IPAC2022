namespace MetodProgra3IPAC2022
{
    partial class ArreglosMatrices
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
            this.MatrizButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MatrizButton
            // 
            this.MatrizButton.Location = new System.Drawing.Point(375, 173);
            this.MatrizButton.Name = "MatrizButton";
            this.MatrizButton.Size = new System.Drawing.Size(100, 33);
            this.MatrizButton.TabIndex = 0;
            this.MatrizButton.Text = "Matriz";
            this.MatrizButton.UseVisualStyleBackColor = true;
            this.MatrizButton.Click += new System.EventHandler(this.MatrizButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(345, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 139);
            this.listBox1.TabIndex = 1;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(99, 173);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(100, 33);
            this.EjecutarButton.TabIndex = 2;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(66, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(166, 139);
            this.listBox2.TabIndex = 3;
            // 
            // ArreglosMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MatrizButton);
            this.Name = "ArreglosMatrices";
            this.Text = "ArreglosMatrices";
            this.Load += new System.EventHandler(this.ArreglosMatrices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button MatrizButton;
        private ListBox listBox1;
        private Button EjecutarButton;
        private ListBox listBox2;
    }
}