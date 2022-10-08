using System;
using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class DOCUMENTOSALIDA
    {
        [Key]
        public int DCMS { get; set; }
        public string DCMS_CODIGO { get; set; }
        public DateTime DCMS_FECHA { get; set; }
        public int EMP_ID { get; set; }
        public int PRV_ID { get; set; }
        public int UBI_IDENTRADA { get; set; }
        public int UBI_IDSALIDA { get; set; }
        public bool DCMS_ANULADO { get; set; }
        public string DCMS_CONCEPTO { get; set; }
        public bool DCMS_FINALIZADO { get; set; }
    }
}
