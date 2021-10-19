using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Simulacro_PC3.Models
{
    [Table("t_categoria")]

    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

         public int Id {get; set; }

         public string Nombre {get; set; }

         public ICollection<Solicitud> Solicitudes {get; set; }

    }
}