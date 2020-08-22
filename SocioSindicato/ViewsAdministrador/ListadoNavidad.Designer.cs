namespace SocioSindicato.ViewsAdministrador
{
    partial class ListadoNavidad
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
            this.btnvolvernavidad = new System.Windows.Forms.Button();
            this.comboniñosporedad = new System.Windows.Forms.ComboBox();
            this.gridnavidadniños = new System.Windows.Forms.DataGridView();
            this.btnbuscarniñosnavidad = new System.Windows.Forms.Button();
            this.btndescargarexcel = new System.Windows.Forms.Button();
            this.lbprueba = new System.Windows.Forms.Label();
            this.gridcargarn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcargarn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolvernavidad
            // 
            this.btnvolvernavidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnvolvernavidad.FlatAppearance.BorderSize = 0;
            this.btnvolvernavidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolvernavidad.ForeColor = System.Drawing.Color.White;
            this.btnvolvernavidad.Location = new System.Drawing.Point(942, 677);
            this.btnvolvernavidad.Name = "btnvolvernavidad";
            this.btnvolvernavidad.Size = new System.Drawing.Size(142, 36);
            this.btnvolvernavidad.TabIndex = 0;
            this.btnvolvernavidad.Text = "Volver";
            this.btnvolvernavidad.UseVisualStyleBackColor = false;
            this.btnvolvernavidad.Click += new System.EventHandler(this.btnvolvernavidad_Click);
            // 
            // comboniñosporedad
            // 
            this.comboniñosporedad.FormattingEnabled = true;
            this.comboniñosporedad.Items.AddRange(new object[] {
            "Niños Menores De 1 Año",
            "Niñas Menores De 1 Año",
            "Niños De 1 Año",
            "Niñas De 1 Año",
            "Niños De 2 Años",
            "Niñas De 2 Años",
            "Niños De 3 Años",
            "Niñas De 3 Años",
            "Niños De 4 Años",
            "Niñas De 4 Años",
            "Niños De 5 Años",
            "Niñas De 5 Años",
            "Niños De 6 Años",
            "Niñas De 6 Años",
            "Niños De 7 Años",
            "Niñas De 7 Años",
            "Niños De 8 Años",
            "Niñas De 8 Años",
            "Niños De 9 Años",
            "Niñas De 9 Años",
            "Niños De 10 Años",
            "Niñas De 10 Años",
            "Niños De 11 Años",
            "Niñas De 11 Años",
            "Niños De 12 Años",
            "Niñas De 12 Años"});
            this.comboniñosporedad.Location = new System.Drawing.Point(107, 53);
            this.comboniñosporedad.Name = "comboniñosporedad";
            this.comboniñosporedad.Size = new System.Drawing.Size(803, 21);
            this.comboniñosporedad.TabIndex = 1;
            // 
            // gridnavidadniños
            // 
            this.gridnavidadniños.AllowUserToOrderColumns = true;
            this.gridnavidadniños.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridnavidadniños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnavidadniños.Location = new System.Drawing.Point(107, 104);
            this.gridnavidadniños.Name = "gridnavidadniños";
            this.gridnavidadniños.Size = new System.Drawing.Size(977, 478);
            this.gridnavidadniños.TabIndex = 2;
            this.gridnavidadniños.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridnavidadniños_RowPostPaint);
            // 
            // btnbuscarniñosnavidad
            // 
            this.btnbuscarniñosnavidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnbuscarniñosnavidad.FlatAppearance.BorderSize = 0;
            this.btnbuscarniñosnavidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarniñosnavidad.ForeColor = System.Drawing.Color.White;
            this.btnbuscarniñosnavidad.Location = new System.Drawing.Point(942, 47);
            this.btnbuscarniñosnavidad.Name = "btnbuscarniñosnavidad";
            this.btnbuscarniñosnavidad.Size = new System.Drawing.Size(142, 31);
            this.btnbuscarniñosnavidad.TabIndex = 3;
            this.btnbuscarniñosnavidad.Text = "Buscar";
            this.btnbuscarniñosnavidad.UseVisualStyleBackColor = false;
            this.btnbuscarniñosnavidad.Click += new System.EventHandler(this.btnbuscarniñosnavidad_Click);
            // 
            // btndescargarexcel
            // 
            this.btndescargarexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btndescargarexcel.FlatAppearance.BorderSize = 0;
            this.btndescargarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargarexcel.ForeColor = System.Drawing.Color.White;
            this.btndescargarexcel.Location = new System.Drawing.Point(107, 677);
            this.btndescargarexcel.Name = "btndescargarexcel";
            this.btndescargarexcel.Size = new System.Drawing.Size(126, 36);
            this.btndescargarexcel.TabIndex = 4;
            this.btndescargarexcel.Text = "Descargar";
            this.btndescargarexcel.UseVisualStyleBackColor = false;
            this.btndescargarexcel.Click += new System.EventHandler(this.btndescargarexcel_Click);
            // 
            // lbprueba
            // 
            this.lbprueba.AutoSize = true;
            this.lbprueba.Location = new System.Drawing.Point(378, 358);
            this.lbprueba.Name = "lbprueba";
            this.lbprueba.Size = new System.Drawing.Size(0, 13);
            this.lbprueba.TabIndex = 5;
            // 
            // gridcargarn
            // 
            this.gridcargarn.AllowUserToOrderColumns = true;
            this.gridcargarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcargarn.Location = new System.Drawing.Point(107, 607);
            this.gridcargarn.Name = "gridcargarn";
            this.gridcargarn.Size = new System.Drawing.Size(977, 43);
            this.gridcargarn.TabIndex = 6;
            this.gridcargarn.Visible = false;
            // 
            // ListadoNavidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1143, 745);
            this.Controls.Add(this.gridcargarn);
            this.Controls.Add(this.lbprueba);
            this.Controls.Add(this.btndescargarexcel);
            this.Controls.Add(this.btnbuscarniñosnavidad);
            this.Controls.Add(this.gridnavidadniños);
            this.Controls.Add(this.comboniñosporedad);
            this.Controls.Add(this.btnvolvernavidad);
            this.Name = "ListadoNavidad";
            this.Text = "ListadoNavidad";
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcargarn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolvernavidad;
        private System.Windows.Forms.ComboBox comboniñosporedad;
        private System.Windows.Forms.DataGridView gridnavidadniños;
        private System.Windows.Forms.Button btnbuscarniñosnavidad;
        private System.Windows.Forms.Button btndescargarexcel;
        private System.Windows.Forms.Label lbprueba;
        private System.Windows.Forms.DataGridView gridcargarn;
    }
}