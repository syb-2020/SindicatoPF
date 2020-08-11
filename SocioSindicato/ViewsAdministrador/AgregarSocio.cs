using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private void solonumeros(KeyPressEventArgs e ) {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                } else if(char.IsControl(e.KeyChar)){
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte[] file = null;

        private void btnvolveragregar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }


       

        private void btnseleccionarimagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:/";
            openFileDialog1.Filter = "Images (.JPEG;.BMP;.JPG;.GIF;.PNG;.)|.JPEG;.BMP;.JPG;.GIF;*.PNG";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                fotosocio.Image = img;


                Stream mySream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    mySream.CopyTo(ms);
                    file = ms.ToArray();
                }


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
                        imagen = file,
                        nombre_socio = txtnombresocio.Text,
                        fecha_ingreso = Convert.ToDateTime(dateingresoempresasocio.Text),
                        id_categoria = Convert.ToInt32(combocategoriasocio.SelectedValue),
                        tipo_contrato = combocontratosocio.Text,
                        id_planta = Convert.ToInt32(comboplantasocio.SelectedValue),
                        fecha_nacimiento = Convert.ToDateTime(datefechanacimientosocio.Text),
                        edad = Convert.ToInt32(txtedadsocio.Text),
                        domicilio = txtdomiciliosocio.Text,
                        estado_civil = comboestadocivilagregar.Text,
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


                    MessageBox.Show("Socio Agregado Correctamente!");

                }
                catch (Exception)
                {

                   
                    MessageBox.Show("Socio No Agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void txtedadsocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtedadconyugesocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }
    }
}
