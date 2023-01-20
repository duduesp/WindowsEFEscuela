using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WindowsEFEscuela.Modelos
{
    [Table("Alumno")]
    public class Alumno
    {

        [Key]
        public int IdAlumno { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }


        public DateTime? FechaNacimiento { get; set; }

        public Profesor Profesor { get; set; }

        [ForeignKey("ProfesorId")]
        public int ProfesorId { get; set; }


    }
}
