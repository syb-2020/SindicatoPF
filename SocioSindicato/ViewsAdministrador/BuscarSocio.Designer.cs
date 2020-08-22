namespace SocioSindicato.ViewsAdministrador
{
    partial class BuscarSocio
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
			this.btnbuscar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lbbuscarsocio = new System.Windows.Forms.Label();
			this.gridbuscar = new System.Windows.Forms.DataGridView();
			this.btnvolverbuscar = new System.Windows.Forms.Button();
			this.imagenbuscarsociomostrar = new System.Windows.Forms.PictureBox();
			this.btnddexcel = new System.Windows.Forms.Button();
			this.btcargas = new System.Windows.Forms.Button();
			this.gridConyuge = new System.Windows.Forms.DataGridView();
			this.gridHijo = new System.Windows.Forms.DataGridView();
			this.btconyuge = new System.Windows.Forms.Button();
			this.gbtodo = new System.Windows.Forms.DataGridView();
			this.btnexcelsocio = new System.Windows.Forms.Button();
			this.btnexcelsocioconyuge = new System.Windows.Forms.Button();
			this.btnexcelsociohijo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagenbuscarsociomostrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridConyuge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridHijo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbtodo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnbuscar
			// 
			this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnbuscar.FlatAppearance.BorderSize = 0;
			this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscar.ForeColor = System.Drawing.Color.White;
			this.btnbuscar.Location = new System.Drawing.Point(359, 63);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(107, 23);
			this.btnbuscar.TabIndex = 0;
			this.btnbuscar.Text = "Buscar Socio";
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(44, 63);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(275, 20);
			this.txtbuscar.TabIndex = 1;
			// 
			// lbbuscarsocio
			// 
			this.lbbuscarsocio.AutoSize = true;
			this.lbbuscarsocio.Location = new System.Drawing.Point(601, 63);
			this.lbbuscarsocio.Name = "lbbuscarsocio";
			this.lbbuscarsocio.Size = new System.Drawing.Size(0, 13);
			this.lbbuscarsocio.TabIndex = 2;
			// 
			// gridbuscar
			// 
			this.gridbuscar.AllowUserToOrderColumns = true;
			this.gridbuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridbuscar.Location = new System.Drawing.Point(44, 193);
			this.gridbuscar.Name = "gridbuscar";
			this.gridbuscar.Size = new System.Drawing.Size(575, 61);
			this.gridbuscar.TabIndex = 3;
			this.gridbuscar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridbuscar_RowPostPaint);
			// 
			// btnvolverbuscar
			// 
			this.btnvolverbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnvolverbuscar.FlatAppearance.BorderSize = 0;
			this.btnvolverbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnvolverbuscar.ForeColor = System.Drawing.Color.White;
			this.btnvolverbuscar.Location = new System.Drawing.Point(821, 560);
			this.btnvolverbuscar.Name = "btnvolverbuscar";
			this.btnvolverbuscar.Size = new System.Drawing.Size(75, 23);
			this.btnvolverbuscar.TabIndex = 4;
			this.btnvolverbuscar.Text = "Volver";
			this.btnvolverbuscar.UseVisualStyleBackColor = false;
			this.btnvolverbuscar.Click += new System.EventHandler(this.btnvolverbuscar_Click);
			// 
			// imagenbuscarsociomostrar
			// 
			this.imagenbuscarsociomostrar.Location = new System.Drawing.Point(668, 120);
			this.imagenbuscarsociomostrar.Name = "imagenbuscarsociomostrar";
			this.imagenbuscarsociomostrar.Size = new System.Drawing.Size(173, 189);
			this.imagenbuscarsociomostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagenbuscarsociomostrar.TabIndex = 5;
			this.imagenbuscarsociomostrar.TabStop = false;
			this.imagenbuscarsociomostrar.Click += new System.EventHandler(this.imagenbuscarsociomostrar_Click);
			// 
			// btnddexcel
			// 
			this.btnddexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnddexcel.FlatAppearance.BorderSize = 0;
			this.btnddexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnddexcel.ForeColor = System.Drawing.Color.White;
			this.btnddexcel.Location = new System.Drawing.Point(468, 560);
			this.btnddexcel.Name = "btnddexcel";
			this.btnddexcel.Size = new System.Drawing.Size(193, 23);
			this.btnddexcel.TabIndex = 6;
			this.btnddexcel.Text = "Descargar Socios - Conyuge - Hijos";
			this.btnddexcel.UseVisualStyleBackColor = false;
			this.btnddexcel.Click += new System.EventHandler(this.btnddexcel_Click);
			// 
			// btcargas
			// 
			this.btcargas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btcargas.FlatAppearance.BorderSize = 0;
			this.btcargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btcargas.ForeColor = System.Drawing.Color.White;
			this.btcargas.Location = new System.Drawing.Point(181, 120);
			this.btcargas.Name = "btcargas";
			this.btcargas.Size = new System.Drawing.Size(123, 23);
			this.btcargas.TabIndex = 7;
			this.btcargas.Text = "Buscar Hijos";
			this.btcargas.UseVisualStyleBackColor = false;
			this.btcargas.Click += new System.EventHandler(this.btcargas_Click);
			// 
			// gridConyuge
			// 
			this.gridConyuge.AllowUserToOrderColumns = true;
			this.gridConyuge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridConyuge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridConyuge.Location = new System.Drawing.Point(44, 269);
			this.gridConyuge.Name = "gridConyuge";
			this.gridConyuge.Size = new System.Drawing.Size(575, 56);
			this.gridConyuge.TabIndex = 8;
			this.gridConyuge.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridConyuge_RowPostPaint);
			// 
			// gridHijo
			// 
			this.gridHijo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridHijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridHijo.Location = new System.Drawing.Point(44, 345);
			this.gridHijo.Name = "gridHijo";
			this.gridHijo.Size = new System.Drawing.Size(575, 145);
			this.gridHijo.TabIndex = 9;
			this.gridHijo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridHijo_RowPostPaint);
			// 
			// btconyuge
			// 
			this.btconyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btconyuge.FlatAppearance.BorderSize = 0;
			this.btconyuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btconyuge.ForeColor = System.Drawing.Color.White;
			this.btconyuge.Location = new System.Drawing.Point(44, 120);
			this.btconyuge.Name = "btconyuge";
			this.btconyuge.Size = new System.Drawing.Size(111, 23);
			this.btconyuge.TabIndex = 10;
			this.btconyuge.Text = "Buscar Conyuge";
			this.btconyuge.UseVisualStyleBackColor = false;
			this.btconyuge.Click += new System.EventHandler(this.btconyuge_Click);
			// 
			// gbtodo
			// 
			this.gbtodo.AllowUserToOrderColumns = true;
			this.gbtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gbtodo.Location = new System.Drawing.Point(44, 160);
			this.gbtodo.Name = "gbtodo";
			this.gbtodo.Size = new System.Drawing.Size(575, 27);
			this.gbtodo.TabIndex = 11;
			this.gbtodo.Visible = false;
			// 
			// btnexcelsocio
			// 
			this.btnexcelsocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnexcelsocio.FlatAppearance.BorderSize = 0;
			this.btnexcelsocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnexcelsocio.ForeColor = System.Drawing.Color.White;
			this.btnexcelsocio.Location = new System.Drawing.Point(44, 560);
			this.btnexcelsocio.Name = "btnexcelsocio";
			this.btnexcelsocio.Size = new System.Drawing.Size(110, 23);
			this.btnexcelsocio.TabIndex = 12;
			this.btnexcelsocio.Text = "Descargar Socio";
			this.btnexcelsocio.UseVisualStyleBackColor = false;
			this.btnexcelsocio.Click += new System.EventHandler(this.btnexcelsocio_Click);
			// 
			// btnexcelsocioconyuge
			// 
			this.btnexcelsocioconyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnexcelsocioconyuge.FlatAppearance.BorderSize = 0;
			this.btnexcelsocioconyuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnexcelsocioconyuge.ForeColor = System.Drawing.Color.White;
			this.btnexcelsocioconyuge.Location = new System.Drawing.Point(160, 560);
			this.btnexcelsocioconyuge.Name = "btnexcelsocioconyuge";
			this.btnexcelsocioconyuge.Size = new System.Drawing.Size(159, 23);
			this.btnexcelsocioconyuge.TabIndex = 13;
			this.btnexcelsocioconyuge.Text = "Descargar Socio - Conyuge";
			this.btnexcelsocioconyuge.UseVisualStyleBackColor = false;
			this.btnexcelsocioconyuge.Click += new System.EventHandler(this.btnexcelsocioconyuge_Click);
			// 
			// btnexcelsociohijo
			// 
			this.btnexcelsociohijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnexcelsociohijo.FlatAppearance.BorderSize = 0;
			this.btnexcelsociohijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnexcelsociohijo.ForeColor = System.Drawing.Color.White;
			this.btnexcelsociohijo.Location = new System.Drawing.Point(334, 560);
			this.btnexcelsociohijo.Name = "btnexcelsociohijo";
			this.btnexcelsociohijo.Size = new System.Drawing.Size(128, 23);
			this.btnexcelsociohijo.TabIndex = 14;
			this.btnexcelsociohijo.Text = "Descargar Socio - Hijo";
			this.btnexcelsociohijo.UseVisualStyleBackColor = false;
			this.btnexcelsociohijo.Click += new System.EventHandler(this.btnexcelsociohijo_Click);
			// 
			// BuscarSocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(922, 618);
			this.Controls.Add(this.btnexcelsociohijo);
			this.Controls.Add(this.btnexcelsocioconyuge);
			this.Controls.Add(this.btnexcelsocio);
			this.Controls.Add(this.gbtodo);
			this.Controls.Add(this.btconyuge);
			this.Controls.Add(this.gridHijo);
			this.Controls.Add(this.gridConyuge);
			this.Controls.Add(this.btcargas);
			this.Controls.Add(this.btnddexcel);
			this.Controls.Add(this.imagenbuscarsociomostrar);
			this.Controls.Add(this.btnvolverbuscar);
			this.Controls.Add(this.gridbuscar);
			this.Controls.Add(this.lbbuscarsocio);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.btnbuscar);
			this.Name = "BuscarSocio";
			this.Text = "BuscarSocio";
			((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagenbuscarsociomostrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridConyuge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridHijo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbtodo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbbuscarsocio;
        private System.Windows.Forms.DataGridView gridbuscar;
        private System.Windows.Forms.Button btnvolverbuscar;
        private System.Windows.Forms.PictureBox imagenbuscarsociomostrar;
        private System.Windows.Forms.Button btnddexcel;
        private System.Windows.Forms.Button btcargas;
        private System.Windows.Forms.DataGridView gridConyuge;
        private System.Windows.Forms.DataGridView gridHijo;
        private System.Windows.Forms.Button btconyuge;
        private System.Windows.Forms.DataGridView gbtodo;
        private System.Windows.Forms.Button btnexcelsocio;
        private System.Windows.Forms.Button btnexcelsocioconyuge;
        private System.Windows.Forms.Button btnexcelsociohijo;
    }
}