Stack<int> miPila = new Stack<int>();
int a = 1;
while (a==1)
{
    Console.WriteLine("\nOperaciones disponibles:");
    Console.WriteLine("1. Agregar elemento a la pila");
    Console.WriteLine("2. Quitar elemento de la pila");
    Console.WriteLine("3. Mostrar elemento superior de la pila (sin quitar)");
    Console.WriteLine("4. Mostrar todos los elementos de la pila");
    Console.WriteLine("5. Salir");

    Console.Write("Seleccione una operación (1-5): ");
    string opcion = Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el elemento a agregar a la pila: ");
            if (int.TryParse(Console.ReadLine(), out int elementoAgregar))
            {
                miPila.Push(elementoAgregar);
                Console.WriteLine($"Elemento {elementoAgregar} agregado a la pila.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número entero.");
            }
            break;

        case "2":
            if (miPila.Count > 0)
            {
                int elementoQuitar = miPila.Pop();
                Console.WriteLine($"Elemento {elementoQuitar} quitado de la pila.");
            }
            else
            {
                Console.WriteLine("La pila está vacía. No se puede quitar ningún elemento.");
            }
            break;

        case "3":
            if (miPila.Count > 0)
            {
                int elementoSuperiorPeek = miPila.Peek();
                Console.WriteLine($"Elemento superior de la pila (sin quitar): {elementoSuperiorPeek}");
            }
            else
            {
                Console.WriteLine("La pila está vacía. No hay elementos para mostrar.");
            }
            break;

        case "4":
            Console.WriteLine("Elementos en la pila:");
            foreach (var elemento in miPila)
            {
                Console.WriteLine(elemento);
            }
            break;

        case "5":
            Console.WriteLine("Saliendo del programa.");
            a = 2;
            return;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
}