using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models.ModelSP
{
    public class PRODUCTO_RESULT
    {
        [Key]
        public int PRD_ID { get; set; }
        public string PRD_CODIGO { get; set; }
        public string PRD_NOMBRE { get; set; }
        public int CTGPRD_ID { get; set; }
        public string CTGPRD_NOMBRE { get; set; }
        public int MARC_ID { get; set; }
        public string MARC_NOMBRE { get; set; }
        public double PRD_PRECIOVENTA { get; set; }
        public double PRD_COSTO { get; set; }
        public string PRD_URLIMG { get; set; }
        public bool PRD_ACTIVO { get; set; }
        public double PRD_PRCGANC { get; set; }
    }
}
