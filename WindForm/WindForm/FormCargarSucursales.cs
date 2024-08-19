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
    public partial class FormCargarSucursales : Form,IPasaSucursal
    {
        public FormCargarSucursales()
        {
            InitializeComponent();
        }
        public bool PasarSucursal(Sucursal sucursal)
        {
            IFormPrincipal formPrincipal = this.Owner as IFormPrincipal;
            formPrincipal.GuardarSucursal(sucursal);

            return true;
        }
        private void buttonGuardarSucursal_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxIDSucursal.Text);
            string Direccion = textBoxDireccionSucursal.Text;
            int TasaInteres = int.Parse(textBoxTasaInteresSucursal.Text);
            int CodigoPostal = int.Parse(textBoxCPSucursal.Text);
            string Ciudad = textBoxCiudadSucursal.Text;

            Sucursal nuevaSucursal = new Sucursal(ID,Ciudad,Direccion,CodigoPostal,TasaInteres);
            PasarSucursal(nuevaSucursal);

            this.Close();
        }
    }
}
