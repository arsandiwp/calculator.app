class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 6;

        Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + penambahan(a, b));
        Console.WriteLine("HAsil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));

        Console.WriteLine("\nTekan sembarangan key untuk keluar");
        Console.ReadKey();

    }
    static int penambahan (int a, int b)
     {
            return a + b;
     }
     static int pengurangan (int a, int b)
     {
            return a - b;
     }
}