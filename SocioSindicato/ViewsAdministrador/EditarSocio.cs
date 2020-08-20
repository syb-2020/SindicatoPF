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
            sindicatoPFEntities context = new sindicatoPFEntities();
            combocategoriasocio.DataSource = context.Categoria.ToList();
            combocategoriasocio.DisplayMember = "numero_categoria";
            combocategoriasocio.ValueMember = "id_categoria";

            comboplantasocio.DataSource = context.Planta.ToList();
            comboplantasocio.DisplayMember = "nombre";
            comboplantasocio.ValueMember = "id_planta";

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

        string buscar_rut = "";

        private void btnbuscareditar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                buscar_rut = txtbuscar.Text;
                var buscarSolosocio = from solosocio in context.Socio
                                      where solosocio.rut_socio.Equals(buscar_rut)
                                      select new
                                      {
                                          Rut = solosocio.rut_socio,
                                          Nombre = solosocio.nombre_socio,
                                          FechaDeIngreso = solosocio.fecha_ingreso,
                                          Categoria = solosocio.id_categoria,
                                          Planta = solosocio.Planta.nombre,
                                          fechanacimiento = solosocio.fecha_ingreso,
                                          EDAD = solosocio.edad,
                                          DOMICILIO = solosocio.domicilio,
                                          CIVIL = solosocio.estado_civil,
                                          TELEFONO = solosocio.telefono,
                                          NACIONALIDAD = solosocio.nacionalidad,
                                          CORREO = solosocio.correo,
                                          NOMBREP = solosocio.datos_papa,
                                          NOMBREM = solosocio.datos_mama,
                                          contratosocio = solosocio.tipo_contrato,
                                      };

                gridbuscarsolosocio.DataSource = buscarSolosocio.ToList();

                var buscarSocioconConyuge = from sociorut in context.Socio
                                            join conyu in context.Conyuge
                                            on sociorut.rut_socio equals conyu.rut_socio
                                            where sociorut.rut_socio.Equals(buscar_rut)
                                            where sociorut.rut_socio.Equals(conyu.rut_socio)
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
                                                contratosocio = sociorut.tipo_contrato,                                               
                                                nombrecon = conyu.nombre,
                                                convivientecon = conyu.conviviente,
                                                rutcon = conyu.rut,
                                                nacimientocon = conyu.nacimiento,
                                                edadcon = conyu.edad,
                                                
                                            };
                grideditarsocioconyu.DataSource = buscarSocioconConyuge.ToList();

                var buscarSocioconHijo = from sociorut in context.Socio
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
                                             contratosocio = sociorut.tipo_contrato,
                                             nombrehij = hij.nombre,
                                             ruthij = hij.rut_hijo,
                                             sexohijo = hij.sexo,
                                             fechahij = hij.nacimiento
                                         };
                grideditarsociohijo.DataSource = buscarSocioconHijo.ToList();

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
                                  nacimientocon = conyu.nacimiento,
                                  edadcon = conyu.edad,
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
                    //BORRAR DATOS SOCIO
                    txtrutsocio.Text = "";
                    fotosocio.Image = null;
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
                    comboconvivienteconyugesocio.SelectedIndex = 0; 
                    txtrutconyugesocio.Text = "";
                    datefechanacimientoconyugesocio.Value = DateTime.Now;
                    txtedadconyugesocio.Text = "";

                    //BORAR COMBO HIJO
                    cbhijossocio.SelectedItem = null;
                    var bushij = from c in context.Socio
                                 join h in context.Hijo
                                 on c.rut_socio equals h.rut_socio
                                 where h.rut_socio.Equals(buscar_rut)
                                 select new { h.id_hijo, h.nombre, c.rut_socio };


                    cbhijossocio.DataSource = bushij.ToList();
                    cbhijossocio.DisplayMember = "nombre";
                    cbhijossocio.ValueMember = "id_hijo";



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
                                comboplantasocio.Text = Convert.ToString(row.Cells[4].Value);
                                datefechanacimientosocio.Value = Convert.ToDateTime(row.Cells[5].Value);
                                txtedadsocio.Text = Convert.ToString(row.Cells[6].Value);
                                txtdomiciliosocio.Text = Convert.ToString(row.Cells[7].Value);
                                comboestadocivilagregar.Text = Convert.ToString(row.Cells[8].Value);
                                txttelefonosocio.Text = Convert.ToString(row.Cells[9].Value);
                                txtnacionalidadsocio.Text = Convert.ToString(row.Cells[10].Value);
                                txtcorreosocio.Text = Convert.ToString(row.Cells[11].Value);
                                txtnombrepadre.Text = Convert.ToString(row.Cells[12].Value);
                                txtnombremadre.Text = Convert.ToString(row.Cells[13].Value);
                                combocontratosocio.Text = Convert.ToString(row.Cells[19].Value);

                                //datos de la conyu


                                txtconyugesocio.Text = Convert.ToString(row.Cells[14].Value);
                                comboconvivienteconyugesocio.Text = Convert.ToString(row.Cells[15].Value);
                                txtrutconyugesocio.Text = Convert.ToString(row.Cells[16].Value);
                                datefechanacimientoconyugesocio.Value = Convert.ToDateTime(row.Cells[17].Value);
                                txtedadconyugesocio.Text = Convert.ToString(row.Cells[18].Value);

                                var bushij = from c in context.Socio
                                             join h in context.Hijo
                                             on c.rut_socio equals h.rut_socio
                                             where h.rut_socio.Equals(buscar_rut)
                                             select new { h.id_hijo,h.nombre, c.rut_socio };


                                cbhijossocio.DataSource = bushij.ToList();
                                cbhijossocio.DisplayMember = "nombre";
                                cbhijossocio.ValueMember = "id_hijo";

                               
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
                    else if (buscarSocioconConyuge.Count() != 0)
                    {
                        foreach (DataGridViewRow row in grideditarsocioconyu.Rows)
                        {
                            for (int i = 0; i < grideditarsocioconyu.Columns.Count; i++)
                            {
                                //datos del socio
                                txtrutsocio.Text = Convert.ToString(row.Cells[0].Value);
                                txtnombresocio.Text = Convert.ToString(row.Cells[1].Value);
                                dateingresoempresasocio.Value = Convert.ToDateTime(row.Cells[2].Value);
                                combocategoriasocio.Text = Convert.ToString(row.Cells[3].Value);
                                comboplantasocio.Text = Convert.ToString(row.Cells[4].Value);
                                datefechanacimientosocio.Value = Convert.ToDateTime(row.Cells[5].Value);
                                txtedadsocio.Text = Convert.ToString(row.Cells[6].Value);
                                txtdomiciliosocio.Text = Convert.ToString(row.Cells[7].Value);
                                comboestadocivilagregar.Text = Convert.ToString(row.Cells[8].Value);
                                txttelefonosocio.Text = Convert.ToString(row.Cells[9].Value);
                                txtnacionalidadsocio.Text = Convert.ToString(row.Cells[10].Value);
                                txtcorreosocio.Text = Convert.ToString(row.Cells[11].Value);
                                txtnombrepadre.Text = Convert.ToString(row.Cells[12].Value);
                                txtnombremadre.Text = Convert.ToString(row.Cells[13].Value);
                                combocontratosocio.Text = Convert.ToString(row.Cells[14].Value);
                                //datos de la conyu
                                txtconyugesocio.Text = Convert.ToString(row.Cells[15].Value);
                                comboconvivienteconyugesocio.Text = Convert.ToString(row.Cells[16].Value);
                                txtrutconyugesocio.Text = Convert.ToString(row.Cells[17].Value);
                                datefechanacimientoconyugesocio.Value = Convert.ToDateTime(row.Cells[18].Value);
                                txtedadconyugesocio.Text = Convert.ToString(row.Cells[19].Value);

                                using (sindicatoPFEntities db = new sindicatoPFEntities())
                                {
                                    var oImage = db.Socio.Find(buscar_rut);
                                    MemoryStream ms = new MemoryStream(oImage.imagen);
                                    Bitmap bmp = new Bitmap(ms);
                                    fotosocio.Image = bmp;
                                }

                            }
                        }
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        MessageBox.Show("Edite los campos que desee!");

                    }
                    else if (buscarSocioconHijo.Count() != 0)
                    {
                        foreach (DataGridViewRow row in grideditarsociohijo.Rows)
                        {
                            for (int i = 0; i < grideditarsociohijo.Columns.Count; i++)
                            {
                                //datos del socio
                                txtrutsocio.Text = Convert.ToString(row.Cells[0].Value);
                                txtnombresocio.Text = Convert.ToString(row.Cells[1].Value);
                                dateingresoempresasocio.Value = Convert.ToDateTime(row.Cells[2].Value);
                                combocategoriasocio.Text = Convert.ToString(row.Cells[3].Value);
                                comboplantasocio.Text = Convert.ToString(row.Cells[4].Value);
                                datefechanacimientosocio.Value = Convert.ToDateTime(row.Cells[5].Value);
                                txtedadsocio.Text = Convert.ToString(row.Cells[6].Value);
                                txtdomiciliosocio.Text = Convert.ToString(row.Cells[7].Value);
                                comboestadocivilagregar.Text = Convert.ToString(row.Cells[8].Value);
                                txttelefonosocio.Text = Convert.ToString(row.Cells[9].Value);
                                txtnacionalidadsocio.Text = Convert.ToString(row.Cells[10].Value);
                                txtcorreosocio.Text = Convert.ToString(row.Cells[11].Value);
                                txtnombrepadre.Text = Convert.ToString(row.Cells[12].Value);
                                txtnombremadre.Text = Convert.ToString(row.Cells[13].Value);
                                combocontratosocio.Text = Convert.ToString(row.Cells[14].Value);

                                var bushij = from c in context.Socio
                                             join h in context.Hijo
                                             on c.rut_socio equals h.rut_socio
                                             where h.rut_socio.Equals(buscar_rut)
                                             select new { h.id_hijo, h.nombre, c.rut_socio };


                                cbhijossocio.DataSource = bushij.ToList();
                                cbhijossocio.DisplayMember = "nombre";
                                cbhijossocio.ValueMember = "id_hijo";

                                using (sindicatoPFEntities db = new sindicatoPFEntities())
                                {
                                    var oImage = db.Socio.Find(buscar_rut);
                                    MemoryStream ms = new MemoryStream(oImage.imagen);
                                    Bitmap bmp = new Bitmap(ms);
                                    fotosocio.Image = bmp;
                                }
                            }

                        }

                        //BORRAR DATOS CONYUGE
                        txtconyugesocio.Text = "";
                        comboconvivienteconyugesocio.SelectedIndex = 0; ;
                        txtrutconyugesocio.Text = "";
                        datefechanacimientoconyugesocio.Value = DateTime.Now;
                        txtedadconyugesocio.Text = "";

                        MessageBox.Show("Edite los campos que desee!");

                    }
                    else if (buscarSolosocio.Count() != 0)
                    {
                        foreach (DataGridViewRow row in gridbuscarsolosocio.Rows)
                        {
                            for (int i = 0; i < gridbuscarsolosocio.Columns.Count; i++)
                            {
                                //datos del socio
                                txtrutsocio.Text = Convert.ToString(row.Cells[0].Value);
                                txtnombresocio.Text = Convert.ToString(row.Cells[1].Value);
                                dateingresoempresasocio.Value = Convert.ToDateTime(row.Cells[2].Value);
                                combocategoriasocio.Text = Convert.ToString(row.Cells[3].Value);
                                comboplantasocio.Text = Convert.ToString(row.Cells[4].Value);
                                datefechanacimientosocio.Value = Convert.ToDateTime(row.Cells[5].Value);
                                txtedadsocio.Text = Convert.ToString(row.Cells[6].Value);
                                txtdomiciliosocio.Text = Convert.ToString(row.Cells[7].Value);
                                comboestadocivilagregar.Text = Convert.ToString(row.Cells[8].Value);
                                txttelefonosocio.Text = Convert.ToString(row.Cells[9].Value);
                                txtnacionalidadsocio.Text = Convert.ToString(row.Cells[10].Value);
                                txtcorreosocio.Text = Convert.ToString(row.Cells[11].Value);
                                txtnombrepadre.Text = Convert.ToString(row.Cells[12].Value);
                                txtnombremadre.Text = Convert.ToString(row.Cells[13].Value);
                                combocontratosocio.Text = Convert.ToString(row.Cells[14].Value);

                                using (sindicatoPFEntities db = new sindicatoPFEntities())
                                {
                                    var oImage = db.Socio.Find(buscar_rut);
                                    MemoryStream ms = new MemoryStream(oImage.imagen);
                                    Bitmap bmp = new Bitmap(ms);
                                    fotosocio.Image = bmp;
                                }


                            }

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

        MemoryStream ms2 = new MemoryStream();
        public byte[] file2 = null;
       

        private void btneditar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                buscar_rut = txtbuscar.Text;



                if (txtrutsocio.Text == "")
                {
                    MessageBox.Show("Socio no pudo ser editado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (sindicatoPFEntities db = new sindicatoPFEntities())
                    {
                        var oImage = db.Socio.Find(buscar_rut);
                        MemoryStream ms = new MemoryStream(oImage.imagen);
                        Bitmap bmp = new Bitmap(ms);
                        fotosocio.Image = bmp;
                        file2 = ms2.ToArray();
                    }

                    Socio nuevosocio = new Socio();
                    nuevosocio = context.Socio.Find(buscar_rut);
                    nuevosocio.imagen = file2;
                    nuevosocio.nombre_socio = txtnombresocio.Text;
                    nuevosocio.fecha_ingreso = Convert.ToDateTime(dateingresoempresasocio.Text);
                    nuevosocio.id_categoria = Convert.ToInt32(combocategoriasocio.SelectedValue);
                    nuevosocio.tipo_contrato = combocontratosocio.Text;
                    nuevosocio.id_planta = Convert.ToInt32(comboplantasocio.SelectedValue);
                    nuevosocio.fecha_nacimiento = Convert.ToDateTime(datefechanacimientosocio.Text);
                    nuevosocio.edad = Convert.ToInt32(txtedadsocio.Text);
                    nuevosocio.domicilio = txtdomiciliosocio.Text;
                    nuevosocio.estado_civil = comboestadocivilagregar.Text;
                    nuevosocio.telefono = Convert.ToInt32(txttelefonosocio.Text);
                    nuevosocio.nacionalidad = txtnacionalidadsocio.Text;
                    nuevosocio.correo = txtcorreosocio.Text;
                    nuevosocio.datos_papa = txtnombrepadre.Text;
                    nuevosocio.datos_mama = txtnombremadre.Text;



                    context.SaveChanges();


                    //BUSCAR
                    txtbuscar.Text = "";

                    //BORRAR DATOS SOCIO
                    txtrutsocio.Text = "";
                    fotosocio.Image = null;
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


                    //BORAR COMBO HIJO
                    cbhijossocio.SelectedItem = null;

                    var bushij = from c in context.Socio
                                 join h in context.Hijo
                                 on c.rut_socio equals h.rut_socio
                                 where h.rut_socio.Equals(txtbuscar.Text)
                                 select new { h.id_hijo, h.nombre, c.rut_socio };


                    cbhijossocio.DataSource = bushij.ToList();
                    cbhijossocio.DisplayMember = "nombre";
                    cbhijossocio.ValueMember = "id_hijo";

                    MessageBox.Show("Socio Editado Correctamente!");
                  
                }





            }

        }

        private void btneliminarcon_Click(object sender, EventArgs e)
        {
            if (buscar_rut == "")
            {

                MessageBox.Show("Ingrese Rut Del Socio Para Eliminar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    using (sindicatoPFEntities context = new sindicatoPFEntities())
                    {
                        var result1 = from c in context.Conyuge
                                      where c.rut_socio.Equals(buscar_rut)
                                      select new { id_con = c.id_conyuge };
                        int rut_soc1 = result1.ToList()[0].id_con;


                        context.Conyuge.Remove(context.Conyuge.Find(rut_soc1));
                        context.SaveChanges();

                        MessageBox.Show("Conyuge Eliminada!");
                        //BORRAR BUSCADOR
                        txtbuscar.Text = "";

                        //BORRAR DATOS SOCIO
                        txtrutsocio.Text = "";
                        fotosocio.Image = null;
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
                        comboconvivienteconyugesocio.SelectedIndex = 0;
                        txtrutconyugesocio.Text = "";
                        datefechanacimientoconyugesocio.Value = DateTime.Now;
                        txtedadconyugesocio.Text = "";

                        //BORAR COMBO HIJO
                        cbhijossocio.SelectedItem = null;
                        var bushij = from c in context.Socio
                                     join h in context.Hijo
                                     on c.rut_socio equals h.rut_socio
                                     where h.rut_socio.Equals(buscar_rut)
                                     select new { h.id_hijo, h.nombre, c.rut_socio };


                        cbhijossocio.DataSource = bushij.ToList();
                        cbhijossocio.DisplayMember = "nombre";
                        cbhijossocio.ValueMember = "id_hijo";

                    }
                }
                catch
                {
                    MessageBox.Show("Conyuge No Eliminado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnagregarcon_Click(object sender, EventArgs e)
        {

            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                if (txtrutsocio.Text=="")
                {
                    MessageBox.Show("Debe ingresar el rut del socio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtconyugesocio.Text=="")
                {
                    MessageBox.Show("Debe ingresar el nombre del conyuge", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else if (txtrutconyugesocio.Text=="")
                {
                    MessageBox.Show("Debe ingresar el rut del conyuge", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtedadconyugesocio.Text=="")
                {
                    MessageBox.Show("Debe ingresar la edad del conyuge", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (comboconvivienteconyugesocio.SelectedIndex == -1)
                {

                    MessageBox.Show("Debe ingresar si es conviviente o no", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Conyuge con = new Conyuge
                    {
                        rut_socio = txtrutsocio.Text,
                        nombre = txtconyugesocio.Text,
                        conviviente = comboconvivienteconyugesocio.Text,
                        rut = txtrutconyugesocio.Text,
                        nacimiento = Convert.ToDateTime(datefechanacimientoconyugesocio.Text),
                        edad = Convert.ToInt32(txtedadconyugesocio.Text)
                    };

                    context.Conyuge.Add(con);
                    context.SaveChanges();
                    MessageBox.Show("Conyuge Agregada!");

                    //BORRAR BUSCADOR
                    txtbuscar.Text = "";

                    //BORRAR DATOS SOCIO
                    txtrutsocio.Text = "";
                    fotosocio.Image = null;
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
                    comboconvivienteconyugesocio.SelectedIndex = 0;
                    txtrutconyugesocio.Text = "";
                    datefechanacimientoconyugesocio.Value = DateTime.Now;
                    txtedadconyugesocio.Text = "";

                    //BORAR COMBO HIJO
                    cbhijossocio.SelectedItem = null;
                    var bushij = from c in context.Socio
                                 join h in context.Hijo
                                 on c.rut_socio equals h.rut_socio
                                 where h.rut_socio.Equals(buscar_rut)
                                 select new { h.id_hijo, h.nombre, c.rut_socio };


                    cbhijossocio.DataSource = bushij.ToList();
                    cbhijossocio.DisplayMember = "nombre";
                    cbhijossocio.ValueMember = "id_hijo";

                }




            }

        }

        private void btneliminarhi_Click(object sender, EventArgs e)
        {
            if (buscar_rut == "")
            {

                MessageBox.Show("Ingrese Rut Del Socio Para Eliminar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    using (sindicatoPFEntities context = new sindicatoPFEntities())
                    {
                        var result2 = from c in context.Hijo
                                      where c.rut_socio.Equals(buscar_rut)
                                      select new { id_hij = c.id_hijo };

                        int rut_soc2 = result2.ToList()[1].id_hij;


                        //cbhijossocio



                        context.Hijo.Remove(context.Hijo.Find(rut_soc2));

                        context.SaveChanges();

                        var bushij = from c in context.Socio
                                     join h in context.Hijo
                                     on c.rut_socio equals h.rut_socio
                                     where h.rut_socio.Equals(buscar_rut)
                                     select new { h.id_hijo,h.nombre, c.rut_socio };


                        cbhijossocio.DataSource = bushij.ToList();
                        cbhijossocio.DisplayMember = "nombre";
                        cbhijossocio.ValueMember = "id_hijo";

                        MessageBox.Show("Hijo Eliminado!");


                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                    }
                }
                catch
                {
                    MessageBox.Show("Hijo No Eliminado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnagregarhij_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {

                if (txtrutsocio.Text == "")
                {
                    MessageBox.Show("Debe ingresar el rut del socio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtnombrehijosocio.Text == "")
                {

                    MessageBox.Show("Debe ingresar el nombre del hijo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtruthijosocio.Text == "")
                {
                    MessageBox.Show("Debe ingresar el rut del hijo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbSexo.SelectedValue != null)
                {
                    MessageBox.Show("Debe ingresar el sexo del hijo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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

                    gridcapdatosedi.DataSource = mashijos.ToArray();

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
                    context.SaveChanges();
                    var bushij = from c in context.Socio
                                 join h in context.Hijo
                                 on c.rut_socio equals h.rut_socio
                                 where h.rut_socio.Equals(buscar_rut)
                                 select new { h.id_hijo, h.nombre, c.rut_socio };


                    cbhijossocio.DataSource = bushij.ToList();
                    cbhijossocio.DisplayMember = "nombre";
                    cbhijossocio.ValueMember = "id_hijo";

                    MessageBox.Show("Hijo Agregado!");
                }

            }


        }

       

        private void cbhijossocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void gridcapdatosedi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridcapdatosedi.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void cbhijossocio_TextChanged(object sender, EventArgs e)
        {
            
        }

        //BOTON DE SELECCIONAR HIJO
        private void button1_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                

                int nombrexd = Convert.ToInt32(cbhijossocio.SelectedValue.ToString());
               
                var bushij = from c in context.Socio
                             join h in context.Hijo
                             on c.rut_socio equals h.rut_socio
                             where h.id_hijo.Equals(nombrexd)
                             select new { h.id_hijo, h.nombre, c.rut_socio };



           
                int cod = bushij.ToList()[0].id_hijo;
                Hijo nuevohij = new Hijo();
                nuevohij = context.Hijo.Find(cod);


                txtnombrehijosocio.Text = nuevohij.nombre;
                txtruthijosocio.Text = nuevohij.rut_hijo;
                cbSexo.Text = nuevohij.sexo;
                datenacimientohijosocio.Value = Convert.ToDateTime(nuevohij.nacimiento);

                string rut3 = bushij.ToList()[0].rut_socio;
                var bushij2 = from c in context.Socio
                             join h in context.Hijo
                             on c.rut_socio equals h.rut_socio
                             where h.rut_socio.Equals(rut3)
                             select new { h.id_hijo, h.nombre, c.rut_socio };


              
                cbhijossocio.DataSource = bushij2.ToList();
                cbhijossocio.DisplayMember = "nombre";
                cbhijossocio.ValueMember = "id_hijo";
                MessageBox.Show("Hijo Seleccionado!");
               

            }
        }
    }
}
