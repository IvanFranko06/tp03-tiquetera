
using System.Collections.Generic;




    static class Tiquetera
    {

        static private Dictionary<int, Cliente> dicCliente = new Dictionary<int, Cliente>();
        static private int UltimoIdEntrada = 0;


        static public int devolverUltimoIdEntrada()
        {


            return UltimoIdEntrada;
        }

        static public int agregarCliente(Cliente cliente)
        {
            UltimoIdEntrada++;
            dicCliente.Add(UltimoIdEntrada, cliente);
            return UltimoIdEntrada;
        }

        static public Cliente encontrarCliente(int identrada)
        {
            if (dicCliente.ContainsKey(identrada))
            {
                return dicCliente[identrada];
            }
            else
            {
                return null;
            }

        }

        static public bool cambiarEntrada(int id, int tipo, int total)
        {
            int valorEntrada;
            bool sePudo = false;
            System.Console.WriteLine("que entrada desea comprar?");
            System.Console.WriteLine("Opción 1 - Día 1 , valor a abonar $15000\nOpción 2 - Día 2, valor a abonar $30000\nOpción 3 - Día 3, valor a abonar $10000\nOpción 4 - Full Pass, valor a abonar $40000");
            int tipoEntrada = int.Parse(System.Console.ReadLine());
            while (tipoEntrada < 1 || tipoEntrada > 4)
            {
                System.Console.WriteLine("ingrese una opción valida(1-4)");
                tipoEntrada = int.Parse(System.Console.ReadLine());
            }

            int[] valorEntradas = { -1, 15000, 30000, 10000, 40000 };
            valorEntrada = valorEntradas[tipoEntrada];



            if (total < valorEntrada)
            {
                dicCliente[id].TipoEntrada = tipoEntrada;
                dicCliente[id].TotalAbonado = valorEntrada;
                sePudo = true;

            }
            return sePudo;
        }


        static public List<string> estadisticas()
        {
            int cantidadClientes = dicCliente.Count();
            if (cantidadClientes <=0 )
            {
                
                return new List<string>();
            }
            int[] entradas = { 0, 0, 0, 0 };
            List<string> listaEstadisticas = new List<string>();
            
            listaEstadisticas.Add("La cantidad de clientes que participan es de:" + cantidadClientes);
            foreach (var cliente in dicCliente)
            {
                entradas[cliente.Value.TipoEntrada - 1]++;
            }
            double porcentaje1 = (entradas[0] * 100) / cantidadClientes;
            double porcentaje2 = (entradas[1] * 100) / cantidadClientes;
            double porcentaje3 = (entradas[2] * 100) / cantidadClientes;
            double porcentaje4 = (entradas[3] * 100) / cantidadClientes;
            listaEstadisticas.Add($"los porcentajes son:\n entrada tipo 1: %{porcentaje1}\n entrada tipo 2: %{porcentaje2}\n entrada tipo 3: %{porcentaje3}\n entrada tipo 4: %{porcentaje4}");
            int totalEntradas1 = entradas[0] * 15000;
            int totalEntradas2 = entradas[1] * 30000;
            int totalEntradas3 = entradas[2] * 10000;
            int totalEntradas4 = entradas[3] * 40000;
            listaEstadisticas.Add($"la cantidad recaudada es:\n entrada tipo 1: ${totalEntradas1}\n entrada tipo 2: ${totalEntradas2}\n entrada tipo 3: ${totalEntradas3}\n entrada tipo 4: ${totalEntradas4}");
            int totalRecaudado = totalEntradas1 + totalEntradas2 + totalEntradas3 + totalEntradas4;
            listaEstadisticas.Add("el total recaudado es de " + totalRecaudado);
            return listaEstadisticas;
        }
























    




























}