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

                lbsocioplantaencontrado.Text = "Socios Planta 1 encontrados!";
                gridverplantas.DataSource = sociosplanta1.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta 2 encontrados!";
                gridverplantas.DataSource = sociosplanta2.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta 3 encontrados!";
                gridverplantas.DataSource = sociosplanta3.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta 4 encontrados!";
                gridverplantas.DataSource = sociosplanta4.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta CDT encontrados!";
                gridverplantas.DataSource = sociosplantacdt.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta Pizza encontrados!";
                gridverplantas.DataSource = sociosplantapizza.ToList();


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

                lbsocioplantaencontrado.Text = "Socios Planta Carnico encontrados!";
                gridverplantas.DataSource = sociosplantacarnico.ToList();


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

                lbsocioplantaencontrado.Text = "Todos los socios encontrados!";
                gridverplantas.DataSource = allsociosplanta.ToList();


            }
        }
    }
}
