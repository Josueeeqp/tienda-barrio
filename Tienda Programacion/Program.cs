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
        // Crear datos
        // (id, producto , costo , cantidad)
        static void Main(string[] args)
        {
            var products = new List<(int id, string name, int cost, int cantidad)>{
                (1,"pan", 1000, 10),
                (2,"queso", 4500, 12),
                (3,"aceite", 2700, 17),
                (4,"huevos", 300, 120),
                (5,"leche", 2400, 16),
                (6,"azucar", 1700, 20),
                (7,"arroz", 1800, 30),
                (8,"sal", 900, 15),
                (9,"panela", 1300, 17),
                (10,"jamon", 5000, 0)
            };


            var lista_de_compra = new List<(int id, string name, int cost, int cantidad)> { };


            var clients = new List<(int id, string name, int deuda)>{
                (1,"Cliente A", 0),
                (1,"Cliente B", 0),
                (1,"Cliente C", 0),
                (1,"Cliente D", 0)
            };


            string selectedOptionMainMenu = null;

            while(selectedOptionMainMenu != "9") {

                ShowMainMenu();
                selectedOptionMainMenu = Console.ReadLine();

                switch (selectedOptionMainMenu)
                {
                    case "1":
                        lista_de_compra = Option_buscar_producto(products, lista_de_compra);
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
                        Option_acerca_de();
                        break;
                    case "9":
                        Option_salir();
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

        //Option 1
        static List<(int, string, int, int)> Option_buscar_producto(List<(int id, string name, int cost, int cantidad)> products, List<(int id, string name, int cost, int cantidad)> lista_de_compra) {

            string opcion_menu1 = null;

            while (opcion_menu1 != "4") {
                Console.WriteLine(
                    "\n 1. Mostrar todos los productos" +
                    "\n 2. Buscar Producto" +
                    "\n 3. Ver lista de compra" +
                    "\n 4. Regresar al menu principal"
                    );

                Console.Write("Seleccione una opcion: ");
                opcion_menu1 = Console.ReadLine();

                switch (opcion_menu1) {
                    case "1":
                        Console.WriteLine(
                            "\n---------------------" +
                            "\n|id| Producto | Precio  | Cantidad |"
                        );
                        for (int i = 0; i < products.Count; i++)
                        { 
                                Console.WriteLine(
                                    "---------------------"+
                                    $"\n|{products[i].id}| {products[i].name} | {products[i].cost} | {products[i].cantidad} |"
                                    );
                        }
                        break;
                    case "2":
                        Console.Write("\nEscriba el nombre del producto para ver el inventario: ");
                        string nombre_producto = Console.ReadLine();
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].name == nombre_producto)
                            {
                                Console.WriteLine(
                                    "\n---------------------" +
                                    "\n|id| Producto | Precio  | Cantidad |" +
                                    $"\n|{products[i].id}| {products[i].name} | {products[i].cost} | {products[i].cantidad} |" +
                                    "\n---------------------"
                                    );

                                Console.Write("Desea comprar el producto? si / no): ");
                                string comprar_prodcuto = Console.ReadLine();
                                if (comprar_prodcuto == "si") {
                                    Console.WriteLine($"El producto tiene {products[i].cantidad} unidades disponibles");
                                    if (products[i].cantidad > 0)
                                    {
                                        Console.Write("Cuantas unidades del producto quiere comprar?: ");
                                        string unidades_de_compra = Console.ReadLine();
                                        if (products[i].cantidad >= int.Parse(unidades_de_compra)) {
                                            lista_de_compra.Add((products[i].id, products[i].name, int.Parse(unidades_de_compra) * products[i].cost, int.Parse(unidades_de_compra)));
                                        }
                                        else
                                        {
                                            Console.WriteLine($"El producto solo tiene {products[i].cantidad} elementos disponibles, usted esta tratando de comprar {unidades_de_compra} unidades.");
                                        }                                  
                                    }                                    
                                }
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine(
                            "\n---------------------" +
                            "\n|id| Producto | Precio  | Cantidad |"
                        );
                        Console.WriteLine(lista_de_compra);
                        for (int i = 0; i < lista_de_compra.Count; i++)
                        {
                            Console.WriteLine(
                                "---------------------" +
                                $"\n|{lista_de_compra[i].id}| {lista_de_compra[i].name} | {lista_de_compra[i].cost} | {lista_de_compra[i].cantidad} |"
                                );
                        }
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Selecciono una opcion incorrecta.");
                        break;
                }
            }

            return lista_de_compra;
        }

        //Option 8
        static void Option_acerca_de() {
            Console.WriteLine(
                "\n"+
                "-----------------------------------------------\n"+
                "Trabajo Realizado por:\n"+
                "   Josue Quinche Parra - Estudiante UPB\n"+
                "-----------------------------------------------"
                );
        }

        //Option 9
        static void Option_salir()
        {
            Console.WriteLine(
                "\n"+
                "-----------------------------------------------"+
                "\n Gracias por su visita.");
            Thread.Sleep(3000);
        }

    }
}
