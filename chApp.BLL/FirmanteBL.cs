using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chApp.DAL;
using chApp.DAL.Models.DataModelTableAdapters;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class FirmanteBL : BaseBL
    {
        public void Delete(int id)
        {
            using (FirmanteTableAdapter adapter = new FirmanteTableAdapter())
            {
                var toDelete = this.GetById(id);
                adapter.Delete(toDelete.Id, toDelete.Nombre, toDelete.Cuit, toDelete.Direccion, toDelete.Telefono, toDelete.Email);
            }
        }

        public List<FirmanteDTO> GetAll()
        {
            List<FirmanteDTO> result = new List<FirmanteDTO>();
            using (FirmanteTableAdapter adapter = new FirmanteTableAdapter())
            {
                FirmanteDataTable FirmanteTable = adapter.GetData();

                if (HasTableRowData(FirmanteTable))
                {
                    foreach (FirmanteRow row in FirmanteTable.Rows)
                    {
                        result.Add(new FirmanteDTO(row));
                    }
                }
            }

            return result;
        }

        public FirmanteDTO GetById(int idFirmante)
        {
            FirmanteDTO result = null;
            using (FirmanteTableAdapter tableAdapter = new FirmanteTableAdapter())
            {
                FirmanteRow FirmanteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == idFirmante).SingleOrDefault();

                if (FirmanteRow != null)
                {
                    return new FirmanteDTO(FirmanteRow);
                }
            }
            return result;
        }

        public FirmanteDTO GetFirmanteByCuit(string value)
        {
            FirmanteDTO result = null;
            using (FirmanteTableAdapter tableAdapter = new FirmanteTableAdapter())
            {
                FirmanteRow FirmanteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Cuit == value).SingleOrDefault();

                if (FirmanteRow != null)
                {
                    return new FirmanteDTO(FirmanteRow);
                }
            }
            return result;
        }

        public FirmanteDTO GetFirmanteByNombre(string value)
        {
            FirmanteDTO result = null;
            using (FirmanteTableAdapter tableAdapter = new FirmanteTableAdapter())
            {
                FirmanteRow FirmanteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Nombre == value).SingleOrDefault();

                if (FirmanteRow != null)
                {
                    return new FirmanteDTO(FirmanteRow);
                }
            }
            return result;
        }

        public void Create(FirmanteDTO newFirmante)
        {
            using (FirmanteTableAdapter tableAdapter = new FirmanteTableAdapter())
            {
                tableAdapter.Insert(newFirmante.Nombre, newFirmante.Cuit, newFirmante.Direccion, newFirmante.Telefono, newFirmante.Email);
            }
        }

        public bool Update(FirmanteDTO firmanteUpdate)
        {
            using (FirmanteTableAdapter tableAdapter = new FirmanteTableAdapter())
            {
                FirmanteRow FirmanteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == firmanteUpdate.Id).SingleOrDefault();
                FirmanteRow.Nombre = firmanteUpdate.Nombre;
                FirmanteRow.Cuit = firmanteUpdate.Cuit;
                FirmanteRow.Direccion = firmanteUpdate.Direccion;
                FirmanteRow.Telefono = firmanteUpdate.Telefono;
                FirmanteRow.Email = firmanteUpdate.Email;
                tableAdapter.Update(FirmanteRow);
            }

            return true;
        }
    }
}
