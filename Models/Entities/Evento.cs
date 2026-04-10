namespace SimuladorSEJU.Models.Entities
{
    public class Evento
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }

        public required string Titulo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
