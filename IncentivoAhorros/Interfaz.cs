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
            int cedula, estrato, meta_ahorro, consumo_actual, opcion;
            float valor_a_pagar, valor_total_descuento;
            opcion =  0;
            EPM epm = new EPM();


            while(opcion != 8)
            {
                Console.WriteLine("Incetivo de Ahorros EPM");
                Console.WriteLine("Seleccione una de las opciones");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("presione 1: Almacenar información de cliente \n " +
                    "presione 2: Calcular valor a pagar de un cliente \n " +
                    "presione 3: Calcular el promedio del consumo actual de energia \n " +
                    "presione 4: Calcular conceptos de descuentos \n " +
                    "presione 5: Mostrar porcentajes de ahorro por estrato \n " +
                    "presione 6: Contabilizar los clientes que tuvieron un cobro adicional \n " +
                    "presione 7: mostrar clientes \n " +
                    "presione 8: salir");

                switch(opcion)
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
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la cedula del cliente que desea calcularle su valor a pagar");
                        cedula = Convert.ToInt32(Console.ReadLine());

                        valor_a_pagar = epm.Calcular_valor(cedula);

                        Console.WriteLine("el valor a pagar del cliente con cédula {0} es: {1}", cedula, valor_a_pagar);

                        break;

                    case 3:
                        Console.WriteLine(" El valor total que se le dio a los clientes por concepto de descuentos es: ");
                        valor_total_descuento = epm.Calcular_concepto_descuento();
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    default:
                        Console.WriteLine("Hasta la próxima");
                        break;
                }
            }

        }
    }
}
