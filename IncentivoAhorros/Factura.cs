using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncentivoAhorros
{
    class Factura
    {
        private Cliente Cliente;
        private int Valor_a_pagar;

        public Factura(Cliente cliente, int valor_a_pagar)
        {
            Cliente = cliente;
            Valor_a_pagar = valor_a_pagar;
        }
    }
}
