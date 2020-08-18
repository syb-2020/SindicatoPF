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
using EO.Internal;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Drawing2D;
using Rectangle = System.Drawing.Rectangle;

namespace SocioSindicato
{
    public partial class Form1 : Form
    {
        private void customise()
        {
            //TextBox Usuario
            txtusuario.AutoSize = false;
            txtusuario.Size = new Size(350, 35);

            //TextBox Clave
            txtclave.AutoSize = false;
            txtclave.Size = new Size(350, 35);
            txtclave.UseSystemPasswordChar = true;
        }//campos de texto personalizados
        public Form1()
        {
            InitializeComponent();
            customise();
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
                    txtusuario.Text = "";
                    txtclave.Text = "";
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

       

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //mueve el panel por el escritorio
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtiniciarsesion_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonpath = new GraphicsPath();
            Rectangle myRec = txtiniciarsesion.ClientRectangle;
            myRec.Inflate(0, 30);
            buttonpath.AddEllipse(myRec);
            txtiniciarsesion.Region = new Region(buttonpath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
