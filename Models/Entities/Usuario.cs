namespace SimuladorSEJU.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string NombreCompleto { get; set; }

        public List<Causa>? Causas { get; set; } 
    }
}
