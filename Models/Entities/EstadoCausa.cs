namespace SimuladorSEJU.Models.Entities
{
    public class EstadoCausa
    {
        public int Id { get; set; }
        public required string Nombre { get; set; } // Activo, Cerrado, etc.

        public List<Causa>? Causas { get; set; }
    }
}
