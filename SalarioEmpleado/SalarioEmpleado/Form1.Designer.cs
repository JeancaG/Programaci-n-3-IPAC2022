namespace SalarioEmpleado
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
            this.VentasTextBox = new System.Windows.Forms.TextBox();
            this.IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProcesarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VentasTextBox
            // 
            this.VentasTextBox.Location = new System.Drawing.Point(296, 222);
            this.VentasTextBox.Name = "VentasTextBox";
            this.VentasTextBox.Size = new System.Drawing.Size(100, 23);
            this.VentasTextBox.TabIndex = 0;
            // 
            // IngresoDateTimePicker
            // 
            this.IngresoDateTimePicker.Location = new System.Drawing.Point(296, 167);
            this.IngresoDateTimePicker.Name = "IngresoDateTimePicker";
            this.IngresoDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.IngresoDateTimePicker.TabIndex = 1;
            // 
            // ProcesarButton
            // 
            this.ProcesarButton.Location = new System.Drawing.Point(296, 284);
            this.ProcesarButton.Name = "ProcesarButton";
            this.ProcesarButton.Size = new System.Drawing.Size(100, 29);
            this.ProcesarButton.TabIndex = 2;
            this.ProcesarButton.Text = "Procesar";
            this.ProcesarButton.UseVisualStyleBackColor = true;
            this.ProcesarButton.Click += new System.EventHandler(this.ProcesarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese la fecha de ingreso del empleado";
            // 
            // NacimientoDateTimePicker
            // 
            this.NacimientoDateTimePicker.Location = new System.Drawing.Point(296, 110);
            this.NacimientoDateTimePicker.Name = "NacimientoDateTimePicker";
            this.NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.NacimientoDateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese la fecha de nacimiento del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese las ventas del empleado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NacimientoDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcesarButton);
            this.Controls.Add(this.IngresoDateTimePicker);
            this.Controls.Add(this.VentasTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox VentasTextBox;
        private DateTimePicker IngresoDateTimePicker;
        private Button ProcesarButton;
        private Label label1;
        private DateTimePicker NacimientoDateTimePicker;
        private Label label2;
        private Label label3;
    }
}