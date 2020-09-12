using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IncentivoAhorros
{
    class EPM
    {
        private List<Cliente> clientes;

        public EPM()
        {
            clientes = null;
            
        }

        public void almcenar_clientes(int cedula, int estrato, int meta_ahorro, int consumo_actual)
        {
            Cliente cliente = new Cliente(cedula, estrato, meta_ahorro, consumo_actual);
            clientes.Add(cliente);
        }

        public float Calcular_valor(int cedula)
        {
            int valor_parcial, valor_incentivo;
            float valor_a_pagar;
            valor_a_pagar = 0;

            for (int i = 0; i<clientes.Count(); i++)
            {
                if (clientes[i].Cedula == cedula)
                {
                    Cliente cliente = clientes[i];
                    valor_parcial = cliente.Consumo_actual * 500;
                    valor_incentivo = (cliente.Meta_ahorro - valor_parcial) * 500;
                    valor_a_pagar = valor_parcial - valor_incentivo;
                }
            }

            return valor_a_pagar;
        }

        public float Calcular_promedio()
        {
            int contador_consumo_actual = 0;
            float promedio_consumo_actual;

            for (int i = 0; i < clientes.Count(); i++)
            {
                contador_consumo_actual += clientes[i].Consumo_actual;
            }

            promedio_consumo_actual = contador_consumo_actual / clientes.Count();
            return promedio_consumo_actual;
        }

        public float Calcular_concepto_descuento()
        {
            float valor_total_descuentos = 0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];

                if (cliente.Consumo_actual <= cliente.Meta_ahorro)
                {
                    valor_total_descuentos += (cliente.Meta_ahorro - cliente.Consumo_actual);
                }
            }

            return valor_total_descuentos;

        }


        public float Calcular_porcentaje_ahorros()
        {
            int cont_estrato1, cont_estrato2, cont_estrato3, cont_estrato4, cont_estrato5, cont_estrato6, contador_total,
                kilovatios, ahorro_dinero, sum_estrato1, sum_estrato2, sum_estrato3, sum_estrato4, sum_estrato5, sum_estrato6,suma_total;

            cont_estrato1 = cont_estrato2 = cont_estrato3 = cont_estrato4 = cont_estrato5 = cont_estrato6 = 
                contador_total = kilovatios = ahorro_dinero = sum_estrato1 = sum_estrato2 = sum_estrato3 = sum_estrato4 = 
                sum_estrato5 = sum_estrato6 =0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];

                switch (cliente.Estrato)
                {
                    case 1:
                        cont_estrato1 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual)*500 >= 0) 
                        {
                            sum_estrato1 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                    case 2:
                        cont_estrato2 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual) * 500 >= 0)
                        {
                            sum_estrato2 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                    case 3:
                        cont_estrato3 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual) * 500 >= 0)
                        {
                            sum_estrato3 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                    case 4:
                        cont_estrato4 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual) * 500 >= 0)
                        {
                            sum_estrato4 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                    case 5:
                        cont_estrato5 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual) * 500 >= 0)
                        {
                            sum_estrato5 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                    case 6:
                        cont_estrato6 += 1;
                        if ((cliente.Meta_ahorro - cliente.Consumo_actual) * 500 >= 0)
                        {
                            sum_estrato6 += (cliente.Meta_ahorro - cliente.Consumo_actual) * 500;
                        }
                        break;

                }
            }
            suma_total = sum_estrato1 + sum_estrato2 + sum_estrato3 + sum_estrato4 + sum_estrato5 + sum_estrato6;
            Console.WriteLine("El porcentaje de ahorro para el Estrato 1 es :" + sum_estrato1 * 100 / suma_total);
            Console.WriteLine("El porcentaje de ahorro para el Estrato 2 es :" + sum_estrato2 * 100 / suma_total);
            Console.WriteLine("El porcentaje de ahorro para el Estrato 3 es :" + sum_estrato3 * 100 / suma_total);
            Console.WriteLine("El porcentaje de ahorro para el Estrato 4 es :" + sum_estrato4 * 100 / suma_total);
            Console.WriteLine("El porcentaje de ahorro para el Estrato 5 es :" + sum_estrato5 * 100 / suma_total);
            Console.WriteLine("El porcentaje de ahorro para el Estrato 6 es :" + sum_estrato6 * 100 / suma_total);

        }
        public float Contar_Clientes_Cobro_Adicional()
        {
            float Contador_Irresponsables = 0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];

                if (cliente.Consumo_actual > cliente.Meta_ahorro)
                {
                    Contador_Irresponsables += 1;
                }
            }

            return Contador_Irresponsables;

        }
}
