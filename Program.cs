using System;

namespace App
{

	class Names
	{
		public static Random r = new Random();

		public static int randomNum(int a, int b)
		{
			return r.Next(a, b + 1);
		}

		public static string fruitNames()
		{
			List<string> names = new List<string>();

			names.Add("Apple");
			names.Add("Bananna");
			names.Add("Pear");
			names.Add("Pineapple");

			int namesLength = r.Next(names.Count);

			return names[namesLength];

		}
		 
		public static string fruitNames2()
		{
			List<string> names = new List<string>();

			names.Add("Apple");
			names.Add("Bananna");
			names.Add("Pear");
			names.Add("Pineapple");

			int namesLength = r.Next(names.Count);

			return names[namesLength];
		}


		public static string Operators(params string[] op)
		{

			List<string> MathOp = new List<string>();
			MathOp.Add("+");
			MathOp.Add("-");
			MathOp.Add("*");

			int randomOp = r.Next(MathOp.Count);
			return MathOp[randomOp];

		}

		public static string fruitName1()
		{
			List<string> names = new List<string>();

			names.Add("Apple's");
			names.Add("Bananna's");
			names.Add("Pear's");
			names.Add("Pineapple's");

			int namesLength = r.Next(names.Count);



			return names[namesLength];

		}

		public static string FruitNames1()
		{
			List<string> names = new List<string>();
			names.Add("Lemon");
			names.Add("Plum");
			names.Add("Blueberry");
			names.Add("Raspberry");

			int randomName = r.Next(names.Count);
			return names[randomName];


		}


		public static string FruitNames2()
		{
			List<string> names = new List<string>();
			names.Add("Lemon's");
			names.Add("Plum's");
			names.Add("Blueberry's");
			names.Add("Raspberry's");

			int randomName = r.Next(names.Count);
			return names[randomName];


		}


		public void WelcomeUser(params string[] message)
		{

			for(int i = 0; i < message.Length; i++)
			{
				Console.WriteLine((message[i]));
			}
		}

	}


	class MathFunctions
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static int Sub(int a, int b)
		{
			return a - b;
		}

		public static int Mul(int a, int b)
		{
			return a * b;
		}



		public static void isAddingNum(int num1, int a, int b)
		{
			if (num1 == Add(a, b))
			{
				Console.WriteLine($"Correct That: {a} + {b} = {Add(a, b)}");
				Console.ReadLine();
			}

		}

		public static void isSubNum(int num1, int a, int b)
		{
			if (num1 == Sub(a, b))
			{
				Console.WriteLine($"Correct That: {a} - {b} = {Sub(a, b)}");
				Console.ReadLine();
			}

		}

		public static void isMulNum(int num1, int a, int b)
		{
			if (num1 == Mul(a, b))
			{
				Console.WriteLine($"Correct That: {a} * {b} = {Mul(a, b)}");
				Console.ReadLine();
			}

		}

	}

	class App
	{

		public static void Main(string[] _)
		{

			App app = new App();
			Names n = new Names();
			MathFunctions m = new MathFunctions();

			string? op = Names.Operators();
			
			int num1 = Names.randomNum(0, 10);
			int num2 = Names.randomNum(0, 10);

			Console.WriteLine($"What is: {num1} {op} {num2}");
			int answer = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("Enter Your Name: ");
			string? name = Console.ReadLine();

			n.WelcomeUser("Welcome to: " + name);



			MathFunctions.isAddingNum(answer, num1, num2);
			MathFunctions.isSubNum(answer, num1, num2);
			
			Console.ReadLine();

		}

	}

}