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
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolvernavidad
            // 
            this.btnvolvernavidad.Location = new System.Drawing.Point(690, 401);
            this.btnvolvernavidad.Name = "btnvolvernavidad";
            this.btnvolvernavidad.Size = new System.Drawing.Size(75, 23);
            this.btnvolvernavidad.TabIndex = 0;
            this.btnvolvernavidad.Text = "Volver";
            this.btnvolvernavidad.UseVisualStyleBackColor = true;
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
            this.comboniñosporedad.Location = new System.Drawing.Point(107, 44);
            this.comboniñosporedad.Name = "comboniñosporedad";
            this.comboniñosporedad.Size = new System.Drawing.Size(199, 21);
            this.comboniñosporedad.TabIndex = 1;
            // 
            // gridnavidadniños
            // 
            this.gridnavidadniños.AllowUserToOrderColumns = true;
            this.gridnavidadniños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnavidadniños.Location = new System.Drawing.Point(107, 104);
            this.gridnavidadniños.Name = "gridnavidadniños";
            this.gridnavidadniños.Size = new System.Drawing.Size(530, 155);
            this.gridnavidadniños.TabIndex = 2;
            this.gridnavidadniños.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridnavidadniños_RowPostPaint);
            // 
            // btnbuscarniñosnavidad
            // 
            this.btnbuscarniñosnavidad.Location = new System.Drawing.Point(368, 44);
            this.btnbuscarniñosnavidad.Name = "btnbuscarniñosnavidad";
            this.btnbuscarniñosnavidad.Size = new System.Drawing.Size(114, 23);
            this.btnbuscarniñosnavidad.TabIndex = 3;
            this.btnbuscarniñosnavidad.Text = "Buscar";
            this.btnbuscarniñosnavidad.UseVisualStyleBackColor = true;
            this.btnbuscarniñosnavidad.Click += new System.EventHandler(this.btnbuscarniñosnavidad_Click);
            // 
            // btndescargarexcel
            // 
            this.btndescargarexcel.Location = new System.Drawing.Point(107, 288);
            this.btndescargarexcel.Name = "btndescargarexcel";
            this.btndescargarexcel.Size = new System.Drawing.Size(75, 23);
            this.btndescargarexcel.TabIndex = 4;
            this.btndescargarexcel.Text = "Descargar";
            this.btndescargarexcel.UseVisualStyleBackColor = true;
            this.btndescargarexcel.Click += new System.EventHandler(this.btndescargarexcel_Click);
            // 
            // ListadoNavidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndescargarexcel);
            this.Controls.Add(this.btnbuscarniñosnavidad);
            this.Controls.Add(this.gridnavidadniños);
            this.Controls.Add(this.comboniñosporedad);
            this.Controls.Add(this.btnvolvernavidad);
            this.Name = "ListadoNavidad";
            this.Text = "ListadoNavidad";
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolvernavidad;
        private System.Windows.Forms.ComboBox comboniñosporedad;
        private System.Windows.Forms.DataGridView gridnavidadniños;
        private System.Windows.Forms.Button btnbuscarniñosnavidad;
        private System.Windows.Forms.Button btndescargarexcel;
    }
}