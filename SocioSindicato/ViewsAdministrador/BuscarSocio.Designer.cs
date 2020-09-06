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
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lbbuscarsocio = new System.Windows.Forms.Label();
			this.gridbuscar = new System.Windows.Forms.DataGridView();
			this.imagenbuscarsociomostrar = new System.Windows.Forms.PictureBox();
			this.btnddexcel = new System.Windows.Forms.Button();
			this.gridConyuge = new System.Windows.Forms.DataGridView();
			this.gridHijo = new System.Windows.Forms.DataGridView();
			this.gbtodo = new System.Windows.Forms.DataGridView();
			this.btDownload = new FontAwesome.Sharp.IconButton();
			this.btDownloadSocioHijo = new FontAwesome.Sharp.IconButton();
			this.btDownloadSocioConyu = new FontAwesome.Sharp.IconButton();
			this.btDownloadTodos = new FontAwesome.Sharp.IconButton();
			this.btBuscarUser = new FontAwesome.Sharp.IconButton();
			this.btBuscarHijo = new FontAwesome.Sharp.IconButton();
			this.btBuscarConyuge = new FontAwesome.Sharp.IconButton();
			this.label11 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagenbuscarsociomostrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridConyuge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridHijo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbtodo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtbuscar
			// 
			this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbuscar.Location = new System.Drawing.Point(76, 46);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(821, 27);
			this.txtbuscar.TabIndex = 1;
			// 
			// lbbuscarsocio
			// 
			this.lbbuscarsocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbbuscarsocio.AutoSize = true;
			this.lbbuscarsocio.Location = new System.Drawing.Point(601, 63);
			this.lbbuscarsocio.Name = "lbbuscarsocio";
			this.lbbuscarsocio.Size = new System.Drawing.Size(0, 13);
			this.lbbuscarsocio.TabIndex = 2;
			// 
			// gridbuscar
			// 
			this.gridbuscar.AllowUserToOrderColumns = true;
			this.gridbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridbuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridbuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.gridbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridbuscar.Location = new System.Drawing.Point(76, 137);
			this.gridbuscar.Name = "gridbuscar";
			this.gridbuscar.Size = new System.Drawing.Size(718, 115);
			this.gridbuscar.TabIndex = 3;
			this.gridbuscar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridbuscar_RowPostPaint);
			// 
			// imagenbuscarsociomostrar
			// 
			this.imagenbuscarsociomostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imagenbuscarsociomostrar.Location = new System.Drawing.Point(800, 137);
			this.imagenbuscarsociomostrar.Name = "imagenbuscarsociomostrar";
			this.imagenbuscarsociomostrar.Size = new System.Drawing.Size(301, 182);
			this.imagenbuscarsociomostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagenbuscarsociomostrar.TabIndex = 5;
			this.imagenbuscarsociomostrar.TabStop = false;
			this.imagenbuscarsociomostrar.Click += new System.EventHandler(this.imagenbuscarsociomostrar_Click);
			// 
			// btnddexcel
			// 
			this.btnddexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnddexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnddexcel.FlatAppearance.BorderSize = 0;
			this.btnddexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnddexcel.ForeColor = System.Drawing.Color.White;
			this.btnddexcel.Location = new System.Drawing.Point(468, 560);
			this.btnddexcel.Name = "btnddexcel";
			this.btnddexcel.Size = new System.Drawing.Size(193, 23);
			this.btnddexcel.TabIndex = 6;
			this.btnddexcel.Text = "Descargar Socios - Conyuge - Hijos";
			this.btnddexcel.UseVisualStyleBackColor = false;
			// 
			// gridConyuge
			// 
			this.gridConyuge.AllowUserToOrderColumns = true;
			this.gridConyuge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridConyuge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridConyuge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.gridConyuge.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridConyuge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridConyuge.Location = new System.Drawing.Point(76, 290);
			this.gridConyuge.Name = "gridConyuge";
			this.gridConyuge.Size = new System.Drawing.Size(718, 109);
			this.gridConyuge.TabIndex = 8;
			this.gridConyuge.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridConyuge_RowPostPaint);
			// 
			// gridHijo
			// 
			this.gridHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridHijo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridHijo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.gridHijo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridHijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridHijo.Location = new System.Drawing.Point(76, 433);
			this.gridHijo.Name = "gridHijo";
			this.gridHijo.Size = new System.Drawing.Size(718, 194);
			this.gridHijo.TabIndex = 9;
			this.gridHijo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridHijo_RowPostPaint);
			// 
			// gbtodo
			// 
			this.gbtodo.AllowUserToOrderColumns = true;
			this.gbtodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gbtodo.Location = new System.Drawing.Point(108, 159);
			this.gbtodo.Name = "gbtodo";
			this.gbtodo.Size = new System.Drawing.Size(575, 27);
			this.gbtodo.TabIndex = 11;
			this.gbtodo.Visible = false;
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
			this.btDownload.TabIndex = 27;
			this.btDownload.Text = "Descargar Socio";
			this.btDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDownload.UseVisualStyleBackColor = false;
			this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
			// 
			// btDownloadSocioHijo
			// 
			this.btDownloadSocioHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btDownloadSocioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadSocioHijo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadSocioHijo.FlatAppearance.BorderSize = 0;
			this.btDownloadSocioHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDownloadSocioHijo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btDownloadSocioHijo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDownloadSocioHijo.ForeColor = System.Drawing.Color.Gainsboro;
			this.btDownloadSocioHijo.IconChar = FontAwesome.Sharp.IconChar.Download;
			this.btDownloadSocioHijo.IconColor = System.Drawing.Color.Gainsboro;
			this.btDownloadSocioHijo.IconSize = 26;
			this.btDownloadSocioHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btDownloadSocioHijo.Location = new System.Drawing.Point(580, 633);
			this.btDownloadSocioHijo.Name = "btDownloadSocioHijo";
			this.btDownloadSocioHijo.Rotation = 0D;
			this.btDownloadSocioHijo.Size = new System.Drawing.Size(241, 38);
			this.btDownloadSocioHijo.TabIndex = 28;
			this.btDownloadSocioHijo.Text = "Descargar Socio E Hijo";
			this.btDownloadSocioHijo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDownloadSocioHijo.UseVisualStyleBackColor = false;
			this.btDownloadSocioHijo.Click += new System.EventHandler(this.btDownloadSocioHijo_Click);
			// 
			// btDownloadSocioConyu
			// 
			this.btDownloadSocioConyu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btDownloadSocioConyu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadSocioConyu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadSocioConyu.FlatAppearance.BorderSize = 0;
			this.btDownloadSocioConyu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDownloadSocioConyu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btDownloadSocioConyu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDownloadSocioConyu.ForeColor = System.Drawing.Color.Gainsboro;
			this.btDownloadSocioConyu.IconChar = FontAwesome.Sharp.IconChar.Download;
			this.btDownloadSocioConyu.IconColor = System.Drawing.Color.Gainsboro;
			this.btDownloadSocioConyu.IconSize = 26;
			this.btDownloadSocioConyu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btDownloadSocioConyu.Location = new System.Drawing.Point(278, 633);
			this.btDownloadSocioConyu.Name = "btDownloadSocioConyu";
			this.btDownloadSocioConyu.Rotation = 0D;
			this.btDownloadSocioConyu.Size = new System.Drawing.Size(273, 38);
			this.btDownloadSocioConyu.TabIndex = 29;
			this.btDownloadSocioConyu.Text = "Descargar Socio y Conyuge";
			this.btDownloadSocioConyu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDownloadSocioConyu.UseVisualStyleBackColor = false;
			this.btDownloadSocioConyu.Click += new System.EventHandler(this.btDownloadSocioConyu_Click);
			// 
			// btDownloadTodos
			// 
			this.btDownloadTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btDownloadTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btDownloadTodos.FlatAppearance.BorderSize = 0;
			this.btDownloadTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDownloadTodos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btDownloadTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDownloadTodos.ForeColor = System.Drawing.Color.Gainsboro;
			this.btDownloadTodos.IconChar = FontAwesome.Sharp.IconChar.Download;
			this.btDownloadTodos.IconColor = System.Drawing.Color.Gainsboro;
			this.btDownloadTodos.IconSize = 26;
			this.btDownloadTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btDownloadTodos.Location = new System.Drawing.Point(846, 633);
			this.btDownloadTodos.Name = "btDownloadTodos";
			this.btDownloadTodos.Rotation = 0D;
			this.btDownloadTodos.Size = new System.Drawing.Size(255, 38);
			this.btDownloadTodos.TabIndex = 30;
			this.btDownloadTodos.Text = "Descargar Todos";
			this.btDownloadTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDownloadTodos.UseVisualStyleBackColor = false;
			this.btDownloadTodos.Click += new System.EventHandler(this.btDownloadTodos_Click);
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
			this.btBuscarUser.TabIndex = 31;
			this.btBuscarUser.Text = "Buscar Socio";
			this.btBuscarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btBuscarUser.UseVisualStyleBackColor = false;
			this.btBuscarUser.Click += new System.EventHandler(this.btBuscarUser_Click);
			// 
			// btBuscarHijo
			// 
			this.btBuscarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btBuscarHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btBuscarHijo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btBuscarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBuscarHijo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btBuscarHijo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscarHijo.ForeColor = System.Drawing.Color.Gainsboro;
			this.btBuscarHijo.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btBuscarHijo.IconColor = System.Drawing.Color.White;
			this.btBuscarHijo.IconSize = 26;
			this.btBuscarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btBuscarHijo.Location = new System.Drawing.Point(800, 386);
			this.btBuscarHijo.Name = "btBuscarHijo";
			this.btBuscarHijo.Rotation = 0D;
			this.btBuscarHijo.Size = new System.Drawing.Size(301, 38);
			this.btBuscarHijo.TabIndex = 33;
			this.btBuscarHijo.Text = "Buscar Hijo";
			this.btBuscarHijo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btBuscarHijo.UseVisualStyleBackColor = false;
			this.btBuscarHijo.Click += new System.EventHandler(this.btBuscarHijo_Click);
			// 
			// btBuscarConyuge
			// 
			this.btBuscarConyuge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btBuscarConyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btBuscarConyuge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btBuscarConyuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBuscarConyuge.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btBuscarConyuge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscarConyuge.ForeColor = System.Drawing.Color.Gainsboro;
			this.btBuscarConyuge.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btBuscarConyuge.IconColor = System.Drawing.Color.White;
			this.btBuscarConyuge.IconSize = 26;
			this.btBuscarConyuge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btBuscarConyuge.Location = new System.Drawing.Point(800, 340);
			this.btBuscarConyuge.Name = "btBuscarConyuge";
			this.btBuscarConyuge.Rotation = 0D;
			this.btBuscarConyuge.Size = new System.Drawing.Size(301, 38);
			this.btBuscarConyuge.TabIndex = 34;
			this.btBuscarConyuge.Text = "Buscar Conyuge";
			this.btBuscarConyuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btBuscarConyuge.UseVisualStyleBackColor = false;
			this.btBuscarConyuge.Click += new System.EventHandler(this.btBuscarConyuge_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Gainsboro;
			this.label11.Location = new System.Drawing.Point(72, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 23);
			this.label11.TabIndex = 64;
			this.label11.Text = "Datos Del Socio";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Gainsboro;
			this.label17.Location = new System.Drawing.Point(72, 264);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(205, 23);
			this.label17.TabIndex = 65;
			this.label17.Text = "Datos de la Conyuge";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(72, 407);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 23);
			this.label1.TabIndex = 66;
			this.label1.Text = "Datos del o los hijos";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Gainsboro;
			this.label16.Location = new System.Drawing.Point(868, 104);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(173, 23);
			this.label16.TabIndex = 91;
			this.label16.Text = "Imagen Del Socio";
			// 
			// BuscarSocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(1250, 747);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btBuscarConyuge);
			this.Controls.Add(this.btBuscarHijo);
			this.Controls.Add(this.btBuscarUser);
			this.Controls.Add(this.btDownloadTodos);
			this.Controls.Add(this.btDownloadSocioConyu);
			this.Controls.Add(this.btDownloadSocioHijo);
			this.Controls.Add(this.btDownload);
			this.Controls.Add(this.gbtodo);
			this.Controls.Add(this.gridHijo);
			this.Controls.Add(this.gridConyuge);
			this.Controls.Add(this.btnddexcel);
			this.Controls.Add(this.imagenbuscarsociomostrar);
			this.Controls.Add(this.gridbuscar);
			this.Controls.Add(this.lbbuscarsocio);
			this.Controls.Add(this.txtbuscar);
			this.Name = "BuscarSocio";
			this.Text = "BuscarSocio";
			((System.ComponentModel.ISupportInitialize)(this.gridbuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagenbuscarsociomostrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridConyuge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridHijo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbtodo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbbuscarsocio;
        private System.Windows.Forms.DataGridView gridbuscar;
        private System.Windows.Forms.PictureBox imagenbuscarsociomostrar;
        private System.Windows.Forms.Button btnddexcel;
        private System.Windows.Forms.DataGridView gridConyuge;
        private System.Windows.Forms.DataGridView gridHijo;
        private System.Windows.Forms.DataGridView gbtodo;
        private FontAwesome.Sharp.IconButton btDownload;
        private FontAwesome.Sharp.IconButton btDownloadSocioHijo;
        private FontAwesome.Sharp.IconButton btDownloadSocioConyu;
        private FontAwesome.Sharp.IconButton btDownloadTodos;
        private FontAwesome.Sharp.IconButton btBuscarUser;
        private FontAwesome.Sharp.IconButton btBuscarHijo;
        private FontAwesome.Sharp.IconButton btBuscarConyuge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
    }
}