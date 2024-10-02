using AMorfar.Negocios.Actividades;
using AMorfar.Negocios.Entidades;
ActividadCliente actividad = new();

main();

void main()
{

    menu();
}

void menu()
{
    Console.Clear();

    Console.WriteLine("1 - Registrar Cliente");
    Console.WriteLine("2 - Listar Clientes");
    Console.WriteLine("3 - Buscar Cliente");
    Console.WriteLine("4 - Salir");
    Console.Write("Seleccione una opción: ");
    int select = int.Parse(Console.ReadLine());

    switch (select)
    {
        case 1:
            Save();
            break;
        case 2:
            GetAll();
            break;
        case 3:
            Get();
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;

    }


    void Save()
    {
        Persona client = new();
        Console.Write("DNI: ");
        client.DNI = Console.ReadLine();
        Console.Write("Nombre: ");
        client.nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        client.apellido = Console.ReadLine();

        bool result = actividad.Save(client);

        if (!result)
            Console.WriteLine("No se pudo registrar el cliente");
        else
            Console.WriteLine("Cliente registrado");

        Console.ReadKey();
        menu();
    }

    void Get()
    {
        Console.Write("DNI: ");
        string dni = Console.ReadLine();
        Persona? client = actividad.Get(dni);

        if (client == null)
            Console.WriteLine("Cliente no encontrado");
        else
            Console.WriteLine($"Nombre: {client.nombre} {client.apellido}");
        Console.ReadKey();
        menu();
    }

    void GetAll()
    {
        Console.Clear();
        List<Persona> clients = actividad.GetAll();
        foreach (Persona client in clients)
        {
            Console.WriteLine($"DNI: {client.DNI}");
            Console.WriteLine($"Nombre: {client.nombre} {client.apellido}");
            Console.WriteLine("---------------------------------------");
        }
        Console.ReadKey();
        menu();
    }
}
