namespace SalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            /*int ventas = 10000;
            int edad = 30;
            int aniosLaborando = 10;
            DateTime Nacimiento = NacimientoDateTimePicker.Value;
            DateTime Ingreso = IngresoDateTimePicker.Value;
            MessageBox.Show(Nacimiento.Year.ToString());
            if (edad >= Nacimiento.Year)
            {
                MessageBox.Show("Su edad es mayor de 30", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Nacimiento.Year >= edad)
            {
                MessageBox.Show("Su edad es menor de 30", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (aniosLaborando >= Ingreso.Year)
            {
                MessageBox.Show("Su fecha de ingreso es mayor a 10 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ingreso.Year >= aniosLaborando)
            {
                MessageBox.Show("Su fecha de ingreso es menor a 10 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            int edad = Convert.ToInt32(NacimientoDateTimePicker);
            int laborando = Convert.ToInt32(IngresoDateTimePicker);
            int vendido = Convert.ToInt32(VentasTextBox.Text);
            FechaEdad(edad);
            AnioIngreso(laborando);
            vend(vendido);
        }

        void FechaEdad(int num){
            if (num >= 30){
                MessageBox.Show("Su edad es mayor a 30 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Su edad es menor a 30 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void AnioIngreso(int num){
            if (num >= 1){
                MessageBox.Show("El tiempo en el que ingreso es mayor a 10 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("El tiempo en el que ingreso es menor a 10 anios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void vend(int num){
            if (num >= 10000){
                MessageBox.Show("Las ventas son mayores a 10,000", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
{
                MessageBox.Show("El ventas son menores a 10,000", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}