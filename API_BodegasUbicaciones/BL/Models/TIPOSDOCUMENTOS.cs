using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class TIPOSDOCUMENTOS
    {
        [Key]
        public int TPDC_ID { get; set; }
        public string TPDC_CODIGO { get; set; }
        public string TPDC_NOMBRE { get; set; }
        public bool TPDC_ESINTERNO { get; set; }
        public bool TPDC_ESFORMAL { get; set; }
        public int? TPMV_ID { get; set; }
        public bool TPDC_ACTIVO { get; set; }
    }
}
