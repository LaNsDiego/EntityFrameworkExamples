using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesEntityFramework.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string Alias { get; set; }
        public string Clave { get; set; }
        //public int EmpleadoID { get; set; }
        [ForeignKey("Id")]
        public virtual Empleado Empleado { get; set; }
    }
}
