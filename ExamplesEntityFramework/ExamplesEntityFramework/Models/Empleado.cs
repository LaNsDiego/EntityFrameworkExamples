using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesEntityFramework.Models
{
    [Table("Empleados")]
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [StringLength(8) , Index(IsUnique = true)]
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public NombresCargo Cargo { get; set; }
    }
}
