namespace RownaniaKwadratowe;

public static class Program {
    public static void Main(string[] args) {
        var numA = FetchInt("Podaj liczbę A: ");
        var numB = FetchInt("Podaj liczbę B: ");
        var numC = FetchInt("Podaj liczbę C: ");

        var delta = Math.Pow(numB, 2) - 4 * numA * numC;
        if (delta > 0) {
            // Delta dodatnia, dwa rozwiązania
            var x1 = (-numB - Math.Sqrt(delta)) / (2 * numA);
            var x2 = (-numB + Math.Sqrt(delta)) / (2 * numA);
            
            Console.WriteLine($"Rozwiązanie 1: x = {x1}");
            Console.WriteLine($"Rozwiązanie 2: x = {x2}");
        } else if (delta == 0) {
            // Delta równa 0, jedno rozwiązanie
            var x = -numB / (2 * numA);
            Console.WriteLine($"Rozwiązanie: x = {x}");
        } else {
            Console.WriteLine("Brak rozwiązania, delta ujemna");
        }
    }
    
    private static double FetchInt(string prompt) {
        // Nieskończona pętla dopóki użytkownik nie poda poprawnej liczby
        while (true) {
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.WriteLine();

            // TryParse zwraca true jeśli konwersja się udała
            if (int.TryParse(input, out var result) && result != 0) {
                return result;
            }
        }
    }
}
