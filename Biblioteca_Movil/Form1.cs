using System;
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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;
            ServiceReference1.ServicioWebSoapClient servidorWeb = new ServiceReference1.ServicioWebSoapClient();
            if (servidorWeb.autenticacion(usuario, contraseña)==1)
            {
                Busqueda bus = new Busqueda();
                bus.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
