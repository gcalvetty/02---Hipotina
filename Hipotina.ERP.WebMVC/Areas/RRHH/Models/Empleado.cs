using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hipotina.ERP.WebMVC.Areas.RRHH.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        public int Emp_ID { get; set; }
        public string Emp_nombre { get; set; }
        public string Emp_ape_paterno { get; set; }
        public string Emp_ape_materno { get; set; }
        public DateTime Emp_fech_Ingreso { get; set; }

        public virtual ICollection<EmpleadoDato> EmpleadoDato { get; set; }

    }
}