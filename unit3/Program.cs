using System;

class Unit3
{
    static void Main(string[] args) 
    {
        int sayi1;

        Console.WriteLine("Bİr sayı girin: ");
        sayi1 = int.Parse(Console.ReadLine());

        if (sayi1 %2 == 0)
        {
            Console.WriteLine($"{sayi1} çifttir.");
        } else
        {
            Console.WriteLine($"{sayi1} tektir");
        }
        Console.ReadKey();


    }
}
