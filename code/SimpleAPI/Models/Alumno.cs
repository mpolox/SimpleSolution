namespace SimpleAPI.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; } = DateTime.Now;
        public string Matricula { get; set; }
        public string Nota { get; set; }

    }
}
