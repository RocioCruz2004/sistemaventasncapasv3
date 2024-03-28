using SistemasVentas.BSS;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.Modelos;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorListarVista : Form
    {
        public VendedorListarVista()
        {
            InitializeComponent();
        }

        private void VendedorListarVista_Load(object sender, EventArgs e)
        {
            DetalleVentaBss bss = new DetalleVentaBss();
            dataGridView1.DataSource = bss.ListarDetalleVentaBss;
            Persona persona = new Persona();
            textBox1.Text = persona.Nombre + " "+  persona.Apellido;
        }

        private void button1_Click(object sender, EventArgs e) //CLIENTE
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button2_Click(object sender, EventArgs e) //PRODUCTO
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button3_Click(object sender, EventArgs e) //VENTA
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button4_Click(object sender, EventArgs e) //DETALLE INGRESO
        {
            DetalleIngBss bss = new DetalleIngBss();
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
