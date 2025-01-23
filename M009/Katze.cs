namespace M009;

public class Katze : Lebewesen
{
	public Katze(int alter) : base(alter)
	{
	}

	public override void Bewegen(int distanz)
	{
        Console.WriteLine($"Die Katze bewegt sich um {distanz}m");
    }
}