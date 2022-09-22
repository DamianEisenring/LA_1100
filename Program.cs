using System.ComponentModel.Design;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu:           //Das Menu wird hier aufgerufen und stellt möglichkeiten zwischen SPIELEN, SPIELREGELN UND EXIT
            Console.Clear();
            string userSelection;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("░▒█▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄░█▀▄▀█░▒█▄░▒█░█░▒█░█▀▄▀█░█▀▀▄░█▀▀░█▀▀▄░▒█▀▀█░█░▒█░█▀▀░█▀▀░█▀▀░█▀▀░█▀▀▄\r\n░▒█▄▄▀░█▄▄█░█░▒█░█░█░█░░█░█░▀░█░▒█▒█▒█░█░▒█░█░▀░█░█▀▀▄░█▀▀░█▄▄▀░▒█░▄▄░█░▒█░█▀▀░▀▀▄░▀▀▄░█▀▀░█▄▄▀\r\n░▒█░▒█░▀░░▀░▀░░▀░▀▀░░░▀▀░░▀░░▒▀░▒█░░▀█░░▀▀▀░▀░░▒▀░▀▀▀▀░▀▀▀░▀░▀▀░▒█▄▄▀░░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀▀\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("[1] SPIELEN");
                Console.WriteLine("[2] SPIELREGELN");
                Console.WriteLine("[3] EXIT ");
                Console.Write("Wählen sie bitte eine Option: ");
                userSelection = Console.ReadLine();
                
                
               
                switch (userSelection)
                {
                    case "1":
                        goto PLAY;
                        
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("1.Die Zahl muss zwischen 1-100 sein." +
                            "\n2.Die Zahlen dürfen nicht ausgeschrieben werden"+ "\n3.Sie müssen die Runden immer fertig spielen, bis sie wieder zurück ins Menu können." +
                             " \nFalls diese Regeln nicht befolgt werden, wird das Programm neu gestartet");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Drücke einen beliebigen Knopf um zurück zu gehen...");
                        Console.ReadKey();
                        goto Menu;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
            } while (true); ;


        PLAY:
            
            bool weitermachen = true; //Das Spiel wird hier gespielt
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("░▒█▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄░█▀▄▀█░▒█▄░▒█░█░▒█░█▀▄▀█░█▀▀▄░█▀▀░█▀▀▄░▒█▀▀█░█░▒█░█▀▀░█▀▀░█▀▀░█▀▀░█▀▀▄\r\n░▒█▄▄▀░█▄▄█░█░▒█░█░█░█░░█░█░▀░█░▒█▒█▒█░█░▒█░█░▀░█░█▀▀▄░█▀▀░█▄▄▀░▒█░▄▄░█░▒█░█▀▀░▀▀▄░▀▀▄░█▀▀░█▄▄▀\r\n░▒█░▒█░▀░░▀░▀░░▀░▀▀░░░▀▀░░▀░░▒▀░▒█░░▀█░░▀▀▀░▀░░▒▀░▀▀▀▀░▀▀▀░▀░▀▀░▒█▄▄▀░░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀▀\r\n");
                Console.ForegroundColor = ConsoleColor.White;
               



                Random rnd = new Random();
                int number = rnd.Next(1, 100);
                int versuche = 0;
                bool resultat = false;
                int eingabe;
                int runden = 0;
                while (!resultat)
                {

                    

                    try
                    {

                        Console.Write("Geben sie eine Zahl ein: ");
                        eingabe = Convert.ToInt32(Console.ReadLine());
                        if (eingabe > number && eingabe >= 1 && eingabe <= 100)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(eingabe + " ihre Zahl ist zu gross, versuche es kleiner");
                            Console.ForegroundColor = ConsoleColor.White;
                            versuche++;
                        }
                        else if (eingabe < number && eingabe <= 100 && eingabe >= 1)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(eingabe + " ihre Zahl ist zu klein, versuche es grösser");
                            Console.ForegroundColor = ConsoleColor.White;
                            versuche++;
                        }
                        else if (number == eingabe)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ihre Zahl " + number + " ist richtig");
                            Console.ForegroundColor = ConsoleColor.White;
                            resultat = true;
                            versuche++;
                            Console.WriteLine("Sie hatten " + versuche + " Versuche");
                            Console.WriteLine("");
                            Console.WriteLine("----------------------------------------");
                            runden++;

                            Console.Write("Möchten sie weiter machen? [true/false] ");
                            weitermachen = Convert.ToBoolean(Console.ReadLine());
                            if(weitermachen == false)
                            {
                                goto Menu;
                            }
                            if (weitermachen != true && weitermachen != false)
                            {
                                throw new FormatException();
                            }
                        }
                        if (eingabe > 100)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        else if (eingabe < 1)
                        {
                            throw new ArgumentOutOfRangeException();
                        }

                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sie haben eine falsche Eingabe getätigt, wegen dem müssen sie von vorne beginnen.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----------------------------------------");

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Diese Zahl steht nicht zur Auswahl.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----------------------------------------");
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("----------------------------------------");
                    }

                }

            } while (weitermachen == true);
        }
    }
}