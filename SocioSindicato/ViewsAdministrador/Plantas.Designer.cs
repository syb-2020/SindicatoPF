namespace SocioSindicato.ViewsAdministrador
{
    partial class Plantas
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
			this.gridverplantas = new System.Windows.Forms.DataGridView();
			this.lbsocioplantaencontrado = new System.Windows.Forms.Label();
			this.cbordenarcatplant = new System.Windows.Forms.ComboBox();
			this.btplanta1 = new FontAwesome.Sharp.IconButton();
			this.btcdt = new FontAwesome.Sharp.IconButton();
			this.btplanta2 = new FontAwesome.Sharp.IconButton();
			this.btPlantapizza = new FontAwesome.Sharp.IconButton();
			this.btplanta3 = new FontAwesome.Sharp.IconButton();
			this.btPlantaCamicos = new FontAwesome.Sharp.IconButton();
			this.btplanta4 = new FontAwesome.Sharp.IconButton();
			this.btPlantaMujeres = new FontAwesome.Sharp.IconButton();
			this.btTodos = new FontAwesome.Sharp.IconButton();
			this.btDownload = new FontAwesome.Sharp.IconButton();
			this.btOrdenarCategoria = new FontAwesome.Sharp.IconButton();
			this.Buscarsolterossinhijos = new FontAwesome.Sharp.IconButton();
			this.casadomayode40 = new FontAwesome.Sharp.IconButton();
			this.gridcasadohijo = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridverplantas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridcasadohijo)).BeginInit();
			this.SuspendLayout();
			// 
			// gridverplantas
			// 
			this.gridverplantas.AllowUserToAddRows = false;
			this.gridverplantas.AllowUserToDeleteRows = false;
			this.gridverplantas.AllowUserToOrderColumns = true;
			this.gridverplantas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridverplantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridverplantas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.gridverplantas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridverplantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridverplantas.Location = new System.Drawing.Point(76, 248);
			this.gridverplantas.Name = "gridverplantas";
			this.gridverplantas.ReadOnly = true;
			this.gridverplantas.Size = new System.Drawing.Size(1115, 429);
			this.gridverplantas.TabIndex = 9;
			this.gridverplantas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridverplantas_RowPostPaint);
			// 
			// lbsocioplantaencontrado
			// 
			this.lbsocioplantaencontrado.AutoSize = true;
			this.lbsocioplantaencontrado.Location = new System.Drawing.Point(94, 338);
			this.lbsocioplantaencontrado.Name = "lbsocioplantaencontrado";
			this.lbsocioplantaencontrado.Size = new System.Drawing.Size(0, 13);
			this.lbsocioplantaencontrado.TabIndex = 10;
			// 
			// cbordenarcatplant
			// 
			this.cbordenarcatplant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbordenarcatplant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbordenarcatplant.FormattingEnabled = true;
			this.cbordenarcatplant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.cbordenarcatplant.Location = new System.Drawing.Point(531, 689);
			this.cbordenarcatplant.Name = "cbordenarcatplant";
			this.cbordenarcatplant.Size = new System.Drawing.Size(170, 29);
			this.cbordenarcatplant.TabIndex = 12;
			this.cbordenarcatplant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbordenarcatplant_KeyPress);
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
			this.btplanta1.Location = new System.Drawing.Point(76, 40);
			this.btplanta1.Name = "btplanta1";
			this.btplanta1.Rotation = 0D;
			this.btplanta1.Size = new System.Drawing.Size(170, 38);
			this.btplanta1.TabIndex = 15;
			this.btplanta1.Text = "Planta 1";
			this.btplanta1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btplanta1.UseVisualStyleBackColor = false;
			this.btplanta1.Click += new System.EventHandler(this.btplanta1_Click);
			// 
			// btcdt
			// 
			this.btcdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btcdt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btcdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btcdt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btcdt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btcdt.ForeColor = System.Drawing.Color.Gainsboro;
			this.btcdt.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btcdt.IconColor = System.Drawing.Color.White;
			this.btcdt.IconSize = 26;
			this.btcdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btcdt.Location = new System.Drawing.Point(930, 40);
			this.btcdt.Name = "btcdt";
			this.btcdt.Rotation = 0D;
			this.btcdt.Size = new System.Drawing.Size(225, 38);
			this.btcdt.TabIndex = 16;
			this.btcdt.Text = "CDT";
			this.btcdt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btcdt.UseVisualStyleBackColor = false;
			this.btcdt.Click += new System.EventHandler(this.btcdt_Click);
			// 
			// btplanta2
			// 
			this.btplanta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btplanta2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btplanta2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btplanta2.ForeColor = System.Drawing.Color.Gainsboro;
			this.btplanta2.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btplanta2.IconColor = System.Drawing.Color.White;
			this.btplanta2.IconSize = 26;
			this.btplanta2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btplanta2.Location = new System.Drawing.Point(281, 40);
			this.btplanta2.Name = "btplanta2";
			this.btplanta2.Rotation = 0D;
			this.btplanta2.Size = new System.Drawing.Size(170, 38);
			this.btplanta2.TabIndex = 17;
			this.btplanta2.Text = "Planta 2";
			this.btplanta2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btplanta2.UseVisualStyleBackColor = false;
			this.btplanta2.Click += new System.EventHandler(this.btplanta2_Click);
			// 
			// btPlantapizza
			// 
			this.btPlantapizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantapizza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantapizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlantapizza.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btPlantapizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlantapizza.ForeColor = System.Drawing.Color.Gainsboro;
			this.btPlantapizza.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btPlantapizza.IconColor = System.Drawing.Color.White;
			this.btPlantapizza.IconSize = 26;
			this.btPlantapizza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPlantapizza.Location = new System.Drawing.Point(76, 112);
			this.btPlantapizza.Name = "btPlantapizza";
			this.btPlantapizza.Rotation = 0D;
			this.btPlantapizza.Size = new System.Drawing.Size(170, 38);
			this.btPlantapizza.TabIndex = 18;
			this.btPlantapizza.Text = "Planta Pizza";
			this.btPlantapizza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btPlantapizza.UseVisualStyleBackColor = false;
			this.btPlantapizza.Click += new System.EventHandler(this.btPlantapizza_Click);
			// 
			// btplanta3
			// 
			this.btplanta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btplanta3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btplanta3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btplanta3.ForeColor = System.Drawing.Color.Gainsboro;
			this.btplanta3.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btplanta3.IconColor = System.Drawing.Color.White;
			this.btplanta3.IconSize = 26;
			this.btplanta3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btplanta3.Location = new System.Drawing.Point(494, 40);
			this.btplanta3.Name = "btplanta3";
			this.btplanta3.Rotation = 0D;
			this.btplanta3.Size = new System.Drawing.Size(170, 38);
			this.btplanta3.TabIndex = 19;
			this.btplanta3.Text = "Planta 3";
			this.btplanta3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btplanta3.UseVisualStyleBackColor = false;
			this.btplanta3.Click += new System.EventHandler(this.btplanta3_Click);
			// 
			// btPlantaCamicos
			// 
			this.btPlantaCamicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantaCamicos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantaCamicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlantaCamicos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btPlantaCamicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlantaCamicos.ForeColor = System.Drawing.Color.Gainsboro;
			this.btPlantaCamicos.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btPlantaCamicos.IconColor = System.Drawing.Color.White;
			this.btPlantaCamicos.IconSize = 26;
			this.btPlantaCamicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPlantaCamicos.Location = new System.Drawing.Point(281, 112);
			this.btPlantaCamicos.Name = "btPlantaCamicos";
			this.btPlantaCamicos.Rotation = 0D;
			this.btPlantaCamicos.Size = new System.Drawing.Size(170, 38);
			this.btPlantaCamicos.TabIndex = 20;
			this.btPlantaCamicos.Text = "Planta Camicos";
			this.btPlantaCamicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btPlantaCamicos.UseVisualStyleBackColor = false;
			this.btPlantaCamicos.Click += new System.EventHandler(this.btPlantaCamicos_Click);
			// 
			// btplanta4
			// 
			this.btplanta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btplanta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btplanta4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btplanta4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btplanta4.ForeColor = System.Drawing.Color.Gainsboro;
			this.btplanta4.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btplanta4.IconColor = System.Drawing.Color.White;
			this.btplanta4.IconSize = 26;
			this.btplanta4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btplanta4.Location = new System.Drawing.Point(705, 40);
			this.btplanta4.Name = "btplanta4";
			this.btplanta4.Rotation = 0D;
			this.btplanta4.Size = new System.Drawing.Size(170, 38);
			this.btplanta4.TabIndex = 21;
			this.btplanta4.Text = "Planta 4";
			this.btplanta4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btplanta4.UseVisualStyleBackColor = false;
			this.btplanta4.Click += new System.EventHandler(this.btplanta4_Click);
			// 
			// btPlantaMujeres
			// 
			this.btPlantaMujeres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantaMujeres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btPlantaMujeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlantaMujeres.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btPlantaMujeres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlantaMujeres.ForeColor = System.Drawing.Color.Gainsboro;
			this.btPlantaMujeres.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btPlantaMujeres.IconColor = System.Drawing.Color.White;
			this.btPlantaMujeres.IconSize = 26;
			this.btPlantaMujeres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPlantaMujeres.Location = new System.Drawing.Point(494, 112);
			this.btPlantaMujeres.Name = "btPlantaMujeres";
			this.btPlantaMujeres.Rotation = 0D;
			this.btPlantaMujeres.Size = new System.Drawing.Size(170, 38);
			this.btPlantaMujeres.TabIndex = 22;
			this.btPlantaMujeres.Text = "Planta Mujeres";
			this.btPlantaMujeres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btPlantaMujeres.UseVisualStyleBackColor = false;
			this.btPlantaMujeres.Click += new System.EventHandler(this.btPlantaMujeres_Click);
			// 
			// btTodos
			// 
			this.btTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTodos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTodos.ForeColor = System.Drawing.Color.Gainsboro;
			this.btTodos.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btTodos.IconColor = System.Drawing.Color.White;
			this.btTodos.IconSize = 26;
			this.btTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btTodos.Location = new System.Drawing.Point(930, 183);
			this.btTodos.Name = "btTodos";
			this.btTodos.Rotation = 0D;
			this.btTodos.Size = new System.Drawing.Size(225, 38);
			this.btTodos.TabIndex = 23;
			this.btTodos.Text = "Todos";
			this.btTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btTodos.UseVisualStyleBackColor = false;
			this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
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
			this.btDownload.Location = new System.Drawing.Point(76, 683);
			this.btDownload.Name = "btDownload";
			this.btDownload.Rotation = 0D;
			this.btDownload.Size = new System.Drawing.Size(170, 38);
			this.btDownload.TabIndex = 25;
			this.btDownload.Text = "Descargar";
			this.btDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDownload.UseVisualStyleBackColor = false;
			this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
			// 
			// btOrdenarCategoria
			// 
			this.btOrdenarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btOrdenarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btOrdenarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btOrdenarCategoria.FlatAppearance.BorderSize = 0;
			this.btOrdenarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btOrdenarCategoria.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btOrdenarCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btOrdenarCategoria.ForeColor = System.Drawing.Color.Gainsboro;
			this.btOrdenarCategoria.IconChar = FontAwesome.Sharp.IconChar.SortNumericUp;
			this.btOrdenarCategoria.IconColor = System.Drawing.Color.Gainsboro;
			this.btOrdenarCategoria.IconSize = 26;
			this.btOrdenarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btOrdenarCategoria.Location = new System.Drawing.Point(281, 683);
			this.btOrdenarCategoria.Name = "btOrdenarCategoria";
			this.btOrdenarCategoria.Rotation = 0D;
			this.btOrdenarCategoria.Size = new System.Drawing.Size(230, 38);
			this.btOrdenarCategoria.TabIndex = 26;
			this.btOrdenarCategoria.Text = "Ordenar Por Categoria";
			this.btOrdenarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btOrdenarCategoria.UseVisualStyleBackColor = false;
			this.btOrdenarCategoria.Click += new System.EventHandler(this.btOrdenarCategoria_Click);
			// 
			// Buscarsolterossinhijos
			// 
			this.Buscarsolterossinhijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.Buscarsolterossinhijos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.Buscarsolterossinhijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Buscarsolterossinhijos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.Buscarsolterossinhijos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buscarsolterossinhijos.ForeColor = System.Drawing.Color.Gainsboro;
			this.Buscarsolterossinhijos.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.Buscarsolterossinhijos.IconColor = System.Drawing.Color.White;
			this.Buscarsolterossinhijos.IconSize = 26;
			this.Buscarsolterossinhijos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Buscarsolterossinhijos.Location = new System.Drawing.Point(705, 112);
			this.Buscarsolterossinhijos.Name = "Buscarsolterossinhijos";
			this.Buscarsolterossinhijos.Rotation = 0D;
			this.Buscarsolterossinhijos.Size = new System.Drawing.Size(162, 38);
			this.Buscarsolterossinhijos.TabIndex = 27;
			this.Buscarsolterossinhijos.Text = "Socio Soltero";
			this.Buscarsolterossinhijos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Buscarsolterossinhijos.UseVisualStyleBackColor = false;
			this.Buscarsolterossinhijos.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// casadomayode40
			// 
			this.casadomayode40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.casadomayode40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.casadomayode40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.casadomayode40.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.casadomayode40.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.casadomayode40.ForeColor = System.Drawing.Color.Gainsboro;
			this.casadomayode40.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.casadomayode40.IconColor = System.Drawing.Color.White;
			this.casadomayode40.IconSize = 26;
			this.casadomayode40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.casadomayode40.Location = new System.Drawing.Point(930, 112);
			this.casadomayode40.Name = "casadomayode40";
			this.casadomayode40.Rotation = 0D;
			this.casadomayode40.Size = new System.Drawing.Size(225, 38);
			this.casadomayode40.TabIndex = 28;
			this.casadomayode40.Text = "Casado Mayor De 40";
			this.casadomayode40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.casadomayode40.UseVisualStyleBackColor = false;
			this.casadomayode40.Click += new System.EventHandler(this.casadomayode40_Click);
			// 
			// gridcasadohijo
			// 
			this.gridcasadohijo.AllowUserToOrderColumns = true;
			this.gridcasadohijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridcasadohijo.Location = new System.Drawing.Point(12, 12);
			this.gridcasadohijo.Name = "gridcasadohijo";
			this.gridcasadohijo.Size = new System.Drawing.Size(32, 14);
			this.gridcasadohijo.TabIndex = 29;
			this.gridcasadohijo.Visible = false;
			// 
			// Plantas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(1250, 747);
			this.Controls.Add(this.gridcasadohijo);
			this.Controls.Add(this.casadomayode40);
			this.Controls.Add(this.Buscarsolterossinhijos);
			this.Controls.Add(this.btOrdenarCategoria);
			this.Controls.Add(this.btDownload);
			this.Controls.Add(this.btTodos);
			this.Controls.Add(this.btPlantaMujeres);
			this.Controls.Add(this.btplanta4);
			this.Controls.Add(this.btPlantaCamicos);
			this.Controls.Add(this.btplanta3);
			this.Controls.Add(this.btPlantapizza);
			this.Controls.Add(this.btplanta2);
			this.Controls.Add(this.btcdt);
			this.Controls.Add(this.btplanta1);
			this.Controls.Add(this.cbordenarcatplant);
			this.Controls.Add(this.lbsocioplantaencontrado);
			this.Controls.Add(this.gridverplantas);
			this.Name = "Plantas";
			this.Text = "Plantas";
			((System.ComponentModel.ISupportInitialize)(this.gridverplantas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridcasadohijo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridverplantas;
        private System.Windows.Forms.Label lbsocioplantaencontrado;
        private System.Windows.Forms.ComboBox cbordenarcatplant;
        private FontAwesome.Sharp.IconButton btplanta1;
        private FontAwesome.Sharp.IconButton btcdt;
        private FontAwesome.Sharp.IconButton btplanta2;
        private FontAwesome.Sharp.IconButton btPlantapizza;
        private FontAwesome.Sharp.IconButton btplanta3;
        private FontAwesome.Sharp.IconButton btPlantaCamicos;
        private FontAwesome.Sharp.IconButton btplanta4;
        private FontAwesome.Sharp.IconButton btPlantaMujeres;
        private FontAwesome.Sharp.IconButton btTodos;
        private FontAwesome.Sharp.IconButton btDownload;
        private FontAwesome.Sharp.IconButton btOrdenarCategoria;
		private FontAwesome.Sharp.IconButton Buscarsolterossinhijos;
		private FontAwesome.Sharp.IconButton casadomayode40;
		private System.Windows.Forms.DataGridView gridcasadohijo;
	}
}