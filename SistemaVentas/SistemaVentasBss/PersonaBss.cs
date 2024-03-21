using SistemaVentas.Dal;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasBss
{
   public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {

            return dal.ListarPersonaDal();
        }
        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDAL(persona);
        }
    }
}
