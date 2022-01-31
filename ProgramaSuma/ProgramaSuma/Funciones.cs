namespace ProgramaSuma
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1textBox.Text);
            int num2 = Convert.ToInt32(Numero2textBox.Text);

            Sumar(num1, num2);

            ResultadotextBox.Text = Sumar(num1, num2).ToString();

        }

        private int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        private void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }
    }
}