using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Hipotina.ERP.WebMVC.Areas.RRHH.Models
{
    
    public enum sexo { Masculino, Femenino }
    public enum estadocivil { Soltero, Casado, Divorciado, Viudo}

    [Table("Datos del Empleados")]
    public class EmpleadoDato
    {
        [Key]
        public int Empd_ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Empd_fecNac { get; set; }        
        public string Empd_ci { get; set; }
        public estadocivil? Empd_estadocivil { get; set; }               
        public sexo? Empd_sexo { get; set; }

        [DataType(DataType.PhoneNumber)]
        public Nullable<int> Empd_telf { get; set; }

        [DataType(DataType.PhoneNumber)]
        public Nullable<int> Empd_movil { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Empd_email { get; set; }

        /* --- Relacion EmpleadoDato -> Empleado --- */
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}