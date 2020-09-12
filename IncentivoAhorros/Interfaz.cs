using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncentivoAhorros
{
    class Interfaz
    {
        static void Main(string[] args)
        {
            int cedula, estrato, meta_ahorro, consumo_actual, contador_clientes, opcion;
            float valor_a_pagar, valor_total_descuento, promedio;
            opcion =  0;
            EPM epm = new EPM();


            while(opcion != 8)
            {
                Console.WriteLine("Incetivo de Ahorros EPM");
                Console.WriteLine("Seleccione una de las opciones");
                

                Console.WriteLine("1: Almacenar información de cliente \n " +
                    "2: Calcular valor a pagar de un cliente \n " +
                    "3: Calcular el promedio del consumo actual de energia \n " +
                    "4: Calcular conceptos de descuentos \n " +
                    "5: Mostrar porcentajes de ahorro por estrato \n " +
                    "6: Contabilizar los clientes que tuvieron un cobro adicional \n " +
                    "7: mostrar clientes \n " +
                    "8: salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese los siguientes datos");

                        Console.WriteLine("Cédula del cliente: ");
                        cedula = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Estrato del cliente:");
                        estrato = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("meta_ahorro del cliente");
                        meta_ahorro = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("consumo_actual");
                        consumo_actual = Convert.ToInt32(Console.ReadLine());

                        epm.almcenar_clientes(cedula, estrato, meta_ahorro, consumo_actual);

                        Console.WriteLine("Se agregó la información correctamente \n\n");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la cedula del cliente que desea calcularle su valor a pagar");
                        cedula = Convert.ToInt32(Console.ReadLine());

                        valor_a_pagar = epm.Calcular_valor(cedula);

                        Console.WriteLine("el valor a pagar del cliente con cédula {0} es: {1}", cedula, valor_a_pagar);

                        break;

                    case 3:
                        promedio = epm.Calcular_promedio();
                        Console.WriteLine("el promedio de consumo actual de energía de todos los clientes es: " + promedio);
                        break;

                    case 4:

                        valor_total_descuento = epm.Calcular_concepto_descuento();
                        Console.WriteLine(" El valor total que se le dio a los clientes por concepto de descuentos es: " 
                            + valor_total_descuento);
                        break;

                    case 5:

                        Console.WriteLine("los porcentajes por estratos son los siguientes");
                        epm.Calcular_porcentaje_ahorros();

                        break;

                    case 6:

                        contador_clientes = epm.Contar_Clientes_Cobro_Adicional();
                        Console.WriteLine("El número de clientes que tuvieron cobro adicional es: " + contador_clientes);

                        break;

                    case 7:

                        for (int i = 0; i < epm.clientes.Count(); i++)
                        {
                            Cliente cliente = epm.clientes[i];
                            Console.WriteLine("cedula {0} \n estrato {1} \n meta de ahorro {2} \n consumo actual {3} \n\n\n ", 
                                cliente.Cedula, cliente.Estrato, cliente.Meta_ahorro, cliente.Consumo_actual);
                        }

                        break;

                    default:
                        Console.WriteLine("Hasta la próxima");
                        break;
                }
            }

        }
    }
}
