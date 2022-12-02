namespace CorEscuela.Entidades
{
    public class Escuela
    {
        // ATRIBUTOS
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre 
        {
            get { return "Nombre de la escuela: " + nombre; }
            set { nombre = value; }
        }
        public int añoCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela { get; set; }
        public List<Curso> Cursos { get; set; }


        // CONSTRUCTOR
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            this.nombre = nombre;
            añoCreación = año;
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"{this.Nombre}, Tipo: {this.TiposEscuela}, País: {this.Pais}, Ciudad: {this.Ciudad}";
        }
    }
}