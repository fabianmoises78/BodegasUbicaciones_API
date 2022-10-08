using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class UBICACIONES
    {
        [Key]
        public int UBI_ID { get; set; }
        public string UBI_CODIGO { get; set; }
        public string UBI_NOMBRE { get; set; }
        public int? MUN_ID { get; set; }
        public string UBI_DIRECCION { get; set; }
        public bool UBI_ACTIVA { get; set; }
        public bool UBI_ESPRINCIPAL { get; set; }
    }
}
