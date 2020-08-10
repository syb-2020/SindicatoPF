using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SocioSindicato.Models;
using System.Runtime.InteropServices;

namespace SocioSindicato
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                string nombre = txtusuario.Text;
                string clave = txtclave.Text;

                var result = from c in context.Usuario
                             where c.clave.Equals(clave) && c.nombre.Equals(nombre)
                             select c;
                

                if (result.ToList().Count == 0)
                {
                  
                   // MessageBox.Show("Usuario y/o Contraseña invalida");
                    MessageBox.Show("Usuario y/o Contraseña invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    int usuario_rol = result.ToList()[0].id_rol;
                    int usuario_id = result.ToList()[0].id_usuario;


                    txtusuario.Text = "";
                    txtclave.Text = "";
                    if (usuario_rol == 1)
                    {

                        Administrador oAdm = new Administrador();
                        this.Hide();
                        MessageBox.Show("Bienvenido: " + nombre);
                        oAdm.ShowDialog();                       
                        this.Close();
                       



                    }
                    if (usuario_rol == 2)
                    {
                        
                        Visitor oVis = new Visitor();                   
                        this.Hide();
                        MessageBox.Show("Bienvenido: " + nombre);
                        oVis.ShowDialog();
                        this.Close();
                        
                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Cerrado!");
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }


        private void barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
