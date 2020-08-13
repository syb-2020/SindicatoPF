using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato.ViewsAdministrador
{
    public partial class EditarSocio : Form
    {
        public EditarSocio()
        {
            InitializeComponent();
        }

        private void btnvolvereditar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

       
        public byte[] file = null;

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

        private void btnbuscareditar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                string buscar_rut = txtbuscar.Text;

                var listRut = from sociorut in context.Socio
                                  join conyu in context.Conyuge
                                  on sociorut.rut_socio equals conyu.rut_socio
                                  where sociorut.rut_socio.Equals(buscar_rut)
                                  join hij in context.Hijo on sociorut.rut_socio equals hij.rut_socio
                                  where sociorut.rut_socio.Equals(buscar_rut)
                                  select new
                                  { 
                                  Rut = sociorut.rut_socio, 
                                  Nombre = sociorut.nombre_socio,
                                  FechaDeIngreso = sociorut.fecha_ingreso,
                                  Categoria = sociorut.id_categoria, 
                                  Planta = sociorut.Planta.nombre,
                                  fechanacimiento = sociorut.fecha_ingreso,
                                  EDAD = sociorut.edad,
                                  DOMICILIO = sociorut.domicilio,
                                  CIVIL = sociorut.estado_civil,
                                  TELEFONO = sociorut.telefono,
                                  NACIONALIDAD = sociorut.nacionalidad,
                                  CORREO = sociorut.correo,
                                  NOMBREP = sociorut.datos_papa,
                                  NOMBREM = sociorut.datos_mama,
                                  nombrecon = conyu.nombre,
                                  convivientecon = conyu.conviviente,
                                  rutcon = conyu.rut,
                                  nacimientocon=conyu.nacimiento,
                                  edadcon=conyu.edad,
                                  contratosocio = sociorut.tipo_contrato,
                                  nombrehij = hij.nombre,
                                  ruthij = hij.rut_hijo,
                                  sexohijo = hij.sexo,
                                  fechahij = hij.nacimiento
                              };

                gridcapdatosedi.DataSource = listRut.ToList();




                if (txtbuscar.Text == "")
                {


                    MessageBox.Show("Ingrese Rut del socio para editar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fotosocio.Image = null;

                    txtbuscar.Text = "";
                }
                else
                {
                    if (listRut.Count() != 0)
                    {
                        foreach (DataGridViewRow row in gridcapdatosedi.Rows)
                        {
                            for (int i = 0; i < gridcapdatosedi.Columns.Count; i++)
                            {
                                //datos del socio
                                txtrutsocio.Text = Convert.ToString(row.Cells[0].Value);
                                txtnombresocio.Text = Convert.ToString(row.Cells[1].Value);                               
                                dateingresoempresasocio.Value = Convert.ToDateTime(row.Cells[2].Value);
                                combocategoriasocio.Text = Convert.ToString(row.Cells[3].Value);
                                comboplantasocio.Text= Convert.ToString(row.Cells[4].Value);
                                datefechanacimientosocio.Value = Convert.ToDateTime(row.Cells[5].Value);
                                txtedadsocio.Text = Convert.ToString(row.Cells[6].Value);
                                txtdomiciliosocio.Text = Convert.ToString(row.Cells[7].Value);
                                comboestadocivilagregar.Text = Convert.ToString(row.Cells[8].Value);
                                txttelefonosocio.Text = Convert.ToString(row.Cells[9].Value);
                                txtnacionalidadsocio.Text = Convert.ToString(row.Cells[10].Value);
                                txtcorreosocio.Text= Convert.ToString(row.Cells[11].Value);
                                txtnombrepadre.Text = Convert.ToString(row.Cells[12].Value);
                                txtnombremadre.Text = Convert.ToString(row.Cells[13].Value);
                                combocontratosocio.Text = Convert.ToString(row.Cells[19].Value);

                                //datos de la conyu
                                txtconyugesocio.Text = Convert.ToString(row.Cells[14].Value);
                                comboconvivienteconyugesocio.Text = Convert.ToString(row.Cells[15].Value);
                                txtrutconyugesocio.Text = Convert.ToString(row.Cells[16].Value);
                                datefechanacimientoconyugesocio.Value = Convert.ToDateTime(row.Cells[17].Value);
                                txtedadconyugesocio.Text = Convert.ToString(row.Cells[18].Value);

                                //datos del hijo
                                txtnombrehijosocio.Text = Convert.ToString(row.Cells[20].Value);
                                txtruthijosocio.Text = Convert.ToString(row.Cells[21].Value);
                                cbSexo.Text = Convert.ToString(row.Cells[22].Value);
                                datenacimientohijosocio.Value = Convert.ToDateTime(row.Cells[23].Value);

                                
                                using (sindicatoPFEntities db = new sindicatoPFEntities())
                                {
                                    var oImage = db.Socio.Find(buscar_rut);
                                    MemoryStream ms = new MemoryStream(oImage.imagen);
                                    Bitmap bmp = new Bitmap(ms);
                                    fotosocio.Image = bmp;
                                }

                              
                            }
                        }

                        MessageBox.Show("Edite los campos que desee!");

                    }
                    else
                    {

                        MessageBox.Show("Socio No Encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbuscar.Text = "";

                    }

                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                try
                {
                    Socio nuevosocio = new Socio
                    {
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

                    //falta el hijo como poder editar si son varios.

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

                    gridcapdatosedi.DataSource = "";
                }
                catch (Exception)
                {


                    MessageBox.Show("Socio no pudo ser eliminado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
