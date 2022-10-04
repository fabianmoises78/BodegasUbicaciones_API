using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class CATEGORIAPRODUCTOS
    {
        [Key]
        public int CTGPRD_ID { get; set; }
        public string CTGPRD_CODIGO { get; set; }
        public string CTGPRD_NOMBRE { get; set; }
        public bool CTGPRD_ACTIVA { get; set; }
    }
}
