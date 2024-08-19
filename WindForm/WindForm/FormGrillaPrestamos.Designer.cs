namespace WindForm
{
    partial class FormGrillaPrestamos
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
            this.buttonCargarPrestamo = new System.Windows.Forms.Button();
            this.buttonVolverPrincipal = new System.Windows.Forms.Button();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.DniClienteAsociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComercioAdherido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCuotasPagadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCuotasFaltantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCargarPrestamo
            // 
            this.buttonCargarPrestamo.Location = new System.Drawing.Point(1758, 345);
            this.buttonCargarPrestamo.Name = "buttonCargarPrestamo";
            this.buttonCargarPrestamo.Size = new System.Drawing.Size(154, 29);
            this.buttonCargarPrestamo.TabIndex = 6;
            this.buttonCargarPrestamo.Text = "Cargar Prestamo";
            this.buttonCargarPrestamo.UseVisualStyleBackColor = true;
            this.buttonCargarPrestamo.Click += new System.EventHandler(this.buttonCargarPrestamo_Click);
            // 
            // buttonVolverPrincipal
            // 
            this.buttonVolverPrincipal.Location = new System.Drawing.Point(1758, 380);
            this.buttonVolverPrincipal.Name = "buttonVolverPrincipal";
            this.buttonVolverPrincipal.Size = new System.Drawing.Size(154, 29);
            this.buttonVolverPrincipal.TabIndex = 5;
            this.buttonVolverPrincipal.Text = "Volver";
            this.buttonVolverPrincipal.UseVisualStyleBackColor = true;
            this.buttonVolverPrincipal.Click += new System.EventHandler(this.buttonVolverPrincipal_Click);
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniClienteAsociado,
            this.NumeroPrestamo,
            this.Fecha,
            this.IdComercioAdherido,
            this.IdSucursal,
            this.MontoCredito,
            this.Tasa,
            this.MontoCuota,
            this.CantidadCuotasPagadas,
            this.CantidadCuotasFaltantes,
            this.Eliminar,
            this.Detalle});
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(16, 12);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.RowHeadersWidth = 62;
            this.dataGridViewPrestamos.RowTemplate.Height = 28;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(1896, 315);
            this.dataGridViewPrestamos.TabIndex = 4;
            // 
            // DniClienteAsociado
            // 
            this.DniClienteAsociado.HeaderText = "Dni del Cliente Asociado";
            this.DniClienteAsociado.MinimumWidth = 8;
            this.DniClienteAsociado.Name = "DniClienteAsociado";
            this.DniClienteAsociado.Width = 150;
            // 
            // NumeroPrestamo
            // 
            this.NumeroPrestamo.HeaderText = "Numero del Prestamo";
            this.NumeroPrestamo.MinimumWidth = 8;
            this.NumeroPrestamo.Name = "NumeroPrestamo";
            this.NumeroPrestamo.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha del Prestamo";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // IdComercioAdherido
            // 
            this.IdComercioAdherido.HeaderText = "ID del Comercio Adherido";
            this.IdComercioAdherido.MinimumWidth = 8;
            this.IdComercioAdherido.Name = "IdComercioAdherido";
            this.IdComercioAdherido.Width = 150;
            // 
            // IdSucursal
            // 
            this.IdSucursal.HeaderText = "ID de la Sucursal";
            this.IdSucursal.MinimumWidth = 8;
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 150;
            // 
            // MontoCredito
            // 
            this.MontoCredito.HeaderText = "Monto del Credito";
            this.MontoCredito.MinimumWidth = 8;
            this.MontoCredito.Name = "MontoCredito";
            this.MontoCredito.Width = 150;
            // 
            // Tasa
            // 
            this.Tasa.HeaderText = "Tasa";
            this.Tasa.MinimumWidth = 8;
            this.Tasa.Name = "Tasa";
            this.Tasa.Width = 150;
            // 
            // MontoCuota
            // 
            this.MontoCuota.HeaderText = "Monto por Cuota";
            this.MontoCuota.MinimumWidth = 8;
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.Width = 150;
            // 
            // CantidadCuotasPagadas
            // 
            this.CantidadCuotasPagadas.HeaderText = "Cantidad de Cuotas Pagadas";
            this.CantidadCuotasPagadas.MinimumWidth = 8;
            this.CantidadCuotasPagadas.Name = "CantidadCuotasPagadas";
            this.CantidadCuotasPagadas.Width = 150;
            // 
            // CantidadCuotasFaltantes
            // 
            this.CantidadCuotasFaltantes.HeaderText = "Cantidad de Cuotas Faltantes";
            this.CantidadCuotasFaltantes.MinimumWidth = 8;
            this.CantidadCuotasFaltantes.Name = "CantidadCuotasFaltantes";
            this.CantidadCuotasFaltantes.Width = 150;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 150;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 8;
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 150;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(1598, 345);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(154, 29);
            this.buttonActualizar.TabIndex = 7;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 636);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCargarPrestamo);
            this.Controls.Add(this.buttonVolverPrincipal);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGrillaPrestamos";
            this.Text = "FormGrillaPrestamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGrillaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarPrestamo;
        private System.Windows.Forms.Button buttonVolverPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniClienteAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComercioAdherido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCuotasPagadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCuotasFaltantes;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.DataGridViewLinkColumn Detalle;
        private System.Windows.Forms.Button buttonActualizar;
    }
}