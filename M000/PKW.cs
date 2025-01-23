namespace M000;

public class PKW : Fahrzeug
{
	public int Sitzanzahl { get; set; }

	public PKW(string name, int maxV, double preis, int sitzanzahl) : base(name, maxV, preis)
	{
		Sitzanzahl = sitzanzahl;
	}

	public override string Info()
	{
		return "Der PKW" + base.Info() + $" Es hat {Sitzanzahl} Sitze.";
	}

	public override void Hupen()
	{
        Console.WriteLine("...");
    }
}