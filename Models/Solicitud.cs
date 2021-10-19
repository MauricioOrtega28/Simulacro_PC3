using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Simulacro_PC3.Models
{
    [Table("t_solicitud")]
    public class Solicitud
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        public string Nombre {get; set; }

        public string Foto {get; set; }

        public string Descripcion {get; set;}

        public double Precio {get; set; }

        public string Celular {get; set; }

        public string Lugar {get; set; }

        public string Comprador {get; set; }

        public DateTime Fecha {get; set; }

        public Categoria categoria {get; set; }

        public Solicitud(){
            this.Fecha=new DateTime();
        }
    }
}