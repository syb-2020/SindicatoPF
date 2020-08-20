using Microsoft.Office.Interop.Excel;
using SocioSindicato.Models;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
               

                var listadoTodo = from c in context.Socio
                                             join conyu in context.Conyuge
                                             on c.rut_socio equals conyu.rut_socio
                                             where c.rut_socio.Equals(buscar_rut)
                                             join hij in context.Hijo on c.rut_socio equals hij.rut_socio where c.rut_socio.Equals(buscar_rut)
                                             select new
                                             {
                                                 RUT_SOCIO = c.rut_socio,
                                                 NOMBRE_SOCIO = c.nombre_socio,
                                                 CATEGORIA = c.id_categoria,
                                                 PLANTA = c.Planta.nombre,
                                                 FECHA_DE_INGRESO = c.fecha_ingreso,
                                                 RUT_CONYUGE = conyu.rut,
                                                 NOMBRE_CONYUGE = conyu.nombre,
                                                 NACIMIENTO_CONYUGE = conyu.nacimiento,
                                                 CONVIVIENTE = conyu.conviviente,
                                                 RUT_HIJO = hij.rut_hijo,
                                                 NOMBRE_HIJO = hij.nombre,
                                                 NACIMIENTO_HIJO = hij.nacimiento,
                                                 SEXO = hij.sexo

                                             };

                if (txtbuscar.Text=="")
                {
                    
                    
                    MessageBox.Show("Ingrese Rut del socio!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    imagenbuscarsociomostrar.Image = null;
                    gridbuscar.DataSource = "";
                    txtbuscar.Text = "";
                }
                else
                {
                    if (listRut.Count() != 0)
                    {
                        
                        MessageBox.Show("Socio encontrado!");
                        gridbuscar.DataSource = listRut.ToList();
                        gridConyuge.DataSource = "";
                        gridHijo.DataSource = "";
                        gbtodo.DataSource = listadoTodo.ToList();



                        string rut = gridbuscar.Rows[gridbuscar.CurrentRow.Index].Cells[0].Value.ToString();
                        using (sindicatoPFEntities db = new sindicatoPFEntities())
                        {
                            var oImage = db.Socio.Find(rut);
                            MemoryStream ms = new MemoryStream(oImage.imagen);
                            Bitmap bmp = new Bitmap(ms);
                            imagenbuscarsociomostrar.Image = bmp;
                        }
                    }
                    else
                    {
                        
                      
                        MessageBox.Show("Socio No Encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void imagenbuscarsociomostrar_Click(object sender, EventArgs e)
        {
           
        }
       
        public void exportardatos(DataGridView datalistado) {

            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);
           
            

            int indicecolum = 0;
        

            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolum++;
                exportarexcel.Cells[1, indicecolum] = columna.Name;              
            }
           
            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows )
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
            if (gbtodo.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                exportardatos(gbtodo);                
            }

            

        }

        private void btconyuge_Click(object sender, EventArgs e)
        {
            sindicatoPFEntities context = new sindicatoPFEntities();
            string buscar_rut = txtbuscar.Text;
            
            if (gridbuscar.Rows.Count == 0)
            {


                MessageBox.Show("Primero debe buscar Socio!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                imagenbuscarsociomostrar.Image = null;
                gridConyuge.DataSource = "";
                txtbuscar.Text = "";
            }
            else
            {
                var listConyu = from conyu in context.Conyuge
                                where buscar_rut.Equals(conyu.rut_socio)
                                select new { RUT = conyu.rut, NOMBRE = conyu.nombre, NACIMIENTO = conyu.nacimiento, CONVIVIENTE = conyu.conviviente };
                if (listConyu.Count() != 0)
                {

                    MessageBox.Show("Conyuge encontrado!");

                    gridConyuge.DataSource = listConyu.ToList();                    
                }
                else
                {


                    MessageBox.Show("Socio no tiene Conyuge !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridConyuge.DataSource = "";
                   


                }
            }
        }

        private void btcargas_Click(object sender, EventArgs e)
        {
            sindicatoPFEntities context = new sindicatoPFEntities();
            string buscar_rut = txtbuscar.Text;
            
            if (gridbuscar.Rows.Count == 0)
            {


                MessageBox.Show("Primero debe buscar Socio!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                imagenbuscarsociomostrar.Image = null;
                gridHijo.DataSource = "";
                txtbuscar.Text = "";
            }
            else
            {
                var listHijo = from hijobt in context.Hijo
                               where buscar_rut.Equals(hijobt.rut_socio)
                               select new { RUT = hijobt.rut_hijo, NOMBRE = hijobt.nombre, NACIMIENTO = hijobt.nacimiento, SEXO = hijobt.sexo };
                if (listHijo.Count() != 0)
                {

                    MessageBox.Show("Hijo encontrado!");

                    gridHijo.DataSource = listHijo.ToList();
                }
                else
                {


                    MessageBox.Show("Socio no tiene hijo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridHijo.DataSource = "";
                    


                }
            }
        }

        private void btnexcelsocio_Click(object sender, EventArgs e)
        {
            if (gridbuscar.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gridbuscar);
            }

        }

        private void gridbuscar_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            using (SolidBrush b = new SolidBrush(gridbuscar.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void gridConyuge_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridConyuge.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void gridHijo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridHijo.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnexcelsocioconyuge_Click(object sender, EventArgs e)
        {
            string buscar_rut = txtbuscar.Text;
            sindicatoPFEntities context = new sindicatoPFEntities();
            var Listadosocioconyuge = from c in context.Socio
                              join conyu in context.Conyuge
                              on c.rut_socio equals conyu.rut_socio
                              where c.rut_socio.Equals(buscar_rut)                           
                              select new
                              {
                                  RUT_SOCIO = c.rut_socio,
                                  NOMBRE_SOCIO = c.nombre_socio,
                                  CATEGORIA = c.id_categoria,
                                  PLANTA = c.Planta.nombre,
                                  FECHA_DE_INGRESO = c.fecha_ingreso,
                                  RUT_CONYUGE = conyu.rut,
                                  NOMBRE_CONYUGE = conyu.nombre,
                                  NACIMIENTO_CONYUGE = conyu.nacimiento,
                                  CONVIVIENTE = conyu.conviviente,                                
                              };
            gbtodo.DataSource = Listadosocioconyuge.ToList();

            if (gbtodo.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gbtodo);
            }
        }

        private void btnexcelsociohijo_Click(object sender, EventArgs e)
        {
             string buscar_rut = txtbuscar.Text;
            sindicatoPFEntities context = new sindicatoPFEntities();
            var listadosociohijo = from c in context.Socio                            
                              join hij in context.Hijo on c.rut_socio equals hij.rut_socio
                              where c.rut_socio.Equals(buscar_rut)
                              select new
                              {
                                  RUT_SOCIO = c.rut_socio,
                                  NOMBRE_SOCIO = c.nombre_socio,
                                  CATEGORIA = c.id_categoria,
                                  PLANTA = c.Planta.nombre,
                                  FECHA_DE_INGRESO = c.fecha_ingreso,                                 
                                  RUT_HIJO = hij.rut_hijo,
                                  NOMBRE_HIJO = hij.nombre,
                                  NACIMIENTO_HIJO = hij.nacimiento,
                                  SEXO = hij.sexo

                              };

            gbtodo.DataSource = listadosociohijo.ToList();

            if (gbtodo.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gbtodo);
            }
        }
    }
}
