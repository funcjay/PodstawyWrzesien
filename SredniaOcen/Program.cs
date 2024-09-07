namespace SredniaOcen;

public static class Program {
    public static void Main(string[] args) {
        var gradeCount = FetchInt("Podaj liczbę ocen: ");
        var grades = new List<int>();

        for (var i = 0; i < gradeCount; i++) {
            grades.Add(FetchGrade($"Podaj ocenę {i + 1}: "));
        }
        
        var sum = grades.Sum();
        // Ręczna konwersja na double aby dostać liczby po przecinku, bez niej zwrócony był by int
        var result = (double)sum / gradeCount;
        
        // Zaokrąglij
        result = Math.Round(result, 2);
        
        Console.WriteLine($"Średnia podanych ocen: {result}");
    }
    
    // wiem że to prawie to samo. odechciało mi się
    
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
    
    private static int FetchGrade(string prompt) {
        // Nieskończona pętla dopóki użytkownik nie poda poprawnej liczby
        while (true) {
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.WriteLine();

            // TryParse zwraca true jeśli konwersja się udała
            if (int.TryParse(input, out var result) && result is > 0 and < 7) {
                return result;
            }
        }
    }
}
