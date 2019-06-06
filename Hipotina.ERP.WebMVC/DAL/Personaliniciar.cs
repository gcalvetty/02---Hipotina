using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Hipotina.ERP.WebMVC.Models;

namespace Hipotina.ERP.WebMVC.DAL
{
    public class Personaliniciar : System.Data.Entity.DropCreateDatabaseIfModelChanges<HipotinaContext>
    {
        protected override void Seed(HipotinaContext context) {
            var Empleados = new List<Personal> {
                new Personal{ PER_ID = 1, PER_Nombre = "Misael",    PER_FecIngreso=DateTime.Parse("1/01/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},
                new Personal{ PER_ID = 2, PER_Nombre = "Veronica",  PER_FecIngreso=DateTime.Parse("1/02/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},
                new Personal{ PER_ID = 3, PER_Nombre = "Juan",      PER_FecIngreso=DateTime.Parse("1/03/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},

                new Personal{ PER_ID = 4, PER_Nombre = "Guillermo", PER_FecIngreso=DateTime.Parse("20/05/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
                new Personal{ PER_ID = 5, PER_Nombre = "Luis",      PER_FecIngreso=DateTime.Parse("21/06/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
                new Personal{ PER_ID = 6, PER_Nombre = "Christian", PER_FecIngreso=DateTime.Parse("22/07/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
            };            
            Empleados.ForEach(s => context.Personales.Add(s));
            context.SaveChanges();
            /* -------------- */
            var DatEmpleados = new List<PersonalDatos>
            {
                new PersonalDatos { PD_ID = 1, PD_CI = "1111111", PD_FecNac = DateTime.Parse("01/01/1990"), PD_Telf = 4523687, PD_Movil = 75428965 },
                new PersonalDatos { PD_ID = 2, PD_CI = "2222222", PD_FecNac = DateTime.Parse("10/02/1990"), PD_Telf = 4458759, PD_Movil = 75254586 },
                new PersonalDatos { PD_ID = 3, PD_CI = "3333333", PD_FecNac = DateTime.Parse("20/03/1990"), PD_Telf = 4352456, PD_Movil = 75328965 },
                new PersonalDatos { PD_ID = 4, PD_CI = "4444444", PD_FecNac = DateTime.Parse("30/04/1990"), PD_Telf = 4723687, PD_Movil = 65428965 },
                new PersonalDatos { PD_ID = 5, PD_CI = "5555555", PD_FecNac = DateTime.Parse("05/05/1990"), PD_Telf = 4832145, PD_Movil = 68428965 },
                new PersonalDatos { PD_ID = 6, PD_CI = "6666666", PD_FecNac = DateTime.Parse("15/06/1990"), PD_Telf = 4915987, PD_Movil = 62428965 },
            };
            DatEmpleados.ForEach(s => context.PersonalDatoses.Add(s));
            context.SaveChanges();
        }
    }
}