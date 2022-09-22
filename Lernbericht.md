# Lern-Bericht
Damian Eisenring

## Einleitung

Es ging darum, dass wir einen Random Number Guesser programmierten.

## Was habe ich gelernt?

Ich habe gelernt, wie ich mit Try und Catch Fehler erkennen kann.

## Beschreibung

Mit Try und Catch verhindern kannst du Fehler, also Exceptions (Ausnahmen) erkennen und diesen dann mit throw behandeln, wenn du mit einer spezifischen Exception eine andere Ausgabe geben willst, als wenn es nur catch hat dann hat es für jede Exception immer die gleiche Rückgabe. Heisst catch enthält immmer eine Sonderrückmeldung falls eine Exception auftritt. Mit throw kann man die Exception spezifizieren und so andere Nachrichten machen, dass es genauere Nachrichten gibt. Mit Try und Catch kann man jetzt auch Zahlen begrenzen ohne das Programm gleich abstürzt ohne eine Nachricht zu Hinterlassen.

```csharp 
	do
            {
                try
                {
                    Console.Write("Geben sie eine Zahl ein: ");
                    int eingabe = Convert.ToInt32(Console.ReadLine());
		    if(eingabe < 1 || eingabe > 10) //Hier wird die Zahlen ausgabe begrenzt
		    {
		    	throw new FormatException();
		    }

                }
                catch(FormatException)
                {
			Console.WriteLine("Üngülitge Eingabe");
                }
		catch
		{
		 	Console.WriteLine("Error 404");
		}
            } while (true);	    //Die Do-While schleifen macht, dass der User im wieder Zahlen eingeben kann.
```
![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/111045919/191697705-330f816a-0f93-4d0b-b803-167da3685d9d.gif)
#### Hier wird dargestellt, welche Fehlernachricht wann kommt und dass die Zahlen begrenzt worden sind.

	
## Verifikation

Ich habe einem Laien erklärt, was Try und Catch ist und wie es die Person anwenden kann.

# Reflektion zum Arbeitsprozess

Ich ging sehr motiviert an dieses Projekt ran und kam somit sehr gut voran.

Weil ich so gut vorankam, hatte ich nach einer Zeit das Problem, dass ich schon fertig war mit dem Programm und im Homeschooling Unterricht in der letzten Woche schon fertig war mit dem Programm.

**VBV**: Ich würde nächstes mal bei der Planung mehr Zeit investieren, dass ich nächstes mal mehr User Stories habe und mehr umsetzten kann und dann eher etwas nicht gemacht habe, anstatt in der Programmierzeit dann neue Ideen zu suchen.
