using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chApp.DAL;
using chApp.DAL.Models.DataModelTableAdapters;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class ClienteBL : BaseBL
    {
        public void Delete(int id)
        {
            using (ClienteTableAdapter adapter = new ClienteTableAdapter())
            {
                var toDelete = this.GetById(id);
                adapter.Delete(toDelete.Id, toDelete.Nombre, toDelete.Apellido, toDelete.Direccion, toDelete.Telefono, toDelete.TelefonoAux, toDelete.Email, toDelete.CupoMax, toDelete.CupoRestante);
            }
        }

        public List<ClienteDTO> GetAll()
        {
            List<ClienteDTO> result = new List<ClienteDTO>();
            using (ClienteTableAdapter adapter = new ClienteTableAdapter())
            {
                ClienteDataTable clienteTable = adapter.GetData();

                if (HasTableRowData(clienteTable))
                {
                    foreach (ClienteRow row in clienteTable.Rows)
                    {
                        result.Add(new ClienteDTO(row));
                    }
                }
            }

            return result;
        }

        public List<ClienteDTO> GetByNameSurname(string value)
        {
            using (ClienteTableAdapter tableAdapter = new ClienteTableAdapter())
            {
                List<ClienteRow> clienteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Apellido.ToLower().Contains(value.ToLower()) || ch.Nombre.ToLower().Contains(value.ToLower())).ToList();
                return ClienteDTO.ConvertToList(clienteRow);
            }
        }

        public ClienteDTO GetById(int idCliente)
        {
            ClienteDTO result = null;
            using (ClienteTableAdapter tableAdapter = new ClienteTableAdapter())
            {
                ClienteRow ClienteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == idCliente).SingleOrDefault();

                if (ClienteRow != null)
                {
                    return new ClienteDTO(ClienteRow);
                }
            }
            return result;
        }

        public void Create(ClienteDTO newCliente)
        {
            using (ClienteTableAdapter tableAdapter = new ClienteTableAdapter())
            {
                tableAdapter.Insert(newCliente.Nombre, newCliente.Apellido, newCliente.Direccion, newCliente.Telefono, newCliente.TelefonoAux, newCliente.Email, newCliente.CupoMax, newCliente.CupoRestante);
            }
        }

        public bool Update(ClienteDTO clienteUpdate)
        {
            using (ClienteTableAdapter tableAdapter = new ClienteTableAdapter())
            {
                ClienteRow ClienteRow = tableAdapter.GetData().AsEnumerable().Where(ch => ch.Id == clienteUpdate.Id).SingleOrDefault();
                ClienteRow.Apellido = clienteUpdate.Apellido;
                ClienteRow.CupoMax = clienteUpdate.CupoMax;
                ClienteRow.CupoRestante = clienteUpdate.CupoRestante;
                ClienteRow.Direccion = clienteUpdate.Direccion;
                ClienteRow.Email = clienteUpdate.Email;
                ClienteRow.Nombre = clienteUpdate.Nombre;
                ClienteRow.Telefono = clienteUpdate.Telefono;
                ClienteRow.TelefonoAux = clienteUpdate.TelefonoAux;
                tableAdapter.Update(ClienteRow);
            }

            return true;
        }
    }
}
