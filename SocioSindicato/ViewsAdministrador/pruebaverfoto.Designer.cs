namespace SocioSindicato.ViewsAdministrador
{
    partial class pruebaverfoto
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
            this.fotosocioprueba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotosocioprueba)).BeginInit();
            this.SuspendLayout();
            // 
            // fotosocioprueba
            // 
            this.fotosocioprueba.Location = new System.Drawing.Point(86, 111);
            this.fotosocioprueba.Name = "fotosocioprueba";
            this.fotosocioprueba.Size = new System.Drawing.Size(194, 109);
            this.fotosocioprueba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotosocioprueba.TabIndex = 0;
            this.fotosocioprueba.TabStop = false;
            this.fotosocioprueba.Click += new System.EventHandler(this.fotosocioprueba_Click);
            // 
            // pruebaverfoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fotosocioprueba);
            this.Name = "pruebaverfoto";
            this.Text = "pruebaverfoto";
            ((System.ComponentModel.ISupportInitialize)(this.fotosocioprueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fotosocioprueba;
    }
}