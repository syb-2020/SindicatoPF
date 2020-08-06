namespace SocioSindicato
{
    partial class Administrador
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
            this.btnbuscarsocioadmi = new System.Windows.Forms.Button();
            this.btneliminarsocioadmi = new System.Windows.Forms.Button();
            this.btnagregarsocioadm = new System.Windows.Forms.Button();
            this.btnplantasadmi = new System.Windows.Forms.Button();
            this.btnnavidadadm = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscarsocioadmi
            // 
            this.btnbuscarsocioadmi.Location = new System.Drawing.Point(31, 30);
            this.btnbuscarsocioadmi.Name = "btnbuscarsocioadmi";
            this.btnbuscarsocioadmi.Size = new System.Drawing.Size(122, 23);
            this.btnbuscarsocioadmi.TabIndex = 0;
            this.btnbuscarsocioadmi.Text = "Buscar Socio";
            this.btnbuscarsocioadmi.UseVisualStyleBackColor = true;
            this.btnbuscarsocioadmi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminarsocioadmi
            // 
            this.btneliminarsocioadmi.Location = new System.Drawing.Point(36, 80);
            this.btneliminarsocioadmi.Name = "btneliminarsocioadmi";
            this.btneliminarsocioadmi.Size = new System.Drawing.Size(117, 23);
            this.btneliminarsocioadmi.TabIndex = 1;
            this.btneliminarsocioadmi.Text = "Eliminar Socio";
            this.btneliminarsocioadmi.UseVisualStyleBackColor = true;
            this.btneliminarsocioadmi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnagregarsocioadm
            // 
            this.btnagregarsocioadm.Location = new System.Drawing.Point(36, 134);
            this.btnagregarsocioadm.Name = "btnagregarsocioadm";
            this.btnagregarsocioadm.Size = new System.Drawing.Size(117, 23);
            this.btnagregarsocioadm.TabIndex = 2;
            this.btnagregarsocioadm.Text = "Agregar Socio";
            this.btnagregarsocioadm.UseVisualStyleBackColor = true;
            this.btnagregarsocioadm.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnplantasadmi
            // 
            this.btnplantasadmi.Location = new System.Drawing.Point(36, 185);
            this.btnplantasadmi.Name = "btnplantasadmi";
            this.btnplantasadmi.Size = new System.Drawing.Size(117, 23);
            this.btnplantasadmi.TabIndex = 3;
            this.btnplantasadmi.Text = "Plantas";
            this.btnplantasadmi.UseVisualStyleBackColor = true;
            this.btnplantasadmi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnnavidadadm
            // 
            this.btnnavidadadm.Location = new System.Drawing.Point(36, 240);
            this.btnnavidadadm.Name = "btnnavidadadm";
            this.btnnavidadadm.Size = new System.Drawing.Size(117, 23);
            this.btnnavidadadm.TabIndex = 4;
            this.btnnavidadadm.Text = "Listado Navidad";
            this.btnnavidadadm.UseVisualStyleBackColor = true;
            this.btnnavidadadm.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(661, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Cerrar Sesion";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnnavidadadm);
            this.Controls.Add(this.btnplantasadmi);
            this.Controls.Add(this.btnagregarsocioadm);
            this.Controls.Add(this.btneliminarsocioadmi);
            this.Controls.Add(this.btnbuscarsocioadmi);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbuscarsocioadmi;
        private System.Windows.Forms.Button btneliminarsocioadmi;
        private System.Windows.Forms.Button btnagregarsocioadm;
        private System.Windows.Forms.Button btnplantasadmi;
        private System.Windows.Forms.Button btnnavidadadm;
        private System.Windows.Forms.Button button6;
    }
}