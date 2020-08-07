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

            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {

                string eli = txteliminar.Text;
                if (txteliminar.Text == "")
                {
                    lbeliminar.Text = "Ingrese Rut para eliminar socio";
                    grideliminar.DataSource = "";
                    txteliminar.Text = "";
                }
                else
                {
                    try
                    {
                        var result1 = from c in context.Conyuge
                                      where c.rut_socio.Equals(eli)
                                      select new { id_con = c.id_conyuge };
                        int rut_soc1 = result1.ToList()[0].id_con;

                        var result2 = from c in context.Hijo
                                      where c.rut_socio.Equals(eli)
                                      select new { id_hij = c.id_hijo };
                        int rut_soc2 = result2.ToList()[0].id_hij;

                        var result3 = from c in context.Socio
                                      where c.rut_socio.Equals(eli)
                                      select c;
                        string rut_soc3 = result3.ToList()[0].rut_socio;


                        context.Conyuge.Remove(context.Conyuge.Find(rut_soc1));
                        context.Hijo.Remove(context.Hijo.Find(rut_soc2));
                        context.Socio.Remove(context.Socio.Find(rut_soc3));
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
