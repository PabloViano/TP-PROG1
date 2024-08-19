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
    public partial class Form1 : Form,IFormPrincipal,IAdministrarClientes,IAdministrarPrestamos
    {
        CredArg logica = new CredArg();
        public Form1()
        {
            InitializeComponent();
        }
        private void ListasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrillaClientes formGrillaClientes = new FormGrillaClientes();
            formGrillaClientes.Owner = this;
            formGrillaClientes.Show();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        
        }
        private void PrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrillaPrestamos formGrillaPrestamos = new FormGrillaPrestamos();
            formGrillaPrestamos.Owner = this;
            formGrillaPrestamos.Show();
        }
        private void SucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void LugaresDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ComerciosAdheridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportePago formReportePago = new FormReportePago();
            formReportePago.Owner = this;
            formReportePago.Show();
        }
        private void CreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrillaPrestamos formGrillaPrestamos = new FormGrillaPrestamos();
            formGrillaPrestamos.Owner = this;
            formGrillaPrestamos.Show();
        }
        public bool GuardarCliente(Cliente cliente)
        {
            logica.DarAltaCliente(cliente.TipoDocumento,cliente.NumeroDocumento,cliente.NombreApellido,cliente.Email,cliente.MontoMaximo,cliente.TipoCliente,cliente.Celular,cliente.FechaNac,cliente.Sexo,cliente.Domicilio,cliente.CP,cliente.Localidad);
            return true;
        }
        public bool EliminarCliente(Cliente cliente)
        {
            logica.DarBajaCliente(cliente.TipoDocumento,cliente.NumeroDocumento);
            return true;
        }
        public List<Cliente> ObtenerListaClientes()
        {
            return logica.LeerClientes();
        }
        public List<Prestamo> ObtenerListaPrestamos()
        {
            return logica.LeerPrestamo();
        }
        public List<Sucursal> ObtenerListaSucursales()
        {
            return logica.LeerSucursales();
        }
        public List<ComercioAdherido> ObtenerListaComercios()
        {
             return logica.LeerComercios();
        }
        public List<LugarPago> ObtenerListaLugares()
        {
            return logica.LeerLugares();
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarSucursales formCargarSucursales = new FormCargarSucursales();
            formCargarSucursales.Owner = this;
            formCargarSucursales.Show();
        }
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCargarLugarPago formCargarLugarPago = new FormCargarLugarPago();
            formCargarLugarPago.Owner = this;
            formCargarLugarPago.Show();
        }
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCargarComercioAdherido formCargarComercioAdherido = new FormCargarComercioAdherido();
            formCargarComercioAdherido.Owner = this;
            formCargarComercioAdherido.Show();
        }
        public bool GuardarPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas)
        {
            logica.DarAltaPrestamo(cliente, comercioAdherido, sucursal, montoCredito, cantidadCuotas);
            return true;
        }
        public bool EliminarPrestamo(int nroPrestamo)
        {
            logica.DarBajaPrestamo(nroPrestamo);
            return true;
        }
        public Cliente BuscarCliente(tipoDocumento tipoDocumento, int NumeroDocumento)
        {
            return logica.BuscarCliente(tipoDocumento, NumeroDocumento);
        }
        public Sucursal BuscarSucursal(int IDSucursal)
        {
            return logica.BuscarSucursal(IDSucursal);
        }
        public ComercioAdherido BuscarComercio(int IDComercio)
        {
            return logica.BuscarComercio(IDComercio);
        }
        public bool GuardarSucursal(Sucursal sucursal)
        {
            logica.DarAltaSucursal(sucursal.ID, sucursal.Ciudad, sucursal.Direccion, sucursal.CP, sucursal.TasaInteres);
            return true;
        }
        public bool GuardarComercio(ComercioAdherido comercio)
        {
            logica.DarAltaComercio(comercio.ID, comercio.Ciudad, comercio.Direccion, comercio.CP, comercio.RazonSocial);
            return true;
        }
        public bool GuardarLugar(LugarPago lugarPago)
        {
            logica.DarAltaLugarPago(lugarPago.ID, lugarPago.Ciudad, lugarPago.Direccion, lugarPago.CP, lugarPago.RazonSocial, lugarPago.EsSucursal);
            return true;
        }
    }
}
