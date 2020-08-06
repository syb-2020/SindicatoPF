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
            ((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).BeginInit();
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
            this.txtbuscar.Location = new System.Drawing.Point(172, 63);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(192, 20);
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
            this.gridbuscar.Location = new System.Drawing.Point(96, 155);
            this.gridbuscar.Name = "gridbuscar";
            this.gridbuscar.Size = new System.Drawing.Size(575, 189);
            this.gridbuscar.TabIndex = 3;
            // 
            // btnvolverbuscar
            // 
            this.btnvolverbuscar.Location = new System.Drawing.Point(696, 405);
            this.btnvolverbuscar.Name = "btnvolverbuscar";
            this.btnvolverbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnvolverbuscar.TabIndex = 4;
            this.btnvolverbuscar.Text = "Volver";
            this.btnvolverbuscar.UseVisualStyleBackColor = true;
            this.btnvolverbuscar.Click += new System.EventHandler(this.btnvolverbuscar_Click);
            // 
            // BuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolverbuscar);
            this.Controls.Add(this.gridbuscar);
            this.Controls.Add(this.lbbuscarsocio);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Name = "BuscarSocio";
            this.Text = "BuscarSocio";
            ((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbbuscarsocio;
        private System.Windows.Forms.DataGridView gridbuscar;
        private System.Windows.Forms.Button btnvolverbuscar;
    }
}