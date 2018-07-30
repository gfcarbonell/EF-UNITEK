using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITEK.Modelos
{
    [Table("Alumnos")] //Anotación para dar nombre a nuestra tabla al realizar la migración
    public class Alumno
    {
        [Key] //Anotación para establecer la llave primaria a nuestra tabla
        [Column("id_alumno")] //Anotación para dar nombre a una columna de nuestra tabla
        [Required] //Anotación que obliga a no tener valores nulos
        public int IdAlumno  { get; set; }

        [Column("nombres")]
        [Required]
        [StringLength(50)] //Anotación permite establecer una cadena con valor máximo de 50 carácteres
        public string Nombres { get; set; }

        [Column("apellidos")]
        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }
    }
}
