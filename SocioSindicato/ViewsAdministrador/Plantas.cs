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

        private void btnplanta1_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp1 = 1;
                var sociosplanta1 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp1)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };


                gridverplantas.DataSource = sociosplanta1.ToList();

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
            
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp2 = 2;
                
                var sociosplanta2 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp2)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };



                gridverplantas.DataSource = sociosplanta2.ToList();

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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp3 = 3;
                var sociosplanta3 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp3)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };

                gridverplantas.DataSource = sociosplanta3.ToList();

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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idp4 = 4;
                var sociosplanta4 = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idp4)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };



                gridverplantas.DataSource = sociosplanta4.ToList();

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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpcdt = 5;
                var sociosplantacdt = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idpcdt)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };


                gridverplantas.DataSource = sociosplantacdt.ToList();

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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpp = 6;
                var sociosplantapizza = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idpp)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };


                gridverplantas.DataSource = sociosplantapizza.ToList();


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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                int idpcrn = 7;
                var sociosplantacarnico = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    where plansoc.id_planta.Equals(idpcrn)
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };

                gridverplantas.DataSource = sociosplantacarnico.ToList();

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
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
               
                var allsociosplanta = from socplan in context.Socio
                                    join plansoc in context.Planta
                                    on socplan.id_planta equals plansoc.id_planta
                                    orderby plansoc.id_planta
                                    select new { NOMBRE = socplan.nombre_socio, RUT = socplan.rut_socio, PLANTA = plansoc.nombre };

                gridverplantas.DataSource = allsociosplanta.ToList();

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
    }
}
