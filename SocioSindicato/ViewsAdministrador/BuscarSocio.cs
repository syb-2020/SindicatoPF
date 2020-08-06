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
                
                var listRut = from sociorut in context.Usuario join sociorol in context.Rol
                              on sociorut.id_rol equals sociorol.id_rol
                              where sociorut.nombre.Equals(buscar_rut)
                              select new { IDUSUARIO= sociorut.id_usuario,Nombre = sociorut.nombre, IDROL = sociorol.id_rol };

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
