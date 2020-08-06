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
    public partial class EliminarSocio : Form
    {
        public EliminarSocio()
        {
            InitializeComponent();
        }
        public string rut_socio = "";
        private void btnbuscarel_Click(object sender, EventArgs e)
        {

            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                string buscar_rut = txteliminar.Text;

                var listRut = from sociorut in context.Usuario
                              join sociorol in context.Rol
                              on sociorut.id_rol equals sociorol.id_rol
                              where sociorut.nombre.Equals(buscar_rut)
                              select new { IDUSUARIO = sociorut.id_usuario, Nombre = sociorut.nombre, IDROL = sociorol.id_rol };


                if (txteliminar.Text == "")
                {
                    lbeliminar.Text = "Ingrese Rut Socio!";
                    grideliminar.DataSource = "";
                    txteliminar.Text = "";
                }
                else
                {
                    if (listRut.Count() != 0)
                    {
                        grideliminar.DataSource = listRut.ToList();
                        lbeliminar.Text = "Socio encontrado!";
                        rut_socio = listRut.ToList()[0].Nombre;
                        
                    }
                    else
                    {
                        lbeliminar.Text = "Socio no encontrado!";
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";

                    }
                }
            }

        }
      
        private void btneliminar_Click(object sender, EventArgs e)
        {
           
            using (sindicatoPFEntities context = new sindicatoPFEntities()) {

                string eli = txteliminar.Text;
                if (txteliminar.Text == "")
                {
                    lbeliminar.Text = "Ingrese Rut para eliminar socio";
                    grideliminar.DataSource = "";
                    txteliminar.Text = "";
                }
                else
                {

                    var result = from c in context.Usuario
                                 where c.nombre.Equals(rut_socio)
                                 select c;
                int id_socio = result.ToList()[0].id_usuario;

                    try
                    {
                        Usuario users = new Usuario();
                    context.Usuario.Remove(context.Usuario.Find(id_socio));
                        context.SaveChanges();

                        lbeliminar.Text = "Socio Eliminado!";
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";

                    }
                    catch (Exception)
                    {
                        lbeliminar.Text = "Socio no eliminado!";
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";

                    }
                }
            }
                
        }

        private void btnvolvereliminar_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }
    }
}
