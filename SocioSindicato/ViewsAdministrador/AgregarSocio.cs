using SocioSindicato.Models;
using System;
using System.Collections;
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

        public class Datos
        {

            public string rutsocio { get; set; }
            public string nombrehijo { get; set; }
            public string ruthijo { get; set; }
            public string sexohijo { get; set; }
            public DateTime nacimientohijo { get; set; }

        }

        List<Datos> mashijos = new List<Datos>();

        private void btnagregarotrohijo_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {

               

               
                Datos dato = new Datos()
                {
                    rutsocio = txtrutsocio.Text,
                    nombrehijo = txtnombrehijosocio.Text,
                    ruthijo = txtruthijosocio.Text,
                    sexohijo = cbSexo.Text,
                    nacimientohijo = Convert.ToDateTime(datenacimientohijosocio.Text),
                    
                };
                mashijos.Add(dato);



                txtnombrehijosocio.Text = "";
                txtruthijosocio.Text = "";
                cbSexo.SelectedIndex = 0;
                datenacimientohijosocio.Value = DateTime.Now;
               
                gridpruebahijo.DataSource = mashijos.ToArray();
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

                    foreach (var a in mashijos)
                    {
                        Hijo hs = new Hijo
                        {
                            rut_socio = a.rutsocio,
                            nombre = a.nombrehijo,
                            rut_hijo = a.ruthijo,
                            sexo = a.sexohijo,
                            nacimiento = a.nacimientohijo
                        };
                        context.Hijo.Add(hs);
                    }

                    context.Socio.Add(nuevosocio);
                    context.Conyuge.Add(con);

                    context.SaveChanges();


                    //BORRAR DATOS SOCIO
                    txtrutsocio.Text = "";
                    file = null;
                    txtnombresocio.Text = "";
                    dateingresoempresasocio.Value = DateTime.Now;
                    combocategoriasocio.SelectedIndex = 0;
                    combocontratosocio.SelectedIndex = 0; ;
                    comboplantasocio.SelectedIndex = 0; ;
                    datefechanacimientosocio.Value = DateTime.Now;
                    txtedadsocio.Text = "";
                    txtdomiciliosocio.Text = "";
                    comboestadocivilagregar.SelectedIndex = 0;
                    txttelefonosocio.Text = "";
                    txtnacionalidadsocio.Text = "";
                    txtcorreosocio.Text = "";
                    txtnombrepadre.Text = "";
                    txtnombremadre.Text = "";
                    //BORRAR DATOS CONYUGE
                    txtconyugesocio.Text = "";
                    comboconvivienteconyugesocio.SelectedIndex = 0; ;
                    txtrutconyugesocio.Text = "";
                    datefechanacimientoconyugesocio.Value = DateTime.Now;
                    txtedadconyugesocio.Text = "";
                    //BORRAR DATOS HIJOS
                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;


                    MessageBox.Show("Socio Agregado Correctamente!");

                    gridpruebahijo.DataSource = "";





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

        private void AgregarSocio_Load(object sender, EventArgs e)
        {

        }

        private void gridpruebahijo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridpruebahijo.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
