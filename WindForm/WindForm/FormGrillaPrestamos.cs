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
    public partial class FormGrillaPrestamos : Form,IAdministrarPrestamos
    {
        List<Prestamo> Prestamos = new List<Prestamo>();
        public FormGrillaPrestamos()
        {
            InitializeComponent();
        }
        private void FormGrillaPrestamos_Load(object sender, EventArgs e)
        {
            IFormPrincipal formPrincipal = this.Owner as IFormPrincipal;
            Prestamos = formPrincipal.ObtenerListaPrestamos();

            dataGridViewPrestamos.DataSource = Prestamos;
            CargarDataGridView();
        }
        private void CargarDataGridView()
        {
            dataGridViewPrestamos.AutoGenerateColumns = false;
            dataGridViewPrestamos.DataSource = null;
            dataGridViewPrestamos.DataSource = Prestamos;
        }
        private void buttonVolverPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCargarPrestamo_Click(object sender, EventArgs e)
        {
            CargarPrestamo cargarPrestamos = new CargarPrestamo();
            cargarPrestamos.Owner = this;
            cargarPrestamos.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
        public bool GuardarPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas)
        {
            IAdministrarPrestamos formPrincipal = this.Owner as IAdministrarPrestamos;
            formPrincipal.GuardarPrestamo( cliente, comercioAdherido, sucursal, montoCredito, cantidadCuotas);

            return true;
        }
        public bool EliminarPrestamo(int nroPrestamo)
        {
            IAdministrarPrestamos formPrincipal = this.Owner as IAdministrarPrestamos;
            formPrincipal.EliminarPrestamo(nroPrestamo);

            return true;
        }
        public Cliente BuscarCliente(tipoDocumento tipoDocumento, int NumeroDocumento)
        {
            IAdministrarPrestamos formPrincipal = this.Owner as IAdministrarPrestamos;
            Cliente cliente = formPrincipal.BuscarCliente(tipoDocumento,NumeroDocumento);

            return cliente;
        }
        public Sucursal BuscarSucursal(int IDSucursal)
        {
            IAdministrarPrestamos formPrincipal = this.Owner as IAdministrarPrestamos;
            Sucursal sucursal = formPrincipal.BuscarSucursal(IDSucursal);

            return sucursal;
        }
        public ComercioAdherido BuscarComercio(int IDComercio)
        {
            IAdministrarPrestamos formPrincipal = this.Owner as IAdministrarPrestamos;
            ComercioAdherido comercio = formPrincipal.BuscarComercio(IDComercio);

            return comercio;
        }
    }
}
