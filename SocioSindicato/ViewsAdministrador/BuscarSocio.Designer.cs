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
            ((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenbuscarsociomostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConyuge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbtodo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(409, 63);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(107, 23);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar Socio";
            this.btnbuscar.UseVisualStyleBackColor = true;
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
            this.gridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbuscar.Location = new System.Drawing.Point(44, 153);
            this.gridbuscar.Name = "gridbuscar";
            this.gridbuscar.Size = new System.Drawing.Size(575, 175);
            this.gridbuscar.TabIndex = 3;
            this.gridbuscar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridbuscar_RowPostPaint);
            // 
            // btnvolverbuscar
            // 
            this.btnvolverbuscar.Location = new System.Drawing.Point(821, 560);
            this.btnvolverbuscar.Name = "btnvolverbuscar";
            this.btnvolverbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnvolverbuscar.TabIndex = 4;
            this.btnvolverbuscar.Text = "Volver";
            this.btnvolverbuscar.UseVisualStyleBackColor = true;
            this.btnvolverbuscar.Click += new System.EventHandler(this.btnvolverbuscar_Click);
            // 
            // imagenbuscarsociomostrar
            // 
            this.imagenbuscarsociomostrar.Location = new System.Drawing.Point(681, 153);
            this.imagenbuscarsociomostrar.Name = "imagenbuscarsociomostrar";
            this.imagenbuscarsociomostrar.Size = new System.Drawing.Size(173, 189);
            this.imagenbuscarsociomostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenbuscarsociomostrar.TabIndex = 5;
            this.imagenbuscarsociomostrar.TabStop = false;
            this.imagenbuscarsociomostrar.Click += new System.EventHandler(this.imagenbuscarsociomostrar_Click);
            // 
            // btnddexcel
            // 
            this.btnddexcel.Location = new System.Drawing.Point(44, 560);
            this.btnddexcel.Name = "btnddexcel";
            this.btnddexcel.Size = new System.Drawing.Size(164, 23);
            this.btnddexcel.TabIndex = 6;
            this.btnddexcel.Text = "Descargar Socios Con Cargas";
            this.btnddexcel.UseVisualStyleBackColor = true;
            this.btnddexcel.Click += new System.EventHandler(this.btnddexcel_Click);
            // 
            // btcargas
            // 
            this.btcargas.Location = new System.Drawing.Point(444, 560);
            this.btcargas.Name = "btcargas";
            this.btcargas.Size = new System.Drawing.Size(75, 23);
            this.btcargas.TabIndex = 7;
            this.btcargas.Text = "Cargas";
            this.btcargas.UseVisualStyleBackColor = true;
            this.btcargas.Click += new System.EventHandler(this.btcargas_Click);
            // 
            // gridConyuge
            // 
            this.gridConyuge.AllowUserToOrderColumns = true;
            this.gridConyuge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConyuge.Location = new System.Drawing.Point(44, 334);
            this.gridConyuge.Name = "gridConyuge";
            this.gridConyuge.Size = new System.Drawing.Size(575, 77);
            this.gridConyuge.TabIndex = 8;
            this.gridConyuge.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridConyuge_RowPostPaint);
            // 
            // gridHijo
            // 
            this.gridHijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHijo.Location = new System.Drawing.Point(44, 417);
            this.gridHijo.Name = "gridHijo";
            this.gridHijo.Size = new System.Drawing.Size(575, 81);
            this.gridHijo.TabIndex = 9;
            this.gridHijo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridHijo_RowPostPaint);
            // 
            // btconyuge
            // 
            this.btconyuge.Location = new System.Drawing.Point(354, 560);
            this.btconyuge.Name = "btconyuge";
            this.btconyuge.Size = new System.Drawing.Size(75, 23);
            this.btconyuge.TabIndex = 10;
            this.btconyuge.Text = "Conyuge";
            this.btconyuge.UseVisualStyleBackColor = true;
            this.btconyuge.Click += new System.EventHandler(this.btconyuge_Click);
            // 
            // gbtodo
            // 
            this.gbtodo.AllowUserToOrderColumns = true;
            this.gbtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbtodo.Location = new System.Drawing.Point(44, 120);
            this.gbtodo.Name = "gbtodo";
            this.gbtodo.Size = new System.Drawing.Size(575, 27);
            this.gbtodo.TabIndex = 11;
            this.gbtodo.Visible = false;
            // 
            // btnexcelsocio
            // 
            this.btnexcelsocio.Location = new System.Drawing.Point(224, 560);
            this.btnexcelsocio.Name = "btnexcelsocio";
            this.btnexcelsocio.Size = new System.Drawing.Size(110, 23);
            this.btnexcelsocio.TabIndex = 12;
            this.btnexcelsocio.Text = "Descargar Socio";
            this.btnexcelsocio.UseVisualStyleBackColor = true;
            this.btnexcelsocio.Click += new System.EventHandler(this.btnexcelsocio_Click);
            // 
            // BuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 618);
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
    }
}