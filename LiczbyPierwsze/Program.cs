namespace LiczbyPierwsze;

public static class Program {
    public static void Main(string[] args) {
        // Pobierz liczbę od użytkownika
        var inNum = FetchInt("Podaj liczbę naturalną większą niż 2: ");

        Console.WriteLine("Liczby pierwsze:");
        for (var i = 2; i < inNum; i++) {
            if (IsPrimary(i)) {
                Console.Write($"{i} ");
            }
        }
    }

    private static bool IsPrimary(int num) {
        // Zakładam, że podana zawsze jest podzielna przez 1
        for (var i = 2; i <= num; i++) {
            // Jeśli podana jest podzielna przez tą liczbę, a nie jest ona podaną...
            if (num % i == 0 && i != num) {
                // ...to nie jest ona liczbą pierwszą
                return false;
            }
        }
        
        return true;
    }
    
    private static int FetchInt(string prompt) {
        // Nieskończona pętla dopóki użytkownik nie poda poprawnej liczby
        while (true) {
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.WriteLine();

            // TryParse zwraca true jeśli konwersja się udała
            if (int.TryParse(input, out var result) && result > 2) {
                return result;
            }
        }
    }
}
