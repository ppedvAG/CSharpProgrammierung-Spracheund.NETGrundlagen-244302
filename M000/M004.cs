internal class M004
{
	private static void Main2(string[] args)
	{
		while (true)
		{
			Console.Write("Gib die erste Zahl ein: ");
			string eingabe1 = Console.ReadLine();
			double zahl1 = double.Parse(eingabe1);

			Console.Write("Gib die zweite Zahl ein: ");
			string eingabe2 = Console.ReadLine();
			double zahl2 = double.Parse(eingabe2);

			Console.WriteLine("Wähle eine Rechenoperation aus: ");
			Rechenoperation[] operationen = Enum.GetValues<Rechenoperation>();
			foreach (Rechenoperation operation in operationen)
			{
				int z = (int) operation; //Enumwert in Zahl umwandeln
				Console.WriteLine($"{z}: {operation}");
			}
			string eingabe3 = Console.ReadLine();

			//int zahl3 = int.Parse(eingabe2);
			//Rechenoperation op = (Rechenoperation) zahl3;

			Rechenoperation op = Enum.Parse<Rechenoperation>(eingabe3);
			switch (op)
			{
				case Rechenoperation.Addition:
					Console.WriteLine($"Ergebnis: {zahl1 + zahl2}");
					break;
				case Rechenoperation.Subtraktion:
					Console.WriteLine($"Ergebnis: {zahl1 - zahl2}");
					break;
				case Rechenoperation.Multiplikation:
					Console.WriteLine($"Ergebnis: {zahl1 * zahl2}");
					break;
				case Rechenoperation.Division:
					if (zahl2 != 0)
						Console.WriteLine($"Ergebnis: {zahl1 / zahl2}");
					else
						Console.WriteLine("Division durch 0 nicht möglich!");
					break;
			}

			Console.WriteLine("Enter drücken zum Wiederholen");
			if (Console.ReadKey(true).Key != ConsoleKey.Enter)
				break;
			else
				Console.Clear();
		}
	}
}