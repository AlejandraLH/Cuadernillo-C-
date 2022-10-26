Namespace Suplementos

{
	Public static class Program

	{
		Public static void Main()

		{
			//entrada

			Int cre,pro,pre,precio,t;

		Console.WriteLine(“ingresa la cantidad de creatina que deseas comprar”);

		Cre= int.Parse(Console.ReadLine());

		Cre=cre*650;

		Console.WriteLine(“ingresa la cantidad de creatina que deseas comprar”);

		Pro= int.Parse(Console.ReadLine());

		Pro=pro*800;

		Console.WriteLine(“ingresa la cantidad de creatina que deseas comprar”);

		Pre= int.Parse(Console.ReadLine());

		Pre=pre*500;
		T=cre+pro+pre;
			

Console.WriteLine(“el precio de la creatina es:”+ cre );

Console.WriteLine(“el precio del proteina es:”+ pro );

Console.WriteLine(“el precio del prentreno  es:”+pre);

Console.WriteLine(“el total de su compra es:”+ t );

Console.ReadKey();

		}

	}

}
