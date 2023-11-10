using System;

class Taschenrechner
{
    static void Main()
    {
        double zahl1, zahl2, ergebnis = 0.0;
        char operatorSymbol;

        Console.Write("Gib die erste Zahl ein: ");
        while (!double.TryParse(Console.ReadLine(), out zahl1))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein: ");
        }

        Console.Write("Wähle eine Operation (+, -, *, /): ");
        while (!char.TryParse(Console.ReadLine(), out operatorSymbol) || (operatorSymbol != '+' && operatorSymbol != '-' && operatorSymbol != '*' && operatorSymbol != '/'))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte wähle eine gültige Operation: ");
        }

        Console.Write("Gib die zweite Zahl ein: ");
        while (!double.TryParse(Console.ReadLine(), out zahl2))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein: ");
        }

        switch (operatorSymbol)
        {
            case '+':
                ergebnis = zahl1 + zahl2;
                break;
            case '-':
                ergebnis = zahl1 - zahl2;
                break;
            case '*':
                ergebnis = zahl1 * zahl2;
                break;
            case '/':
                if (zahl2 != 0)
                {
                    ergebnis = zahl1 / zahl2;
                }
                else
                {
                    Console.WriteLine("Division durch Null ist nicht erlaubt.");
                    return;
                }
                break;
        }

        Console.WriteLine("Das Ergebnis von {0} {1} {2} ist: {3}", zahl1, operatorSymbol, zahl2, ergebnis);
    }
}