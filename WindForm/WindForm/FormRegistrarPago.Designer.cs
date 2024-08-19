namespace WindForm
{
    partial class FormRegistrarPago
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
            this.textBoxIDLugarPago = new System.Windows.Forms.TextBox();
            this.labelIDLugarPago = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonPagarPago = new System.Windows.Forms.Button();
            this.textBoxCantidadCuotas = new System.Windows.Forms.TextBox();
            this.labelCantidadCuotasFaltantes = new System.Windows.Forms.Label();
            this.textBoxMontoCredito = new System.Windows.Forms.TextBox();
            this.labelCantidadCuotasPagadas = new System.Windows.Forms.Label();
            this.labelFechaCredito = new System.Windows.Forms.Label();
            this.textBoxNumeroCredito = new System.Windows.Forms.TextBox();
            this.labelNumeroCredito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIDLugarPago
            // 
            this.textBoxIDLugarPago.Location = new System.Drawing.Point(11, 24);
            this.textBoxIDLugarPago.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDLugarPago.Name = "textBoxIDLugarPago";
            this.textBoxIDLugarPago.Size = new System.Drawing.Size(96, 20);
            this.textBoxIDLugarPago.TabIndex = 73;
            // 
            // labelIDLugarPago
            // 
            this.labelIDLugarPago.AutoSize = true;
            this.labelIDLugarPago.Location = new System.Drawing.Point(11, 9);
            this.labelIDLugarPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDLugarPago.Name = "labelIDLugarPago";
            this.labelIDLugarPago.Size = new System.Drawing.Size(91, 13);
            this.labelIDLugarPago.TabIndex = 72;
            this.labelIDLugarPago.Text = "ID Lugar de Pago";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // buttonPagarPago
            // 
            this.buttonPagarPago.Location = new System.Drawing.Point(312, 96);
            this.buttonPagarPago.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPagarPago.Name = "buttonPagarPago";
            this.buttonPagarPago.Size = new System.Drawing.Size(95, 25);
            this.buttonPagarPago.TabIndex = 70;
            this.buttonPagarPago.Text = "Pagar";
            this.buttonPagarPago.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidadCuotas
            // 
            this.textBoxCantidadCuotas.Location = new System.Drawing.Point(162, 74);
            this.textBoxCantidadCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantidadCuotas.Name = "textBoxCantidadCuotas";
            this.textBoxCantidadCuotas.Size = new System.Drawing.Size(96, 20);
            this.textBoxCantidadCuotas.TabIndex = 69;
            this.textBoxCantidadCuotas.Visible = false;
            // 
            // labelCantidadCuotasFaltantes
            // 
            this.labelCantidadCuotasFaltantes.AutoSize = true;
            this.labelCantidadCuotasFaltantes.Location = new System.Drawing.Point(159, 59);
            this.labelCantidadCuotasFaltantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadCuotasFaltantes.Name = "labelCantidadCuotasFaltantes";
            this.labelCantidadCuotasFaltantes.Size = new System.Drawing.Size(146, 13);
            this.labelCantidadCuotasFaltantes.TabIndex = 68;
            this.labelCantidadCuotasFaltantes.Text = "Cantidad de Cuotas Faltantes";
            this.labelCantidadCuotasFaltantes.Visible = false;
            // 
            // textBoxMontoCredito
            // 
            this.textBoxMontoCredito.Location = new System.Drawing.Point(11, 74);
            this.textBoxMontoCredito.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMontoCredito.Name = "textBoxMontoCredito";
            this.textBoxMontoCredito.Size = new System.Drawing.Size(96, 20);
            this.textBoxMontoCredito.TabIndex = 67;
            this.textBoxMontoCredito.Visible = false;
            // 
            // labelCantidadCuotasPagadas
            // 
            this.labelCantidadCuotasPagadas.AutoSize = true;
            this.labelCantidadCuotasPagadas.Location = new System.Drawing.Point(8, 59);
            this.labelCantidadCuotasPagadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadCuotasPagadas.Name = "labelCantidadCuotasPagadas";
            this.labelCantidadCuotasPagadas.Size = new System.Drawing.Size(145, 13);
            this.labelCantidadCuotasPagadas.TabIndex = 66;
            this.labelCantidadCuotasPagadas.Text = "Cantidad de Cuotas Pagadas";
            this.labelCantidadCuotasPagadas.Visible = false;
            // 
            // labelFechaCredito
            // 
            this.labelFechaCredito.AutoSize = true;
            this.labelFechaCredito.Location = new System.Drawing.Point(159, 9);
            this.labelFechaCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaCredito.Name = "labelFechaCredito";
            this.labelFechaCredito.Size = new System.Drawing.Size(90, 13);
            this.labelFechaCredito.TabIndex = 65;
            this.labelFechaCredito.Text = "Fecha del Credito";
            // 
            // textBoxNumeroCredito
            // 
            this.textBoxNumeroCredito.Location = new System.Drawing.Point(312, 24);
            this.textBoxNumeroCredito.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroCredito.Name = "textBoxNumeroCredito";
            this.textBoxNumeroCredito.Size = new System.Drawing.Size(96, 20);
            this.textBoxNumeroCredito.TabIndex = 64;
            this.textBoxNumeroCredito.Visible = false;
            // 
            // labelNumeroCredito
            // 
            this.labelNumeroCredito.AutoSize = true;
            this.labelNumeroCredito.Location = new System.Drawing.Point(312, 9);
            this.labelNumeroCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroCredito.Name = "labelNumeroCredito";
            this.labelNumeroCredito.Size = new System.Drawing.Size(95, 13);
            this.labelNumeroCredito.TabIndex = 63;
            this.labelNumeroCredito.Text = "Numero de Credito";
            this.labelNumeroCredito.Visible = false;
            // 
            // FormRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 178);
            this.Controls.Add(this.textBoxIDLugarPago);
            this.Controls.Add(this.labelIDLugarPago);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonPagarPago);
            this.Controls.Add(this.textBoxCantidadCuotas);
            this.Controls.Add(this.labelCantidadCuotasFaltantes);
            this.Controls.Add(this.textBoxMontoCredito);
            this.Controls.Add(this.labelCantidadCuotasPagadas);
            this.Controls.Add(this.labelFechaCredito);
            this.Controls.Add(this.textBoxNumeroCredito);
            this.Controls.Add(this.labelNumeroCredito);
            this.Name = "FormRegistrarPago";
            this.Text = "FormRegistrarPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDLugarPago;
        private System.Windows.Forms.Label labelIDLugarPago;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonPagarPago;
        private System.Windows.Forms.TextBox textBoxCantidadCuotas;
        private System.Windows.Forms.Label labelCantidadCuotasFaltantes;
        private System.Windows.Forms.TextBox textBoxMontoCredito;
        private System.Windows.Forms.Label labelCantidadCuotasPagadas;
        private System.Windows.Forms.Label labelFechaCredito;
        private System.Windows.Forms.TextBox textBoxNumeroCredito;
        private System.Windows.Forms.Label labelNumeroCredito;
    }
}