using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncentivoAhorros
{
    class Cliente
    {
        public int Cedula, Estrato, Meta_ahorro, Consumo_actual;

        public Cliente(int cedula, int estrato, int meta_ahorro, int consumo_actual)
        {
            Cedula = cedula;
            Estrato = estrato;
            Meta_ahorro = meta_ahorro;
            Consumo_actual = consumo_actual;
        }
    }
}
