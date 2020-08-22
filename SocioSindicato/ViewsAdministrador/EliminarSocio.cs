﻿using SocioSindicato.Models;
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


        //BOTON BUSCAR USUARIO        
        private void btBuscarUser_Click(object sender, EventArgs e)
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
                    pb.Image = null;
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

                        MessageBox.Show("Socio Encontrado!");

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

        //FIN BUSCAR USUARIO

        bool estadoEliminado = false;
        //BOTON ELIMINAR USUARIO
        private void btEliminar_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {

                string eli = txteliminar.Text;
                if (txteliminar.Text == "")
                {

                    MessageBox.Show("Ingrese Rut Del Socio Para Eliminar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grideliminar.DataSource = "";
                    txteliminar.Text = "";
                    pb.Image = null;
                }
                else
                {


                    var result3 = from c in context.Socio
                                  where c.rut_socio.Equals(eli)
                                  select c;

                    gridsociosolo.DataSource = result3.ToList();

                    var result1 = from c in context.Conyuge
                                  where c.rut_socio.Equals(eli)
                                  select new { id_con = c.id_conyuge };
                    gridsolocon.DataSource = result1.ToList();


                    var result2 = from c in context.Hijo
                                  where c.rut_socio.Equals(eli)
                                  select new { id_hij = c.id_hijo };

                    gridhijo.DataSource = result2.ToList();

                    // ELIMINAR SOCIO CONYU HIJO
                    if (result3.Count() != 0) //socio
                    {


                        if (result1.Count() != 0) //conyuge
                        {


                            if (result2.Count() != 0) //hijo
                            {
                                string rut_soc3 = result3.ToList()[0].rut_socio;
                                int rut_soc1 = result1.ToList()[0].id_con;
                                int rut_soc2 = result2.ToList()[0].id_hij;

                                var rellenarSocioEliminado = from c in context.Socio
                                                             join plansoc in context.Planta
                                                             on c.id_planta equals plansoc.id_planta
                                                             where c.rut_socio.Equals(eli)
                                                             select new
                                                             {
                                                                 c.rut_socio,
                                                                 c.nombre_socio,
                                                                 c.id_categoria,
                                                                 c.fecha_ingreso,
                                                                 plansoc.nombre
                                                             };

                                string rut2 = rellenarSocioEliminado.ToList()[0].rut_socio;
                                string nombre2 = rellenarSocioEliminado.ToList()[0].nombre_socio;
                                int categoria2 = rellenarSocioEliminado.ToList()[0].id_categoria;
                                DateTime fecha2 = Convert.ToDateTime(rellenarSocioEliminado.ToList()[0].fecha_ingreso);
                                string planta2 = rellenarSocioEliminado.ToList()[0].nombre;

                                socioEliminado nuevoSocioEliminado = new socioEliminado
                                {

                                    rut = rut2,
                                    nombre = nombre2,
                                    categoria = categoria2,
                                    fechaIngreso = fecha2,
                                    planta = planta2,

                                };

                                context.socioEliminado.Add(nuevoSocioEliminado);
                                context.SaveChanges();

                                context.Conyuge.Remove(context.Conyuge.Find(rut_soc1));


                                for (int i = 0; i < gridhijo.RowCount; i++)
                                {
                                    int ihe = int.Parse(gridhijo.Rows[i].Cells[0].Value.ToString());
                                    context.Hijo.Remove(context.Hijo.Find(ihe));
                                }




                                context.Socio.Remove(context.Socio.Find(rut_soc3));

                                context.SaveChanges();

                                estadoEliminado = true;



                            }


                        }
                    }



                    //ELIMINAR SOCIO CONYUGE
                    if (result3.Count() != 0)
                    {
                        if (result1.Count() != 0)
                        {
                            string rut_soc3 = result3.ToList()[0].rut_socio;
                            int rut_soc1 = result1.ToList()[0].id_con;

                            var rellenarSocioEliminado = from c in context.Socio
                                                         join plansoc in context.Planta
                                                         on c.id_planta equals plansoc.id_planta
                                                         where c.rut_socio.Equals(eli)
                                                         select new
                                                         {
                                                             c.rut_socio,
                                                             c.nombre_socio,
                                                             c.id_categoria,
                                                             c.fecha_ingreso,
                                                             plansoc.nombre
                                                         };

                            string rut2 = rellenarSocioEliminado.ToList()[0].rut_socio;
                            string nombre2 = rellenarSocioEliminado.ToList()[0].nombre_socio;
                            int categoria2 = rellenarSocioEliminado.ToList()[0].id_categoria;
                            DateTime fecha2 = Convert.ToDateTime(rellenarSocioEliminado.ToList()[0].fecha_ingreso);
                            string planta2 = rellenarSocioEliminado.ToList()[0].nombre;

                            socioEliminado nuevoSocioEliminado = new socioEliminado
                            {

                                rut = rut2,
                                nombre = nombre2,
                                categoria = categoria2,
                                fechaIngreso = fecha2,
                                planta = planta2,

                            };

                            context.socioEliminado.Add(nuevoSocioEliminado);
                            context.SaveChanges();

                            context.Conyuge.Remove(context.Conyuge.Find(rut_soc1));

                            context.Socio.Remove(context.Socio.Find(rut_soc3));

                            context.SaveChanges();
                            estadoEliminado = true;





                        }

                    }



                    //ELIMINAR SOCIO HIJO
                    if (result3.Count() != 0)
                    {
                        if (result2.Count() != 0)
                        {
                            string rut_soc3 = result3.ToList()[0].rut_socio;
                            int rut_soc2 = result2.ToList()[0].id_hij;

                            var rellenarSocioEliminado = from c in context.Socio
                                                         join plansoc in context.Planta
                                                         on c.id_planta equals plansoc.id_planta
                                                         where c.rut_socio.Equals(eli)
                                                         select new
                                                         {
                                                             c.rut_socio,
                                                             c.nombre_socio,
                                                             c.id_categoria,
                                                             c.fecha_ingreso,
                                                             plansoc.nombre
                                                         };

                            string rut2 = rellenarSocioEliminado.ToList()[0].rut_socio;
                            string nombre2 = rellenarSocioEliminado.ToList()[0].nombre_socio;
                            int categoria2 = rellenarSocioEliminado.ToList()[0].id_categoria;
                            DateTime fecha2 = Convert.ToDateTime(rellenarSocioEliminado.ToList()[0].fecha_ingreso);
                            string planta2 = rellenarSocioEliminado.ToList()[0].nombre;

                            socioEliminado nuevoSocioEliminado = new socioEliminado
                            {

                                rut = rut2,
                                nombre = nombre2,
                                categoria = categoria2,
                                fechaIngreso = fecha2,
                                planta = planta2,

                            };

                            context.socioEliminado.Add(nuevoSocioEliminado);
                            context.SaveChanges();



                            for (int i = 0; i < gridhijo.RowCount; i++)
                            {
                                int ihe = int.Parse(gridhijo.Rows[i].Cells[0].Value.ToString());
                                context.Hijo.Remove(context.Hijo.Find(ihe));
                            }




                            context.Socio.Remove(context.Socio.Find(rut_soc3));

                            context.SaveChanges();


                            estadoEliminado = true;



                        }

                    }


                    //ELIMINAR SOCIO SOLO
                    if (result3.Count() != 0)
                    {
                        string rut_soc3 = result3.ToList()[0].rut_socio;
                        var rellenarSocioEliminado = from c in context.Socio
                                                     join plansoc in context.Planta
                                                     on c.id_planta equals plansoc.id_planta
                                                     where c.rut_socio.Equals(eli)
                                                     select new
                                                     {
                                                         c.rut_socio,
                                                         c.nombre_socio,
                                                         c.id_categoria,
                                                         c.fecha_ingreso,
                                                         plansoc.nombre
                                                     };

                        string rut2 = rellenarSocioEliminado.ToList()[0].rut_socio;
                        string nombre2 = rellenarSocioEliminado.ToList()[0].nombre_socio;
                        int categoria2 = rellenarSocioEliminado.ToList()[0].id_categoria;
                        DateTime fecha2 = Convert.ToDateTime(rellenarSocioEliminado.ToList()[0].fecha_ingreso);
                        string planta2 = rellenarSocioEliminado.ToList()[0].nombre;

                        socioEliminado nuevoSocioEliminado = new socioEliminado
                        {

                            rut = rut2,
                            nombre = nombre2,
                            categoria = categoria2,
                            fechaIngreso = fecha2,
                            planta = planta2,

                        };

                        context.socioEliminado.Add(nuevoSocioEliminado);


                        context.Socio.Remove(context.Socio.Find(rut_soc3));
                        context.SaveChanges();


                        estadoEliminado = true;
                    }



                    if (estadoEliminado == true)
                    {
                        MessageBox.Show("Socio Eliminado!");
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";
                        pb.Image = null;



                    }
                    else if (estadoEliminado == false)
                    {
                        MessageBox.Show("Socio No Eliminado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        grideliminar.DataSource = "";
                        txteliminar.Text = "";
                        pb.Image = null;
                    }

                    estadoEliminado = false;




                }
            }
        }
        //FIN ELIMINAR USUARIO
        
        private void btVolver_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            this.Close();
        }

        private void grideliminar_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(grideliminar.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        
    }
}
