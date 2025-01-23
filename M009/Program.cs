namespace M009;

internal class Program
{
	static void Main(string[] args)
	{
		//Polymorphismus
		//-> Typkompatibilität
		//Welche Typen passen mit welchen anderen Typen zusammen?

		//Jeder Typ ist immer mit seinen Oberklassen kompatibel
		Lebewesen lw = new Mensch(30, "Max");

		//Lebewesen l = new Lebewesen(20);

		//object ist mit allen Typen kompatibel, da es die oberste Klasse in der Typhierarchie ist
		object o = new Mensch(10, "");
		o = new Program();
		o = 123;

		//Ein object[] kann alles halten
		object[] objects = [new Mensch(10, ""), 123, "Hallo", false];

		//Polymorphismus gilt überall wo Typen verwendet werden
		Test(lw);
		Test(o);
		Test(objects);

		///////////////////////////////////////////////////////////////////////

		//Typ
		//Jedes Objekt hat immer einen Typen
		//Der Typ eines Objekts ist immer die Klasse/Struct dahinter

		//GetType()
		//Gibt den Typen hinter einem Objekt zurück (welches an der Variable hängt)
		//GetType() kann bei jedem beliebigen Objekt verwendet werden
		lw.GetType();
        Console.WriteLine(lw.GetType()); //M009.Mensch

		//typeof(...)
		//Gibt den Typen hinter einem Namen zurück (Klassenname, Structname, Enumname, ...)
		//Funktioniert nicht bei Variablennamen
		Type lType = typeof(Lebewesen);

        //Typvergleich
        //Mit einem Typvergleich können wir herausfinden, was sich hinter einer Variable befindet
        //WICHTIG: Dieser Typvergleich ist exakt
        Console.WriteLine(lw.GetType()); //Mensch
        Console.WriteLine(typeof(Lebewesen)); //Lebewesen
        if (lw.GetType() == typeof(Lebewesen))
		{
			//false
		}

		if (lw.GetType() == typeof(Mensch))
		{
			//true
		}

		//Vererbungshierarchietypvergleich
		//is-Vergleich
		//Mithilfe von is werden Vererbungen beachtet
		if (lw is Mensch)
		{
			//true
		}

		if (lw is Lebewesen)
		{
			//true
		}

		if (lw is object)
		{
			//immer true
		}

		///////////////////////////////////////////////////////////////////////

		//abstract
		//Klassen, welche nur eine Struktur vorgeben
		//Diese Klassen werden ausschließlich für Vererbung verwendet
		//Jede Methode/Property in der Klasse hat keinen Body
		//Von abstrakten Klassen können keine Objekte erstellen (kein new)

		//Beispiel: Lebewesen[]
		Lebewesen[] zoo = new Lebewesen[3];
		zoo[0] = new Mensch(30, "");
		zoo[1] = new Katze(10);
		zoo[2] = new Mensch(25, "");

		foreach (Lebewesen lebewesen in zoo)
		{
			//Aufgabe: Von jedem Lebewesen den Namen ausgeben
			//Problem: Nicht jedes Lebewesen hat einen Namen

			if (lebewesen.GetType() == typeof(Mensch))
			{
				//Problem: Ein Lebewesen Objekt hat keinen Namen
				//Lösung: Das Lebewesen Objekt zu einem Mensch Objekt konvertieren

				//Durch den Typvergleich wurde hier sichtergestellt, dass es sich hierbei um einen Menschen handelt
				Mensch m = (Mensch) lebewesen; //Bei einem Typvergleich folgt generell eine Konvertierung
                Console.WriteLine(m.Name);
            }

			//Beim is-Vergleich ist die Konvertierung direkt implementierbar
			if (lebewesen is Mensch m2)
			{
				//Mensch m2 = (Mensch) lebewesen;
				Console.WriteLine(m2.Name);
            }
		}
	}

	static void Test(object o) { }
}