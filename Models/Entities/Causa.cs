namespace SimuladorSEJU.Models.Entities
{
    public class Causa
    {
        public int Id { get; set; }

        public int Circunscripcion { get; set; }
        public int Expediente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? UltimaPublicacion { get; set; }
        public required string Caratula { get; set; }

        // Relaciones
        public int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }

        public int TipoCausaId { get; set; }
        public required TipoCausa TipoCausa { get; set; }

        public int EstadoCausaId { get; set; }
        public required EstadoCausa EstadoCausa { get; set; }

        public int JuzgadoId { get; set; }
        public required Juzgado Juzgado { get; set; }

        public List<Publicacion>? Publicaciones { get; set; }
    }
}
