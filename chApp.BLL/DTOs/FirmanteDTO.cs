using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chApp.DAL;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class FirmanteDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public List<ChequeDTO> Cheques { get; set; }

        public FirmanteDTO()
        {

        }

        public FirmanteDTO(FirmanteRow f)
        {
            this.Id = f.Id;
            this.Nombre = f.Nombre;
            this.Cuit = f.Cuit;
            this.Direccion = f.Direccion;
            this.Telefono = f.Telefono;
            this.Email = f.Email;
            this.Cheques = ChequeDTO.ConvertToList(f.GetChequeRows());
        }
    }
}
