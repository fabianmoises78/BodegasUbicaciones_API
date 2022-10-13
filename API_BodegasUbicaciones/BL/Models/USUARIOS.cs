using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_BodegasUbicaciones.BL.Models
{
    [Table("USUARIOS")]
    public class USUARIOS
    {
        [Key]
        public int? USR_ID { get; set; }
        public string USR_EMAIL { get; set; }
        public string USR_USRACCESO { get; set; }
        public string USR_PASSWORD { get; set; }
        public int? EMP_ID { get; set; }
        public bool USR_ACTIVO { get; set; }
    }
}
