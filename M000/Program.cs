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

		Fahrzeug fzg = new Fahrzeug("VW", 250, 20000);
        Console.WriteLine(fzg.Info());
		fzg.Beschleunige(50); //Fehler
		fzg.StarteMotor(); //OK
		fzg.Beschleunige(100); //OK
		fzg.Beschleunige(500); //Fehler
        Console.WriteLine(fzg.Info());
        fzg.StoppeMotor(); //Fehler
		fzg.Beschleunige(-100); //OK
		fzg.StoppeMotor(); //OK
        Console.WriteLine(fzg.Info());
    }
}
