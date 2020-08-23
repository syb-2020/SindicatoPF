namespace SocioSindicato.ViewsAdministrador
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
            this.grideliminar = new System.Windows.Forms.DataGridView();
            this.lbeliminar = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.gridsociosolo = new System.Windows.Forms.DataGridView();
            this.gridsolocon = new System.Windows.Forms.DataGridView();
            this.gridhijo = new System.Windows.Forms.DataGridView();
            this.btVolver = new FontAwesome.Sharp.IconButton();
            this.btBuscarUser = new FontAwesome.Sharp.IconButton();
            this.btEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.grideliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsociosolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridsolocon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridhijo)).BeginInit();
            this.SuspendLayout();
            // 
            // txteliminar
            // 
            this.txteliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteliminar.Location = new System.Drawing.Point(76, 46);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(790, 27);
            this.txteliminar.TabIndex = 0;
            // 
            // grideliminar
            // 
            this.grideliminar.AllowUserToOrderColumns = true;
            this.grideliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grideliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grideliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.grideliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grideliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideliminar.Location = new System.Drawing.Point(76, 120);
            this.grideliminar.Name = "grideliminar";
            this.grideliminar.Size = new System.Drawing.Size(671, 415);
            this.grideliminar.TabIndex = 2;
            this.grideliminar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grideliminar_RowPostPaint);
            // 
            // lbeliminar
            // 
            this.lbeliminar.AutoSize = true;
            this.lbeliminar.Location = new System.Drawing.Point(372, 318);
            this.lbeliminar.Name = "lbeliminar";
            this.lbeliminar.Size = new System.Drawing.Size(0, 13);
            this.lbeliminar.TabIndex = 4;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(767, 186);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(334, 349);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // gridsociosolo
            // 
            this.gridsociosolo.AllowUserToOrderColumns = true;
            this.gridsociosolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsociosolo.Location = new System.Drawing.Point(809, 616);
            this.gridsociosolo.Name = "gridsociosolo";
            this.gridsociosolo.Size = new System.Drawing.Size(240, 12);
            this.gridsociosolo.TabIndex = 7;
            this.gridsociosolo.Visible = false;
            // 
            // gridsolocon
            // 
            this.gridsolocon.AllowUserToOrderColumns = true;
            this.gridsolocon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsolocon.Location = new System.Drawing.Point(809, 647);
            this.gridsolocon.Name = "gridsolocon";
            this.gridsolocon.Size = new System.Drawing.Size(240, 10);
            this.gridsolocon.TabIndex = 8;
            this.gridsolocon.Visible = false;
            // 
            // gridhijo
            // 
            this.gridhijo.AllowUserToOrderColumns = true;
            this.gridhijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhijo.Location = new System.Drawing.Point(809, 673);
            this.gridhijo.Name = "gridhijo";
            this.gridhijo.Size = new System.Drawing.Size(240, 10);
            this.gridhijo.TabIndex = 9;
            this.gridhijo.Visible = false;
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
            this.btVolver.TabIndex = 29;
            this.btVolver.Text = "Volver";
            this.btVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btBuscarUser
            // 
            this.btBuscarUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btBuscarUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btBuscarUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBuscarUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btBuscarUser.IconColor = System.Drawing.Color.White;
            this.btBuscarUser.IconSize = 26;
            this.btBuscarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscarUser.Location = new System.Drawing.Point(931, 40);
            this.btBuscarUser.Name = "btBuscarUser";
            this.btBuscarUser.Rotation = 0D;
            this.btBuscarUser.Size = new System.Drawing.Size(170, 38);
            this.btBuscarUser.TabIndex = 28;
            this.btBuscarUser.Text = "Buscar";
            this.btBuscarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscarUser.UseVisualStyleBackColor = false;
            this.btBuscarUser.Click += new System.EventHandler(this.btBuscarUser_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btEliminar.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btEliminar.IconColor = System.Drawing.Color.White;
            this.btEliminar.IconSize = 26;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(76, 633);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Rotation = 0D;
            this.btEliminar.Size = new System.Drawing.Size(170, 38);
            this.btEliminar.TabIndex = 30;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // EliminarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1250, 747);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBuscarUser);
            this.Controls.Add(this.gridhijo);
            this.Controls.Add(this.gridsolocon);
            this.Controls.Add(this.gridsociosolo);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lbeliminar);
            this.Controls.Add(this.grideliminar);
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
        private System.Windows.Forms.DataGridView grideliminar;
        private System.Windows.Forms.Label lbeliminar;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.DataGridView gridsociosolo;
        private System.Windows.Forms.DataGridView gridsolocon;
        private System.Windows.Forms.DataGridView gridhijo;
        private FontAwesome.Sharp.IconButton btVolver;
        private FontAwesome.Sharp.IconButton btBuscarUser;
        private FontAwesome.Sharp.IconButton btEliminar;
    }
}