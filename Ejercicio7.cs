namespace ColorDelUniforme
{
    class ColorDelUniforme
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Selecciona el valor de dia.");
            Console.WriteLine("\t1.- domingo");
            Console.WriteLine("\t2.- lunes");
            Console.WriteLine("\t3.- martes");
            Console.WriteLine("\t4.- miercoles");
            Console.WriteLine("\t5.- jueves");
            Console.WriteLine("\t6.- viernes");
            Console.WriteLine("\t7.- sabado");
            Console.Write("\t: ");
            
            
                dia = int.Parse(Console.ReadLine());
                if (dia < 1 || dia > 7)
                    Console.Write("Valor incorrecto. Ingresalo nuevamente.: ");
                if(dia < 1 || dia > 7);
            if (dia == 2 || dia == 3 || dia == 4)
                Console.WriteLine("Tu uniforme es de color azul.");
            else
                Console.WriteLine("Usar el uniforme amarillo.");
            Console.ReadKey();
        }
    }
}
