using System.Diagnostics;

namespace M010;

/// <summary>
/// Interfaces
/// Bietet eine Gemeinsamkeit bei Typen, welche keine Gemeinsamkeiten haben
/// Klassen sollten bei der Vererbung nur verwendet werden, wenn die Unterklassen einen Zusammenhang haben
/// z.B.: IComparable bei int, bool, double
/// 
/// Interfaces wie abstrakten Klassen (keine Objekte, keine Bodies bei Methoden)
/// Unterschied zu abstrakten Klassen: Mehrfachvererbung
/// 
/// Verwendung: Polymorphismus
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		Smartphone s = new Smartphone();
		Wertkarte w = new Wertkarte();

		IAufladbar[] a = [s, w];
		a[0].Maximum = 100;
		a[0].Aufladen(50);
		a[1].Maximum = 500;
		a[1].Aufladen(10);
		a[0].PrintLadezustand();
		a[1].PrintLadezustand();

		//Wie kann ich prüfen, ob eine Klasse ein Interface hat?
		if (s is IAufladbar)
		{
			//Typvergleich mit is
		}
	}

	/// <summary>
	/// Wenn ich diese Funktion ausführen möchte, muss ich einen der 7 Wochentage auswählen
	/// </summary>
	static void PrintWochentag(DayOfWeek day)
	{
		//...
	}

	/// <summary>
	/// Auch hier wird über das Interface eingeschränkt, welche Objekte hier übergeben werden können
	/// </summary>
	static void Test(IAufladbar a)
	{
		//...
	}
}

public interface IAufladbar
{
	int Ladezustand { get; set; }

	int Maximum { get; set; }

	public void Aufladen(int x);

	/// <summary>
	/// Ladezustand schön ausgeben
	/// </summary>
	public void PrintLadezustand();

	/// <summary>
	/// Maximum in Prozent darstellen (0-1)
	/// </summary>
	public double MaxProzent();
}

public class Smartphone : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; set; }

	public void Aufladen(int x)
	{
		if (Ladezustand + x > Maximum || Ladezustand + x < 0)
			return;
		Ladezustand += x;
	}

	public double MaxProzent()
	{
		return (double) Ladezustand / Maximum;
	}

	public void PrintLadezustand()
	{
        Console.WriteLine($"Das Smartphone ist zu {MaxProzent() * 100}% geladen.");
    }
}

public class Wertkarte : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; set; }

	public void Aufladen(int x)
	{
		if (Ladezustand + x > Maximum || Ladezustand + x < 0)
			return;
		Ladezustand += x;
	}

	public double MaxProzent()
	{
		return Maximum / Ladezustand;
	}

	public void PrintLadezustand()
	{
		Console.WriteLine($"Die Wertkarte ist mit {Ladezustand}€ beladen.");
	}
}