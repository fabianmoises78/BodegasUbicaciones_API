using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class MARCASPRODUCTOS
    {
        [Key]
        public int MARC_ID { get; set; }
        public string MARC_CODIGO { get; set; }
        public string MARC_NOMBRE { get; set; }
        public bool MARC_ACTIVA { get; set; }
    }
}
