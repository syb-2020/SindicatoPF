using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato.ViewsAdministrador
{
    public partial class Plantas : Form
    {
        public Plantas()
        {
            InitializeComponent();           
        }

        private void btnplantasvolver_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }
        
       
        /// CREACION DE VARIABLES PARA CAPTURAR EL BOTON SELECCIONADO
        
        private bool btnplanta1seleccionado = false;
        private bool btnplanta2seleccionado = false;
        private bool btnplanta3seleccionado = false;
        private bool btnplanta4seleccionado = false;
        private bool btnplantacdtseleccionado = false;
        private bool btnplantapizzaseleccionado = false;
        private bool btnplantacarnicoseleccionado = false;
        private bool btnplantaallseleccionado = false;


        //INICIO BOTONES
        private void btnplanta1_Click(object sender, EventArgs e)
        {
            btnplanta1seleccionado = true;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;

            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp1 = 1;
                var sociosplanta1 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp1)
                                    select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta 1 Encontrados!");


                }


            }

        }

        private void btnplanta2_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = true;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp2 = 2;

                var sociosplanta2 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp2)
                                    select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };




                gridverplantas.DataSource = sociosplanta2.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta 2 Encontrados!");


                }





            }
        }

        private void btnplanta3_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = true;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp3 = 3;
                var sociosplanta3 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp3)
                                    select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                gridverplantas.DataSource = sociosplanta3.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta 3 Encontrados!");



                }

            }
        }

        private void btnplanta4_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = true;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp4 = 4;
                var sociosplanta4 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp4)
                                    select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };



                gridverplantas.DataSource = sociosplanta4.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta 4 Encontrados!");



                }


            }
        }
        private void btncdt_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = true;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpcdt = 5;
                var sociosplantacdt = from socplan in context.Socio
                                      join plansoc in context.Planta
                                      on socplan.id_planta equals plansoc.id_planta
                                      where plansoc.id_planta.Equals(idpcdt)
                                      select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                gridverplantas.DataSource = sociosplantacdt.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta CDT Encontrados!");

                }

            }
        }

        private void btnplantapizza_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = true;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpp = 6;
                var sociosplantapizza = from socplan in context.Socio
                                        join plansoc in context.Planta
                                        on socplan.id_planta equals plansoc.id_planta
                                        where plansoc.id_planta.Equals(idpp)
                                        select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                gridverplantas.DataSource = sociosplantapizza.OrderBy(s => s.CATEGORIA).ToList();


                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta Pizza Encontrados!");


                }


            }
        }

        private void btnplantacarnicos_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = true;
            btnplantaallseleccionado = false;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpcrn = 7;
                var sociosplantacarnico = from socplan in context.Socio
                                          join plansoc in context.Planta
                                          on socplan.id_planta equals plansoc.id_planta
                                          where plansoc.id_planta.Equals(idpcrn)
                                          select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                gridverplantas.DataSource = sociosplantacarnico.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios en esta planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Socio Planta Carnicos Encontrados!");



                }


            }
        }

        private void btntodos_Click(object sender, EventArgs e)
        {

            btnplanta1seleccionado = false;
            btnplanta2seleccionado = false;
            btnplanta3seleccionado = false;
            btnplanta4seleccionado = false;
            btnplantacdtseleccionado = false;
            btnplantapizzaseleccionado = false;
            btnplantacarnicoseleccionado = false;
            btnplantaallseleccionado = true;
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {

                var allsociosplanta = from socplan in context.Socio
                                      join plansoc in context.Planta
                                      on socplan.id_planta equals plansoc.id_planta
                                      orderby plansoc.id_planta
                                      select new { RUT = socplan.rut_socio, NOMBRE = socplan.nombre_socio,  PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                gridverplantas.DataSource = allsociosplanta.OrderBy(s => s.CATEGORIA).ToList();

                if (gridverplantas.Rows.Count == 0)
                {
                    MessageBox.Show("No Existen Socios En Ninguna Planta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Todos Los Socios!");



                }


            }
        }


        //FIN BOTONES



        public void exportardatos(DataGridView datalistado)
        {

            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);

            int indicecolum = 0;
            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolum++;
                exportarexcel.Cells[1, indicecolum] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolum = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolum++;
                    exportarexcel.Cells[indicefila + 1, indicecolum] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }

        private void btnddexcel_Click(object sender, EventArgs e)
        {            
            if (gridverplantas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gridverplantas);
            }
        }

        //public void mostrarAllplantas()
        //{
        //    using (sindicatoPFEntities context = new sindicatoPFEntities())
        //    {

        //        var allsociosplanta = from socplan in context.Socio
        //                              join plansoc in context.Planta
        //                              on socplan.id_planta equals plansoc.id_planta
        //                              orderby plansoc.id_planta
        //                              select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

        //        gridverplantas.DataSource = allsociosplanta.ToList();
        //        gridverplantas.DataSource = allsociosplanta.OrderBy(s => s.PLANTA).ToList();

        //    }
        //}

        private void gridverplantas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridverplantas.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnordenarplanta_Click(object sender, EventArgs e)
        {
            if (cbordenarcatplant.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Campo Para ordenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int indice = cbordenarcatplant.SelectedIndex;

            if (btnplanta1seleccionado == true)
            {

                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplanta1seleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }




                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplanta1seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {

                    if (btnplanta1seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {

                    if (btnplanta1seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }





                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplanta1seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplanta1seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta 1";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };


                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }


            }

            else if (btnplanta2seleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }



                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {

                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {

                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {

                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {

                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {

                    if (btnplanta2seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta 2";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }
                }

            }
            else if (btnplanta3seleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }




                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplanta3seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta 3";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }

                }

            }
            else if (btnplanta4seleccionado == true)
            {

                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }




                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplanta4seleccionado == true)
                    {

                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta 4";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }

            }
            else if (btnplantacdtseleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 1;
                            //string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                //where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }



                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 2;
                            string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 3;
                            string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 4;
                            string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 5;
                            string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplantacdtseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {

                            int idpcategoria = 6;
                            string nombreplanta = "CDT";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();
                        }


                    }
                }

            }
            else if (btnplantapizzaseleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }





                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplantapizzaseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta pizza";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }

            }
            else if (btnplantacarnicoseleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }





                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplantacarnicoseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;
                            string nombreplanta = "planta carnico";
                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)
                                                where plansoc.nombre.Equals(nombreplanta)
                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }
                    }
                }

            }
            else if (btnplantaallseleccionado == true)
            {
                if (Convert.ToInt32(indice.ToString()) == 0)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 1;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }




                }
                else if (Convert.ToInt32(indice.ToString()) == 1)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 2;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 2)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 3;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 3)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 4;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 4)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 5;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }

                }
                else if (Convert.ToInt32(indice.ToString()) == 5)
                {
                    if (btnplantaallseleccionado == true)
                    {
                        using (sindicatoPFEntities context = new sindicatoPFEntities())
                        {
                            int idpcategoria = 6;

                            var sociosplanta1 = from socplan in context.Socio
                                                join plansoc in context.Planta
                                                on socplan.id_planta equals plansoc.id_planta
                                                join cat in context.Categoria
                                                on socplan.id_categoria equals cat.id_categoria
                                                where cat.id_categoria.Equals(idpcategoria)

                                                select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre, CATEGORIA = socplan.id_categoria };

                            gridverplantas.DataSource = sociosplanta1.OrderBy(s => s.PLANTA).ToList();

                        }

                    }


                }

            }
            else
            {

                MessageBox.Show("Selecciones una planta para ordenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
