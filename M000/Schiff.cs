namespace M000;

public class Schiff : Fahrzeug
{
	public string Treibstoff { get; set; }

	public Schiff(string name, int maxV, double preis, string treibstoff) : base(name, maxV, preis)
	{
		Treibstoff = treibstoff;
	}

	public override string Info()
	{
		return "Das Schiff" + base.Info() + $" Es fährt mit {Treibstoff}.";
	}
}