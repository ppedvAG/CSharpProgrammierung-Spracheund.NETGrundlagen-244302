﻿while (true)
{
	//Console.Write("Gib die erste Zahl ein: ");
	//string eingabe1 = Console.ReadLine();
	//double zahl1 = double.Parse(eingabe1);
	double zahl1 = ZahlEingabe("Gib die erste Zahl ein: ");

	//Console.Write("Gib die zweite Zahl ein: ");
	//string eingabe2 = Console.ReadLine();
	//double zahl2 = double.Parse(eingabe2);
	double zahl2 = ZahlEingabe("Gib die zweite Zahl ein: ");

	//Console.WriteLine("Wähle eine Rechenoperation aus: ");
	//Rechenoperation[] operationen = Enum.GetValues<Rechenoperation>();
	//foreach (Rechenoperation operation in operationen)
	//{
	//	int z = (int) operation; //Enumwert in Zahl umwandeln
	//	Console.WriteLine($"{z}: {operation}");
	//}
	//string eingabe3 = Console.ReadLine();

	//int zahl3 = int.Parse(eingabe2);
	//Rechenoperation op = (Rechenoperation) zahl3;

	//Rechenoperation op = Enum.Parse<Rechenoperation>(eingabe3);

	Rechenoperation op = RechenoperationEingabe();

	Berechne(zahl1, zahl2, op);

	Console.WriteLine("Enter drücken zum Wiederholen");
	if (Console.ReadKey(true).Key != ConsoleKey.Enter)
		break;
	else
		Console.Clear();
}

double Berechne(double zahl1, double zahl2, Rechenoperation operation)
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

double ZahlEingabe(string text)
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

Rechenoperation RechenoperationEingabe()
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

enum Rechenoperation
{
	Addition = 1,
	Subtraktion,
	Multiplikation,
	Division
}