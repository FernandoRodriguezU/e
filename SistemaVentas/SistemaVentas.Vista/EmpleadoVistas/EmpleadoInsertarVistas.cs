using SistemaVentas.Modelos;
using SistemaVentasBss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vista.EmpleadoVistas
{
    public partial class EmpleadoInsertarVistas : Form
    {
        public EmpleadoInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        EmpleadoBss bss = new EmpleadoBss();
        PersonaBss Bss = new PersonaBss();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario");
        }
    }
}
