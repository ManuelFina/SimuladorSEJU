namespace SimuladorSEJU.Models.Entities
{
    public class Publicacion
    {
        public int Id { get; set; }

        public int CausaId { get; set; }
        public required Causa Causa { get; set; }

        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
