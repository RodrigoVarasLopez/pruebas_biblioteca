using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Movil
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            
        }

        private void Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient servidorWeb = new ServiceReference1.ServicioWebSoapClient();
            ServiceReference1.Obra obra = servidorWeb.consulta_Obras("quijote");
            List<ServiceReference1.Obra> lobra = new List<ServiceReference1.Obra>();
            lobra.Add(obra);
            dgbBusqueda.DataSource = lobra;

        }
    }
}
