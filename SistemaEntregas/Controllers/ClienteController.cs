﻿using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            MeusClientes.Add(cliente);
        }

        public Cliente PesquisarPorNome(string nome)
        {
            var c = from x in MeusClientes
                    where x.Nome.ToLower().Equals(nome.Trim().ToLower())
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public Cliente PesquisarPorID(int idCliente)
        {
            var c = from x in MeusClientes
                    where x.PessoaID.Equals(idCliente)
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }
    }
}