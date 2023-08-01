using System;

class LuasLingkaran
{
    public static void Main(string[] args)
    {
        const float Phi = 3.14f;

        Console.WriteLine("===Program Luas Lingkaran===");
        Console.Write("Input jari-jari :");
        int r = int.Parse(Console.ReadLine());

        var luas = Phi * r * r;

        Console.WriteLine($"Luas Lingkaran : {luas}");
    }
}