namespace AdminBodegas.Models
{
    public class Coordinacion
    {
        public string coordinacion { get; set; } = string.Empty;
        public List<Bodega> bodegas { get; set; } = new List<Bodega>();
    }
}
