namespace descuento_vestido 
{
	class descuento_vestido 
{

		static void Main(string[] args) 
{
			double ct;
			double de;
			double pf;
			// Declaracion de variables
			// entrada
			Console.WriteLine("CT");
			ct = Double.Parse(Console.ReadLine());
			// Proceso 
			if ((ct>=4500))
			{
				de = ct*0.25;
			} else {
				de = ct*0.09;
			}
			pf = ct-de;
			Console.WriteLine("El precio final es "+pf);
			Console.WriteLine("El descuento final es "+de);
		}

	}

}
