using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/* --- Para Aplicar los modelos --- */
using Hipotina.ERP.WebMVC.Models;
using Hipotina.ERP.WebMVC.Areas.RRHH.Models;

namespace Hipotina.ERP.WebMVC.DAL
{
    public class HipotinaIniciar : System.Data.Entity.DropCreateDatabaseIfModelChanges<HipotinaContext>
    {
        protected override void Seed(HipotinaContext context) {
            var Personal = new List<Personal> {
                new Personal{ PER_ID = 1, PER_Nombre = "Misael",    PER_FecIngreso=DateTime.Parse("1/01/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},
                new Personal{ PER_ID = 2, PER_Nombre = "Veronica",  PER_FecIngreso=DateTime.Parse("1/02/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},
                new Personal{ PER_ID = 3, PER_Nombre = "Juan",      PER_FecIngreso=DateTime.Parse("1/03/2018"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=1},

                new Personal{ PER_ID = 4, PER_Nombre = "Guillermo", PER_FecIngreso=DateTime.Parse("20/05/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
                new Personal{ PER_ID = 5, PER_Nombre = "Luis",      PER_FecIngreso=DateTime.Parse("21/06/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
                new Personal{ PER_ID = 6, PER_Nombre = "Christian", PER_FecIngreso=DateTime.Parse("22/07/2019"), PER_FecSalida=DateTime.Parse(null),PER_TipoPersonal=2},
            };            
            Personal.ForEach(s => context.Personales.Add(s));
            context.SaveChanges();

            /* -------------- */

            var PersonalDat = new List<PersonalDatos>
            {
                new PersonalDatos { PD_ID = 1, PD_CI = "1111111", PD_FecNac = DateTime.Parse("01/01/1990"), PD_Telf = 4523687, PD_Movil = 75428965 },
                new PersonalDatos { PD_ID = 2, PD_CI = "2222222", PD_FecNac = DateTime.Parse("10/02/1990"), PD_Telf = 4458759, PD_Movil = 75254586 },
                new PersonalDatos { PD_ID = 3, PD_CI = "3333333", PD_FecNac = DateTime.Parse("20/03/1990"), PD_Telf = 4352456, PD_Movil = 75328965 },
                new PersonalDatos { PD_ID = 4, PD_CI = "4444444", PD_FecNac = DateTime.Parse("30/04/1990"), PD_Telf = 4723687, PD_Movil = 65428965 },
                new PersonalDatos { PD_ID = 5, PD_CI = "5555555", PD_FecNac = DateTime.Parse("05/05/1990"), PD_Telf = 4832145, PD_Movil = 68428965 },
                new PersonalDatos { PD_ID = 6, PD_CI = "6666666", PD_FecNac = DateTime.Parse("15/06/1990"), PD_Telf = 4915987, PD_Movil = 62428965 },
            };
            PersonalDat.ForEach(s => context.PersonalDatoses.Add(s));
            context.SaveChanges();

            /* ------------------------------------- */
            /* Adicionar a las Tablas de Area: RRHHH */
            /* ------------------------------------- */
            var Empleado = new List<Empleado>
                {
                    new Empleado { Emp_nombre="Guillermo", Emp_ape_paterno="Calvetty",  Emp_ape_materno="Nuñez",    Emp_fech_Ingreso=DateTime.Parse("20/05/2019") },
                    new Empleado { Emp_nombre="Elias",     Emp_ape_paterno="Nuñez",     Emp_ape_materno="Calvetty", Emp_fech_Ingreso=DateTime.Parse("21/05/2019") },
                    new Empleado { Emp_nombre="Andrea",    Emp_ape_paterno="Aranda",    Emp_ape_materno="Perez",    Emp_fech_Ingreso=DateTime.Parse("22/05/2019") }
                };

            var EmpleadoDato = new List<EmpleadoDato>
                {
                    new EmpleadoDato { Empd_ci="3999272", Empd_estadocivil=estadocivil.Casado,  Empd_fecNac=DateTime.Parse("26/07/1975"), Empd_sexo=sexo.Masculino, Empd_telf=4536159, Empd_movil=60742361, Empd_email="gcalvetty@gmail.com" },
                    new EmpleadoDato { Empd_ci="7548652", Empd_estadocivil=estadocivil.Soltero, Empd_fecNac=DateTime.Parse("14/01/1980"), Empd_sexo=sexo.Masculino, Empd_telf=4521478, Empd_movil=75412365, Empd_email="gecn-dev@gmail.com" },
                    new EmpleadoDato { Empd_ci="2452156", Empd_estadocivil=estadocivil.Casado,  Empd_fecNac=DateTime.Parse("09/03/1960"), Empd_sexo=sexo.Masculino, Empd_telf=4452165, Empd_movil=62357485, Empd_email="andrea@gmail.com" }
                };
            /* ------------------------------------- */

        }
    }
}