int opcion;
opcion = menu();
while (opcion != 5)
{

    switch (opcion)
    {

        case 1:
            nuevaInscripcion();
            break;
        case 2:
            obtenerEstadisticas();
            break;
        case 3:
            buscarCliente();
            break;
        case 4:
            cambiarEntradaDeCliente();
            break;
    }






    System.Console.WriteLine("presiona enter para continuar");
    System.Console.ReadLine();
    opcion = menu();
}






void cambiarEntradaDeCliente()
{
    System.Console.WriteLine("ingrese el id de entrada del cliente que desea cambiar la entrada");
    int id = int.Parse(System.Console.ReadLine());
    Cliente clienteEncontrado = Tiquetera.encontrarCliente(id);
    if (clienteEncontrado == null)
    {
        System.Console.WriteLine("no fue encontrado");
    }
    else
    {
        Tiquetera.cambiarEntrada(id, clienteEncontrado.TipoEntrada, clienteEncontrado.TotalAbonado);
    }


}






void buscarCliente()
{
    System.Console.WriteLine("ingrese el id de entrada del cliente que desea encontrar");
    int id = int.Parse(System.Console.ReadLine());
    Cliente clienteEncontrado = Tiquetera.encontrarCliente(id);
    if (clienteEncontrado == null)
    {
        System.Console.WriteLine("no fue encontrado");
    }
    else
    {
        System.Console.WriteLine("Nombre: " + clienteEncontrado.Nombre);
        System.Console.WriteLine("Apellido: " + clienteEncontrado.Apellido);
        System.Console.WriteLine("DNI: " + clienteEncontrado.DNI);
        System.Console.WriteLine("Tipo de entrada: " + clienteEncontrado.TipoEntrada);
        System.Console.WriteLine("Total abonado: " + clienteEncontrado.TotalAbonado);
        System.Console.WriteLine("Fecha de inscripción: " + clienteEncontrado.FechaInscripcion);
    }
}




void obtenerEstadisticas()
{
    List<string> listaEstadisticasMostrar = new List<string>();
    listaEstadisticasMostrar = Tiquetera.estadisticas();
    if (listaEstadisticasMostrar.Count == 0)
    {
        System.Console.WriteLine("aun no hay inscriptos");


    }
    else
    {
        listaEstadisticasMostrar.ForEach(Console.WriteLine);
    }

}





void nuevaInscripcion()
{
    System.Console.WriteLine("ingrese su nombre");
    string nom = System.Console.ReadLine();
    System.Console.WriteLine("ingrese su apellido");
    string ape = System.Console.ReadLine();
    System.Console.WriteLine("ingrese su dni");
    int dni = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("ingrese el tipo de entrada que va a llevar(1-4)");
    System.Console.WriteLine("Opción 1 - Día 1 , valor a abonar $15000\nOpción 2 - Día 2, valor a abonar $30000\nOpción 3 - Día 3, valor a abonar $10000\nOpción 4 - Full Pass, valor a abonar $40000");
    int tipoE = int.Parse(System.Console.ReadLine());
    while (tipoE < 1 || tipoE > 4)
    {
        System.Console.WriteLine("ingrese una opción valida(1-4)");
        tipoE = int.Parse(System.Console.ReadLine());
    }

    int[] valorE = { -1, 15000, 30000, 10000, 40000 };
    int totalA = valorE[tipoE];

    DateTime inscripcion = DateTime.Today;

    Cliente unCliente = new Cliente(nom, ape, dni, tipoE, totalA, inscripcion);
    Tiquetera.agregarCliente(unCliente);

}




int menu()
{

    int opcion;
    Console.Clear();
    System.Console.WriteLine("///////////////////menu/////////////////////");
    System.Console.WriteLine("1-Nueva inscripción");
    System.Console.WriteLine("2-Obtener estadísticas del Evento");
    System.Console.WriteLine("3-Buscar Cliente");
    System.Console.WriteLine("4-Cambiar entrada de un Cliente");
    System.Console.WriteLine("5-Salir");
    opcion = int.Parse(System.Console.ReadLine());

    while (opcion < 0 || opcion > 5)
    {
        System.Console.WriteLine("Opcion invalida, intente ingresar un numero entre 1 y 5");
        opcion = int.Parse(System.Console.ReadLine());
    }



    return opcion;
}
