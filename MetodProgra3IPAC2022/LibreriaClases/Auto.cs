namespace LibreriaClases;

    public class Auto
    {
    //Atributos.
    private int id;
    /*private string modelo;
      private string precio;
      private string km;*/

    //Propiedades.
    public int Id { get => id; set => id = value; }

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
    public int Km { get; set; }

    //Contructores
    public Auto()
    {
    }
    public Auto(int id, string marca)
    {
        Id = id;
        Marca = marca;
    }

    //Metodos
    public string DevolverDatosAuto()
    {
        return "Id: " + Id + " Marca: " + Marca + " Modelo: " + Modelo;
    }
}
