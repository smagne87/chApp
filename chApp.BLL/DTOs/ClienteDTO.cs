using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chApp.DAL;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAux { get; set; }
        public string Email { get; set; }
        public double CupoMax { get; set; }
        private double _cupoRestante;
        public double CupoRestante 
        { 
            get
            {
                return GetCupoRestante();
            }
            set
            {
                this._cupoRestante = value;
            }
        }

        public List<ChequeDTO> Cheques { get; set; }

        public static List<ClienteDTO> ConvertToList(IEnumerable<ClienteRow> list)
        {
            return list.Select(o => new ClienteDTO(o)).ToList();
        }

        public ClienteDTO()
        {

        }

        public ClienteDTO(ClienteRow c, bool withCheques = true)
        {
            this.Id = (int) c.Id;
            this.Nombre = c.Nombre;
            this.Apellido = c.Apellido;
            this.Direccion = c.Direccion;
            this.Telefono = c.Telefono;
            this.TelefonoAux = c.TelefonoAux;
            this.Email = c.Email;
            this.CupoMax = c.CupoMax;
            if (withCheques)
            {
                this.Cheques = ChequeDTO.ConvertToList(c.GetChequeRows());
                this.CupoRestante = GetCupoRestante();
            }
        }

        public double CalcularMontoRestante(double monto)
        {
            return this.CupoRestante - monto;
        }

        private double GetCupoRestante()
        {
            if (this.Cheques != null)
                return this.CupoMax - (double)this.Cheques.Sum(ch => ch.Monto);
            else
                return this.CupoMax;
        }
    }
}
