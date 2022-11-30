namespace CorEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre 
        {
            get { return "Nombre de la escuela: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int añoCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela { get; set; }

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     this.añoCreación = año;
        // }
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            this.nombre = nombre;
            añoCreación = año;
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre{this.Nombre}, Tipo: {this.TiposEscuela}, País: {this.Pais}, Ciudad: {this.Ciudad}";
        }
    }
}