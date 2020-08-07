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

                var listRut = from sociorut in context.Socio
                              where sociorut.rut_socio.Equals(buscar_rut)
                              select new { Rut = sociorut.rut_socio, Nombre = sociorut.nombre_socio, Categoria = sociorut.id_categoria, Planta = sociorut.Planta.nombre, FechaDeIngreso = sociorut.fecha_ingreso };

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

                        lbeliminar.Text = "Socio encontrado!";
                        grideliminar.DataSource = listRut.ToList();                   

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

                    var result = from c in context.Socio
                                 where c.rut_socio.Equals(eli)
                                 select c;
                    string rut_soc = result.ToList()[0].rut_socio;
                    if (result.Count() != 0)
                    {
                        
                            Socio users = new Socio();
                            users.rut_socio = txteliminar.Text;
                            context.Socio.Remove(context.Socio.Find(rut_soc));
                            context.SaveChanges();

                            lbeliminar.Text = "Socio Eliminado!";
                            grideliminar.DataSource = "";
                            txteliminar.Text = "";

                    }
                    else
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
