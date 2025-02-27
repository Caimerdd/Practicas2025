namespace EjercicioFibo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números deseas en la secuencia de Fibonacci? ");
            int cantidad = int.Parse(Console.ReadLine());

            Matematicas.Fibonacci(cantidad);
        }
    }
}

