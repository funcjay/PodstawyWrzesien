namespace SortowanieBabelkowe;

public static class Program {
    public static void Main(string[] args) {
        // Tablica zapisana na twardo
        int[] liczby = [1, 3, 7, 5, 2, 5, 4];
        
        Console.Write("Tablica oryginalna: ");
        foreach (var num in liczby) {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        // Pętla zagnieżdżona.
        // Dla całej długości tablicy wykonaj długość - 1 porównań
        for (var i = 0; i < liczby.Length; i++) {
            for (var j = 0; j < liczby.Length - 1; j++) {
                if (liczby[j] > liczby[j + 1]) {
                    // Zamień liczby w tablicy
                    (liczby[j], liczby[j + 1]) = (liczby[j + 1], liczby[j]);
                }
            }
        }
        
        Console.Write("Tablica posortowana: ");
        foreach (var num in liczby) {
            Console.Write($"{num} ");
        }
    }
}
