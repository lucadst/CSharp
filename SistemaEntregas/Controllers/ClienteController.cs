using System;
using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    public class ClienteController
    {
        public static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            MeusClientes.Add(cliente);
        }

    }
}