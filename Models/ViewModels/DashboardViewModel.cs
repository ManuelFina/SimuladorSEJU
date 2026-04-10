namespace SimuladorSEJU.Models.ViewModels
{
    public class DashboardViewModel
    {
        // Contadores (cards superiores)
        public int Penales { get; set; }
        public int NoPenales { get; set; }
        public int Notificaciones { get; set; }
        public int AgendaEventos { get; set; }
        public int Cargos { get; set; }

        // Usuario actual
        public required string NombreUsuario { get; set; }

        // Listado de causas
        public List<CausaItemViewModel> Causas { get; set; }
    }
}
