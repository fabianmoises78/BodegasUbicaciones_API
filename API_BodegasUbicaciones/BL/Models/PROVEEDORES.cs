using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class PROVEEDORES
    {
        [Key]
        public int? PRV_ID { get; set; }
        public string PRV_CODIGO { get; set; }
        public string PRV_NOMBRE { get; set; }
        public string PRV_NIT { get; set; }
        public string PRV_NUMCONTACTO { get; set; }
        public string PRV_EMAIL { get; set; }
        public bool PRV_ESNACIONAL { get; set; }
        public string PRV_GIRO { get; set; }
        public int? MUN_ID { get; set; }
        public string PRV_DIRECCION { get; set; }
        public bool PRV_ACTIVO { get; set; }
    }
}
