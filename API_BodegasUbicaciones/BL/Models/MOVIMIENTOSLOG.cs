using System;
using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class MOVIMIENTOSLOG
    {
        [Key]
        public int? MOV_ID { get; set; }
        public string MOV_CODIGO { get; set; }
        public DateTime MOV_FECHA { get; set; }
        public int? DCMS_ID { get; set; }
        public int? DCME_ID { get; set; }
        public int? TPMV_ID { get; set; }
        public string MOV_DESCRIPCION { get; set; }
    }
}
