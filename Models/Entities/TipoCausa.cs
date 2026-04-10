namespace SimuladorSEJU.Models.Entities
{
    public class TipoCausa
    {
        public int Id { get; set; }
        public required string Nombre { get; set; } // Penal / No Penal

        public List<Causa>? Causas { get; set; }
    }
}
