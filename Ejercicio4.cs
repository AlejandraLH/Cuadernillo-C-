namespace Cuadernillo_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double A, SI, P, N, S;
            //Entrada
            Console.WriteLine("Ingresar Años Trabajados");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Año inicial");
            SI = double.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresar el porcentaje");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar los años trabajados");
            N = double.Parse(Console.ReadLine());


            //Proceso
            S = (SI + (SI * P / 2500)) * N;

            //Salida
            Console.WriteLine("El Salario es:");
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
