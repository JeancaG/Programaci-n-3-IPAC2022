namespace ClasesLibreria;

    public class Coche
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
    public Coche() { 
    }
    public Coche(int id, string modelo) {
        Id = id;
        Modelo = modelo;
    }

    //Metodos
    public string DevolverDatosCoche()
    {
        return "Id: " + Id + " Marca: " + Marca + " Modelo: " + Modelo; 
    }

}
