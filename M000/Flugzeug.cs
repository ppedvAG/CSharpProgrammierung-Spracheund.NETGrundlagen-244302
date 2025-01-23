namespace M000;

public class Flugzeug : Fahrzeug
{
	public int MaxFlughoehe { get; set; }

	public Flugzeug(string name, int maxV, double preis, int maxFlughoehe) : base(name, maxV, preis)
	{
		MaxFlughoehe = maxFlughoehe;
	}

	public override string Info()
	{
		return "Das Flugzeug" + base.Info() + $" Es kann auf maximal {MaxFlughoehe}m aufsteigen.";
	}
}