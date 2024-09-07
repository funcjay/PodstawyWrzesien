namespace Kalkulator;

/*
WAŻNE!!!

C# czyta liczby z ciągów znaków różnie w zależności od regionu/języka systemu.
To znaczy, że w Polsce, wpisując "2.5" do double.TryParse nie zadziała, ponieważ w Polsce poprawna pisownia to "2,5"
*/

public static class Program {
    // Rodzaj działania do wykonania
    private enum Operation {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    
    public static void Main(string[] args) {
        // Pobierz liczby od użytkownika
        var inNum1 = FetchDouble("Liczba 1: ");
        var inNum2 = FetchDouble("Liczba 2: ");

        // Nieskończona pętla dopóki użytkownik nie wprowadzi poprawnego rodzaju działania
        Operation op;
        while (true) {
            Console.Write("Działanie: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            Operation? temp = input switch {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "*" => Operation.Multiply,
                "/" => Operation.Divide,
                _ => null
            };

            if (temp is null) continue;
            
            op = temp.Value;
            break;
        }

        // Jeśli działaniem jest dzielenie i któraś z podanych liczb jest zerem, zwróć 0.0
        var result = op switch {
            Operation.Add => inNum1 + inNum2,
            Operation.Subtract => inNum1 - inNum2,
            Operation.Multiply => inNum1 * inNum2,
            Operation.Divide => inNum1 != 0.0 && inNum2 != 0.0 ? inNum1 / inNum2 : 0.0,
            _ => 0.0
        };

        if (op is Operation.Divide && (inNum1 == 0.0 || inNum2 == 0.0)) {
            Console.WriteLine("Nie można dzielić przez 0!");
            return;
        }
        
        Console.WriteLine($"Wynik: {result}");
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
