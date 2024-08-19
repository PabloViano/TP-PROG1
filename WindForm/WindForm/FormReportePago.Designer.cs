namespace WindForm
{
    partial class FormReportePago
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
            this.buttonVolverPrincipal = new System.Windows.Forms.Button();
            this.labelMontoTotalCuotasPagadas = new System.Windows.Forms.Label();
            this.labelMontoCuotasPagadas = new System.Windows.Forms.Label();
            this.labelMontoPromedioTasaInteres = new System.Windows.Forms.Label();
            this.labelPromedioTasaInteres = new System.Windows.Forms.Label();
            this.labelMontoTotalDineroPrestado = new System.Windows.Forms.Label();
            this.labelMontoDineroPrestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVolverPrincipal
            // 
            this.buttonVolverPrincipal.Location = new System.Drawing.Point(520, 89);
            this.buttonVolverPrincipal.Name = "buttonVolverPrincipal";
            this.buttonVolverPrincipal.Size = new System.Drawing.Size(225, 29);
            this.buttonVolverPrincipal.TabIndex = 13;
            this.buttonVolverPrincipal.Text = "Volver";
            this.buttonVolverPrincipal.UseVisualStyleBackColor = true;
            this.buttonVolverPrincipal.Click += new System.EventHandler(this.buttonVolverPrincipal_Click);
            // 
            // labelMontoTotalCuotasPagadas
            // 
            this.labelMontoTotalCuotasPagadas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMontoTotalCuotasPagadas.Location = new System.Drawing.Point(519, 34);
            this.labelMontoTotalCuotasPagadas.Name = "labelMontoTotalCuotasPagadas";
            this.labelMontoTotalCuotasPagadas.Size = new System.Drawing.Size(226, 20);
            this.labelMontoTotalCuotasPagadas.TabIndex = 12;
            // 
            // labelMontoCuotasPagadas
            // 
            this.labelMontoCuotasPagadas.AutoSize = true;
            this.labelMontoCuotasPagadas.Location = new System.Drawing.Point(519, 14);
            this.labelMontoCuotasPagadas.Name = "labelMontoCuotasPagadas";
            this.labelMontoCuotasPagadas.Size = new System.Drawing.Size(229, 20);
            this.labelMontoCuotasPagadas.TabIndex = 11;
            this.labelMontoCuotasPagadas.Text = "Monto total de cuotas pagadas";
            // 
            // labelMontoPromedioTasaInteres
            // 
            this.labelMontoPromedioTasaInteres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMontoPromedioTasaInteres.Location = new System.Drawing.Point(270, 34);
            this.labelMontoPromedioTasaInteres.Name = "labelMontoPromedioTasaInteres";
            this.labelMontoPromedioTasaInteres.Size = new System.Drawing.Size(226, 20);
            this.labelMontoPromedioTasaInteres.TabIndex = 10;
            // 
            // labelPromedioTasaInteres
            // 
            this.labelPromedioTasaInteres.AutoSize = true;
            this.labelPromedioTasaInteres.Location = new System.Drawing.Point(270, 14);
            this.labelPromedioTasaInteres.Name = "labelPromedioTasaInteres";
            this.labelPromedioTasaInteres.Size = new System.Drawing.Size(185, 20);
            this.labelPromedioTasaInteres.TabIndex = 9;
            this.labelPromedioTasaInteres.Text = "Promedio de tasa interes";
            // 
            // labelMontoTotalDineroPrestado
            // 
            this.labelMontoTotalDineroPrestado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMontoTotalDineroPrestado.Location = new System.Drawing.Point(16, 34);
            this.labelMontoTotalDineroPrestado.Name = "labelMontoTotalDineroPrestado";
            this.labelMontoTotalDineroPrestado.Size = new System.Drawing.Size(226, 20);
            this.labelMontoTotalDineroPrestado.TabIndex = 8;
            // 
            // labelMontoDineroPrestado
            // 
            this.labelMontoDineroPrestado.AutoSize = true;
            this.labelMontoDineroPrestado.Location = new System.Drawing.Point(16, 14);
            this.labelMontoDineroPrestado.Name = "labelMontoDineroPrestado";
            this.labelMontoDineroPrestado.Size = new System.Drawing.Size(226, 20);
            this.labelMontoDineroPrestado.TabIndex = 7;
            this.labelMontoDineroPrestado.Text = "Monto total de dinero prestado";
            // 
            // FormReportePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 235);
            this.Controls.Add(this.buttonVolverPrincipal);
            this.Controls.Add(this.labelMontoTotalCuotasPagadas);
            this.Controls.Add(this.labelMontoCuotasPagadas);
            this.Controls.Add(this.labelMontoPromedioTasaInteres);
            this.Controls.Add(this.labelPromedioTasaInteres);
            this.Controls.Add(this.labelMontoTotalDineroPrestado);
            this.Controls.Add(this.labelMontoDineroPrestado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReportePago";
            this.Text = "FormReportePago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverPrincipal;
        private System.Windows.Forms.Label labelMontoTotalCuotasPagadas;
        private System.Windows.Forms.Label labelMontoCuotasPagadas;
        private System.Windows.Forms.Label labelMontoPromedioTasaInteres;
        private System.Windows.Forms.Label labelPromedioTasaInteres;
        private System.Windows.Forms.Label labelMontoTotalDineroPrestado;
        private System.Windows.Forms.Label labelMontoDineroPrestado;
    }
}