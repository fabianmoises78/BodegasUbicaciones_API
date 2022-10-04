using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class DETALLEDOCUMENTOSALIDA
    {
        [Key]
        public int DTDS_ID { get; set; }
        public int DCMS_ID { get; set; }
        public int PRD_ID { get; set; }
        public int DTDS_CANTIDAD { get; set; }
        public double DTDS_PRECIOUNITARIO { get; set; }
        public double DTDS_DESCUENTO { get; set; }
        public double DTDS_SUBTOTAL { get; set; }
    }
}
