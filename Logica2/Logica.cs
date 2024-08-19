using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logica2
{
    public class CredArg
    {
        List<Sucursal> Sucursales;
        List<LugarPago> LugaresPago;
        List<ComercioAdherido> Comercios;
        List<Cliente> Clientes;
        List<Prestamo> Prestamos;
        public CredArg()
        {
            Sucursales = new List<Sucursal>();
            LugaresPago = new List<LugarPago>();
            Comercios = new List<ComercioAdherido>();
            Clientes = new List<Cliente>();
            Prestamos = new List<Prestamo>();
        }

        string pathClientes = @"D:\Pablo\Universidad\Programacion\prog1-tp-net-2021-sotelo-viano-zbrun-20240819T124249Z-001\prog1-tp-net-2021-sotelo-viano-zbrun\Listas\Clientes.txt";
        string pathPrestamos = @"D:\Pablo\Universidad\Programacion\prog1-tp-net-2021-sotelo-viano-zbrun-20240819T124249Z-001\prog1-tp-net-2021-sotelo-viano-zbrun\Listas\Prestamos.txt";
        string pathSucursales = @"D:\Pablo\Universidad\Programacion\prog1-tp-net-2021-sotelo-viano-zbrun-20240819T124249Z-001\prog1-tp-net-2021-sotelo-viano-zbrun\Listas\Sucursales.txt";
        string pathComercios = @"D:\Pablo\Universidad\Programacion\prog1-tp-net-2021-sotelo-viano-zbrun-20240819T124249Z-001\prog1-tp-net-2021-sotelo-viano-zbrun\Listas\Comercios.txt";
        string pathLugares = @"D:\Pablo\Universidad\Programacion\prog1-tp-net-2021-sotelo-viano-zbrun-20240819T124249Z-001\prog1-tp-net-2021-sotelo-viano-zbrun\Listas\Lugares.txt";
        public List<Cliente> LeerClientes()
        {
            if (File.Exists(pathClientes))
            {
                using (StreamReader reader = new StreamReader(pathClientes))
                {
                    string cliente = reader.ReadToEnd();
                    if (cliente != "")
                    {
                        Clientes = JsonConvert.DeserializeObject<List<Cliente>>(cliente);
                    }
                }
            }
            return Clientes;
        }
        public List<Prestamo> LeerPrestamo()
        {
            if (File.Exists(pathPrestamos))
            {
                using (StreamReader reader = new StreamReader(pathPrestamos))
                {
                    string prestamo = reader.ReadToEnd();
                    Prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(prestamo);
                }

            }

            return Prestamos;
        }
        public List<Sucursal> LeerSucursales()
        {
            if (File.Exists(pathSucursales))
            {
                using (StreamReader reader = new StreamReader(pathSucursales))
                {
                    string sucursal = reader.ReadToEnd();
                    Sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(sucursal);
                }
            }

            return Sucursales;
        }
        public List<ComercioAdherido> LeerComercios()
        {
            if (File.Exists(pathComercios))
            {
                using (StreamReader reader = new StreamReader(pathComercios))
                {
                    string comercio = reader.ReadToEnd();
                    Comercios = JsonConvert.DeserializeObject<List<ComercioAdherido>>(comercio);
                }
            }

            return Comercios;
        }
        public List<LugarPago> LeerLugares()
        {
            if (File.Exists(pathLugares))
            {
                using (StreamReader reader = new StreamReader(pathLugares))
                {
                    string lugar = reader.ReadToEnd();
                    LugaresPago = JsonConvert.DeserializeObject<List<LugarPago>>(lugar);
                }
            }

            return LugaresPago;
        }
        public void GuardarListadoPrestamos(List<Prestamo> PrestamosListado)
        {
            if (!File.Exists(pathPrestamos))
            {
                File.Create(pathPrestamos);
                using (StreamWriter writer = new StreamWriter(pathPrestamos, false))
                {
                    string prestamoJson = JsonConvert.SerializeObject(PrestamosListado);
                    writer.Write(prestamoJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathPrestamos, false))
                {
                    string prestamoJson = JsonConvert.SerializeObject(PrestamosListado);
                    writer.Write(prestamoJson);
                }
            }
        }
        public void GuardarListadoClientes(List<Cliente> ClientesListado)
        {
            if (!File.Exists(pathClientes))
            {
                File.Create(pathClientes);
                using (StreamWriter writer = new StreamWriter(pathClientes,false))
                {
                    string clienteJson = JsonConvert.SerializeObject(ClientesListado);
                    writer.Write(clienteJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathClientes, false))
                {
                    string clienteJson = JsonConvert.SerializeObject(ClientesListado);
                    writer.Write(clienteJson);
                }
            }
        }
        public void GuardarListadoSucursales(List<Sucursal> SucursalesListado)
        {
            if (!File.Exists(pathSucursales))
            {
                File.Create(pathSucursales);
                using (StreamWriter writer = new StreamWriter(pathSucursales, false))
                {
                    string sucursalJson = JsonConvert.SerializeObject(SucursalesListado);
                    writer.Write(sucursalJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathSucursales, false))
                {
                    string sucursalJson = JsonConvert.SerializeObject(SucursalesListado);
                    writer.Write(sucursalJson);
                }
            }
        }
        public void GuardarListadoComercios(List<ComercioAdherido> ComerciosListado)
        {
            if (!File.Exists(pathComercios))
            {
                File.Create(pathComercios);
                using (StreamWriter writer = new StreamWriter(pathComercios, false))
                {
                    string comercioJson = JsonConvert.SerializeObject(ComerciosListado);
                    writer.Write(comercioJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathComercios, false))
                {
                    string comercioJson = JsonConvert.SerializeObject(ComerciosListado);
                    writer.Write(comercioJson);
                }
            }
        }
        public void GuardarListadoLugares(List<LugarPago> LugaresListado)
        {
            if (!File.Exists(pathLugares))
            {
                File.Create(pathLugares);
                using (StreamWriter writer = new StreamWriter(pathLugares, false))
                {
                    string lugarJson = JsonConvert.SerializeObject(LugaresListado);
                    writer.Write(lugarJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathLugares, false))
                {
                    string lugarJson = JsonConvert.SerializeObject(LugaresListado);
                    writer.Write(lugarJson);
                }
            }
        }
        public Cliente BuscarCliente(tipoDocumento tipoDocumento,int NumeroDocumento)
        {
            Clientes = LeerClientes();
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.TipoDocumento == tipoDocumento && cliente.NumeroDocumento == NumeroDocumento)
                {
                    return cliente;
                }
            }

            return null;
           
        }
        public bool DarAltaCliente(tipoDocumento tipoDocumento, int numeroDocumento, string nombreApellido, string email, decimal montoMaximo, tipoCliente tipoCliente, int celular = 0, DateTime fechaNacimiento = default(DateTime), string sexo = "", string domicilio = "", int codigoPostal = 0, string localidad = "")
        {
            Cliente nuevoCliente = new Cliente(tipoDocumento, numeroDocumento, nombreApellido, email, montoMaximo, tipoCliente, celular, fechaNacimiento, sexo, domicilio, codigoPostal, localidad);
            int ban = 0;

            if (nuevoCliente.TipoDocumento != tipoDocumento.indefinido && nuevoCliente.NumeroDocumento != 0 && nuevoCliente.NombreApellido != "" && nuevoCliente.Email != "" && nuevoCliente.MontoMaximo != 0 && nuevoCliente.TipoCliente != tipoCliente.indefinido)
            { 
                foreach (Cliente cliente in Clientes)
                {
                    if (cliente.TipoDocumento == nuevoCliente.TipoDocumento && cliente.NumeroDocumento == nuevoCliente.NumeroDocumento)
                    {
                        ban = 1;
                    }
                }

                if (ban == 0 && nuevoCliente.MontoMaximo >= 0)
                {
                    Clientes.Add(nuevoCliente);
                    GuardarListadoClientes(Clientes);
                }
            }

            if (ban == 1)
            {
                return false;
            }
            return true;
        }
        public void DarBajaCliente(tipoDocumento tipoDocumento, int NumeroDocumento)
        {
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.TipoDocumento == tipoDocumento && cliente.NumeroDocumento == NumeroDocumento)
                {
                    Clientes.Remove(cliente);
                }
            }
        }
        public void DarAltaPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas)
        {
            Prestamo nuevoPrestamo = new Prestamo(cliente, Prestamos.Count + 2, comercioAdherido, sucursal, montoCredito, cantidadCuotas);
            if (nuevoPrestamo.MontoCredito < cliente.MontoMaximo && cantidadCuotas > 0)
            {
                Prestamos.Add(nuevoPrestamo);
                GuardarListadoPrestamos(Prestamos);
            }
        }
        public void DarBajaPrestamo(int NumeroPrestamo)
        {
            foreach (Prestamo prestamo in Prestamos)
            {
                if (prestamo.NroPrestamo == NumeroPrestamo)
                {
                    Prestamos.Remove(prestamo);
                }
            }
        }
        public void GurdarSucursal(Sucursal sucursal)
        {
            if (!File.Exists(pathSucursales))
            {
                File.Create(pathSucursales);
                using (StreamWriter writer = new StreamWriter(pathSucursales, false))
                {
                    string sucursalJson = JsonConvert.SerializeObject(sucursal);
                    writer.Write(sucursalJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathSucursales, false))
                {
                    string sucursalJson = JsonConvert.SerializeObject(sucursal);
                    writer.Write(sucursalJson);
                }
            }
        }
        public void DarAltaSucursal(int id, string ciudad, string direccion, int codigoPostal, int tasaInteres)
        {
            Sucursal nuevaSucursal = new Sucursal(id, ciudad, direccion, codigoPostal, tasaInteres);
            Sucursales.Add(nuevaSucursal);
            GuardarListadoSucursales(Sucursales);
        }
        public void DarBajaSucursal(int ID)
        {
            foreach (Sucursal sucursal in Sucursales)
            {
                if (sucursal.ID == ID)
                {
                    Sucursales.Remove(sucursal);
                }
            }
        }
        public Sucursal BuscarSucursal(int IdSucursal)
        {
            Sucursal sucursalNueva = null;

            foreach (Sucursal sucursal in Sucursales)
            {
                if (sucursal.ID == IdSucursal)
                {
                    sucursalNueva = sucursal;
                }
            }

            return sucursalNueva;
        }
        public void GurdarComercio(ComercioAdherido comercio)
        {
            if (!File.Exists(pathComercios))
            {
                File.Create(pathComercios);
                using (StreamWriter writer = new StreamWriter(pathComercios, false))
                {
                    string comercioJson = JsonConvert.SerializeObject(comercio);
                    writer.Write(comercioJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathComercios, false))
                {
                    string comercioJson = JsonConvert.SerializeObject(comercio);
                    writer.Write(comercioJson);
                }
            }
        }
        public void DarAltaComercio(int id, string ciudad, string direccion, int codigoPostal, string razonSocial)
        {
            ComercioAdherido nuevoComercio = new ComercioAdherido(id, ciudad, direccion, codigoPostal, razonSocial);
            Comercios.Add(nuevoComercio);
            GuardarListadoComercios(Comercios);
        }
        public void DarBajaComercio(int ID)
        {
            foreach (ComercioAdherido comercio in Comercios)
            {
                if (comercio.ID == ID)
                {
                    Comercios.Remove(comercio);
                }
            }
        }
        public ComercioAdherido BuscarComercio(int IdComercio)
        {
            foreach (ComercioAdherido comercio in Comercios)
            {
                if (comercio.ID == IdComercio)
                {
                    return comercio;
                }
            }

            return null;
        }
        public void GurdarLugar(LugarPago lugar)
        {
            if (!File.Exists(pathLugares))
            {
                File.Create(pathLugares);
                using (StreamWriter writer = new StreamWriter(pathLugares, false))
                {
                    string lugarJson = JsonConvert.SerializeObject(lugar);
                    writer.Write(lugarJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(pathLugares, false))
                {
                    string lugarJson = JsonConvert.SerializeObject(lugar);
                    writer.Write(lugarJson);
                }
            }
        }
        public void DarAltaLugarPago(int id, string ciudad, string direccion, int codigoPostal, string razonSocial, bool esSucursal)
        {
            LugarPago nuevoLugar = new LugarPago(id, ciudad, direccion, codigoPostal, razonSocial, esSucursal);
            LugaresPago.Add(nuevoLugar);
            GuardarListadoLugares(LugaresPago);
        }
        public void DarBajaLugar(int ID)
        {
            foreach (LugarPago lugarPago in LugaresPago)
            {
                if (lugarPago.ID == ID)
                {
                    LugaresPago.Remove(lugarPago);
                }
            }
        }
    }
}
