using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class CATEGORIASEMPLEADOS
    {
        [Key]
        public int? CTGEMP_ID { get; set; }
        public string CTGEMP_CODIGO { get; set; }
        public string CTGEMP_NOMBRE { get; set; }
        public bool CTGEMP_ACTIVA { get; set; }
    }
}
