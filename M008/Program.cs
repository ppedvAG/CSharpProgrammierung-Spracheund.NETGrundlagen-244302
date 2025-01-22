namespace M008;

/// <summary>
/// Vererbung
/// 
/// Oberklassen definieren, welche eine Oberkategorie zu beliebig vielen Unterklassen darstellen
/// 
/// z.B.: Haus -> Hochhaus, Einfamilienhaus, Hütte, ...
/// z.B.: Pflanze -> Baum, Busch, Gras, ...
/// z.B.: Lebewesen -> Mensch, Hund, Katze, ...
/// 
/// Effekte
/// - Die Oberklasse vererbt ihre Properties + Methoden an die Unterklassen weiter
/// - Polymorphismus
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch(30, "Max");
		m.Alter = 30; //Alter wird vererbt
		m.Bewegen(10); //Bewegen wird vererbt
	}
}

public class Lebewesen
{
	public int Alter { get; set; }

	/// <summary>
	/// virtual & override
	/// 
	/// Eine mit virtual gekennzeichnete Methode kann in den Unterklassen überschrieben werden
	/// Normale Methoden können nicht überschrieben werden
	/// 
	/// Mithilfe des override Keywords kann eine Überschreibung erzeugt werden
	/// </summary>
	public virtual void Bewegen(int distanz)
	{
        Console.WriteLine($"Lebewesen bewegt sich um {distanz}m");
    }

	/// <summary>
	/// Wenn ein Konstruktor in der Oberklasse definiert ist, muss jede Unterklasse einen verketteten Konstruktor enthalten
	/// </summary>
	public Lebewesen(int alter)
	{
		Alter = alter;
	}
}

/// <summary>
/// Mit : <Klasse> kann eine Vererbung erzeugt werden
/// 
/// Die Mensch Klasse erbt nun Alter + Bewegen von der Oberklasse
/// </summary>
public sealed class Mensch : Lebewesen
{
	public string Name { get; set; }

	/// <summary>
	/// Strg + . -> Generate Constructor
	/// 
	/// Wenn dieser Konstruktor weitere Felder enthalten soll, können diese hier einfach hinzugefügt werden
	/// </summary>
	public Mensch(int alter, string name) : base(alter)
	{
		Name = name;
	}

	/// <summary>
	/// override eintippen -> Abstand -> Methode auswählen -> Enter
	/// </summary>
	public override void Bewegen(int distanz)
	{
        Console.WriteLine($"{Name} bewegt sich um {distanz}m");
    }
}