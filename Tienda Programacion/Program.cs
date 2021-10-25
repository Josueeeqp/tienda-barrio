using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tienda_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedOptionMainMenu = null;

            while(selectedOptionMainMenu != "9") {

                ShowMainMenu();
                selectedOptionMainMenu = Console.ReadLine();

                switch (selectedOptionMainMenu)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        option_salir();
                        break;
                    default:
                        Console.WriteLine("No selecciono una opcion correcta, intente nuevamente.");
                        break;

                }

            }
        }

        static void ShowMainMenu() {
            Console.WriteLine(
                "\n 1. Buscar Producto"+
                "\n 2. Suma Rapida de Productos" +
                "\n 3. Pagar Cuenta" +
                "\n 4. Consultar Cuenta Cliente" +
                "\n 5. Actualizar Cuenta Cliente" +
                "\n 6. Calcular Informe de Ventas" +
                "\n 7. Calcular Cartera de Clientes - Cuentas por Pagar" +
                "\n 8. Acerca de" +
                "\n 9. Salir"
                );
        }

        static void option_salir()
        {
            Console.WriteLine("Gracias por su visita.");
            Thread.Sleep(3000);
        }
    }
}
