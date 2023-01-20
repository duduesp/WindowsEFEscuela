using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Modelos
{
    public class Aula
    {
        public int Id { get; set; }


        [Required]
        public int Capacidad { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(1)]
        [Required]
        public string Codigo { get; set; }
    }
}
