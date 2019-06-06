using System;
using System.Data.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hipotina.ERP.WebMVC.Models
{
    [Table("Personal")]
    public class Personal
    {
        [Key]
        public int PER_ID { get; set; }
        public int PER_TipoPersonal { get; set; }
        public string PER_Nombre { get; set; }
        public DateTime PER_FecIngreso { get; set; }
        public DateTime PER_FecSalida { get; set; }

        public virtual ICollection<PersonalDatos> PersonalDatos { get; set; }

        public class HipotinaDBContext : DbContext
        {
            public HipotinaDBContext(): base(){ }
            public DbSet<Personal> Personal { get; set; }
        }
    }
}