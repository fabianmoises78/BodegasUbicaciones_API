using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class TIPOSMOVIMIENTOS
    {
        [Key]
        public int? TPMV_ID { get; set; }
        public string TPMV_CODIGO { get; set; }
        public string TPMV_NOMBRE { get; set; }
        public bool TPMV_ESPORENTRADA { get; set; }
        public bool TPMV_ESPORSALIDA { get; set; }
        public bool TPMV_ACTIVO { get; set; }
    }
}
