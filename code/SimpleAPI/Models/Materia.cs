namespace SimpleAPI.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string NombreMaestro { get; set; }
        public List<Parcial> Parciales { get; set; }
        public int Creditos { get; set; }

    }
}
