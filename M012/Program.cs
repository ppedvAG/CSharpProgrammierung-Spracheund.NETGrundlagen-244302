using System.Diagnostics;

namespace M012;

internal class Program
{
	static void Main(string[] args)
	{
		#region Einfaches Linq
		//IEnumerable
		//Anleitung zur Erstellung der fertigen Daten
		//Die Daten werden erzeugt, wenn die Anleitung ausgeführt wird (foreach, ToArray, ToList, ...)
		IEnumerable<int> zahlen = Enumerable.Range(0, 1_000_000_000);
		
		List<int> ints = Enumerable.Range(1, 20).ToList();

        Console.WriteLine(ints.Average());
        Console.WriteLine(ints.Min());
        Console.WriteLine(ints.Max());
        Console.WriteLine(ints.Sum());

        Console.WriteLine(ints.First());
        Console.WriteLine(ints.Last());

        Console.WriteLine(ints.FirstOrDefault());
        Console.WriteLine(ints.LastOrDefault());

		//WICHTIG: Jede Linq-Funktion fängt mit e => an
		//Sucht das erste Element, welches durch 50 teilbar ist
		//Console.WriteLine(ints.First(e => e % 50 == 0)); //Absturz
		Console.WriteLine(ints.FirstOrDefault(e => e % 50 == 0)); //0, kein Absturz
		#endregion

		#region Linq mit Objekten
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//Alle VWs finden
		List<Fahrzeug> vws = fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW).ToList();

		//Alle VWs finden, welche mind. 250km/h fahren können
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW && e.MaxV >= 250);
		fahrzeuge
			.Where(e => e.Marke == FahrzeugMarke.VW)
			.Where(e => e.MaxV >= 250);

		//OrderBy, OrderByDescending
		//Alle Fahrzeuge nach Marke sortieren
		fahrzeuge.OrderBy(e => e.Marke);

		//Alle Fahrzeuge nach Marke, MaxV sortieren
		fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxV);
		fahrzeuge.OrderByDescending(e => e.Marke).ThenByDescending(e => e.MaxV);

		//Wieviele Fahrzeuge mit MaxV > 200 haben wir?
		fahrzeuge.Count(e => e.MaxV > 200);

		//All, Any
		//Prüft ob alle/mind. ein Element(e) einer Bedingung entsperchen
		//Wird generell mit einer if verwendet
		if (fahrzeuge.Where(e => e.Marke == FahrzeugMarke.BMW).All(e => e.MaxV >= 200))
		{
			//...
		}

		fahrzeuge.Any(); //Prüft, ob die Liste Elemente hat
						 //fahrzeuge.Count > 0

		//Average, Min, MinBy, Max, MaxBy, Sum
		//Wie schnell sind alle Fahrzeuge im Durchschnitt?
		fahrzeuge.Average(e => e.MaxV); //208.41666666666666
		fahrzeuge.Min(e => e.MaxV);
		fahrzeuge.Max(e => e.MaxV);
		fahrzeuge.Sum(e => e.MaxV);

		fahrzeuge.Min(e => e.MaxV); //Die kleinste Geschwindigkeit (int)
		fahrzeuge.MinBy(e => e.MaxV); //Das Fahrzeug mit der kleinsten Geschwindigkeit (Fahrzeug)

		//Skip, Take
		//Überspringe X Elemente, nimm X Elemente

		//Beispiel: Webshop
		int proSeite = 10;
		int seite = 1;
		fahrzeuge.Skip(seite * proSeite).Take(proSeite);

		//Beispiel: Die 3 schnellsten Autos
		fahrzeuge
			.OrderByDescending(e => e.MaxV)
			.Take(3);

		//Select
		//Liste in eine andere Form umwandeln

		//Zwei Fälle
		//1. Einzelnes Feld entnehmen (80%)
		//Beispiel: Liste der Marken
		List<FahrzeugMarke> marken = fahrzeuge.Select(e => e.Marke).ToList();

		fahrzeuge
			.Select(e => e.MaxV)
			.Average();

		//Distinct
		//Welche Marken haben wir?
		marken.Distinct();
		fahrzeuge
			.Select(e => e.Marke)
			.Distinct();

		//2. Liste transformieren (20%)

		//Beispiel: Liste von 0-10 mit 0.1er Schritten
		List<double> d = new();
		for (int i = 0; i < 100; i++)
			d.Add(i / 10.0);

		IEnumerable<double> d2 = Enumerable.Range(0, 100).Select(e => e / 10.0);

        Console.WriteLine(d.SequenceEqual(d2));

		//Liste casten
		//Beispiel: Hinter jeder Marke die Zahl entnehmen
		fahrzeuge.Select(e => (int) e.Marke);
        #endregion
    }
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV;

	public FahrzeugMarke Marke;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxV = v;
		Marke = fm;
	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}