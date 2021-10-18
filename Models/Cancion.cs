using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApicancion2.Models
{
    public class Cancion
    {
        [Key]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Autor { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {10} y {200}")]
        public string Letra { get; set; }

        [Url]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {1} y {1000}")]
        public string Enlace { get; set; }
    }
}
