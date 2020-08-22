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
            this.comboniñosporedad = new System.Windows.Forms.ComboBox();
            this.gridnavidadniños = new System.Windows.Forms.DataGridView();
            this.lbprueba = new System.Windows.Forms.Label();
            this.gridcargarn = new System.Windows.Forms.DataGridView();
            this.btplanta1 = new FontAwesome.Sharp.IconButton();
            this.btDownload = new FontAwesome.Sharp.IconButton();
            this.btVolver = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcargarn)).BeginInit();
            this.SuspendLayout();
            // 
            // comboniñosporedad
            // 
            this.comboniñosporedad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboniñosporedad.Size = new System.Drawing.Size(790, 29);
            this.comboniñosporedad.TabIndex = 1;
            // 
            // gridnavidadniños
            // 
            this.gridnavidadniños.AllowUserToOrderColumns = true;
            this.gridnavidadniños.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridnavidadniños.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridnavidadniños.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.gridnavidadniños.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridnavidadniños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnavidadniños.Location = new System.Drawing.Point(107, 104);
            this.gridnavidadniños.Name = "gridnavidadniños";
            this.gridnavidadniños.Size = new System.Drawing.Size(994, 497);
            this.gridnavidadniños.TabIndex = 2;
            this.gridnavidadniños.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridnavidadniños_RowPostPaint);
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
            this.gridcargarn.Size = new System.Drawing.Size(994, 43);
            this.gridcargarn.TabIndex = 6;
            this.gridcargarn.Visible = false;
            // 
            // btplanta1
            // 
            this.btplanta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btplanta1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btplanta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btplanta1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btplanta1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btplanta1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btplanta1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btplanta1.IconColor = System.Drawing.Color.White;
            this.btplanta1.IconSize = 26;
            this.btplanta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btplanta1.Location = new System.Drawing.Point(931, 47);
            this.btplanta1.Name = "btplanta1";
            this.btplanta1.Rotation = 0D;
            this.btplanta1.Size = new System.Drawing.Size(170, 38);
            this.btplanta1.TabIndex = 16;
            this.btplanta1.Text = "Buscar";
            this.btplanta1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btplanta1.UseVisualStyleBackColor = false;
            this.btplanta1.Click += new System.EventHandler(this.btplanta1_Click);
            // 
            // btDownload
            // 
            this.btDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btDownload.FlatAppearance.BorderSize = 0;
            this.btDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDownload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btDownload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btDownload.IconColor = System.Drawing.Color.Gainsboro;
            this.btDownload.IconSize = 26;
            this.btDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDownload.Location = new System.Drawing.Point(76, 633);
            this.btDownload.Name = "btDownload";
            this.btDownload.Rotation = 0D;
            this.btDownload.Size = new System.Drawing.Size(170, 38);
            this.btDownload.TabIndex = 26;
            this.btDownload.Text = "Descargar";
            this.btDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // btVolver
            // 
            this.btVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btVolver.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btVolver.IconColor = System.Drawing.Color.Gainsboro;
            this.btVolver.IconSize = 26;
            this.btVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVolver.Location = new System.Drawing.Point(1145, 12);
            this.btVolver.Name = "btVolver";
            this.btVolver.Rotation = 0D;
            this.btVolver.Size = new System.Drawing.Size(93, 38);
            this.btVolver.TabIndex = 27;
            this.btVolver.Text = "Volver";
            this.btVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // ListadoNavidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1250, 747);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.btplanta1);
            this.Controls.Add(this.gridcargarn);
            this.Controls.Add(this.lbprueba);
            this.Controls.Add(this.gridnavidadniños);
            this.Controls.Add(this.comboniñosporedad);
            this.Name = "ListadoNavidad";
            this.Text = "ListadoNavidad";
            ((System.ComponentModel.ISupportInitialize)(this.gridnavidadniños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcargarn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboniñosporedad;
        private System.Windows.Forms.DataGridView gridnavidadniños;
        private System.Windows.Forms.Label lbprueba;
        private System.Windows.Forms.DataGridView gridcargarn;
        private FontAwesome.Sharp.IconButton btplanta1;
        private FontAwesome.Sharp.IconButton btDownload;
        private FontAwesome.Sharp.IconButton btVolver;
    }
}