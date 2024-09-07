namespace Kosci;

public static class Program {
    private static readonly Random Rng = new();
    
    public static void Main(string[] args) {
        ThrowDice();

        while (true) {
            Console.Write("Rzucić ponownie? (y/n): ");
            var input = Console.ReadLine();

            if (input is null) continue;

            if (input is "y" or "Y") {
                ThrowDice();
            } else if (input is "n" or "N") {
                return;
            }
        }
    }

    private static void ThrowDice() {
        Console.Clear();
        
        var dice1 = Rng.Next(1, 7);
        var dice2 = Rng.Next(1, 7);
        
        Console.WriteLine($"Kość 1: {dice1}");
        Console.WriteLine($"Kość 2: {dice2}");
        Console.WriteLine($"Suma: {dice1 + dice2}");
    }
}
