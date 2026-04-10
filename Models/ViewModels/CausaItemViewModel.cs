namespace SimuladorSEJU.Models.ViewModels
{
    public class CausaItemViewModel
    {
        public int Circunscripcion { get; set; }
        public int Expediente { get; set; }
        public DateTime Fecha { get; set; }
        public string? Caratula { get; set; }

        public string? Estado { get; set; }
        public string? Juzgado { get; set; }

        public DateTime? UltimaPublicacion { get; set; }
    }
}
