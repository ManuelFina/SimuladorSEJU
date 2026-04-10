namespace SimuladorSEJU.Models.Entities
{
    public class Notificacion
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }

        public string Mensaje { get; set; } = string.Empty;
        public bool Leida { get; set; }
        public DateTime Fecha { get; set; }
    }
}
