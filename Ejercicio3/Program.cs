using System;


namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta() {

                Numero = "1",
                Saldo = 2000,
                Fecha = Convert.ToDateTime("01/03/2020")
            
            };
            Console.WriteLine(cuenta.Retirar(500));
            Console.WriteLine(cuenta.Consignar(600));
            Console.WriteLine(cuenta.ConsultarSaldo());
            Console.ReadLine();
        }
    }
}
