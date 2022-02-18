using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_Impar
{
    public partial class Numero_Par_o_Impar : Form
    {
        public Numero_Par_o_Impar()
        {
            InitializeComponent();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(NumeroTextBox.Text);

            if (numero % 2 == 0)
            {
                MessageBox.Show("El numero es par");
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }

            if(esPrimo(numero))
            {
                MessageBox.Show("Es primo");
            }
            else
            {
                MessageBox.Show("No es primo");
            }

        }

        private bool esPrimo(int num)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < num)
            {
                resto = num % divisor;
                if(resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }
    }
}
