using CorEscuela.Entidades;

namespace ProyectoEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Plazti School", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald","Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura { Nombre = "Matemáticas" },
                    new Asignatura { Nombre = "Educación Física" },
                    new Asignatura { Nombre = "Lengua" },
                    new Asignatura { Nombre = "Inglés" }
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }
        private void CargarEvaluaciones()
        {
            
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso() {
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                    new Curso() {
                    Nombre = "201",
                    Jornada = TiposJornada.Mañana
                },
                    new Curso() {
                    Nombre = "301",
                    Jornada = TiposJornada.Mañana
                },
                    new Curso() {
                    Nombre = "401",
                    Jornada = TiposJornada.Tarde
                },
                    new Curso() {
                    Nombre = "501",
                    Jornada = TiposJornada.Tarde
                }
            };

            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 30);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);               
            }
        }
    }
}