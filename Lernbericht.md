# Lern-Bericht
Damian Eisenring

## Einleitung

Es ging darum, dass wir einen Random Number Guesser programmierten.

## Was habe ich gelernt?

Ich habe gelernt, wie ich mit Try und Catch Fehler erkennen kann.

## Beschreibung

Mit Try und Catch verhindern kannst du Fehler, also Exceptions (Ausnahmen) erkennen und diesen dann mit throw behandeln, wenn du mit einer spezifischen Exception eine andere Ausgabe geben willst, als wenn es nur catch hat dann hat es für jede Exception immer die gleiche Rückgabe. Heisst catch enthält immmer eine Sonderrückmeldung falls eine Exception auftritt. Mit throw kann man die Exception spezifizieren und so andere Nachrichten machen, dass es genauere Nachrichten gibt. 

```csharp 
	do
            {
                try
                {
                    Console.Write("Geben sie eine Zahl ein: ");
                    int eingabe = Convert.ToInt32(Console.ReadLine());
		    if(eingabe < 1 || eingabe > 10)
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
            } while (true);	    
```
![ezgif com-gif-maker](https://user-images.githubusercontent.com/111045919/191690569-7090981e-efb9-44c6-81ef-0a9b270c04b4.gif)

	


* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.
	
## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
