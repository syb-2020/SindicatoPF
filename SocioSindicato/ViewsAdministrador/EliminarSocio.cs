using SocioSindicato.Models;
using System;
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
                    
                    
                    MessageBox.Show("Ingrese Rut del socio!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grideliminar.DataSource = "";
                    txteliminar.Text = "";
                }
                else
                {
                    if (listRut.Count() != 0)
                    {
                        

                        grideliminar.DataSource = listRut.ToList();
                        string rut = grideliminar.Rows[grideliminar.CurrentRow.Index].Cells[0].Value.ToString();
                        using (sindicatoPFEntities db = new sindicatoPFEntities())
                        {
                            var oImage = db.Socio.Find(rut);
                            MemoryStream ms = new MemoryStream(oImage.imagen);
                            Bitmap bmp = new Bitmap(ms);
                            pb.Image = bmp;
                        }

                        txteliminar.Text = "";

                    }
                    else
                    {
                    
                       
                        MessageBox.Show("Socio No Encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    
                    MessageBox.Show("Ingrese Rut Del Socio Para Eliminar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                      
                        MessageBox.Show("Socio Eliminado!");
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";

                    }
                    catch (Exception)
                    {
                        

                        MessageBox.Show("Socio No Eliminado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
