namespace MetodProgra3IPAC2022
{
    partial class FuncionesAsincronicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.HornearButton = new System.Windows.Forms.Button();
            this.OtrosProcesosButton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(149, 57);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(93, 43);
            this.HornearButton.TabIndex = 1;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // OtrosProcesosButton2
            // 
            this.OtrosProcesosButton2.Location = new System.Drawing.Point(321, 57);
            this.OtrosProcesosButton2.Name = "OtrosProcesosButton2";
            this.OtrosProcesosButton2.Size = new System.Drawing.Size(88, 43);
            this.OtrosProcesosButton2.TabIndex = 2;
            this.OtrosProcesosButton2.Text = "Otras Tareas";
            this.OtrosProcesosButton2.UseVisualStyleBackColor = true;
            this.OtrosProcesosButton2.Click += new System.EventHandler(this.OtrosProcesosButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(266, 291);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 23);
            this.SumarButton.TabIndex = 5;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // FuncionesAsincronicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OtrosProcesosButton2);
            this.Controls.Add(this.HornearButton);
            this.Controls.Add(this.label1);
            this.Name = "FuncionesAsincronicas";
            this.Text = "FuncionesAsincronicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button HornearButton;
        private Button OtrosProcesosButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SumarButton;
    }
}