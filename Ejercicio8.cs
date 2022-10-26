namespace AlturaDeUnaPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.Write("Ingresa el valor de altura: ");
            altura = int.Parse(Console.ReadLine());
            if (altura <= 150)
                Console.WriteLine("Persona de altura baja");
            if (altura > 150 && altura <= 170)
                Console.WriteLine("Persona de altura media");
            if (altura > 170)
            Console.WriteLine("Persona alta");

            Console.ReadKey();
        }
    }
}
