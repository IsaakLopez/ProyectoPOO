using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Online.Models
{
    public class Resenia
    {
        private int _id;
        private int _idCliente;
        private Cliente _cliente;
        private string _info;

        public Resenia() { }
        public Resenia(int id, int idcliente, string info)
        {
            Id = id;
            IdCliente = idcliente;
            Info = info;
        }

        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public string Info { get => _info; set => _info = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
    }
}