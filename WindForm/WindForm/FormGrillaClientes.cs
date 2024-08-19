using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica2;

namespace WindForm
{
    public partial class FormGrillaClientes : Form, IAdministrarClientes
    {
        List<Cliente> Clientes = new List<Cliente>();
        public FormGrillaClientes()
        {
            InitializeComponent();
        }
        private void FormGrillaClientes_Load(object sender, EventArgs e)
        {
            IFormPrincipal formPrincipal = this.Owner as IFormPrincipal;
            Clientes = formPrincipal.ObtenerListaClientes();

            dataGridViewClientes.DataSource = Clientes;
            CargarDataGridView();
        }
        private void CargarDataGridView()
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = Clientes;
        }
        private void buttonVolverPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool GuardarCliente(Cliente cliente)
        {        
            IAdministrarClientes formPrincipal = this.Owner as IAdministrarClientes;
            formPrincipal.GuardarCliente(cliente);

            return true;
        }
        public bool EliminarCliente(Cliente cliente)
        {
            IAdministrarClientes formPrincipal = this.Owner as IAdministrarClientes;
            formPrincipal.EliminarCliente(cliente);

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarClientes cargarClientes = new CargarClientes();
            cargarClientes.Owner = this;
            cargarClientes.ShowDialog();
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
    }
}
