using System;

class Micajero
{
    double saldo = 20000;

    void menu()
    {
        string opcion;
        do
        {
            Console.Clear();
            Console.WriteLine(@"====Seleccione la operacion====
1.Consultarsaldo
2.Depositar 
3.Retirar 
4.Salir");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    consultarsaldo();
                    break;
                case "2":
                    Depositar();
                    break;
                case "3":
                    Retirar();
                    break;
                case "4":
                    Salir();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, PRECIONE ENTER PARA CONTNUAR....");
                    Console.ReadKey();
                    break;
            }

        }
        while (opcion != "4");

        void consultarsaldo()
        {
            Console.WriteLine($"Su saldo actual es: {saldo}");
            OtraOperacion();
        }

        void Depositar()
        {
            Console.WriteLine("Ingrese la cantidad a depositar....");
            double monto = Convert.ToDouble(Console.ReadLine());
            if (monto <= 0)
            {
                Console.WriteLine("Monto invalido, No debe ser 0, Intente de nuevo....");
                Depositar();
            }
            else
            {
                saldo += monto;
                Console.WriteLine($"Depósito. Nuevo saldo: {saldo}");
                OtraOperacion();
            }
        }

        void Retirar()
        {
            Console.WriteLine("Ingrese el monto a retirar....");
            double retiro = Convert.ToDouble(Console.ReadLine());
            if (retiro == 0)
            {
                Console.WriteLine("Monto invalido, No debe ser 0, Intente de nuevo....");
                Retirar();
            }
            else if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes, Intente de nuevo....");
                Retirar();
            }
            else
            {
                saldo -= retiro;
                Console.WriteLine($"Retiro Exitoso!" +
                    $"Nuevo saldo: {saldo}");
                OtraOperacion();
            }
        }

        void Salir()
        {
            Console.WriteLine(@")===========================================================
THANK YOU VERY MUCH FOR USING OUR SERVICE
============================================================");

            Environment.Exit(0);
        }

        void OtraOperacion()
        {
            Console.WriteLine("\n Desea realizar otra operacion? (1=Si / 2=No)");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                menu();
            }
            else
            {
                Salir();
            }
        }
    }

    static void Main(string[] args)
    {
        Micajero cajero = new Micajero();
        cajero.menu();
    }
}







