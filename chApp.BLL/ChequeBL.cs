using chApp.DAL.Models.DataModelTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class ChequeBL : BaseBL
    {
        public List<SmallChequeDTO> GetChequesByIdFirmante(long id)
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                List<ChequeRow> chequeTable = adapter.GetData().Where(c => c.IdFirmante == id).ToList();
                return SmallChequeDTO.ConvertToList(chequeTable);
            }
        }

        public List<SmallChequeDTO> GetChequesByIdClient(int idClient)
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                List<ChequeRow> chequeTable = adapter.GetData().Where(c => c.IdCliente == idClient || c.IdTenedor == idClient).ToList();
                return SmallChequeDTO.ConvertToList(chequeTable);
            }
        }
        public void Delete(int id)
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                var toDelete = this.GetById(id);
                adapter.Delete(toDelete.Id, toDelete.FechaEntrega, toDelete.LugarEmision, toDelete.FechaPago, toDelete.IdCliente, toDelete.NroOrden, toDelete.Monto, toDelete.Cuenta, toDelete.Cuit, toDelete.IdFirmante, toDelete.Rechazado, toDelete.Descuento, toDelete.MontoDescontar, toDelete.Banco, toDelete.IdTenedor);
            }
        }
        public List<ChequeDTO> GetAll()
        {
            List<ChequeDTO> result = new List<ChequeDTO>();
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                ChequeDataTable chequeTable = adapter.GetData();

                if (HasTableRowData(chequeTable))
                {
                    foreach (ChequeRow row in chequeTable.Rows)
                    {
                        result.Add(new ChequeDTO(row));
                    }
                }
            }

            return result;
        }

        public List<ChequeDTO> GetACobrar()
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                ChequeDataTable chequeTable = adapter.GetData();

                if (HasTableRowData(chequeTable))
                {
                    var result = adapter.GetData().AsEnumerable().Where(c => c.Rechazado != 1 && c.Rechazado != 2).ToList();
                    return ChequeDTO.ConvertToList(result);
                }
                else
                    return new List<ChequeDTO>();
            }
        }

        public List<ChequeDTO> GetRechazados()
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                ChequeDataTable chequeTable = adapter.GetData();

                if (HasTableRowData(chequeTable))
                {
                    var result = adapter.GetData().AsEnumerable().Where(c => c.Rechazado == 1).ToList();
                    return ChequeDTO.ConvertToList(result);
                }
                else
                    return new List<ChequeDTO>();
            }
        }

        public ChequeDTO GetById(int idCheque)
        {
            ChequeDTO result = null;
            using (ChequeTableAdapter tableAdapter = new ChequeTableAdapter())
            {
                ChequeRow chequeRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == idCheque).SingleOrDefault();
                if (chequeRow != null)
                {
                    return new ChequeDTO(chequeRow);
                }
            }
            return result;
        }

        public void Create(ChequeDTO newcheque)
        {
            using (ChequeTableAdapter tableAdapter = new ChequeTableAdapter())
            {
                tableAdapter.Insert(newcheque.FechaEntrega, newcheque.LugarEmision, newcheque.FechaPago, newcheque.IdCliente, newcheque.NroOrden, newcheque.Monto, newcheque.Cuenta, newcheque.Cuit, newcheque.IdFirmante, newcheque.Rechazado, newcheque.Descuento, newcheque.MontoDescontar, newcheque.Banco, newcheque.IdTenedor);
            }
        }

        public List<ChequeDTO> GetChequesByBuscarPor(string value)
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                ChequeDataTable chequeTable = adapter.GetData();

                if (HasTableRowData(chequeTable))
                {
                    var result = adapter.GetData().ToList();
                    
                    var allList = ChequeDTO.ConvertToList(result);
                    List<ChequeDTO> list = new List<ChequeDTO>();
                    ClienteBL cbl = new ClienteBL();
                    FirmanteBL fbl = new FirmanteBL();
                    foreach (var c in allList)
                    {
                        var cli = cbl.GetById((int)c.IdCliente);
                        var fir = fbl.GetById((int)c.IdFirmante);
                        if(cli.Nombre.ToLower().Contains(value) || cli.Apellido.ToLower().Contains(value) || (fir != null && fir.Nombre.ToLower().Contains(value)))
                            list.Add(c);
                    }
                    return list;
                }
                else
                    return new List<ChequeDTO>();
            }
        }

        public List<ChequeDTO> GetByDate(DateTime value)
        {
            using (ChequeTableAdapter adapter = new ChequeTableAdapter())
            {
                ChequeDataTable chequeTable = adapter.GetData();

                if (HasTableRowData(chequeTable))
                {
                    var result = adapter.GetData().AsEnumerable().Where(c => c.FechaCobro >= value).OrderBy(c => c.FechaCobro).ToList();
                    return ChequeDTO.ConvertToList(result);
                }
                else
                    return new List<ChequeDTO>();
            }
        }

        public bool Update(ChequeDTO chequeUpdate)
        {
            using (ChequeTableAdapter tableAdapter = new ChequeTableAdapter())
            {
                ChequeRow chequeRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == chequeUpdate.Id).SingleOrDefault();
                chequeRow.Banco = chequeUpdate.Banco;
                chequeRow.Cuenta = chequeUpdate.Cuenta;
                chequeRow.Cuit = chequeUpdate.Cuit;
                chequeRow.Descuento = chequeUpdate.Descuento;
                chequeRow.FechaCobro = chequeUpdate.FechaPago;
                chequeRow.FechaEntrega = chequeUpdate.FechaEntrega;
                chequeRow.IdCliente = chequeUpdate.IdCliente;
                chequeRow.IdFirmante = chequeUpdate.IdFirmante;
                chequeRow.IdTenedor = chequeUpdate.IdTenedor;
                chequeRow.LugarEmision = chequeUpdate.LugarEmision;
                chequeRow.Monto = chequeUpdate.Monto;
                chequeRow.MontoDescontar = chequeUpdate.MontoDescontar;
                chequeRow.NroCheque = chequeUpdate.NroOrden;
                chequeRow.Rechazado = chequeUpdate.Rechazado;
                tableAdapter.Update(chequeRow);
            }

            return true;
        }
    }
}
