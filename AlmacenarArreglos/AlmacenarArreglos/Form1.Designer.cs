namespace AlmacenarArreglos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.EdadAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.AgregarAlumnoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreAlumnoTextBox
            // 
            this.NombreAlumnoTextBox.Location = new System.Drawing.Point(226, 107);
            this.NombreAlumnoTextBox.Name = "NombreAlumnoTextBox";
            this.NombreAlumnoTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreAlumnoTextBox.TabIndex = 3;
            // 
            // EdadAlumnoTextBox
            // 
            this.EdadAlumnoTextBox.Location = new System.Drawing.Point(226, 182);
            this.EdadAlumnoTextBox.Name = "EdadAlumnoTextBox";
            this.EdadAlumnoTextBox.Size = new System.Drawing.Size(100, 23);
            this.EdadAlumnoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el nombre del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese la edad del alumno";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(414, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 214);
            this.listBox1.TabIndex = 7;
            this.listBox1.Tag = "";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MostrarButton
            // 
            this.MostrarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MostrarButton.Location = new System.Drawing.Point(499, 307);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(114, 38);
            this.MostrarButton.TabIndex = 9;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // AgregarAlumnoButton
            // 
            this.AgregarAlumnoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarAlumnoButton.Location = new System.Drawing.Point(223, 307);
            this.AgregarAlumnoButton.Name = "AgregarAlumnoButton";
            this.AgregarAlumnoButton.Size = new System.Drawing.Size(114, 38);
            this.AgregarAlumnoButton.TabIndex = 10;
            this.AgregarAlumnoButton.Text = "Agregar Alumno";
            this.AgregarAlumnoButton.UseVisualStyleBackColor = true;
            this.AgregarAlumnoButton.Click += new System.EventHandler(this.AgregarAlumnoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Control de Alumnos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgregarAlumnoButton);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdadAlumnoTextBox);
            this.Controls.Add(this.NombreAlumnoTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox NombreAlumnoTextBox;
        private TextBox EdadAlumnoTextBox;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button MostrarButton;
        private Button AgregarAlumnoButton;
        private Label label3;
    }
}