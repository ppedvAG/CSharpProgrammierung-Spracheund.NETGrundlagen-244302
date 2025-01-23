using M000;

internal partial class Program
{
	private static void Main(string[] args)
	{
		//while (true)
		//{
		//	double zahl1 = Rechner.ZahlEingabe("Gib die erste Zahl ein: ");
		//	double zahl2 = Rechner.ZahlEingabe("Gib die zweite Zahl ein: ");
		//	Rechenoperation op = Rechner.RechenoperationEingabe();

		//	Rechner.Berechne(zahl1, zahl2, op);

		//	Console.WriteLine("Enter drücken zum Wiederholen");
		//	if (Console.ReadKey(true).Key != ConsoleKey.Enter)
		//		break;
		//	else
		//		Console.Clear();
		//}

		//////////////////////////////////////////////////

		Console.OutputEncoding = System.Text.Encoding.UTF8;

		//Fahrzeug fzg = new Fahrzeug("VW", 250, 20000);
		//Console.WriteLine(fzg.Info());
		//fzg.Beschleunige(50); //Fehler
		//fzg.StarteMotor(); //OK
		//fzg.Beschleunige(100); //OK
		//fzg.Beschleunige(500); //Fehler
		//Console.WriteLine(fzg.Info());
		//fzg.StoppeMotor(); //Fehler
		//fzg.Beschleunige(-100); //OK
		//fzg.StoppeMotor(); //OK
		//Console.WriteLine(fzg.Info());

		//PKW pkw = new PKW("VW", 250, 20000, 5);
		//Schiff s = new Schiff("Titanic", 50, 10_000_000, "Dampf");
		//Flugzeug f = new Flugzeug("Boeing", 1000, 50_000_000, 10000);
		//Console.WriteLine(pkw.Info());
		//Console.WriteLine(s.Info());
		//Console.WriteLine(f.Info());

		Fahrzeug[] fzg = new Fahrzeug[10];
		for (int i = 0; i < fzg.Length; i++)
		{
			fzg[i] = Fahrzeug.GeneriereFahrzeug(i.ToString());
			//Console.WriteLine(fzg[i].ToString());
        }

		foreach (Fahrzeug f in fzg)
		{
            Console.WriteLine(f); //.ToString() optional
        }

		fzg[2].Hupen();

		int pkws = 0, schiffe = 0, flugzeuge = 0;
		foreach (Fahrzeug f in fzg)
		{
			if (f is PKW)
				pkws++;
			else if (f is Schiff)
				schiffe++;
			else if (f is Flugzeug)
				flugzeuge++;

			//switch (f)
			//{
			//	case PKW:
			//		pkws++;
			//		break;
			//	case Schiff:
			//		schiffe++;
			//		break;
			//	case Flugzeug:
			//		flugzeuge++;
			//		break;
			//}
		}
        Console.WriteLine($"PKWs: {pkws}, Schiffe: {schiffe}, Flugzeuge: {flugzeuge}");
    }
}
