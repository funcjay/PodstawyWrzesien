namespace ZamianaJednostek;

public static class Program {
    private enum InputType {
        Celsius,
        Fahrenheit
    }
    
    public static void Main(string[] args) {
        InputType inputType;
        while (true) {
            Console.WriteLine("Napisz C dla zmiany z Celsjusza na Fahrenheita");
            Console.WriteLine("Napisz F dla zmiany z Fahrenheita na Celsjusza");
            var input = Console.ReadLine();
            Console.WriteLine();

            InputType? temp = input switch {
                "c" or "C" => InputType.Celsius,
                "f" or "F" => InputType.Fahrenheit,
                _ => null
            };

            if (temp is null) continue;
            
            inputType = temp.Value;
            break;
        }
        
        var inTemp = FetchDouble("Podaj temperaturę: ");
        inTemp = Math.Round(inTemp, 1);

        var result = inputType switch {
            InputType.Celsius => inTemp * 1.8 + 32,
            InputType.Fahrenheit => (inTemp - 32) / 1.8,
            _ => 0.0
        };
        result = Math.Round(result, 1);
        
        Console.Write($"{inTemp} to {result} stopni ");
        Console.WriteLine(inputType is InputType.Celsius ? "Fahrenheita" : "Celsjusza");
    }
    
    private static double FetchDouble(string prompt) {
        // Nieskończona pętla dopóki użytkownik nie poda poprawnej liczby
        while (true) {
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.WriteLine();

            // TryParse zwraca true jeśli konwersja się udała
            if (double.TryParse(input, out var result)) {
                return result;
            }
        }
    }
}
