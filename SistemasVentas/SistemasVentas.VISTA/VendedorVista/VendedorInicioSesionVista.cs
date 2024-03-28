using SistemasVentas.DAL;
using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.ProvedorVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorInicioSesionVista : Form
    {
        public VendedorInicioSesionVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña= textBox2.Text;

            /*if(conexion.VerificadorCredenciales(usuario,contraseña))
            {
                MessageBox.Show("Iniciando sesion");
                VendedorListarVista formulario2 = new VendedorListarVista();
                formulario2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta! Inténtelo nuevamente.");
            }*/
          
        }
    }
}
