namespace M014;

/// <summary>
/// Fehlerbehandlung
/// 
/// try-catch
/// Wird verwendet, um Exceptions (= Fehler -> Abstürze) zu verhindern
/// Hintergrund: Plattformunabhängigkeit
/// Wenn im Code ein Fehler auftreten soll, sollte dieser Fehler per Exception verursacht werden
/// Wenn eine Exception auftritt, kann der Benutzer des Codes selbst entscheiden, wie diese Exception behandelt wird
/// Hier kann jetzt z.B. ein Log, auf eine Webseite, in eine GUI geschrieben werden, ...
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		try //Code markieren -> Rechtsklick -> Snippet -> Surround With
		{
			string eingabe = Console.ReadLine(); //3 Fehler: IOException, OutOfMemoryException, ArgumentOutOfRangeException
			int x = int.Parse(eingabe); //3 Fehler: ArgumentNullException, FormatException, OverflowException
		}

		//Wenn ein catch-Block ausgeführt wird, stürzt das Programm nicht mehr ab
		catch (FormatException ex) //Hier kann ein spezifischer Fehler behandelt werden (hier Buchstaben)
		{
            //Über ex kann auf den Fehler zugegriffen werden
            Console.WriteLine("Die Eingabe ist keine Zahl");
            Console.WriteLine(ex.Message); //Die C# interne Fehlermeldung
            Console.WriteLine(ex.StackTrace); //Rückverfolgung, wo der Fehler passiert ist
        }
		catch (OverflowException ex)
		{
            Console.WriteLine("Die Eingabe ist zu groß/klein");
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.StackTrace);
        }
		catch (Exception) //Alle anderen Fehler
		{
            Console.WriteLine("Anderer Fehler");
        }
		finally //Wird immer ausgeführt (egal ob Fehler oder nicht)
		{
            Console.WriteLine("Parsen fertig");
        }

		//throw
		//Fehler/Absturz verursachen
		//Benötigt eine Exception als Argument
		try
		{
			throw new InvalidDataException("Ein Test"); //Hier kann eine Nachricht mitgegeben werden
		}
		catch (Exception e)
		{
            Console.WriteLine(e.Message); //Über e.Message kann die Nachricht ausgelesen werden
			throw; //Programm trotzdem abstürzen lassen (vor dem Absturz noch Code ausführen)
        }
    }
}
