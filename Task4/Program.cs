class Program
{
    static void Main(string[] args)
    {
        int[] favoriteNumbers = { 25, 7, 42, 13, 99 };
      
        Array.Sort(favoriteNumbers);
        Array.Reverse(favoriteNumbers);
        Console.WriteLine("\nReversed Array:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }
        int searchNumber = 43;
        int position = Array.IndexOf(favoriteNumbers, searchNumber);

        if (position >= 0)
        {
            Console.WriteLine($"\nNumber {searchNumber} found at index {position}");
        }
        else
        {
            Console.WriteLine($"\nNumber {searchNumber} not found in the array");
        }
    }
}