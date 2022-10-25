System;
System.Collections.Generic;
System.Linq;
System.Text;
System.Threading.Tasks;

namespace Calorias
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso;
            Console.Write("Ingresa el valor de peso: ");
            peso = int.Parse(Console.ReadLine());
            if (peso < 45)
                Console.WriteLine("Aumentar calorias");
            if (peso >= 45 && peso <= 65)
                Console.WriteLine("Mantener calorias");
            if (peso > 65)
                Console.WriteLine("Reducir calorias");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
  
