namespace SimpleAPI.Models
{
    public class Parcial
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public float Calificacion { get; set; }
        public string Nombre { get; set; } = "Sin nombre de parcial";
        public string Descripcion { get; set; } = "Sin descripcion";
        public int Ausencias { get; set; } = 0;
    }
}
