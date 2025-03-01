class Program
{
    static void Main()
    {
        Matematicas matematicas = new Matematicas();
        int cantidad;

        while (true)
        {
            Console.WriteLine("Introduce la cantidad de números en la secuencia de Fibonacci:");

            string x = Console.ReadLine();

            if (x != null && int.TryParse(x, out cantidad))
            {
                if (cantidad > 0)
                {
                matematicas.Fibonacci(cantidad);
                break;
                } 
                else 
                {
                    Console.WriteLine("El valor indicado no es valido. Ingrese nuevamente...");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es valido. Ingrese nuevamente.");
            }
        }
    }
}