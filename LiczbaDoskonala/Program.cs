namespace LiczbaDoskonala;

public static class Program {
    public static void Main(string[] args) {
        // Pobierz liczbę od użytkownika
        var inNum = FetchInt("Podaj liczbę całkowitą większą niż 0: ");
        
        var result = 0;
        for (var i = 1; i < inNum; i++) {
            if (inNum % i == 0) {
                result += i;
            }
        }

        Console.WriteLine(inNum == result
            ? $"Liczba {inNum} jest liczbą doskonałą"
            : $"Liczba {inNum} nie jest liczbą doskonałą");
    }
    
    private static int FetchInt(string prompt) {
        // Nieskończona pętla dopóki użytkownik nie poda poprawnej liczby
        while (true) {
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.WriteLine();

            // TryParse zwraca true jeśli konwersja się udała
            if (int.TryParse(input, out var result) && result > 0) {
                return result;
            }
        }
    }
}
