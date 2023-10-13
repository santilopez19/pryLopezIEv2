namespace pryLopezIE
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lstProveedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvwProveedores = new System.Windows.Forms.TreeView();
            this.gpbIndicacion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbIndicacion2 = new System.Windows.Forms.GroupBox();
            this.gpbProveedor = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtModificarNumero = new System.Windows.Forms.TextBox();
            this.txtModificarEntidad = new System.Windows.Forms.TextBox();
            this.txtModificarApertura = new System.Windows.Forms.TextBox();
            this.txtModificarNExpediente = new System.Windows.Forms.TextBox();
            this.lblLiquidadorResponsable = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.txtModificarJuzgado = new System.Windows.Forms.TextBox();
            this.txtModificarJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtModificarDireccion = new System.Windows.Forms.TextBox();
            this.txtModificarLiquidadorResponsable = new System.Windows.Forms.TextBox();
            this.gpbDatosProveedores = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.gpbIndicacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbIndicacion2.SuspendLayout();
            this.gpbProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDatosProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1045, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 37);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(13, 637);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 44);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToOrderColumns = true;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(112, 20);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.Size = new System.Drawing.Size(1070, 166);
            this.dgvProveedores.TabIndex = 15;
            // 
            // lstProveedores
            // 
            this.lstProveedores.BackColor = System.Drawing.Color.White;
            this.lstProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProveedores.ForeColor = System.Drawing.Color.Black;
            this.lstProveedores.HideSelection = false;
            this.lstProveedores.Location = new System.Drawing.Point(18, 29);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(684, 190);
            this.lstProveedores.TabIndex = 14;
            this.lstProveedores.UseCompatibleStateImageBehavior = false;
            this.lstProveedores.View = System.Windows.Forms.View.Details;
            this.lstProveedores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstProveedores_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ult. Modificacion";
            this.columnHeader3.Width = 200;
            // 
            // tvwProveedores
            // 
            this.tvwProveedores.BackColor = System.Drawing.Color.White;
            this.tvwProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwProveedores.ForeColor = System.Drawing.Color.Black;
            this.tvwProveedores.Location = new System.Drawing.Point(21, 29);
            this.tvwProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.tvwProveedores.Name = "tvwProveedores";
            this.tvwProveedores.Size = new System.Drawing.Size(240, 190);
            this.tvwProveedores.TabIndex = 13;
            this.tvwProveedores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwProveedores_NodeMouseClick);
            // 
            // gpbIndicacion
            // 
            this.gpbIndicacion.BackColor = System.Drawing.Color.Transparent;
            this.gpbIndicacion.Controls.Add(this.groupBox1);
            this.gpbIndicacion.Controls.Add(this.tvwProveedores);
            this.gpbIndicacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbIndicacion.ForeColor = System.Drawing.Color.White;
            this.gpbIndicacion.Location = new System.Drawing.Point(13, 12);
            this.gpbIndicacion.Name = "gpbIndicacion";
            this.gpbIndicacion.Size = new System.Drawing.Size(284, 235);
            this.gpbIndicacion.TabIndex = 19;
            this.gpbIndicacion.TabStop = false;
            this.gpbIndicacion.Text = "Seleccione la carpeta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvProveedores);
            this.groupBox1.Location = new System.Drawing.Point(1, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 181);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gpbIndicacion2
            // 
            this.gpbIndicacion2.BackColor = System.Drawing.Color.Transparent;
            this.gpbIndicacion2.Controls.Add(this.lstProveedores);
            this.gpbIndicacion2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbIndicacion2.ForeColor = System.Drawing.Color.White;
            this.gpbIndicacion2.Location = new System.Drawing.Point(311, 12);
            this.gpbIndicacion2.Name = "gpbIndicacion2";
            this.gpbIndicacion2.Size = new System.Drawing.Size(720, 235);
            this.gpbIndicacion2.TabIndex = 20;
            this.gpbIndicacion2.TabStop = false;
            this.gpbIndicacion2.Text = "Seleccione el Archivo a mostrar";
            // 
            // gpbProveedor
            // 
            this.gpbProveedor.Controls.Add(this.dataGridView1);
            this.gpbProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProveedor.ForeColor = System.Drawing.Color.White;
            this.gpbProveedor.Location = new System.Drawing.Point(14, 253);
            this.gpbProveedor.Name = "gpbProveedor";
            this.gpbProveedor.Size = new System.Drawing.Size(1017, 191);
            this.gpbProveedor.TabIndex = 21;
            this.gpbProveedor.TabStop = false;
            this.gpbProveedor.Text = "Seleccione el Proveedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(979, 142);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellClick);
            // 
            // lblNExpediente
            // 
            this.lblNExpediente.AutoSize = true;
            this.lblNExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNExpediente.ForeColor = System.Drawing.Color.White;
            this.lblNExpediente.Location = new System.Drawing.Point(15, 143);
            this.lblNExpediente.Name = "lblNExpediente";
            this.lblNExpediente.Size = new System.Drawing.Size(125, 22);
            this.lblNExpediente.TabIndex = 46;
            this.lblNExpediente.Text = "N° Expediente";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.ForeColor = System.Drawing.Color.White;
            this.lblApertura.Location = new System.Drawing.Point(15, 105);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(79, 22);
            this.lblApertura.TabIndex = 45;
            this.lblApertura.Text = "Apertura";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.ForeColor = System.Drawing.Color.White;
            this.lblEntidad.Location = new System.Drawing.Point(15, 67);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(71, 22);
            this.lblEntidad.TabIndex = 44;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(15, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(30, 22);
            this.lblNumero.TabIndex = 43;
            this.lblNumero.Text = "N°";
            // 
            // txtModificarNumero
            // 
            this.txtModificarNumero.Location = new System.Drawing.Point(149, 29);
            this.txtModificarNumero.Multiline = true;
            this.txtModificarNumero.Name = "txtModificarNumero";
            this.txtModificarNumero.Size = new System.Drawing.Size(289, 22);
            this.txtModificarNumero.TabIndex = 42;
            // 
            // txtModificarEntidad
            // 
            this.txtModificarEntidad.Location = new System.Drawing.Point(149, 67);
            this.txtModificarEntidad.Multiline = true;
            this.txtModificarEntidad.Name = "txtModificarEntidad";
            this.txtModificarEntidad.Size = new System.Drawing.Size(289, 22);
            this.txtModificarEntidad.TabIndex = 41;
            // 
            // txtModificarApertura
            // 
            this.txtModificarApertura.Location = new System.Drawing.Point(149, 105);
            this.txtModificarApertura.Multiline = true;
            this.txtModificarApertura.Name = "txtModificarApertura";
            this.txtModificarApertura.Size = new System.Drawing.Size(289, 22);
            this.txtModificarApertura.TabIndex = 40;
            // 
            // txtModificarNExpediente
            // 
            this.txtModificarNExpediente.Location = new System.Drawing.Point(149, 143);
            this.txtModificarNExpediente.Multiline = true;
            this.txtModificarNExpediente.Name = "txtModificarNExpediente";
            this.txtModificarNExpediente.Size = new System.Drawing.Size(289, 22);
            this.txtModificarNExpediente.TabIndex = 39;
            // 
            // lblLiquidadorResponsable
            // 
            this.lblLiquidadorResponsable.AutoSize = true;
            this.lblLiquidadorResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidadorResponsable.ForeColor = System.Drawing.Color.White;
            this.lblLiquidadorResponsable.Location = new System.Drawing.Point(479, 143);
            this.lblLiquidadorResponsable.Name = "lblLiquidadorResponsable";
            this.lblLiquidadorResponsable.Size = new System.Drawing.Size(204, 22);
            this.lblLiquidadorResponsable.TabIndex = 54;
            this.lblLiquidadorResponsable.Text = "Liquidador Responsable";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(479, 105);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 22);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisdiccion.ForeColor = System.Drawing.Color.White;
            this.lblJurisdiccion.Location = new System.Drawing.Point(479, 67);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(104, 22);
            this.lblJurisdiccion.TabIndex = 52;
            this.lblJurisdiccion.Text = "Jurisdicción";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzgado.ForeColor = System.Drawing.Color.White;
            this.lblJuzgado.Location = new System.Drawing.Point(479, 29);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(77, 22);
            this.lblJuzgado.TabIndex = 51;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // txtModificarJuzgado
            // 
            this.txtModificarJuzgado.Location = new System.Drawing.Point(703, 29);
            this.txtModificarJuzgado.Multiline = true;
            this.txtModificarJuzgado.Name = "txtModificarJuzgado";
            this.txtModificarJuzgado.Size = new System.Drawing.Size(289, 22);
            this.txtModificarJuzgado.TabIndex = 50;
            // 
            // txtModificarJurisdiccion
            // 
            this.txtModificarJurisdiccion.Location = new System.Drawing.Point(703, 67);
            this.txtModificarJurisdiccion.Multiline = true;
            this.txtModificarJurisdiccion.Name = "txtModificarJurisdiccion";
            this.txtModificarJurisdiccion.Size = new System.Drawing.Size(289, 22);
            this.txtModificarJurisdiccion.TabIndex = 49;
            // 
            // txtModificarDireccion
            // 
            this.txtModificarDireccion.Location = new System.Drawing.Point(703, 105);
            this.txtModificarDireccion.Multiline = true;
            this.txtModificarDireccion.Name = "txtModificarDireccion";
            this.txtModificarDireccion.Size = new System.Drawing.Size(289, 22);
            this.txtModificarDireccion.TabIndex = 48;
            // 
            // txtModificarLiquidadorResponsable
            // 
            this.txtModificarLiquidadorResponsable.Location = new System.Drawing.Point(703, 143);
            this.txtModificarLiquidadorResponsable.Multiline = true;
            this.txtModificarLiquidadorResponsable.Name = "txtModificarLiquidadorResponsable";
            this.txtModificarLiquidadorResponsable.Size = new System.Drawing.Size(289, 22);
            this.txtModificarLiquidadorResponsable.TabIndex = 47;
            // 
            // gpbDatosProveedores
            // 
            this.gpbDatosProveedores.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatosProveedores.Controls.Add(this.txtModificarNumero);
            this.gpbDatosProveedores.Controls.Add(this.lblLiquidadorResponsable);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarNExpediente);
            this.gpbDatosProveedores.Controls.Add(this.lblDireccion);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarApertura);
            this.gpbDatosProveedores.Controls.Add(this.lblJurisdiccion);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarEntidad);
            this.gpbDatosProveedores.Controls.Add(this.lblJuzgado);
            this.gpbDatosProveedores.Controls.Add(this.lblNumero);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarJuzgado);
            this.gpbDatosProveedores.Controls.Add(this.lblEntidad);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarJurisdiccion);
            this.gpbDatosProveedores.Controls.Add(this.lblApertura);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarDireccion);
            this.gpbDatosProveedores.Controls.Add(this.lblNExpediente);
            this.gpbDatosProveedores.Controls.Add(this.txtModificarLiquidadorResponsable);
            this.gpbDatosProveedores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosProveedores.ForeColor = System.Drawing.Color.White;
            this.gpbDatosProveedores.Location = new System.Drawing.Point(14, 450);
            this.gpbDatosProveedores.Name = "gpbDatosProveedores";
            this.gpbDatosProveedores.Size = new System.Drawing.Size(1017, 180);
            this.gpbDatosProveedores.TabIndex = 13;
            this.gpbDatosProveedores.TabStop = false;
            this.gpbDatosProveedores.Text = "Datos Proveedores";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(655, 637);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(783, 637);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(911, 637);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1097, 694);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbDatosProveedores);
            this.Controls.Add(this.gpbProveedor);
            this.Controls.Add(this.gpbIndicacion2);
            this.Controls.Add(this.gpbIndicacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.gpbIndicacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbIndicacion2.ResumeLayout(false);
            this.gpbProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDatosProveedores.ResumeLayout(false);
            this.gpbDatosProveedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ListView lstProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TreeView tvwProveedores;
        private System.Windows.Forms.GroupBox gpbIndicacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbIndicacion2;
        private System.Windows.Forms.GroupBox gpbProveedor;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtModificarNumero;
        public System.Windows.Forms.TextBox txtModificarEntidad;
        public System.Windows.Forms.TextBox txtModificarApertura;
        public System.Windows.Forms.TextBox txtModificarNExpediente;
        private System.Windows.Forms.Label lblLiquidadorResponsable;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblJuzgado;
        public System.Windows.Forms.TextBox txtModificarJuzgado;
        public System.Windows.Forms.TextBox txtModificarJurisdiccion;
        public System.Windows.Forms.TextBox txtModificarDireccion;
        public System.Windows.Forms.TextBox txtModificarLiquidadorResponsable;
        private System.Windows.Forms.GroupBox gpbDatosProveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}