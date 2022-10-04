using System;
using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class DOCUMENTOENTRADA
    {
        [Key]
        public int DCME { get; set; }
        public string DCME_CODIGO { get; set; }
        public DateTime DCME_FECHA { get; set; }
        public int EMP_ID { get; set; }
        public int PRV_ID { get; set; }
        public int UBI_IDENTRADA { get; set; }
        public int UBI_IDSALIDA { get; set; }
        public double DCME_IVA { get; set; }
        public double DCME_TOTALANTIMP { get; set; }
        public bool DCME_ANULADO { get; set; }
        public string DCME_CONCEPTO { get; set; }
        public bool DCME_FINALIZADO { get; set; }
    }
}
