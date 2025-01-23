namespace M000;

public class Container : IBeladbar
{
	public Fahrzeug GeladenesFahrzeug { get; set; }

	public void Belade(Fahrzeug fzg)
	{
		if (GeladenesFahrzeug == null)
			GeladenesFahrzeug = fzg;
		else
			Console.WriteLine("Container ist bereits beladen");
	}

	public Fahrzeug Entlade()
	{
		Fahrzeug f = GeladenesFahrzeug;
		GeladenesFahrzeug = null;
		return f;
	}
}