using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hipotina.ERP.WebMVC.Models
{
    [Table("PersonalDatos")]
    public class PersonalDatos
    {
        [Key]
        public int PD_ID { get; set; }
        public DateTime PD_FecNac { get; set; }
        public String PD_CI { get; set; }
        public int PD_Telf { get; set; }
        public int PD_Movil { get; set; }

        public virtual Personal Personal { get; set; }
            
    }
}