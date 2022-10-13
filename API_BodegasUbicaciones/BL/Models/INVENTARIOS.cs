using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class INVENTARIOS
    {
        [Key]
        public int? INV_ID { get; set; }
        public string INV_CODIGO { get; set; }
        public int? PRD_ID { get; set; }
        public int INV_EXISTENCIASMIN { get; set; }
        public int INV_EXISTENCIASMAX { get; set; }
        public int INV_EXISTENCIAS { get; set; }
    }
}
