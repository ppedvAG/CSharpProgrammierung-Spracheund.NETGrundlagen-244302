namespace M007;

internal class Program
{
	static void Main(string[] args)
	{
		//GC Demo
		//int[] zahlen = Enumerable.Range(0, 1_000_000_000).ToArray();

		//////////////////////////////////////////////////

		//Static
		//Effektiv "global"
		//Eine Methode/Property mit dem static Modifier kann immer und überall benutzt werden
		//Normale Methoden in C# müssen immer über ein Objekt aufgerufen werden
		//Mit static muss von der entsprechenden Klasse kein Objekt erstellt werden
		//HelloWorld(); //Nicht möglich

		//Alle Funktionen in der Console Klasse sind static
		Console.WriteLine();

		//DateTime.Now ist auch static, weil die jetztige Zeit einfach existiert
        Console.WriteLine(DateTime.Now);

		//Static Methode aus einer anderen Klasse aufrufen (Klassenname muss angegeben werden)
		Program.Test();

		//////////////////////////////////////////////////

		//Arbeiten mit Datumswerten
		//Zwei Klassen: DateTime, TimeSpan
		//DateTime: Bestimmter Punkt mit Datum + Uhrzeit
		//TimeSpan: Zeitspanne, wird für Berechnungen benötigt
		DateTime dt = new DateTime(2025, 01, 22, 16, 02, 30);
		dt += TimeSpan.FromHours(3); //Datumswerte können mit Rechenoperatoren verwendet werden
        Console.WriteLine(dt);

		//////////////////////////////////////////////////

		//Null
		//Die Variable ist leer
		Person p1 = null; //In p1 ist kein Wert enthalten

		//p1.Vorname = "Max"; //Wenn die Person nicht existiert, kann sie auch keinen Namen bekommen

		//Vorher auf null prüfen
		if (p1 != null)
			p1.Vorname = "Max";

		//structs können nicht null sein
		//int x = null; //Nicht möglich

		//Fragezeichen am Ende eines Typens: Nullable Typ
		int? x = null;
	}

	void HelloWorld()
	{
        Console.WriteLine("Hello World");
    }

	static void Test() { }
}

public class Person
{
	public string Vorname { get; set; }
}