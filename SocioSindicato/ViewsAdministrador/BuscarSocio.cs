using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato.ViewsAdministrador
{
    public partial class BuscarSocio : Form
    {
        public BuscarSocio()
        {
            InitializeComponent();
        }
      
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities()) {

                string buscar_rut = txtbuscar.Text;
                
                var listRut = from sociorut in context.Socio 
                              where sociorut.rut_socio.Equals(buscar_rut)
                              select new { Rut= sociorut.rut_socio,Nombre = sociorut.nombre_socio, Categoria = sociorut.id_categoria, Planta = sociorut.Planta.nombre, FechaDeIngreso= sociorut.fecha_ingreso };

                if (txtbuscar.Text=="")
                {
                    lbbuscarsocio.Text = "Ingrese Rut Socio!";
                    gridbuscar.DataSource = "";
                    txtbuscar.Text = "";
                }
                else
                {
                    if (listRut.Count() != 0)
                    {

                        lbbuscarsocio.Text = "Socio encontrado!";
                        gridbuscar.DataSource = listRut.ToList();
                        txtbuscar.Text = "";

                    }
                    else
                    {
                        lbbuscarsocio.Text = "Socio no encontrado!";
                        gridbuscar.DataSource = "";
                        txtbuscar.Text = "";


                    }
                }

            }
         
        }

        private void btnvolverbuscar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }
    }
}
