using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodProgra3IPAC2022
{
    public partial class FuncionRecursiva : Form
    {
        public FuncionRecursiva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoAUno(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void RecorrerDeUnoAUno(int valorInicial, int ValorFinal)
        {
            listBox1.Items.Add(valorInicial);

            if(valorInicial < ValorFinal)
            {
                RecorrerDeUnoAUno(valorInicial + 1, ValorFinal);
            }
        }

    }
}
