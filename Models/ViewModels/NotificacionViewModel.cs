namespace SimuladorSEJU.Models.ViewModels
{
    public class NotificacionViewModel
    {
        public required string Mensaje { get; set; }
        public bool Leida { get; set; }
        public DateTime Fecha { get; set; }
    }
}
