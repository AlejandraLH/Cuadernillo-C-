namespace Cuadernillo_Papas_fritas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double p1, p2, p3, pf1, pf2, pf3, CT;

            //Entrada
            Console.WriteLine("Ingresar cantidad de papas fritas 1");
            pf1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresar cantidad de papas fritas 2");
            pf2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar cantidad de papas fritas 3");
            pf3 = double.Parse(Console.ReadLine());
           //Proceso
            p1 = pf1 * 50;
            p2 = pf2 * 100;
            p3 = pf3 * 150;
            CT = p1 + p2 + p3;
            //Salida
            Console.WriteLine("costo por papas fritas sencilla: ");
            Console.WriteLine(p1);
            Console.WriteLine("costo por papas fritas doble: ");
            Console.WriteLine(p2);
            Console.WriteLine("costo por papas fritas triple: ");
            Console.WriteLine(p3);
            Console.WriteLine("costo total a pagar: ");
            Console.WriteLine(CT);
            Console.ReadKey();
        }
    }
} 
