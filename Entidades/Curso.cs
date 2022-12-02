namespace CorEscuela.Entidades
{
    public class Curso
    {
        // ATRIBUTOS
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }


        // CONSTRUCTOR
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}