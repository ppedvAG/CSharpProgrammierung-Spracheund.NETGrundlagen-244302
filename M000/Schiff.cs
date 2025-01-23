namespace M000;

public class Schiff : Fahrzeug, IBeladbar
{
	public string Treibstoff { get; set; }

	public Fahrzeug GeladenesFahrzeug { get; set; }

	public Schiff(string name, int maxV, double preis, string treibstoff) : base(name, maxV, preis)
	{
		Treibstoff = treibstoff;
	}

	public override string Info()
	{
		return "Das Schiff" + base.Info() + $" Es fährt mit {Treibstoff}." + 
			(GeladenesFahrzeug != null ? $" Es hat {GeladenesFahrzeug} geladen." : "");
	}

	public override void Hupen()
	{
        Console.WriteLine("...");
    }

	public void Belade(Fahrzeug fzg)
	{
		if (GeladenesFahrzeug == null)
			GeladenesFahrzeug = fzg;
		else
            Console.WriteLine("Schiff ist bereits beladen");
    }

	public Fahrzeug Entlade()
	{
		//Hier wird eine Referenz auf das Fahrzeug Objekt gelegt
		Fahrzeug f = GeladenesFahrzeug;
		//Hier gibt es jetzt 2 Referenzen auf das Fahrzeug Objekt
		GeladenesFahrzeug = null;
		return f;
	}
}