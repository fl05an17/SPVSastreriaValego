namespace SPVSastreriaValego.UI
{
    partial class frmTransacciones
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
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.lblTipoTran = new System.Windows.Forms.Label();
            this.cmbTipoTran = new System.Windows.Forms.ComboBox();
            this.btnMostrarT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(828, 36);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::SPVSastreriaValego.Properties.Resources.icon_close;
            this.pictureBoxClose.Location = new System.Drawing.Point(792, 1);
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
            this.lblTop.Location = new System.Drawing.Point(373, 7);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(138, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "TRANSACCIONES";
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Location = new System.Drawing.Point(12, 116);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.Size = new System.Drawing.Size(804, 322);
            this.dgvTransacciones.TabIndex = 3;
            // 
            // lblTipoTran
            // 
            this.lblTipoTran.AutoSize = true;
            this.lblTipoTran.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTran.Location = new System.Drawing.Point(22, 69);
            this.lblTipoTran.Name = "lblTipoTran";
            this.lblTipoTran.Size = new System.Drawing.Size(125, 17);
            this.lblTipoTran.TabIndex = 4;
            this.lblTipoTran.Text = "Tipo de Transacción";
            // 
            // cmbTipoTran
            // 
            this.cmbTipoTran.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTran.FormattingEnabled = true;
            this.cmbTipoTran.Items.AddRange(new object[] {
            "Compras",
            "Ventas"});
            this.cmbTipoTran.Location = new System.Drawing.Point(163, 67);
            this.cmbTipoTran.Name = "cmbTipoTran";
            this.cmbTipoTran.Size = new System.Drawing.Size(377, 25);
            this.cmbTipoTran.TabIndex = 5;
            this.cmbTipoTran.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTran_SelectedIndexChanged);
            // 
            // btnMostrarT
            // 
            this.btnMostrarT.BackColor = System.Drawing.SystemColors.Info;
            this.btnMostrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarT.Location = new System.Drawing.Point(575, 62);
            this.btnMostrarT.Name = "btnMostrarT";
            this.btnMostrarT.Size = new System.Drawing.Size(149, 34);
            this.btnMostrarT.TabIndex = 6;
            this.btnMostrarT.Text = "Mostrar Todo";
            this.btnMostrarT.UseVisualStyleBackColor = false;
            this.btnMostrarT.Click += new System.EventHandler(this.btnMostrarT_Click);
            // 
            // frmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnMostrarT);
            this.Controls.Add(this.cmbTipoTran);
            this.Controls.Add(this.lblTipoTran);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.frmTransacciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.Label lblTipoTran;
        private System.Windows.Forms.ComboBox cmbTipoTran;
        private System.Windows.Forms.Button btnMostrarT;
    }
}