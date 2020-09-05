using Microsoft.Office.Interop.Excel;
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
    public partial class ListadoNavidad : Form
    {
        public ListadoNavidad()
        {
            InitializeComponent();
            mostrarAllHijos();



        }
        
        private void btVolver_Click(object sender, EventArgs e)
        {
            Administrador bs = new Administrador();
            this.Hide();
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

        //BOTON DESCARGA LISTADO NIÑOS NAVIDAD
        private void btDownload_Click(object sender, EventArgs e)
        {
            if (gridnavidadniños.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gridnavidadniños);
            }
        }
        //FIN BOTON LISTADO NIÑOZ NAVIDAD
        private void btndescargarexcel_Click(object sender, EventArgs e)
        {
            if (gridnavidadniños.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                exportardatos(gridnavidadniños);
            }

        }
        public class Datos
        {
            public string NOMBRES { get; set; }
            public int EDAD { get; set; }
            public DateTime FECHA_DE_NACIMIENTO { get; set; }
            public string SEXO { get; set; }
            public string PADRE { get; set; }
            public string PLANTA { get; set; }

        }
        List<Datos> navidad = new List<Datos>();
        int dias = 0;

        public void mostrarAllHijos()
        {
            navidad.Clear();
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {
                var xxx = from hh in context.Hijo
                          select new { hh.nacimiento, hh.nombre };

                gridcargarn.DataSource = xxx.ToList();


                for (int i = 0; i < gridcargarn.RowCount; i++)
                {
                    DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                    string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                    var listaHije = from fech in context.Hijo
                                    where fech.nombre.Equals(name)
                                    select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                    string rut_soc = listaHije.ToList()[0].rut_socio;
                    string nombrehi = listaHije.ToList()[0].nombre;
                    DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                    string sexo2 = listaHije.ToList()[0].sexo;

                    DateTime fechaactual = DateTime.Now;

                    TimeSpan tSpan = fechaactual - fechanacimiento;

                    dias = tSpan.Days;


                    var listaSoc = from Soc in context.Socio
                                   where Soc.rut_socio.Equals(rut_soc)
                                   select new { Soc.nombre_socio, Soc.id_planta };

                    string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                    int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                    var listaPlan = from Plan in context.Planta
                                    where Plan.id_planta.Equals(idPlan)
                                    select new { Plan.nombre };
                    string nombreplan = listaPlan.ToList()[0].nombre;




                    if (dias >= 0 && dias <= 211) 
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadmenorhombre = 0;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadmenorhombre,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }

                    } //niños menores a 1 año
                    if (dias >= 0 && dias <= 211)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 0;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }

                    } //niñas menores a 1 año
                    if (dias >= 212 && dias <= 576)
                    {
                        if (sexo2.Equals("Hombre"))
                        {

                            int edadniños = 1;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 1 año
                    if (dias >= 212 && dias <= 576)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 1;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 1 año
                    if (dias >= 577 && dias <= 941)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 2;

                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 2 año
                    if (dias >= 577 && dias <= 941)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 2;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 2 año
                    if (dias >= 942 && dias <= 1277)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 3;

                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 3 año
                    if (dias >= 942 && dias <= 1277)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 3;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 3 año
                    if (dias >= 1278 && dias <= 1642)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 4;

                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 4 año
                    if (dias >= 1278 && dias <= 1642)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 4;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 4 año
                    if (dias >= 1643 && dias <= 2037)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 5;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 5 año
                    if (dias >= 1643 && dias <= 2037)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 5;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 5 año
                    if (dias >= 2038 && dias <= 2402)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 6;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 6 año
                    if (dias >= 2038 && dias <= 2402)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 6;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 6 año
                    if (dias >= 2403 && dias <= 2768)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 7;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 7 año
                    if (dias >= 2403 && dias <= 2768)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 7;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };

                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 7 año
                    if (dias >= 2769 && dias <= 3133)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 8;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan
                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 8 año
                    if (dias >= 2769 && dias <= 3133)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 8;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 8 año
                    if (dias >= 3134 && dias <= 3498)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 9;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 9 año
                    if (dias >= 3134 && dias <= 3498)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 9;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 9 año
                    if (dias >= 3499 && dias <= 3863)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 10;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 10 año
                    if (dias >= 3499 && dias <= 3863)
                    {
                        if (sexo2.Equals("Mujer"))
                        {

                            int edadniños = 10;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 10 año
                    if (dias >= 3864 && dias <= 4229)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 11;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 11 año
                    if (dias >= 3864 && dias <= 4229)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 11;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 11 año
                    if (dias >= 4230 && dias <= 4595)
                    {
                        if (sexo2.Equals("Hombre"))
                        {
                            int edadniños = 12;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niños de 12 año
                    if (dias >= 4230 && dias <= 4595)
                    {
                        if (sexo2.Equals("Mujer"))
                        {
                            int edadniños = 12;
                            Datos dato = new Datos
                            {
                                NOMBRES = nombrehi,
                                EDAD = edadniños,
                                FECHA_DE_NACIMIENTO = fechanacimiento,
                                SEXO = sexo2,
                                PADRE = nombreSoc,
                                PLANTA = nombreplan

                            };
                            navidad.Add(dato);
                            dias = 0;
                        }
                    } //niñas de 12 año

                    gridnavidadniños.DataSource = navidad.OrderBy(s => s.EDAD).ToList();


                    
                };
                if (gridnavidadniños.Rows.Count == 0)
                {

                    MessageBox.Show("No hay niños ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
        }

        /// BOTON BUSCAR NIÑOS NAVIDAD
        /// 
        private void btplanta1_Click(object sender, EventArgs e)
        {
            if (comboniñosporedad.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Campo Para Buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int indice = comboniñosporedad.SelectedIndex;

            if (Convert.ToInt32(indice.ToString()) == 0)
            {
                //MENOS DE 1 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 0 && dias <= 211)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadmenorhombre = 0;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadmenorhombre,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }

                        }


                    };
                    gridnavidadniños.DataSource = navidad.ToList();

                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños menores a 1 año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

            }       //MENOS DE 1 AÑO NIÑOS        
            else if (Convert.ToInt32(indice.ToString()) == 1)
            {
                //MENOS DE 1 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 0 && dias <= 211)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 0;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }

                        }



                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas menores a 1 año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
            }   //MENOS DE 1 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 2)
            {
                //1 AÑO NIÑOS                
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 212 && dias <= 576)
                        {
                            if (sexo2.Equals("Hombre"))
                            {

                                int edadniños = 1;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 1 año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //1 AÑO NIÑOS  
            else if (Convert.ToInt32(indice.ToString()) == 3)
            {
                //1 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 212 && dias <= 576)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 1;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 1 año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //1 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 4)
            {
                //2 AÑO NIÑOS                              
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;


                        if (dias >= 577 && dias <= 941)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 2;

                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 2 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //2 AÑO NIÑOS 
            else if (Convert.ToInt32(indice.ToString()) == 5)
            {
                //2 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 577 && dias <= 941)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 2;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();

                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 2 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }   //2 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 6)
            {
                //3 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;


                        if (dias >= 942 && dias <= 1277)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 3;

                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 3 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //3 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 7)
            {
                //3 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 942 && dias <= 1277)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 3;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();

                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 3 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }   //3 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 8)
            {
                //4 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 1278 && dias <= 1642)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 4;

                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 4 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //4 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 9)
            {
                //4 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 1278 && dias <= 1642)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 4;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 4 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //4 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 10)
            {
                //5 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 1643 && dias <= 2037)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 5;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 5 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //5 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 11)
            {
                //5 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 1643 && dias <= 2037)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 5;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 5 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //5 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 12)
            {
                //6 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 2038 && dias <= 2402)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 6;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 6 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //6 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 13)
            {
                //6 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 2038 && dias <= 2402)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 6;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 6 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //6 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 14)
            {
                //7 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 2403 && dias <= 2768)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 7;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 7 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //7 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 15)
            {
                //7 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 2403 && dias <= 2768)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 7;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };

                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();

                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 7 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }   //7 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 16)
            {
                //8 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 2769 && dias <= 3133)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 8;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 8 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //8 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 17)
            {
                //8 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 2769 && dias <= 3133)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 8;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 8 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //8 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 18)
            {
                //9 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 3134 && dias <= 3498)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 9;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 9 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }    //9 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 19)
            {
                //9 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 3134 && dias <= 3498)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 9;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 9 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //9 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 20)
            {
                //10 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 3499 && dias <= 3863)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 10;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 10 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //10 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 21)
            {
                //10 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 3499 && dias <= 3863)
                        {
                            if (sexo2.Equals("Mujer"))
                            {

                                int edadniños = 10;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 10 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }   //10 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 22)
            {
                //11 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;



                        if (dias >= 3864 && dias <= 4229)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 11;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 11 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //11 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 23)
            {
                //11 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 3864 && dias <= 4229)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 11;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 11 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //11 AÑO NIÑAS
            else if (Convert.ToInt32(indice.ToString()) == 24)
            {
                //12 AÑO NIÑOS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 4230 && dias <= 4595)
                        {
                            if (sexo2.Equals("Hombre"))
                            {
                                int edadniños = 12;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niños de 12 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //12 AÑO NIÑOS
            else if (Convert.ToInt32(indice.ToString()) == 25)
            {
                //12 AÑO NIÑAS
                navidad.Clear();
                using (sindicatoPFEntities context = new sindicatoPFEntities())
                {
                    var xxx = from hh in context.Hijo
                              select new { hh.nacimiento, hh.nombre };

                    gridcargarn.DataSource = xxx.ToList();


                    for (int i = 0; i < gridcargarn.RowCount; i++)
                    {
                        DateTime fechanacimiento = Convert.ToDateTime(gridcargarn.Rows[i].Cells[0].Value);
                        string name = Convert.ToString(gridcargarn.Rows[i].Cells[1].Value);



                        var listaHije = from fech in context.Hijo
                                        where fech.nombre.Equals(name)
                                        select new { fech.rut_socio, fech.nombre, fech.nacimiento, fech.sexo };

                        string rut_soc = listaHije.ToList()[0].rut_socio;
                        string nombrehi = listaHije.ToList()[0].nombre;
                        DateTime nacimientohi = Convert.ToDateTime(listaHije.ToList()[0].nacimiento);
                        string sexo2 = listaHije.ToList()[0].sexo;

                        DateTime fechaactual = DateTime.Now;

                        TimeSpan tSpan = fechaactual - fechanacimiento;

                        dias = tSpan.Days;


                        var listaSoc = from Soc in context.Socio
                                       where Soc.rut_socio.Equals(rut_soc)
                                       select new { Soc.nombre_socio, Soc.id_planta };

                        string nombreSoc = listaSoc.ToList()[0].nombre_socio;
                        int idPlan = Convert.ToInt32(listaSoc.ToList()[0].id_planta);




                        var listaPlan = from Plan in context.Planta
                                        where Plan.id_planta.Equals(idPlan)
                                        select new { Plan.nombre };
                        string nombreplan = listaPlan.ToList()[0].nombre;




                        if (dias >= 4230 && dias <= 4595)
                        {
                            if (sexo2.Equals("Mujer"))
                            {
                                int edadniños = 12;
                                Datos dato = new Datos
                                {
                                    NOMBRES = nombrehi,
                                    EDAD = edadniños,
                                    FECHA_DE_NACIMIENTO = fechanacimiento,
                                    SEXO = sexo2,
                                    PADRE = nombreSoc,
                                    PLANTA = nombreplan

                                };
                                navidad.Add(dato);
                                dias = 0;
                            }
                        }

                    };
                    gridnavidadniños.DataSource = navidad.ToList();
                    if (gridnavidadniños.Rows.Count == 0)
                    {

                        MessageBox.Show("No hay niñas de 12 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }   //12 AÑO NIÑAS

        }

        // FIN BOTON BUSCAR NIÑOS NAVIDAD

        private void gridnavidadniños_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(gridnavidadniños.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        
    }
}
