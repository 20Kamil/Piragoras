
using System;

class Program
{
    static void Main()
    {
        // Przyprostokątne
        double a = 3.5;
        double b = 6;

        // Obliczenia zgodnie z twierdzeniem Pitagorasa
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        // Wyświetlenie wyniku w konsoli
        Console.WriteLine($"Długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych {a} i {b} wynosi: {c}");
    }
}