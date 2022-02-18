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
    public partial class ArreglosMatrices : Form
    {
        public ArreglosMatrices()
        {
            InitializeComponent();
        }

        private void MatrizButton_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = new int[2, 3]
                        {
                        {4,5,30 },
                        {9,7,10 }
                        };

            int[,] matriz2 = new int[3, 3];

            //Llenar matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = 4 + (fila + 4) * (columna + 3);
                }
            }
            //Mostrar matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posicion: [" + fila + "," + columna + "] = " + matriz2[fila, columna]);
                }
            }
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] arreglo1 = new int[5];
            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 30;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[6] {41,63,45,68,74,99};
            int[] arreglo3 = new int[] {2,5,1,3,7,6};
            int[] arreglo4 = {5,6,4,3,1,9,7};
            string[] arreglo5 = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            /*for (int i = 0; i < arreglo5.Length; i++){
                listBox2.Items.Add(arreglo5[i]);
            }*/

            foreach(String item in arreglo5){
                listBox2.Items.Add(item);
            }
 
        }

        private void ArreglosMatrices_Load(object sender, EventArgs e)
        {

        }
    }
}