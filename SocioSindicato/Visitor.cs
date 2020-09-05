using FontAwesome.Sharp;
using SocioSindicato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocioSindicato
{
    public partial class Visitor : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form newForm;

        public Visitor()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            menupanel.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 126, 241);
        }

        private void activate_Button(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disable_Button();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icono panel y label titulo
                icono_actual.IconChar = currentBtn.IconChar;
                icono_actual.IconColor = color;

            }
        }
        private void disable_Button()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 bs = new Form1();
            this.Hide();
            MessageBox.Show("Cuenta cerrada!");
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

        public void Agrega_soc(Form childForm)
        {
            if (newForm != null)
            {
                newForm.Close();
            }
            newForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbtitulo.Text = childForm.Text;

        }
       

		private void btBuscarSoc_Click_1(object sender, EventArgs e)
		{
            activate_Button(sender, RGBColors.color2);
            Agrega_soc(new ViewsAdministrador.BuscarSocio());
        }

		private void sing_out_Click(object sender, EventArgs e)
		{
            Form1 bs = new Form1();
            this.Hide();
            MessageBox.Show("Cuenta cerrada!");
            bs.ShowDialog();
            this.Close();
        }

		private void maximizar_Click(object sender, EventArgs e)
		{
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
            System.Windows.Forms.Application.Exit();
        }

		private void btPlantas_Click(object sender, EventArgs e)
		{
            activate_Button(sender, RGBColors.color5);
            Agrega_soc(new ViewsAdministrador.Plantas());
        }

		private void btListadoNavi_Click(object sender, EventArgs e)
		{
            activate_Button(sender, RGBColors.color6);
            Agrega_soc(new ViewsAdministrador.ListadoNavidad());
        }

		private void btEliminados_Click(object sender, EventArgs e)
		{
            activate_Button(sender, RGBColors.color7);
            using (sindicatoPFEntities context = new sindicatoPFEntities())
            {


                var listEliminados = from soceli in context.socioEliminado
                                     select new
                                     {
                                         RUT = soceli.rut,
                                         NOMBRE = soceli.nombre,
                                         CATEGORIA = soceli.categoria,
                                         INGRESO = soceli.fechaIngreso,
                                         PLANTA = soceli.planta,
                                     };

                gridvereliminadosvisitor.DataSource = listEliminados.ToList();

                if (gridvereliminadosvisitor.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Socios Eliminados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    exportardatos(gridvereliminadosvisitor);
                }


            }
        }

		private void btnInicio_Click(object sender, EventArgs e)
		{
            if (newForm == null)
            {

                icono_actual.IconChar = IconChar.Home;
                lbtitulo.Text = "Inicio";
            }
            else
            {
                newForm.Close();
                Reset();
                icono_actual.IconChar = IconChar.Home;
                lbtitulo.Text = "Inicio";
            }
        }
        public void Reset()
        {
            disable_Button();
            leftBorderBtn.Visible = false;
            icono_actual.IconChar = currentBtn.IconChar;
            icono_actual.IconColor = Color.MediumPurple;
        }
        //mueve el panel por el escritorio
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titulo_panel_MouseMove(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
            WindowState = FormWindowState.Minimized;
        }
	}
}
