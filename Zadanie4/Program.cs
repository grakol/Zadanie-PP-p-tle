int tury = 0;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    string tekst = Console.ReadLine();

    if (!int.TryParse(tekst, out tury))
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (tury < 1)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    if (tury > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine("Rozpoczynam grę na " + tury + " tur.");

for (int i = 1; i <= tury; i++)
{
    Console.WriteLine("Tura " + i);
}

