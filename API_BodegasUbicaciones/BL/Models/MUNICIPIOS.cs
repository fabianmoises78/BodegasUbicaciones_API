using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class MUNICIPIOS
    {
        [Key]
        public int? MUN_ID { get; set; }
        public string MUN_CODIGO { get; set; }
        public string MUN_NOMBRE { get; set; }
        public int? DPT_ID { get; set; }
        public bool MUN_ACTIVO { get; set; }
    }
}
