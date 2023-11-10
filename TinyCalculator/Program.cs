using System;

class Taschenrechner
{
    static void Main()
    {
        double ergebnis = 0.0;

        while (true)
        {
            Console.WriteLine("Aktuelles Ergebnis: " + ergebnis);
            Console.Write("Möchtest du mit dem alten Ergebnis weiter rechnen? (j/n): ");
            string weiterRechnenAntwort = Console.ReadLine();

            if (weiterRechnenAntwort.ToLower() != "j")
            {
                Console.Write("Gib eine Zahl ein: ");
                string eingabe = Console.ReadLine();

                double zahl;
                if (double.TryParse(eingabe, out zahl))
                {
                    ergebnis = zahl;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                    continue;
                }
            }

            Console.Write("Wähle eine Operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double neueZahl;
            Console.Write("Gib die nächste Zahl ein: ");
            string eingabeNeueZahl = Console.ReadLine();

            if (double.TryParse(eingabeNeueZahl, out neueZahl))
            {
                switch (operation)
                {
                    case "+":
                        ergebnis += neueZahl;
                        break;
                    case "-":
                        ergebnis -= neueZahl;
                        break;
                    case "*":
                        ergebnis *= neueZahl;
                        break;
                    case "/":
                        if (neueZahl != 0)
                        {
                            ergebnis /= neueZahl;
                        }
                        else
                        {
                            Console.WriteLine("Division durch Null ist nicht erlaubt.");
                        }
                        break;
                    default:
                        Console.WriteLine("Ungültige Operation.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
            }

            Console.Write("Möchtest du weiter rechnen? (j/n): ");
            string weiterRechnen = Console.ReadLine();

            if (weiterRechnen.ToLower() != "j")
            {
                break;
            }
        }

        Console.WriteLine("Endgültiges Ergebnis: " + ergebnis);
    }
}