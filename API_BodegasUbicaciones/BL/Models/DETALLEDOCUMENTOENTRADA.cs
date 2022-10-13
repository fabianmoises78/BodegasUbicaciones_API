using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class DETALLEDOCUMENTOENTRADA
    {
        [Key]
        public int? DTDE_ID { get; set; }
        public int? DCME_ID { get; set; }
        public int? PRD_ID { get; set; }
        public int DTDE_CANTIDAD { get; set; }
        public double DTDE_PRECIOUNITARIO { get; set; }
        public double DTDE_DESCUENTO { get; set; }
        public double DTDE_SUBTOTAL { get; set; }
    }
}
