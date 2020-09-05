namespace SocioSindicato
{
    partial class Visitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel_desktop = new System.Windows.Forms.Panel();
			this.titulo_panel = new System.Windows.Forms.Panel();
			this.sing_out = new FontAwesome.Sharp.IconButton();
			this.maximizar = new FontAwesome.Sharp.IconPictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.lbtitulo = new System.Windows.Forms.Label();
			this.icono_actual = new FontAwesome.Sharp.IconPictureBox();
			this.menupanel = new System.Windows.Forms.Panel();
			this.btEliminados = new FontAwesome.Sharp.IconButton();
			this.btListadoNavi = new FontAwesome.Sharp.IconButton();
			this.gridvereliminadosvisitor = new System.Windows.Forms.DataGridView();
			this.btPlantas = new FontAwesome.Sharp.IconButton();
			this.btBuscarSoc = new FontAwesome.Sharp.IconButton();
			this.panel_icono = new System.Windows.Forms.Panel();
			this.btnInicio = new System.Windows.Forms.PictureBox();
			this.panel_desktop.SuspendLayout();
			this.titulo_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icono_actual)).BeginInit();
			this.menupanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridvereliminadosvisitor)).BeginInit();
			this.panel_icono.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_desktop
			// 
			this.panel_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.panel_desktop.Controls.Add(this.titulo_panel);
			this.panel_desktop.Controls.Add(this.menupanel);
			this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_desktop.Location = new System.Drawing.Point(0, 0);
			this.panel_desktop.Name = "panel_desktop";
			this.panel_desktop.Size = new System.Drawing.Size(1535, 889);
			this.panel_desktop.TabIndex = 15;
			// 
			// titulo_panel
			// 
			this.titulo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.titulo_panel.Controls.Add(this.sing_out);
			this.titulo_panel.Controls.Add(this.maximizar);
			this.titulo_panel.Controls.Add(this.btnMinimizar);
			this.titulo_panel.Controls.Add(this.btnClose);
			this.titulo_panel.Controls.Add(this.lbtitulo);
			this.titulo_panel.Controls.Add(this.icono_actual);
			this.titulo_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titulo_panel.Location = new System.Drawing.Point(220, 0);
			this.titulo_panel.Name = "titulo_panel";
			this.titulo_panel.Size = new System.Drawing.Size(1315, 84);
			this.titulo_panel.TabIndex = 12;
			this.titulo_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_panel_MouseMove);
			// 
			// sing_out
			// 
			this.sing_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sing_out.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.sing_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sing_out.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.sing_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sing_out.ForeColor = System.Drawing.Color.Gainsboro;
			this.sing_out.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
			this.sing_out.IconColor = System.Drawing.Color.WhiteSmoke;
			this.sing_out.IconSize = 32;
			this.sing_out.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.sing_out.Location = new System.Drawing.Point(972, 12);
			this.sing_out.Name = "sing_out";
			this.sing_out.Rotation = 0D;
			this.sing_out.Size = new System.Drawing.Size(190, 52);
			this.sing_out.TabIndex = 7;
			this.sing_out.Text = "Cerrar Sesion";
			this.sing_out.UseVisualStyleBackColor = true;
			this.sing_out.Click += new System.EventHandler(this.sing_out_Click);
			// 
			// maximizar
			// 
			this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.maximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.maximizar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
			this.maximizar.IconSize = 19;
			this.maximizar.Location = new System.Drawing.Point(1234, 29);
			this.maximizar.Name = "maximizar";
			this.maximizar.Size = new System.Drawing.Size(21, 19);
			this.maximizar.TabIndex = 6;
			this.maximizar.TabStop = false;
			this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizar.Image = global::SocioSindicato.Properties.Resources.Minimize_Icon;
			this.btnMinimizar.Location = new System.Drawing.Point(1196, 29);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnMinimizar.TabIndex = 3;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Image = global::SocioSindicato.Properties.Resources.Close_Icon1;
			this.btnClose.Location = new System.Drawing.Point(1277, 29);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(16, 16);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnClose.TabIndex = 2;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lbtitulo
			// 
			this.lbtitulo.AutoSize = true;
			this.lbtitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtitulo.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbtitulo.Location = new System.Drawing.Point(52, 29);
			this.lbtitulo.Name = "lbtitulo";
			this.lbtitulo.Size = new System.Drawing.Size(51, 21);
			this.lbtitulo.TabIndex = 1;
			this.lbtitulo.Text = "Inicio";
			// 
			// icono_actual
			// 
			this.icono_actual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.icono_actual.ForeColor = System.Drawing.Color.MediumPurple;
			this.icono_actual.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.icono_actual.IconColor = System.Drawing.Color.MediumPurple;
			this.icono_actual.Location = new System.Drawing.Point(14, 23);
			this.icono_actual.Name = "icono_actual";
			this.icono_actual.Size = new System.Drawing.Size(32, 32);
			this.icono_actual.TabIndex = 0;
			this.icono_actual.TabStop = false;
			// 
			// menupanel
			// 
			this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.menupanel.Controls.Add(this.btEliminados);
			this.menupanel.Controls.Add(this.btListadoNavi);
			this.menupanel.Controls.Add(this.gridvereliminadosvisitor);
			this.menupanel.Controls.Add(this.btPlantas);
			this.menupanel.Controls.Add(this.btBuscarSoc);
			this.menupanel.Controls.Add(this.panel_icono);
			this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menupanel.Location = new System.Drawing.Point(0, 0);
			this.menupanel.Name = "menupanel";
			this.menupanel.Size = new System.Drawing.Size(220, 889);
			this.menupanel.TabIndex = 11;
			// 
			// btEliminados
			// 
			this.btEliminados.Dock = System.Windows.Forms.DockStyle.Top;
			this.btEliminados.FlatAppearance.BorderSize = 0;
			this.btEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEliminados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btEliminados.ForeColor = System.Drawing.Color.Gainsboro;
			this.btEliminados.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btEliminados.IconColor = System.Drawing.Color.Gainsboro;
			this.btEliminados.IconSize = 32;
			this.btEliminados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btEliminados.Location = new System.Drawing.Point(0, 344);
			this.btEliminados.Name = "btEliminados";
			this.btEliminados.Rotation = 0D;
			this.btEliminados.Size = new System.Drawing.Size(220, 52);
			this.btEliminados.TabIndex = 20;
			this.btEliminados.Text = "Eliminados";
			this.btEliminados.UseVisualStyleBackColor = true;
			this.btEliminados.Click += new System.EventHandler(this.btEliminados_Click);
			// 
			// btListadoNavi
			// 
			this.btListadoNavi.Dock = System.Windows.Forms.DockStyle.Top;
			this.btListadoNavi.FlatAppearance.BorderSize = 0;
			this.btListadoNavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btListadoNavi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btListadoNavi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btListadoNavi.ForeColor = System.Drawing.Color.Gainsboro;
			this.btListadoNavi.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
			this.btListadoNavi.IconColor = System.Drawing.Color.Gainsboro;
			this.btListadoNavi.IconSize = 32;
			this.btListadoNavi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btListadoNavi.Location = new System.Drawing.Point(0, 292);
			this.btListadoNavi.Name = "btListadoNavi";
			this.btListadoNavi.Rotation = 0D;
			this.btListadoNavi.Size = new System.Drawing.Size(220, 52);
			this.btListadoNavi.TabIndex = 19;
			this.btListadoNavi.Text = "Listado Navidad";
			this.btListadoNavi.UseVisualStyleBackColor = true;
			this.btListadoNavi.Click += new System.EventHandler(this.btListadoNavi_Click);
			// 
			// gridvereliminadosvisitor
			// 
			this.gridvereliminadosvisitor.AllowUserToOrderColumns = true;
			this.gridvereliminadosvisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridvereliminadosvisitor.Location = new System.Drawing.Point(0, 825);
			this.gridvereliminadosvisitor.Name = "gridvereliminadosvisitor";
			this.gridvereliminadosvisitor.Size = new System.Drawing.Size(220, 61);
			this.gridvereliminadosvisitor.TabIndex = 8;
			this.gridvereliminadosvisitor.Visible = false;
			// 
			// btPlantas
			// 
			this.btPlantas.Dock = System.Windows.Forms.DockStyle.Top;
			this.btPlantas.FlatAppearance.BorderSize = 0;
			this.btPlantas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlantas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btPlantas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlantas.ForeColor = System.Drawing.Color.Gainsboro;
			this.btPlantas.IconChar = FontAwesome.Sharp.IconChar.Building;
			this.btPlantas.IconColor = System.Drawing.Color.Gainsboro;
			this.btPlantas.IconSize = 32;
			this.btPlantas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPlantas.Location = new System.Drawing.Point(0, 240);
			this.btPlantas.Name = "btPlantas";
			this.btPlantas.Rotation = 0D;
			this.btPlantas.Size = new System.Drawing.Size(220, 52);
			this.btPlantas.TabIndex = 18;
			this.btPlantas.Text = "Plantas";
			this.btPlantas.UseVisualStyleBackColor = true;
			this.btPlantas.Click += new System.EventHandler(this.btPlantas_Click);
			// 
			// btBuscarSoc
			// 
			this.btBuscarSoc.Dock = System.Windows.Forms.DockStyle.Top;
			this.btBuscarSoc.FlatAppearance.BorderSize = 0;
			this.btBuscarSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBuscarSoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btBuscarSoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscarSoc.ForeColor = System.Drawing.Color.Gainsboro;
			this.btBuscarSoc.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btBuscarSoc.IconColor = System.Drawing.Color.Gainsboro;
			this.btBuscarSoc.IconSize = 32;
			this.btBuscarSoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btBuscarSoc.Location = new System.Drawing.Point(0, 188);
			this.btBuscarSoc.Name = "btBuscarSoc";
			this.btBuscarSoc.Rotation = 0D;
			this.btBuscarSoc.Size = new System.Drawing.Size(220, 52);
			this.btBuscarSoc.TabIndex = 15;
			this.btBuscarSoc.Text = "Buscar Socio";
			this.btBuscarSoc.UseVisualStyleBackColor = true;
			this.btBuscarSoc.Click += new System.EventHandler(this.btBuscarSoc_Click_1);
			// 
			// panel_icono
			// 
			this.panel_icono.Controls.Add(this.btnInicio);
			this.panel_icono.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_icono.Location = new System.Drawing.Point(0, 0);
			this.panel_icono.Name = "panel_icono";
			this.panel_icono.Size = new System.Drawing.Size(220, 188);
			this.panel_icono.TabIndex = 0;
			// 
			// btnInicio
			// 
			this.btnInicio.Image = global::SocioSindicato.Properties.Resources._56726595_608012969610677_8790191896057085952_n;
			this.btnInicio.Location = new System.Drawing.Point(30, 12);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(156, 150);
			this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnInicio.TabIndex = 0;
			this.btnInicio.TabStop = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// Visitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1535, 889);
			this.Controls.Add(this.panel_desktop);
			this.Name = "Visitor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visitor";
			this.panel_desktop.ResumeLayout(false);
			this.titulo_panel.ResumeLayout(false);
			this.titulo_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icono_actual)).EndInit();
			this.menupanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridvereliminadosvisitor)).EndInit();
			this.panel_icono.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel_desktop;
		private System.Windows.Forms.Panel menupanel;
		private FontAwesome.Sharp.IconButton btEliminados;
		private FontAwesome.Sharp.IconButton btListadoNavi;
		private System.Windows.Forms.DataGridView gridvereliminadosvisitor;
		private FontAwesome.Sharp.IconButton btPlantas;
		private FontAwesome.Sharp.IconButton btBuscarSoc;
		private System.Windows.Forms.Panel panel_icono;
		private System.Windows.Forms.PictureBox btnInicio;
		private System.Windows.Forms.Panel titulo_panel;
		private FontAwesome.Sharp.IconButton sing_out;
		private FontAwesome.Sharp.IconPictureBox maximizar;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.PictureBox btnClose;
		private System.Windows.Forms.Label lbtitulo;
		private FontAwesome.Sharp.IconPictureBox icono_actual;
	}
}