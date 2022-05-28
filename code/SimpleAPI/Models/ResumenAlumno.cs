namespace SimpleAPI.Models
{
    public class ResumenAlumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public List<Materia> Materias { get; set; }
        public Alumno Alumno { get; set; }
    }
}
