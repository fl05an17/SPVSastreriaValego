namespace SPVSastreriaValego.UI
{
    partial class frmComprasVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlProvClie = new System.Windows.Forms.Panel();
            this.dtpFechaDePagoPC = new System.Windows.Forms.DateTimePicker();
            this.txtDireccionPC = new System.Windows.Forms.TextBox();
            this.txtTelefonoPC = new System.Windows.Forms.TextBox();
            this.txtCorreoPC = new System.Windows.Forms.TextBox();
            this.txtNombrePC = new System.Windows.Forms.TextBox();
            this.txtBuscarPC = new System.Windows.Forms.TextBox();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblProvClieTitle = new System.Windows.Forms.Label();
            this.pnlDetProd = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.lblCantidadProd = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.txtInvenProd = new System.Windows.Forms.TextBox();
            this.lblInvePro = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.lblNomProd = new System.Windows.Forms.Label();
            this.txtBsucarProd = new System.Windows.Forms.TextBox();
            this.lblBuscarProd = new System.Windows.Forms.Label();
            this.lblDetProd = new System.Windows.Forms.Label();
            this.pnlDgvProdAgr = new System.Windows.Forms.Panel();
            this.dgvProdAgre = new System.Windows.Forms.DataGridView();
            this.lblProdAgre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDevolver = new System.Windows.Forms.Label();
            this.lblMedPago = new System.Windows.Forms.Label();
            this.lblGranTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblDescue = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDetCalc = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtGranTotal = new System.Windows.Forms.TextBox();
            this.txtMedioPago = new System.Windows.Forms.TextBox();
            this.txtDevolver = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlProvClie.SuspendLayout();
            this.pnlDetProd.SuspendLayout();
            this.pnlDgvProdAgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAgre)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 36);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::SPVSastreriaValego.Properties.Resources.icon_close;
            this.pictureBoxClose.Location = new System.Drawing.Point(1184, 1);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(34, 33);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(503, 7);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(161, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "COMPRAS Y VENTAS";
            // 
            // pnlProvClie
            // 
            this.pnlProvClie.Controls.Add(this.dtpFechaDePagoPC);
            this.pnlProvClie.Controls.Add(this.txtDireccionPC);
            this.pnlProvClie.Controls.Add(this.txtTelefonoPC);
            this.pnlProvClie.Controls.Add(this.txtCorreoPC);
            this.pnlProvClie.Controls.Add(this.txtNombrePC);
            this.pnlProvClie.Controls.Add(this.txtBuscarPC);
            this.pnlProvClie.Controls.Add(this.lblFechaDePago);
            this.pnlProvClie.Controls.Add(this.lblDireccion);
            this.pnlProvClie.Controls.Add(this.lblTelefono);
            this.pnlProvClie.Controls.Add(this.lblEmail);
            this.pnlProvClie.Controls.Add(this.lblNombre);
            this.pnlProvClie.Controls.Add(this.lblBuscar);
            this.pnlProvClie.Controls.Add(this.lblProvClieTitle);
            this.pnlProvClie.Location = new System.Drawing.Point(13, 52);
            this.pnlProvClie.Name = "pnlProvClie";
            this.pnlProvClie.Size = new System.Drawing.Size(1192, 100);
            this.pnlProvClie.TabIndex = 3;
            // 
            // dtpFechaDePagoPC
            // 
            this.dtpFechaDePagoPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDePagoPC.Location = new System.Drawing.Point(965, 29);
            this.dtpFechaDePagoPC.Name = "dtpFechaDePagoPC";
            this.dtpFechaDePagoPC.Size = new System.Drawing.Size(214, 25);
            this.dtpFechaDePagoPC.TabIndex = 12;
            // 
            // txtDireccionPC
            // 
            this.txtDireccionPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionPC.Location = new System.Drawing.Point(659, 29);
            this.txtDireccionPC.Multiline = true;
            this.txtDireccionPC.Name = "txtDireccionPC";
            this.txtDireccionPC.Size = new System.Drawing.Size(196, 59);
            this.txtDireccionPC.TabIndex = 11;
            // 
            // txtTelefonoPC
            // 
            this.txtTelefonoPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPC.Location = new System.Drawing.Point(361, 63);
            this.txtTelefonoPC.Name = "txtTelefonoPC";
            this.txtTelefonoPC.Size = new System.Drawing.Size(213, 25);
            this.txtTelefonoPC.TabIndex = 10;
            // 
            // txtCorreoPC
            // 
            this.txtCorreoPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPC.Location = new System.Drawing.Point(361, 29);
            this.txtCorreoPC.Name = "txtCorreoPC";
            this.txtCorreoPC.Size = new System.Drawing.Size(213, 25);
            this.txtCorreoPC.TabIndex = 9;
            // 
            // txtNombrePC
            // 
            this.txtNombrePC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePC.Location = new System.Drawing.Point(73, 64);
            this.txtNombrePC.Name = "txtNombrePC";
            this.txtNombrePC.Size = new System.Drawing.Size(215, 25);
            this.txtNombrePC.TabIndex = 8;
            // 
            // txtBuscarPC
            // 
            this.txtBuscarPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPC.Location = new System.Drawing.Point(73, 29);
            this.txtBuscarPC.Name = "txtBuscarPC";
            this.txtBuscarPC.Size = new System.Drawing.Size(215, 25);
            this.txtBuscarPC.TabIndex = 7;
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePago.Location = new System.Drawing.Point(865, 31);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(94, 17);
            this.lblFechaDePago.TabIndex = 6;
            this.lblFechaDePago.Text = "Fecha de Pago";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(587, 32);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 17);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(297, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 17);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(297, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(7, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblProvClieTitle
            // 
            this.lblProvClieTitle.AutoSize = true;
            this.lblProvClieTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvClieTitle.Location = new System.Drawing.Point(4, 4);
            this.lblProvClieTitle.Name = "lblProvClieTitle";
            this.lblProvClieTitle.Size = new System.Drawing.Size(221, 17);
            this.lblProvClieTitle.TabIndex = 0;
            this.lblProvClieTitle.Text = "Detalles de Proveedores y Clientes";
            // 
            // pnlDetProd
            // 
            this.pnlDetProd.Controls.Add(this.btnAgregar);
            this.pnlDetProd.Controls.Add(this.txtCantidadProd);
            this.pnlDetProd.Controls.Add(this.lblCantidadProd);
            this.pnlDetProd.Controls.Add(this.txtPrecioProd);
            this.pnlDetProd.Controls.Add(this.lblPrecioProd);
            this.pnlDetProd.Controls.Add(this.txtInvenProd);
            this.pnlDetProd.Controls.Add(this.lblInvePro);
            this.pnlDetProd.Controls.Add(this.txtNombreProd);
            this.pnlDetProd.Controls.Add(this.lblNomProd);
            this.pnlDetProd.Controls.Add(this.txtBsucarProd);
            this.pnlDetProd.Controls.Add(this.lblBuscarProd);
            this.pnlDetProd.Controls.Add(this.lblDetProd);
            this.pnlDetProd.Location = new System.Drawing.Point(13, 168);
            this.pnlDetProd.Name = "pnlDetProd";
            this.pnlDetProd.Size = new System.Drawing.Size(1192, 76);
            this.pnlDetProd.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1043, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 39);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(920, 37);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(102, 25);
            this.txtCantidadProd.TabIndex = 23;
            // 
            // lblCantidadProd
            // 
            this.lblCantidadProd.AutoSize = true;
            this.lblCantidadProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProd.Location = new System.Drawing.Point(854, 41);
            this.lblCantidadProd.Name = "lblCantidadProd";
            this.lblCantidadProd.Size = new System.Drawing.Size(60, 17);
            this.lblCantidadProd.TabIndex = 22;
            this.lblCantidadProd.Text = "Cantidad";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProd.Location = new System.Drawing.Point(695, 37);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(153, 25);
            this.txtPrecioProd.TabIndex = 21;
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd.Location = new System.Drawing.Point(648, 41);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioProd.TabIndex = 20;
            this.lblPrecioProd.Text = "Precio";
            // 
            // txtInvenProd
            // 
            this.txtInvenProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvenProd.Location = new System.Drawing.Point(494, 37);
            this.txtInvenProd.Name = "txtInvenProd";
            this.txtInvenProd.Size = new System.Drawing.Size(150, 25);
            this.txtInvenProd.TabIndex = 19;
            // 
            // lblInvePro
            // 
            this.lblInvePro.AutoSize = true;
            this.lblInvePro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvePro.Location = new System.Drawing.Point(426, 40);
            this.lblInvePro.Name = "lblInvePro";
            this.lblInvePro.Size = new System.Drawing.Size(65, 17);
            this.lblInvePro.TabIndex = 18;
            this.lblInvePro.Text = "Inventario";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(271, 37);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(148, 25);
            this.txtNombreProd.TabIndex = 17;
            // 
            // lblNomProd
            // 
            this.lblNomProd.AutoSize = true;
            this.lblNomProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProd.Location = new System.Drawing.Point(211, 40);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(57, 17);
            this.lblNomProd.TabIndex = 16;
            this.lblNomProd.Text = "Nombre";
            // 
            // txtBsucarProd
            // 
            this.txtBsucarProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBsucarProd.Location = new System.Drawing.Point(60, 37);
            this.txtBsucarProd.Name = "txtBsucarProd";
            this.txtBsucarProd.Size = new System.Drawing.Size(146, 25);
            this.txtBsucarProd.TabIndex = 15;
            // 
            // lblBuscarProd
            // 
            this.lblBuscarProd.AutoSize = true;
            this.lblBuscarProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProd.Location = new System.Drawing.Point(8, 40);
            this.lblBuscarProd.Name = "lblBuscarProd";
            this.lblBuscarProd.Size = new System.Drawing.Size(46, 17);
            this.lblBuscarProd.TabIndex = 14;
            this.lblBuscarProd.Text = "Buscar";
            // 
            // lblDetProd
            // 
            this.lblDetProd.AutoSize = true;
            this.lblDetProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetProd.Location = new System.Drawing.Point(3, 5);
            this.lblDetProd.Name = "lblDetProd";
            this.lblDetProd.Size = new System.Drawing.Size(143, 17);
            this.lblDetProd.TabIndex = 13;
            this.lblDetProd.Text = "Detalles de Productos";
            // 
            // pnlDgvProdAgr
            // 
            this.pnlDgvProdAgr.Controls.Add(this.dgvProdAgre);
            this.pnlDgvProdAgr.Controls.Add(this.lblProdAgre);
            this.pnlDgvProdAgr.Location = new System.Drawing.Point(13, 260);
            this.pnlDgvProdAgr.Name = "pnlDgvProdAgr";
            this.pnlDgvProdAgr.Size = new System.Drawing.Size(604, 335);
            this.pnlDgvProdAgr.TabIndex = 5;
            // 
            // dgvProdAgre
            // 
            this.dgvProdAgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdAgre.Location = new System.Drawing.Point(10, 30);
            this.dgvProdAgre.Name = "dgvProdAgre";
            this.dgvProdAgre.Size = new System.Drawing.Size(582, 292);
            this.dgvProdAgre.TabIndex = 15;
            // 
            // lblProdAgre
            // 
            this.lblProdAgre.AutoSize = true;
            this.lblProdAgre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdAgre.Location = new System.Drawing.Point(4, 5);
            this.lblProdAgre.Name = "lblProdAgre";
            this.lblProdAgre.Size = new System.Drawing.Size(140, 17);
            this.lblProdAgre.TabIndex = 14;
            this.lblProdAgre.Text = "Productos Agregados";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtDevolver);
            this.panel2.Controls.Add(this.txtMedioPago);
            this.panel2.Controls.Add(this.txtGranTotal);
            this.panel2.Controls.Add(this.txtIva);
            this.panel2.Controls.Add(this.txtDescuento);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.lblDevolver);
            this.panel2.Controls.Add(this.lblMedPago);
            this.panel2.Controls.Add(this.lblGranTotal);
            this.panel2.Controls.Add(this.lblIva);
            this.panel2.Controls.Add(this.lblDescue);
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.lblDetCalc);
            this.panel2.Location = new System.Drawing.Point(632, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 335);
            this.panel2.TabIndex = 6;
            // 
            // lblDevolver
            // 
            this.lblDevolver.AutoSize = true;
            this.lblDevolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolver.Location = new System.Drawing.Point(6, 242);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(70, 17);
            this.lblDevolver.TabIndex = 28;
            this.lblDevolver.Text = "A devolver";
            // 
            // lblMedPago
            // 
            this.lblMedPago.AutoSize = true;
            this.lblMedPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedPago.Location = new System.Drawing.Point(6, 201);
            this.lblMedPago.Name = "lblMedPago";
            this.lblMedPago.Size = new System.Drawing.Size(99, 17);
            this.lblMedPago.TabIndex = 27;
            this.lblMedPago.Text = "Medio de Pago";
            // 
            // lblGranTotal
            // 
            this.lblGranTotal.AutoSize = true;
            this.lblGranTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranTotal.Location = new System.Drawing.Point(6, 161);
            this.lblGranTotal.Name = "lblGranTotal";
            this.lblGranTotal.Size = new System.Drawing.Size(68, 17);
            this.lblGranTotal.TabIndex = 26;
            this.lblGranTotal.Text = "Gran Total";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(6, 122);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(49, 17);
            this.lblIva.TabIndex = 25;
            this.lblIva.Text = "IVA (%)";
            // 
            // lblDescue
            // 
            this.lblDescue.AutoSize = true;
            this.lblDescue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescue.Location = new System.Drawing.Point(6, 78);
            this.lblDescue.Name = "lblDescue";
            this.lblDescue.Size = new System.Drawing.Size(92, 17);
            this.lblDescue.TabIndex = 24;
            this.lblDescue.Text = "Descuento (%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(6, 37);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(56, 17);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblDetCalc
            // 
            this.lblDetCalc.AutoSize = true;
            this.lblDetCalc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetCalc.Location = new System.Drawing.Point(6, 5);
            this.lblDetCalc.Name = "lblDetCalc";
            this.lblDetCalc.Size = new System.Drawing.Size(128, 17);
            this.lblDetCalc.TabIndex = 15;
            this.lblDetCalc.Text = "Detalles Calculados";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(116, 33);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(426, 25);
            this.txtSubTotal.TabIndex = 29;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(116, 75);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(426, 25);
            this.txtDescuento.TabIndex = 30;
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(116, 117);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(426, 25);
            this.txtIva.TabIndex = 31;
            // 
            // txtGranTotal
            // 
            this.txtGranTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGranTotal.Location = new System.Drawing.Point(116, 157);
            this.txtGranTotal.Name = "txtGranTotal";
            this.txtGranTotal.ReadOnly = true;
            this.txtGranTotal.Size = new System.Drawing.Size(426, 25);
            this.txtGranTotal.TabIndex = 32;
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedioPago.Location = new System.Drawing.Point(116, 198);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(426, 25);
            this.txtMedioPago.TabIndex = 33;
            // 
            // txtDevolver
            // 
            this.txtDevolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolver.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDevolver.Location = new System.Drawing.Point(116, 236);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.ReadOnly = true;
            this.txtDevolver.Size = new System.Drawing.Size(426, 33);
            this.txtDevolver.TabIndex = 34;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(218, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 45);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmComprasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1221, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDgvProdAgr);
            this.Controls.Add(this.pnlDetProd);
            this.Controls.Add(this.pnlProvClie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComprasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras y Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlProvClie.ResumeLayout(false);
            this.pnlProvClie.PerformLayout();
            this.pnlDetProd.ResumeLayout(false);
            this.pnlDetProd.PerformLayout();
            this.pnlDgvProdAgr.ResumeLayout(false);
            this.pnlDgvProdAgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAgre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlProvClie;
        private System.Windows.Forms.TextBox txtBuscarPC;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblProvClieTitle;
        private System.Windows.Forms.DateTimePicker dtpFechaDePagoPC;
        private System.Windows.Forms.TextBox txtDireccionPC;
        private System.Windows.Forms.TextBox txtTelefonoPC;
        private System.Windows.Forms.TextBox txtCorreoPC;
        private System.Windows.Forms.TextBox txtNombrePC;
        private System.Windows.Forms.Panel pnlDetProd;
        private System.Windows.Forms.Label lblDetProd;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label lblCantidadProd;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.TextBox txtInvenProd;
        private System.Windows.Forms.Label lblInvePro;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label lblNomProd;
        private System.Windows.Forms.TextBox txtBsucarProd;
        private System.Windows.Forms.Label lblBuscarProd;
        private System.Windows.Forms.Panel pnlDgvProdAgr;
        private System.Windows.Forms.DataGridView dgvProdAgre;
        private System.Windows.Forms.Label lblProdAgre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDevolver;
        private System.Windows.Forms.Label lblMedPago;
        private System.Windows.Forms.Label lblGranTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblDescue;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDetCalc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDevolver;
        private System.Windows.Forms.TextBox txtMedioPago;
        private System.Windows.Forms.TextBox txtGranTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}