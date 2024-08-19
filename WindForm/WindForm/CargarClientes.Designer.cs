namespace WindForm
{
    partial class CargarClientes
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
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelTipoCliente = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.textBoxNumeroCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNombreApellido = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.radioButtonDNI = new System.Windows.Forms.RadioButton();
            this.radioButtonLC = new System.Windows.Forms.RadioButton();
            this.radioButtonLE = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoCliente = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonVIP = new System.Windows.Forms.RadioButton();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.labelMontoMaximo = new System.Windows.Forms.Label();
            this.textBoxMontoMaximo = new System.Windows.Forms.TextBox();
            this.groupBoxTipoCliente.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.Location = new System.Drawing.Point(386, 343);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(129, 35);
            this.buttonGuardarCliente.TabIndex = 46;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = true;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(381, 268);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(142, 26);
            this.textBoxLocalidad.TabIndex = 45;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(376, 245);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(77, 20);
            this.labelLocalidad.TabIndex = 44;
            this.labelLocalidad.Text = "Localidad";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(201, 268);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(142, 26);
            this.textBoxCP.TabIndex = 43;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(196, 245);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(107, 20);
            this.labelCP.TabIndex = 42;
            this.labelCP.Text = "Codigo Postal";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(376, 14);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 40;
            this.labelSexo.Text = "Sexo";
            // 
            // labelTipoCliente
            // 
            this.labelTipoCliente.AutoSize = true;
            this.labelTipoCliente.Location = new System.Drawing.Point(196, 14);
            this.labelTipoCliente.Name = "labelTipoCliente";
            this.labelTipoCliente.Size = new System.Drawing.Size(114, 20);
            this.labelTipoCliente.TabIndex = 38;
            this.labelTipoCliente.Text = "Tipo de Cliente";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(201, 195);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(296, 26);
            this.dateTimePickerFechaNacimiento.TabIndex = 37;
            this.dateTimePickerFechaNacimiento.Value = new System.DateTime(2001, 12, 11, 0, 0, 0, 0);
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(196, 174);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(159, 20);
            this.labelFechaNacimiento.TabIndex = 36;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(22, 268);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(142, 26);
            this.textBoxDomicilio.TabIndex = 35;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(18, 245);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(72, 20);
            this.labelDomicilio.TabIndex = 34;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // textBoxNumeroCelular
            // 
            this.textBoxNumeroCelular.Location = new System.Drawing.Point(201, 135);
            this.textBoxNumeroCelular.Name = "textBoxNumeroCelular";
            this.textBoxNumeroCelular.Size = new System.Drawing.Size(142, 26);
            this.textBoxNumeroCelular.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Numero Celular";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(381, 135);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(142, 26);
            this.textBoxEmail.TabIndex = 31;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(376, 112);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email";
            // 
            // textBoxNombreApellido
            // 
            this.textBoxNombreApellido.Location = new System.Drawing.Point(22, 195);
            this.textBoxNombreApellido.Name = "textBoxNombreApellido";
            this.textBoxNombreApellido.Size = new System.Drawing.Size(142, 26);
            this.textBoxNombreApellido.TabIndex = 29;
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(22, 135);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(142, 26);
            this.textBoxNumeroDocumento.TabIndex = 28;
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(18, 174);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(136, 20);
            this.labelNombreApellido.TabIndex = 26;
            this.labelNombreApellido.Text = "Nombre y Apellido";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(16, 112);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(174, 20);
            this.labelNumeroDocumento.TabIndex = 25;
            this.labelNumeroDocumento.Text = "Numero de Documento";
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(16, 14);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(148, 20);
            this.labelTipoDocumento.TabIndex = 24;
            this.labelTipoDocumento.Text = "Tipo de Documento";
            // 
            // radioButtonDNI
            // 
            this.radioButtonDNI.AutoSize = true;
            this.radioButtonDNI.Location = new System.Drawing.Point(38, 37);
            this.radioButtonDNI.Name = "radioButtonDNI";
            this.radioButtonDNI.Size = new System.Drawing.Size(62, 24);
            this.radioButtonDNI.TabIndex = 47;
            this.radioButtonDNI.TabStop = true;
            this.radioButtonDNI.Text = "DNI";
            this.radioButtonDNI.UseVisualStyleBackColor = true;
            // 
            // radioButtonLC
            // 
            this.radioButtonLC.AutoSize = true;
            this.radioButtonLC.Location = new System.Drawing.Point(38, 61);
            this.radioButtonLC.Name = "radioButtonLC";
            this.radioButtonLC.Size = new System.Drawing.Size(54, 24);
            this.radioButtonLC.TabIndex = 48;
            this.radioButtonLC.TabStop = true;
            this.radioButtonLC.Text = "LC";
            this.radioButtonLC.UseVisualStyleBackColor = true;
            // 
            // radioButtonLE
            // 
            this.radioButtonLE.AutoSize = true;
            this.radioButtonLE.Location = new System.Drawing.Point(38, 85);
            this.radioButtonLE.Name = "radioButtonLE";
            this.radioButtonLE.Size = new System.Drawing.Size(54, 24);
            this.radioButtonLE.TabIndex = 49;
            this.radioButtonLE.TabStop = true;
            this.radioButtonLE.Text = "LE";
            this.radioButtonLE.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoCliente
            // 
            this.groupBoxTipoCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTipoCliente.Controls.Add(this.radioButtonRegular);
            this.groupBoxTipoCliente.Controls.Add(this.radioButtonVIP);
            this.groupBoxTipoCliente.Location = new System.Drawing.Point(200, 35);
            this.groupBoxTipoCliente.Name = "groupBoxTipoCliente";
            this.groupBoxTipoCliente.Size = new System.Drawing.Size(142, 72);
            this.groupBoxTipoCliente.TabIndex = 50;
            this.groupBoxTipoCliente.TabStop = false;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(6, 43);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(114, 24);
            this.radioButtonRegular.TabIndex = 52;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "REGULAR";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonVIP
            // 
            this.radioButtonVIP.AutoSize = true;
            this.radioButtonVIP.Location = new System.Drawing.Point(6, 13);
            this.radioButtonVIP.Name = "radioButtonVIP";
            this.radioButtonVIP.Size = new System.Drawing.Size(60, 24);
            this.radioButtonVIP.TabIndex = 51;
            this.radioButtonVIP.TabStop = true;
            this.radioButtonVIP.Text = "VIP";
            this.radioButtonVIP.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSexo.Controls.Add(this.radioButtonFemenino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(380, 35);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(142, 72);
            this.groupBoxSexo.TabIndex = 53;
            this.groupBoxSexo.TabStop = false;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(6, 43);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(118, 24);
            this.radioButtonFemenino.TabIndex = 52;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "FEMENINO";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 13);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(129, 24);
            this.radioButtonMasculino.TabIndex = 51;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "MASCULINO";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // labelMontoMaximo
            // 
            this.labelMontoMaximo.AutoSize = true;
            this.labelMontoMaximo.Location = new System.Drawing.Point(18, 324);
            this.labelMontoMaximo.Name = "labelMontoMaximo";
            this.labelMontoMaximo.Size = new System.Drawing.Size(112, 20);
            this.labelMontoMaximo.TabIndex = 54;
            this.labelMontoMaximo.Text = "Monto Maximo";
            // 
            // textBoxMontoMaximo
            // 
            this.textBoxMontoMaximo.Location = new System.Drawing.Point(20, 347);
            this.textBoxMontoMaximo.Name = "textBoxMontoMaximo";
            this.textBoxMontoMaximo.Size = new System.Drawing.Size(142, 26);
            this.textBoxMontoMaximo.TabIndex = 55;
            // 
            // CargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 408);
            this.Controls.Add(this.textBoxMontoMaximo);
            this.Controls.Add(this.labelMontoMaximo);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.groupBoxTipoCliente);
            this.Controls.Add(this.radioButtonLE);
            this.Controls.Add(this.radioButtonLC);
            this.Controls.Add(this.radioButtonDNI);
            this.Controls.Add(this.buttonGuardarCliente);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelTipoCliente);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.textBoxNumeroCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNombreApellido);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.labelNombreApellido);
            this.Controls.Add(this.labelNumeroDocumento);
            this.Controls.Add(this.labelTipoDocumento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargarClientes";
            this.Text = "CargarClientes";
            this.groupBoxTipoCliente.ResumeLayout(false);
            this.groupBoxTipoCliente.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelTipoCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.TextBox textBoxNumeroCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNombreApellido;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.RadioButton radioButtonDNI;
        private System.Windows.Forms.RadioButton radioButtonLC;
        private System.Windows.Forms.RadioButton radioButtonLE;
        private System.Windows.Forms.GroupBox groupBoxTipoCliente;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonVIP;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label labelMontoMaximo;
        private System.Windows.Forms.TextBox textBoxMontoMaximo;
    }
}