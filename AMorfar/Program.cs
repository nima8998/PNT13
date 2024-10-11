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

    Console.WriteLine("1 - Agregar persona");
    Console.WriteLine("2 - Mostrar todos");
    Console.WriteLine("3 - Buscar");
    Console.WriteLine("4 - Salir");
    Console.Write("Seleccione una opción: ");
    var option = Console.ReadLine();

    // Intenta parsear a int, si no se puede devuelve false. Si puede, se asigna a la variable 'select'
    if (!int.TryParse(option, out int select))
    {
        Console.WriteLine("Opción no válida");
        Console.ReadKey();
        option = null;
        menu();
    }

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
        Persona persona = new();
        Console.Write("Nombre: ");
        persona.Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        persona.Apellido = Console.ReadLine();
        Console.Write("DNI: ");
        persona.DNI = Console.ReadLine();

        bool result = actividad.Save(persona);

        if (!result)
            Console.WriteLine("No se pudo agregar.");
        else
            Console.WriteLine("Persona agregada.");

        Console.ReadKey();
        menu();
    }

    void Get()
    {
        Console.Write("Buscar: ");
        string busqueda = Console.ReadLine();
        List<Persona>? resultadoBusqueda = actividad.Get(busqueda);

        if (resultadoBusqueda == null)
            Console.Write("No se encontraron resultados");
        else
        {
            Console.WriteLine("Resultados: ");
            for(int i = 0; i < resultadoBusqueda.Count; i++)
            {
                Console.WriteLine($"{i+1}. {resultadoBusqueda[i].Nombre}");
            }
        }
        Console.ReadKey();
        menu();
    }

    void GetAll()
    {
        List<Persona> resultado = actividad.GetAll();
        if (resultado.Count == 0)
            Console.WriteLine("No hay registros");
        else
        {
            Console.WriteLine("Personas: ");
            for (int i = 0; i < resultado.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {resultado[i].Nombre}");
            }
        }
        Console.ReadKey();
        menu();
    }
}
