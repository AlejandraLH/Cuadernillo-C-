namespace CalcularPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            float c1, c2, c3, c4, c5, p;
            

            
                //Entrada
                Console.WriteLine("Uso del if");
                Console.WriteLine("Programa para obtener si un alumno aprobó o no ");
                Console.WriteLine("Escribe la calificación 1: ");
                c1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación 2: ");
                c2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación 3: ");
                c3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación 4: ");
                c4 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación 5: ");
                c5 = float.Parse(Console.ReadLine());


                //Proceso y salida
                p = (c1 + c2 + c3 + c4 + c5) / 5;


                if (p >= 7)
                {
                    Console.WriteLine("EL ALUMNO ESTÁ APROBADO CON UN PROMEDIO DE: " + p);
                }
                else
                {
                    Console.WriteLine("EL ALUMNO ESTÁ REPROBADO CON UN PROMEDIO DE: " + p);
                }

                    Console.ReadKey();
            
        }
    }
}
