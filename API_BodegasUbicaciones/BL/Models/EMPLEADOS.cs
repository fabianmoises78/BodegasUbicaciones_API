using System.ComponentModel.DataAnnotations;

namespace API_BodegasUbicaciones.BL.Models
{
    public class EMPLEADOS
    {
        [Key]
        public int? EMP_ID { get; set; }
        public string EMP_CODIGO { get; set; }
        public string EMP_NOMBRES { get; set; }
        public string EMP_APELLIDOS { get; set; }
        public int? MUN_ID { get; set; }
        public int? UBI_ID { get; set; }
        public int? CTGEMP_ID { get; set; }
        public string EMP_TELEFONO { get; set; }
        public bool EMP_ACTIVO { get; set; }
    }
}
