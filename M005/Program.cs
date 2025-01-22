//Funktionen
//Code in Blöcken ablegen und diese später mehrmals verwenden

//Aufbau:
//<Modifier> <Rückgabewert> <Name>(<Par1>, <Par2>, ...) { Body }

//Modifier
//Verschiedene Keywords, welche die Funktion beeinflussen
//Beispiele: Access Modifier, static, async, ref, extern, sealed, abstract, ...

//Rückgabewert
//Jede Funktion kann ein Ergebnis haben, dieses wird per return am Ende der Funktion zurückgegeben
//Das Ergebnis kann im Anschluss in einer Variable gefangen werden und weiterverwendet werden
//Beispiel: Eingabe vom Benutzer bei Console.ReadLine() in einer string-Variable speichern
//WICHTIG: Wenn eine Funktion kein Ergebnis hat, muss sie den Rückgabetyp void haben

//Name
//Über den Namen können wir die Funktion ausführen
//Funktionen in C# werden groß geschrieben

//Parameter
//Gibt vor, welche Daten die Funktion erwartet, wenn sie ausgeführt werden soll
//Wenn eine Funktion ausgeführt wird, muss jeder Parameter mit einem Wert befüllt werden
//Jeder Parameter benötigt immer einen Typen und einen Namen (wie Variable)
//Beispiel: Console.WriteLine() benötigt einen Parameter, dieser wird in der Konsole ausgegeben

//Body
//Der Code den die Funktion ausführen soll
//Kann auf die Parameter zugreifen
//Kann ein Ergebnis zurückgeben per return-Keyword

////////////////////////////////////////////////////////////////////////////

internal class Program
{
	private static void Main(string[] args)
	{
		int s = PrintAddiere(4, 6);
		Console.WriteLine($"Die Summe ist: {s}");

		double summe = PrintAddiere(4.0, 6.0);
        Console.WriteLine($"Die Summe (Kommazahl) ist: {summe}");

		///////////////////////////////////

		Addiere(1, 2);
		Addiere(4, 8, 2);
		Addiere(3, 6, 1, 9, 2);
		Addiere(1);
		Addiere();

		int[] zahlen = [2, 5, 9];
		Addiere(zahlen);

		///////////////////////////////////

		Subtrahiere(); //a, b und c bleiben 0
		Subtrahiere(4, 9); //c bleibt 0
		Subtrahiere(c: 10, a: 30); //b überspringen, b bleibt 0

		///////////////////////////////////

		//TryParse
		//Parsen mit Sicherheit
		//int.Parse("ABC"); //Absturz

		//TryParse gibt einen bool zurück, dieser sagt aus, ob das Parsen funktioniert hat oder nichts
		int ergebnis; //Hier oben muss eine Variable definiert werden, welche das Ergebnis (bei Erfolg) einfängt
		bool funktioniert = int.TryParse("123", out ergebnis); //Über out ergebnis wird der Parameter mit der Variable verbunden
		if (funktioniert)
		{
            Console.WriteLine($"Zahl: {ergebnis}");
        }
		else
		{
            Console.WriteLine("Parsen hat nicht funktioniert");
        }
	}

	//Aufgabe: Funktion, welche zwei Zahlen empfängt und diese Addiert + die Gleichung ausgibt (in der Konsole)
	static int PrintAddiere(int z1, int z2)
	{
		int summe = z1 + z2;
		Console.WriteLine($"{z1} + {z2} = {summe}");
		return summe;
	}

	//Überladung
	//Denselben Funktionsnamen mehrmals verwenden
	//Hierbei müssen sich die Parameter unterscheiden
	//Beispiel: Console.WriteLine() (18 Overloads)
	static double PrintAddiere(double z1, double z2)
	{
		double summe = z1 + z2;
		Console.WriteLine($"{z1} + {z2} = {summe}");
		return summe;
	}

	//params
	//Ermöglicht, beliebig viele Parameter an die Funktion zu geben
	//Innerhalb der Funktion ist der params-Parameter ein Array
	//Jede Funktion kann nur einen params-Parameter haben
	static int Addiere(params int[] zahlen)
	{
		return zahlen.Sum();
	}

	//Optionale Parameter
	//Parameter mit einer Vorbelegung, diese kann überschrieben werden
	static void Subtrahiere(int a = 0, int b = 0, int c = 0)
	{
        Console.WriteLine(a - b - c);
    }
}