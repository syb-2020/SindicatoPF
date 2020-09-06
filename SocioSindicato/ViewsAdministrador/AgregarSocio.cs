using EO.WebEngine;
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

            //CARGAR COMBOBOX AUTOMATICO 
            combocontratosocio.SelectedIndex = 0;
            comboestadocivilagregar.SelectedIndex = 0;
            comboconvivienteconyugesocio.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;

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

        private void btVolver_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();          
            this.Close();
        }

        private void btSubirIMG_Click(object sender, EventArgs e)
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

            public string RUT_SOCIO { get; set; }
            public string NOMBRE_HIJO { get; set; }
            public string RUT { get; set; }
            public string SEXO { get; set; }
            public DateTime NACIMIENTO { get; set; }

        }

        List<Datos> mashijos = new List<Datos>();

        private void btAgregarHijoAList_Click(object sender, EventArgs e)
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
                else if (cbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar el sexo del hijo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Datos dato = new Datos()
                    {
                        RUT_SOCIO = txtrutsocio.Text,
                        NOMBRE_HIJO = txtnombrehijosocio.Text,
                        RUT = txtruthijosocio.Text,
                        SEXO = cbSexo.Text,
                        NACIMIENTO = Convert.ToDateTime(datenacimientohijosocio.Text),

                    };


                    mashijos.Add(dato);



                    MessageBox.Show("Hijo Agregado Correctamente!");
                    gridpruebahijo.DataSource = mashijos.ToArray();
                    gridpruebahijo.ForeColor = Color.Black;

                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;

                }




                //MessageBox.Show("Rellene campos del hijo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btAgregarlos3_Click(object sender, EventArgs e)
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

                    foreach (var a in mashijos)
                    {
                        Hijo hs = new Hijo
                        {
                            rut_socio = a.RUT_SOCIO,
                            nombre = a.NOMBRE_HIJO,
                            rut_hijo = a.RUT,
                            sexo = a.SEXO,
                            nacimiento = a.NACIMIENTO
                        };
                        context.Hijo.Add(hs);
                    }

                    context.Socio.Add(nuevosocio);
                    context.Conyuge.Add(con);

                    context.SaveChanges();


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
                    //BORRAR DATOS HIJOS
                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;
                    gridpruebahijo.DataSource = "";
                    mashijos.Clear();
                    MessageBox.Show("Socio Agregado Correctamente!");

                }
                catch (Exception)
                {


                    if (fotosocio.Image == null)
                    {
                        MessageBox.Show("Debe Ingresar Imagen *Obligatoria* ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Datos Para Agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
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

        private void btAgregarSocio_Click(object sender, EventArgs e)
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
                    context.Socio.Add(nuevosocio);
                    context.SaveChanges();

                    MessageBox.Show("Socio Agregado Correctamente!");

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
                    //BORRAR DATOS HIJOS
                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;
                    mashijos.Clear();
                    gridpruebahijo.DataSource = "";



                }
                catch (Exception)
                {
                    if (fotosocio.Image == null)
                    {
                        MessageBox.Show("Debe Ingresar Imagen *Obligatoria* ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                    else {
                        MessageBox.Show("Ingrese Datos Para Agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                    
                }
            }
        }

        private void btAgregarSocioeConyuge_Click(object sender, EventArgs e)
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

                    context.Socio.Add(nuevosocio);
                    context.Conyuge.Add(con);

                    context.SaveChanges();


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
                    //BORRAR DATOS HIJOS
                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;
                    gridpruebahijo.DataSource = "";
                    mashijos.Clear();

                    MessageBox.Show("Socio Agregado Correctamente!");


                }
                catch (Exception)
                {
                    if (fotosocio.Image == null)
                    {
                        MessageBox.Show("Debe Ingresar Imagen *Obligatoria* ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Datos Para Agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                }
            }
        }

        private void btnAddSocioeHijo_Click(object sender, EventArgs e)
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

                    foreach (var a in mashijos)
                    {
                        Hijo hs = new Hijo
                        {
                            rut_socio = a.RUT_SOCIO,
                            nombre = a.NOMBRE_HIJO,
                            rut_hijo = a.RUT,
                            sexo = a.SEXO,
                            nacimiento = a.NACIMIENTO
                        };
                        context.Hijo.Add(hs);
                    }

                    context.Socio.Add(nuevosocio);
                    context.SaveChanges();


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
                    //BORRAR DATOS HIJOS
                    txtnombrehijosocio.Text = "";
                    txtruthijosocio.Text = "";
                    cbSexo.SelectedIndex = 0;
                    datenacimientohijosocio.Value = DateTime.Now;
                    mashijos.Clear();




                    gridpruebahijo.DataSource = "";
                    MessageBox.Show("Socio Agregado Con Hijo Correctamente!");




                }
                catch (Exception)
                {

                    if (fotosocio.Image == null)
                    {
                        MessageBox.Show("Debe Ingresar Imagen *Obligatoria* ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Datos Para Agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        //BORRAR DATOS HIJOS
                        txtnombrehijosocio.Text = "";
                        txtruthijosocio.Text = "";
                        cbSexo.SelectedIndex = 0;
                        datenacimientohijosocio.Value = DateTime.Now;
                        mashijos.Clear();
                        gridpruebahijo.DataSource = "";
                    }
                }
            }
        }


        private void combocategoriasocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combocontratosocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboplantasocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboestadocivilagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboconvivienteconyugesocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttelefonosocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }
    }
}
