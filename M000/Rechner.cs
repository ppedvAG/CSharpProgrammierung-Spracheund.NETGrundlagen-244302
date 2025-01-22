namespace M000;

public class Rechner
{
	public static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
	{
		switch (operation)
		{
			case Rechenoperation.Addition:
				Console.WriteLine($"Ergebnis: {zahl1 + zahl2}");
				return zahl1 + zahl2;
			case Rechenoperation.Subtraktion:
				Console.WriteLine($"Ergebnis: {zahl1 - zahl2}");
				return zahl1 - zahl2;
			case Rechenoperation.Multiplikation:
				Console.WriteLine($"Ergebnis: {zahl1 * zahl2}");
				return zahl1 * zahl2;
			case Rechenoperation.Division:
				if (zahl2 != 0)
				{
					Console.WriteLine($"Ergebnis: {zahl1 / zahl2}");
					return zahl1 / zahl2;
				}
				else
				{
					Console.WriteLine("Division durch 0 nicht möglich!");
					return double.NaN;
				}
			//Hier muss ein default case definiert werden, da der Compiler nicht wissen kann, das es nur 4 Enumzustände gibt
			default:
				return double.NaN;
		}
	}

	public static double ZahlEingabe(string text)
	{
		while (true)
		{
			Console.Write(text);
			string eingabe = Console.ReadLine();
			double zahl;
			bool b = double.TryParse(eingabe, out zahl);
			if (b)
				return zahl;
		}
	}

	public static Rechenoperation RechenoperationEingabe()
	{
		while (true)
		{
			string info = "Wähle eine Rechenoperation aus: ";
			Rechenoperation[] operationen = Enum.GetValues<Rechenoperation>();
			foreach (Rechenoperation operation in operationen)
			{
				int z = (int) operation; //Enumwert in Zahl umwandeln
				info += $"\n{z}: {operation}";
			}

			double zahl = ZahlEingabe(info + "\n");

			//if (zahl >= 1 && zahl <= 4)
			//{
			//	return (Rechenoperation) zahl;
			//}

			Rechenoperation castOp = (Rechenoperation) zahl;
			if (Enum.IsDefined(castOp))
			{
				return castOp;
			}
		}
	}
}