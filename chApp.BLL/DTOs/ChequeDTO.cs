using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chApp.DAL;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class SmallChequeDTO
    {
        public long Id { get; set; }
        public System.DateTime FechaPago { get; set; }
        public double Monto { get; set; }
        public long Rechazado { get; set; }
        public string Banco { get; set; }
        public int IdCliente { get; set; }
        public int IdTenedor { get; set; }
        public bool IsTenedor { get; set; }

        public string IsTenedorText
        {
            get
            {
                return IsTenedor ? "Si" : "No";
            }
        }

        public string Estado
        {
            get
            {
                switch (this.Rechazado)
                {
                    case 1:
                        return "Rechazado";
                    case 2:
                        return "Cobrado";
                    case 0:
                    default:
                        return "Para Cobro";
                }
            }
        }

        public string FechaDePago
        {
            get
            {
                if (this.FechaPago != null)
                {
                    return this.FechaPago.ToString("dd/MM/yyyy");
                }
                else
                    return "Sin Fecha";
            }
        }



        public static List<SmallChequeDTO> ConvertToList(IEnumerable<ChequeRow> list)
        {
            return list.Select(o => new SmallChequeDTO(o)).ToList();
        }
        public SmallChequeDTO()
        {

        }
        public SmallChequeDTO(ChequeRow c)
        {
            this.Id = c.Id;
            this.FechaPago = c.FechaEntrega;
            this.Monto = c.Monto;
            this.Rechazado = c.Rechazado;
            this.Banco = c.Banco;
            this.IdCliente = (int)c.IdCliente;
            this.IdTenedor = (int)c.IdTenedor;
        }

    }

    public class ChequeDTO
    {
        public long Id { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public string LugarEmision { get; set; }
        public System.DateTime FechaPago { get; set; }
        public long IdCliente { get; set; }
        public string NroOrden { get; set; }
        public double Monto { get; set; }
        public string Cuenta { get; set; }
        public string Cuit { get; set; }
        public long IdFirmante { get; set; }
        public long Rechazado { get; set; }
        public double Descuento { get; set; }
        public double MontoDescontar { get; set; }
        public string Banco { get; set; }
        public long IdTenedor { get; set; }

        public ClienteDTO Cliente { get; set; }
        public FirmanteDTO Firmante { get; set; }

        public string NombreCliente
        {
            get { return this.Cliente.Nombre + " " + this.Cliente.Apellido; }
        }

        public string NombreFirmante
        {
            get { return this.Firmante.Nombre; }
        }

        public string Estado
        {
            get
            {
                switch (this.Rechazado)
                {
                    case 1:
                        return "Rechazado";
                    case 2:
                        return "Cobrado";
                    case 0:
                        return "Para Cobro";
                    default:
                        return "Para Cobro";
                }
            }
        }

        public string FechaDePago
        {
            get
            {
                if (this.FechaEntrega != null)
                {
                    return this.FechaPago.ToString("dd/MM/yyyy");
                }
                else
                    return "Sin Fecha";
            }
        }

        public string FechaLibrado
        {
            get
            {
                if (this.FechaEntrega != null)
                {
                    return this.FechaEntrega.ToString("dd/MM/yyyy");
                }
                else
                    return "Sin Fecha";
            }
        }

        public static List<ChequeDTO> ConvertToList(IEnumerable<ChequeRow> list)
        {
            return list.Select(o => new ChequeDTO(o)).ToList();
        }
        public ChequeDTO()
        {

        }
        public ChequeDTO(ChequeRow c)
        {
            this.Id = c.Id;
            this.LugarEmision = c.LugarEmision;
            this.FechaEntrega = c.FechaEntrega;
            this.FechaPago = c.FechaCobro;
            this.IdCliente = c.IdCliente;
            this.NroOrden = c.NroCheque;
            this.Monto = c.Monto;
            this.Cuenta = c.Cuenta;
            this.Cuit = c.Cuit;
            this.IdFirmante = c.IdFirmante;
            this.Rechazado = c.Rechazado;
            this.Descuento = c.Descuento;
            this.MontoDescontar = c.MontoDescontar;
            this.Banco = c.Banco;
            this.IdTenedor = c.IdTenedor;
            this.Cliente = new ClienteBL().GetById((int)c.IdCliente);
            this.Firmante = new FirmanteBL().GetById((int)c.IdFirmante);
        }

        public ChequeDTO(ChequeRow c, ClienteDTO cli, FirmanteDTO fir)
        {
            this.Id = c.Id;
            this.LugarEmision = c.LugarEmision;
            this.FechaEntrega = c.FechaEntrega;
            this.FechaPago = c.FechaCobro;
            this.IdCliente = c.IdCliente;
            this.NroOrden = c.NroCheque;
            this.Monto = c.Monto;
            this.Cuenta = c.Cuenta;
            this.Cuit = c.Cuit;
            this.IdFirmante = c.IdFirmante;
            this.Rechazado = c.Rechazado;
            this.Descuento = c.Descuento;
            this.MontoDescontar = c.MontoDescontar;
            this.Banco = c.Banco;
            this.IdTenedor = c.IdTenedor;
            this.Cliente = cli;
            this.Firmante = fir;
        }
    }
}
