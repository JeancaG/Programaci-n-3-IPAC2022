using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionIPAC2022
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            LongitudTextBox.Text = cadena.Length.ToString();

            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            RangoTextBox.Text = cadena.Substring(12, 20);

            MayusculaTextBox.Text = cadena.ToUpper();

            MinusculaTextBox.Text = cadena.ToLower();

           
        }
    }
}
