namespace SocioSindicato.ViewsAdministrador
{
    partial class EditarSocio
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
            this.btnvolvereditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvolvereditar
            // 
            this.btnvolvereditar.Location = new System.Drawing.Point(674, 401);
            this.btnvolvereditar.Name = "btnvolvereditar";
            this.btnvolvereditar.Size = new System.Drawing.Size(75, 23);
            this.btnvolvereditar.TabIndex = 0;
            this.btnvolvereditar.Text = "Volver";
            this.btnvolvereditar.UseVisualStyleBackColor = true;
            this.btnvolvereditar.Click += new System.EventHandler(this.btnvolvereditar_Click);
            // 
            // EditarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolvereditar);
            this.Name = "EditarSocio";
            this.Text = "EditarSocio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolvereditar;
    }
}