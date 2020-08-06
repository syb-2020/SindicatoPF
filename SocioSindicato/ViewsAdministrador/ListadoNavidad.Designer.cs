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
            // ListadoNavidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolvernavidad);
            this.Name = "ListadoNavidad";
            this.Text = "ListadoNavidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolvernavidad;
    }
}