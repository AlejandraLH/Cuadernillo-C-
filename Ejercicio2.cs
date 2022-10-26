namespace NumeroMayor
{
    internal class Program
    {
        static void Main(String[] args)
        {
            double num1, num2;
            double R;
                        
                Console.WriteLine("Uso del if");
                Console.WriteLine("Programa para determinar cual de dos números es mayor");
                Console.WriteLine("Escribe el primer número: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el segundo número: ");
                num2 = double.Parse(Console.ReadLine());


                if (num1 > num2)
                {
                    R = num1;
                }
                else
                {
                    R = num2;
                }

                Console.WriteLine("El número mayor es: " + R);
                Console.ReadKey();
               
            
        }
    }
}
