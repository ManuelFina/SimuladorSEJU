namespace SimuladorSEJU.Models.Entities
{
    public class Juzgado
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }

        public List<Causa>? Causas { get; set; }
    }
}
