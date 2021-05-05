using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "El campo debe tener al menos {1} caracter")]
        public string Nombre { get; set; }
        [Range(18, 120)]// la edad debe ser entre 18 y 120
        public int edad { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }
        [Url]
        public string Url { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
