using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 bs = new Form1();
            this.Hide();
            MessageBox.Show("Cuenta cerrada!");
            bs.ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.BuscarSocio bs = new ViewsAdministrador.BuscarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.EliminarSocio bs = new ViewsAdministrador.EliminarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.AgregarSocio bs = new ViewsAdministrador.AgregarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.Plantas bs = new ViewsAdministrador.Plantas();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.ListadoNavidad bs = new ViewsAdministrador.ListadoNavidad();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }
    }
}
