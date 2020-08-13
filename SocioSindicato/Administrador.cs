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

namespace SocioSindicato
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 bs = new Form1();
            this.Hide();
            MessageBox.Show("Cuenta cerrada!");
            bs.ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.BuscarSocio bs = new ViewsAdministrador.BuscarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.EliminarSocio bs = new ViewsAdministrador.EliminarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.AgregarSocio bs = new ViewsAdministrador.AgregarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.Plantas bs = new ViewsAdministrador.Plantas();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.ListadoNavidad bs = new ViewsAdministrador.ListadoNavidad();
            this.Hide();
            bs.ShowDialog();
            this.Close();
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

        

        private void btneliminadosadm_Click(object sender, EventArgs e)
        {
            using (sindicatoPFEntities context = new sindicatoPFEntities()) {


                var listEliminados = from soceli in context.socioEliminado
                                     select new
                                     {
                                         RUT = soceli.rut,
                                         NOMBRE = soceli.nombre,
                                         CATEGORIA = soceli.categoria,
                                         INGRESO = soceli.fechaIngreso,
                                         PLANTA = soceli.planta,
                                     };

                gridvereliminadosadm.DataSource = listEliminados.ToList();

                if (gridvereliminadosadm.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios Eliminados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                 
                    exportardatos(gridvereliminadosadm);
                }


            }
            
                
        }

        private void btneditarsocioADM_Click(object sender, EventArgs e)
        {
            ViewsAdministrador.EditarSocio bs = new ViewsAdministrador.EditarSocio();
            this.Hide();
            bs.ShowDialog();
            this.Close();
        }
    }
}
