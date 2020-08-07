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
    public partial class pruebaverfoto : Form
    {
        public pruebaverfoto()
        {
            InitializeComponent();
            
           
        }

        //  static Image CargarImagen(string Nombre)
        //{

        //    sindicatoPFEntities context = new sindicatoPFEntities();
        //    var fot = from fotover in context.Socio
        //              select fotover.imagen;

        //    using (MySqlConnection conn = GetNewConnection())
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            cmd.Connection = conn;
        //            cmd.CommandText = "SELECT Image FROM imagenes WHERE Nombre = @nombre";
        //            cmd.Parameters.AddWithValue("@nombre", Nombre);
        //            byte[] imgArr = (byte[])cmd.ExecuteScalar();
        //            imgArr = (byte[])cmd.ExecuteScalar();
        //            using (var stream = new MemoryStream(imgArr))
        //            {
        //                Image img = Image.FromStream(stream);
        //                return img;
        //            }
        //        }
        //    }
        //}

        private void fotosocioprueba_Click(object sender, EventArgs e)
        {
            //sindicatoPFEntities context = new sindicatoPFEntities();
            //var fot = from fotover in context.Socio
            //          select fotover.imagen;




            //fotosocioprueba.Image = fot;
        }
    }
}
