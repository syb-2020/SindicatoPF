﻿namespace SocioSindicato.ViewsAdministrador
{
    partial class EliminarSocio
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
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.btnbuscarel = new System.Windows.Forms.Button();
            this.grideliminar = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbeliminar = new System.Windows.Forms.Label();
            this.btnvolvereliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grideliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(208, 56);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(180, 20);
            this.txteliminar.TabIndex = 0;
            // 
            // btnbuscarel
            // 
            this.btnbuscarel.Location = new System.Drawing.Point(425, 54);
            this.btnbuscarel.Name = "btnbuscarel";
            this.btnbuscarel.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarel.TabIndex = 1;
            this.btnbuscarel.Text = "BuscarSocio";
            this.btnbuscarel.UseVisualStyleBackColor = true;
            this.btnbuscarel.Click += new System.EventHandler(this.btnbuscarel_Click);
            // 
            // grideliminar
            // 
            this.grideliminar.AllowUserToOrderColumns = true;
            this.grideliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideliminar.Location = new System.Drawing.Point(208, 118);
            this.grideliminar.Name = "grideliminar";
            this.grideliminar.Size = new System.Drawing.Size(337, 150);
            this.grideliminar.TabIndex = 2;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(233, 313);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lbeliminar
            // 
            this.lbeliminar.AutoSize = true;
            this.lbeliminar.Location = new System.Drawing.Point(372, 318);
            this.lbeliminar.Name = "lbeliminar";
            this.lbeliminar.Size = new System.Drawing.Size(0, 13);
            this.lbeliminar.TabIndex = 4;
            // 
            // btnvolvereliminar
            // 
            this.btnvolvereliminar.Location = new System.Drawing.Point(684, 410);
            this.btnvolvereliminar.Name = "btnvolvereliminar";
            this.btnvolvereliminar.Size = new System.Drawing.Size(75, 23);
            this.btnvolvereliminar.TabIndex = 5;
            this.btnvolvereliminar.Text = "Volver";
            this.btnvolvereliminar.UseVisualStyleBackColor = true;
            this.btnvolvereliminar.Click += new System.EventHandler(this.btnvolvereliminar_Click);
            // 
            // EliminarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolvereliminar);
            this.Controls.Add(this.lbeliminar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.grideliminar);
            this.Controls.Add(this.btnbuscarel);
            this.Controls.Add(this.txteliminar);
            this.Name = "EliminarSocio";
            this.Text = "EliminarSocio";
            ((System.ComponentModel.ISupportInitialize)(this.grideliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.Button btnbuscarel;
        private System.Windows.Forms.DataGridView grideliminar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbeliminar;
        private System.Windows.Forms.Button btnvolvereliminar;
    }
}