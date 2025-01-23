﻿namespace M000;

public class Fahrzeug
{
	public string Name { get; private set; }

	public int MaxV { get; private set; }

	public int AktV { get; private set; }

	public double Preis { get; private set; }

	public bool MotorLaeuft { get; private set; }

	public Fahrzeug(string name, int maxV, double preis)
	{
		Name = name;
		MaxV = maxV;
		Preis = preis;
	}

	public void StarteMotor()
	{
		if (!MotorLaeuft)
		{
			MotorLaeuft = true;
            Console.WriteLine("Motor gestartet");
        }
		else
			Console.WriteLine("Motor läuft bereits");
    }

	public void StoppeMotor()
	{
		if (MotorLaeuft && AktV == 0)
		{
			MotorLaeuft = false;
            Console.WriteLine("Motor ausgeschalten");
        }
		else
			Console.WriteLine("Motor läuft nicht oder Auto fährt noch");
	}

	public virtual string Info()
	{
		return $" {Name} kostet {Preis}€ und kann maximal {MaxV}km/h fahren." +
					(AktV > 0 ? $" Es fährt gerade {AktV}km/h." : "");  //Ternary-Operator: If's in den Code kompakt einbauen
	}

	public void Beschleunige(int a)
	{
		if (!MotorLaeuft)
		{
			Console.WriteLine("Motor läuft nicht");
			return;
		}

		if (AktV + a > MaxV)
		{
			Console.WriteLine("Die neue Geschwindigkeit würde die Maximalgeschwindigkeit überschreiten");
			return;
		}

		if (AktV + a < 0)
		{
			Console.WriteLine("Die neue Geschwindigkeit würde 0km/h unterschreiten");
			return;
		}

		AktV += a;
        Console.WriteLine($"Das Fahrzeug fährt jetzt {AktV}km/h");

        /////////////////////////////////////////////////////

        //Alternative: 
        //if (MotorLaeuft)
        //{
        //	if (AktV + a <= MaxV)
        //	{
        //		AktV += a;
        //	}
        //	else if (AktV + a >= 0)
        //	{
        //		AktV += a;
        //	}
        //	else
        //	{
        //		//...
        //	}
        //}
        //else
        //{
        //	//...
        //}
    }
}