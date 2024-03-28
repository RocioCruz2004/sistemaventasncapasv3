using SistemasVentas.DAL;
using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.ProvedorVista;
using SistemasVentas.VISTA.VendedorVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.SistemaVentaVista
{
    public partial class SistemaVentaInicioVista : Form
    {
        public SistemaVentaInicioVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusername.Text;
            string contraseña = txtcontra.Text;
            string rol = comboBox1.Text; //GERENTE, CAJERO, SUPERVISOR

            if (conexion.VerificadorCredencialesGerente(usuario, contraseña, rol))
            {
                MessageBox.Show("Iniciando sesión como GERENTE");
                GerenteListarVista formulario = new GerenteListarVista();

                formulario.Show();
            }
            else if (conexion.VerificadorCredencialesVendedor(usuario, contraseña, rol))
            {
                MessageBox.Show("Iniciando sesion como CAJERO");
                VendedorListarVista formulario = new VendedorListarVista();

                formulario.Show();
            }
            else if (conexion.VerificadorCredencialesProveedor(usuario, contraseña, rol))
            {
                MessageBox.Show("Iniciando sesión como PROVEEDOR");
                ProvedorListarVista formulario = new ProvedorListarVista();

                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void SistemaVentaInicioVista_Load(object sender, EventArgs e)
        {

        }
    }
}
// GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
//listarvista.Show();
