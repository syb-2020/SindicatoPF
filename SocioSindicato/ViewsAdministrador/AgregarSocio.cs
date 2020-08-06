using SocioSindicato.Models;
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

        private void btnvolveragregar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void btnagregarsocio_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                try
                {
                    Socio nuevosocio = new Socio {
                        rut_socio = txtrutsocio.Text,
                        imagen = "",
                        nombre_socio = txtnombresocio.Text,
                        fecha_ingreso = Convert.ToDateTime(dateingresoempresasocio),
                        id_categoria = Convert.ToInt32(combocategoriasocio.Text),
                        tipo_contrato = combocontratosocio.Text,
                        id_planta = Convert.ToInt32(comboplantasocio.Text),
                        fecha_nacimiento = Convert.ToDateTime(datefechanacimientosocio),
                        edad = Convert.ToInt32(txtedadsocio.Text),
                        domicilio = txtdomiciliosocio.Text,
                        estado_civil = txtestadocivilsocio.Text,
                        telefono = Convert.ToInt32(txttelefonosocio.Text),
                        cantidad_carga = Convert.ToInt32(combocargasocio.Text),
                        nacionalidad = txtnacionalidadsocio.Text,
                        correo = txtcorreosocio.Text,
                        datos_papa = txtnombrepadre.Text,
                        datos_mama = txtnombremadre.Text,
                        

                    };
                        
                }
                catch (Exception)
                {

                    throw;
                }
            }
            }

       
        private void combocategoriasocio_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void btnseleccionarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccion = new OpenFileDialog();
            seleccion.Filter = "Imagenes |*.jpg; *.png";
            seleccion.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            seleccion.Title = "Seleccionar Imagen";

            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                fotosocio.Image = Image.FromFile(seleccion.FileName);
            }
        }
    }
}
