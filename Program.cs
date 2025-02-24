using System;

class CuentaBancaria
{
    private string titular;
    private decimal saldo;
    private static int contadorCuentas = 0;
    private int idCuenta;

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        this.titular = titular;
        saldo = saldoInicial > 0 ? saldoInicial : 0;
        idCuenta = ++contadorCuentas;
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito de RD${monto:F2} realizado con éxito en la cuenta {idCuenta}.");
        }
        else
        {
            Console.WriteLine("El monto a depositar debe ser positivo.");
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro de RD${monto:F2} realizado con éxito en la cuenta {idCuenta}.");
        }
        else if (monto > saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
        }
        else
        {
            Console.WriteLine("El monto a retirar debe ser positivo.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Cuenta ID: {idCuenta}\nTitular: {titular}\nSaldo: RD${saldo:F2}\n");
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta1 = new CuentaBancaria("Penencio Rodriguez", 3000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Maria Lopez", 5000);
        CuentaBancaria cuenta3 = new CuentaBancaria("Juan Perez", 1000);

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Mostrar información");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione cuenta: 1, 2 o 3");
            int cuentaOpcion = int.Parse(Console.ReadLine());
            CuentaBancaria cuentaSeleccionada = cuentaOpcion switch
            {
                2 => cuenta2,
                3 => cuenta3,
                _ => cuenta1,
            };

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese monto a depositar: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    cuentaSeleccionada.Depositar(deposito);
                    break;
                case 2:
                    Console.Write("Ingrese monto a retirar: ");
                    decimal retiro = decimal.Parse(Console.ReadLine());
                    cuentaSeleccionada.Retirar(retiro);
                    break;
                case 3:
                    cuentaSeleccionada.MostrarInformacion();
                    break;
                case 4:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
