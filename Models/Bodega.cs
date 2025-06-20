namespace AdminBodegas.Models
{
    public class Bodega
    {
        public string bodega_c { get; set; } = string.Empty;
        public string bodega_n { get; set; } = string.Empty;
        public double latitud { get; set; }
        public double lngitud { get; set; }
        public List<Visita> visitas { get; set; }
    }
}
