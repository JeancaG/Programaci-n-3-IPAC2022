namespace AlmacenarArreglos;

    public partial class Form1 : Form
    {
        string[] nombres = new string[10] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "};
        int[] edad = new int[10]{0,0,0,0,0,0,0,0,0,0};
    int posicion = 0;
        public Form1()
        {
            InitializeComponent();
        }


    private void AgregarAlumnoButton_Click(object sender, EventArgs e)
    {
        nombres[posicion] = NombreAlumnoTextBox.Text;
        edad[posicion] = Convert.ToInt32(EdadAlumnoTextBox.Text);
        posicion++;
        NombreAlumnoTextBox.Clear();
        EdadAlumnoTextBox.Clear();
    }

    private void MostrarButton_Click(object sender, EventArgs e)
    {
        for(int i = 0; i < nombres.Length; i++)
        {
            if(nombres[i] == " " && edad[i] == 0)
            {

            }
            else
            {
                listBox1.Items.Add("El nombre del alumno es: " + nombres[i] + " Y su edad es: "+ edad[i]);
                
            }
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}