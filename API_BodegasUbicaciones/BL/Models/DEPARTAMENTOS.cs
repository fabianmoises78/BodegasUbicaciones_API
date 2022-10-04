using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class DEPARTAMENTOS
    {
        [Key]
        public int DPT_ID { get; set; }
        public string DPT_CODIGO { get; set; }
        public string DPT_NOMBRE { get; set; }
        public bool DPT_ACTIVO { get; set; }
    }
}
