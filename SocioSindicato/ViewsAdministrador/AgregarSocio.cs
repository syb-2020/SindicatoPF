﻿using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato.ViewsAdministrador
{
    public partial class AgregarSocio : Form
    {
        public AgregarSocio()
        {
            InitializeComponent();
            sindicatoPFEntities context = new sindicatoPFEntities();
            combocategoriasocio.DataSource = context.Categoria.ToList();
            combocategoriasocio.DisplayMember = "numero_categoria";
            combocategoriasocio.ValueMember = "id_categoria";

            comboplantasocio.DataSource = context.Planta.ToList();
            comboplantasocio.DisplayMember = "nombre";
            comboplantasocio.ValueMember = "id_planta";

        }

        public string cadena = "";

        private void btnvolveragregar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }


        public static byte[] ImageToByteArray(Image img, PictureBox fotosocio)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (fotosocio.Image != null)
            { img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); }
            return ms.ToArray();
        }

        private void btnseleccionarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccion = new OpenFileDialog();
            seleccion.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG";
            seleccion.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            seleccion.Title = "Seleccionar Imagen";

            if (seleccion.ShowDialog() == DialogResult.OK)
            {


                Image img = new Bitmap(seleccion.FileName);
                fotosocio.Image = img;

                byte[] byteImg = ImageToByteArray(fotosocio.Image, fotosocio);
                //cadena = Encoding.UTF8.GetString(byteImg);
            }
            
           
        }

        private void btnagregarsocio_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {


                try
                {
                    Socio nuevosocio = new Socio {
                        rut_socio = txtrutsocio.Text,
                        imagen = fotosocio.ToString(),
                        nombre_socio = txtnombresocio.Text,
                        fecha_ingreso = Convert.ToDateTime(dateingresoempresasocio.Text),
                        id_categoria = Convert.ToInt32(combocategoriasocio.SelectedValue),
                        tipo_contrato = combocontratosocio.Text,
                        id_planta = Convert.ToInt32(comboplantasocio.SelectedValue),
                        fecha_nacimiento = Convert.ToDateTime(datefechanacimientosocio.Text),
                        edad = Convert.ToInt32(txtedadsocio.Text),
                        domicilio = txtdomiciliosocio.Text,
                        estado_civil = txtestadocivilsocio.Text,
                        telefono = Convert.ToInt32(txttelefonosocio.Text),
                        cantidad_carga = Convert.ToInt32(combocargasocio.SelectedItem.ToString()),
                        nacionalidad = txtnacionalidadsocio.Text,
                        correo = txtcorreosocio.Text,
                        datos_papa = txtnombrepadre.Text,
                        datos_mama = txtnombremadre.Text,                        
                    };

                    Conyuge con = new Conyuge
                    {
                        rut_socio = txtrutsocio.Text,
                        nombre = txtconyugesocio.Text,
                        conviviente = comboconvivienteconyugesocio.Text,
                        rut = txtrutconyugesocio.Text,
                        nacimiento = Convert.ToDateTime(datefechanacimientoconyugesocio.Text),
                        edad = Convert.ToInt32(txtedadconyugesocio.Text)
                    };

                    Hijo hs = new Hijo { 
                    rut_socio = txtrutsocio.Text,
                    nombre = txtnombrehijosocio.Text,
                    rut_hijo = txtruthijosocio.Text,
                    nacimiento = Convert.ToDateTime(datenacimientohijosocio.Text)
                    };

                    context.Socio.Add(nuevosocio);
                    context.Conyuge.Add(con);
                    context.Hijo.Add(hs);
                    context.SaveChanges();


                    lbagregadosocio.Text = "Socio Ingresado!";

                }
                catch (Exception)
                {

                    lbagregadosocio.Text = "Socio No Ingresado!";
                }
            }
            }
    }
}
