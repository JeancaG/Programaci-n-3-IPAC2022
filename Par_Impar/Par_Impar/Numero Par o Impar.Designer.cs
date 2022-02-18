namespace Par_Impar
{
    partial class Numero_Par_o_Impar
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
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(276, 36);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumeroTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Igrese un numero entero";
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(276, 92);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(100, 34);
            this.GenerarButton.TabIndex = 2;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // Numero_Par_o_Impar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroTextBox);
            this.Name = "Numero_Par_o_Impar";
            this.Text = "Numero_Par_o_Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NumeroTextBox;
        private Label label1;
        private Button GenerarButton;
    }
}