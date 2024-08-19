namespace WindForm
{
    partial class FormGrillaClientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVolverPrincipal = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1492, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cargar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVolverPrincipal
            // 
            this.buttonVolverPrincipal.Location = new System.Drawing.Point(1492, 510);
            this.buttonVolverPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVolverPrincipal.Name = "buttonVolverPrincipal";
            this.buttonVolverPrincipal.Size = new System.Drawing.Size(119, 23);
            this.buttonVolverPrincipal.TabIndex = 4;
            this.buttonVolverPrincipal.Text = "Volver";
            this.buttonVolverPrincipal.UseVisualStyleBackColor = true;
            this.buttonVolverPrincipal.Click += new System.EventHandler(this.buttonVolverPrincipal_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDocumento,
            this.NombreApellido,
            this.Email,
            this.Celular,
            this.FechaNacimiento,
            this.Sexo,
            this.Domicilio,
            this.CodigoPostal,
            this.Localidad,
            this.tipoCliente,
            this.MontoMaximo,
            this.Editar,
            this.Eliminar});
            this.dataGridViewClientes.Location = new System.Drawing.Point(9, 0);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 62;
            this.dataGridViewClientes.RowTemplate.Height = 28;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1601, 458);
            this.dataGridViewClientes.TabIndex = 3;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "Tipo de Documento";
            this.tipoDocumento.MinimumWidth = 8;
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Width = 150;
            // 
            // NombreApellido
            // 
            this.NombreApellido.DataPropertyName = "NombreApellido";
            this.NombreApellido.HeaderText = "Nombre y Apellido";
            this.NombreApellido.MinimumWidth = 8;
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 8;
            this.Celular.Name = "Celular";
            this.Celular.Width = 150;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNac";
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 8;
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 150;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 8;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 150;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.DataPropertyName = "CP";
            this.CodigoPostal.HeaderText = "Codigo Postal";
            this.CodigoPostal.MinimumWidth = 8;
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Width = 150;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.Width = 150;
            // 
            // tipoCliente
            // 
            this.tipoCliente.DataPropertyName = "tipoCliente";
            this.tipoCliente.HeaderText = "Tipo de Cliente";
            this.tipoCliente.MinimumWidth = 8;
            this.tipoCliente.Name = "tipoCliente";
            this.tipoCliente.Width = 150;
            // 
            // MontoMaximo
            // 
            this.MontoMaximo.DataPropertyName = "MontoMaximo";
            this.MontoMaximo.HeaderText = "Monto Maximo a Autorizar";
            this.MontoMaximo.MinimumWidth = 8;
            this.MontoMaximo.Name = "MontoMaximo";
            this.MontoMaximo.Width = 150;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.Width = 150;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 150;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(1359, 482);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(119, 23);
            this.buttonActualizar.TabIndex = 6;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // FormGrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1622, 547);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVolverPrincipal);
            this.Controls.Add(this.dataGridViewClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGrillaClientes";
            this.Text = "FormGrillaCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGrillaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVolverPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMaximo;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}