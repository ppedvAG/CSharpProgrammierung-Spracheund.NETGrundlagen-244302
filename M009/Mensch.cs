namespace M009;

public sealed class Mensch : Lebewesen
{
	public string Name { get; set; }

	public Mensch(int alter, string name) : base(alter)
	{
		Name = name;
	}

	public override void Bewegen(int distanz)
	{
		Console.WriteLine($"{Name} bewegt sich um {distanz}m");
	}
}