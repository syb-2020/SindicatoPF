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
            this.pb = new System.Windows.Forms.PictureBox();
            this.gridsociosolo = new System.Windows.Forms.DataGridView();
            this.gridsolocon = new System.Windows.Forms.DataGridView();
            this.gridhijo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grideliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsociosolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsolocon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridhijo)).BeginInit();
            this.SuspendLayout();
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(87, 56);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(301, 20);
            this.txteliminar.TabIndex = 0;
            // 
            // btnbuscarel
            // 
            this.btnbuscarel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnbuscarel.FlatAppearance.BorderSize = 0;
            this.btnbuscarel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarel.ForeColor = System.Drawing.Color.White;
            this.btnbuscarel.Location = new System.Drawing.Point(470, 54);
            this.btnbuscarel.Name = "btnbuscarel";
            this.btnbuscarel.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarel.TabIndex = 1;
            this.btnbuscarel.Text = "BuscarSocio";
            this.btnbuscarel.UseVisualStyleBackColor = false;
            this.btnbuscarel.Click += new System.EventHandler(this.btnbuscarel_Click);
            // 
            // grideliminar
            // 
            this.grideliminar.AllowUserToOrderColumns = true;
            this.grideliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grideliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideliminar.Location = new System.Drawing.Point(87, 118);
            this.grideliminar.Name = "grideliminar";
            this.grideliminar.Size = new System.Drawing.Size(458, 150);
            this.grideliminar.TabIndex = 2;
            this.grideliminar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grideliminar_RowPostPaint);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(87, 313);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
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
            this.btnvolvereliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnvolvereliminar.FlatAppearance.BorderSize = 0;
            this.btnvolvereliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolvereliminar.ForeColor = System.Drawing.Color.White;
            this.btnvolvereliminar.Location = new System.Drawing.Point(684, 394);
            this.btnvolvereliminar.Name = "btnvolvereliminar";
            this.btnvolvereliminar.Size = new System.Drawing.Size(75, 23);
            this.btnvolvereliminar.TabIndex = 5;
            this.btnvolvereliminar.Text = "Volver";
            this.btnvolvereliminar.UseVisualStyleBackColor = false;
            this.btnvolvereliminar.Click += new System.EventHandler(this.btnvolvereliminar_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(581, 118);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(178, 150);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // gridsociosolo
            // 
            this.gridsociosolo.AllowUserToOrderColumns = true;
            this.gridsociosolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsociosolo.Location = new System.Drawing.Point(320, 303);
            this.gridsociosolo.Name = "gridsociosolo";
            this.gridsociosolo.Size = new System.Drawing.Size(240, 12);
            this.gridsociosolo.TabIndex = 7;
            this.gridsociosolo.Visible = false;
            // 
            // gridsolocon
            // 
            this.gridsolocon.AllowUserToOrderColumns = true;
            this.gridsolocon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsolocon.Location = new System.Drawing.Point(320, 334);
            this.gridsolocon.Name = "gridsolocon";
            this.gridsolocon.Size = new System.Drawing.Size(240, 10);
            this.gridsolocon.TabIndex = 8;
            this.gridsolocon.Visible = false;
            // 
            // gridhijo
            // 
            this.gridhijo.AllowUserToOrderColumns = true;
            this.gridhijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhijo.Location = new System.Drawing.Point(320, 360);
            this.gridhijo.Name = "gridhijo";
            this.gridhijo.Size = new System.Drawing.Size(240, 10);
            this.gridhijo.TabIndex = 9;
            this.gridhijo.Visible = false;
            // 
            // EliminarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridhijo);
            this.Controls.Add(this.gridsolocon);
            this.Controls.Add(this.gridsociosolo);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnvolvereliminar);
            this.Controls.Add(this.lbeliminar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.grideliminar);
            this.Controls.Add(this.btnbuscarel);
            this.Controls.Add(this.txteliminar);
            this.Name = "EliminarSocio";
            this.Text = "EliminarSocio";
            ((System.ComponentModel.ISupportInitialize)(this.grideliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsociosolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsolocon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridhijo)).EndInit();
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
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.DataGridView gridsociosolo;
        private System.Windows.Forms.DataGridView gridsolocon;
        private System.Windows.Forms.DataGridView gridhijo;
    }
}