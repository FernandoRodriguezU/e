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
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarUsuarioBss()
        {

            return dal.ListarEmpleadoDal();
        }
        public void InsertarUsuarioBss(Empleado usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }
    }
}
