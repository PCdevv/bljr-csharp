using System;

class PendaftaranPenduduk
{
    public static void Main(string[] args)
    {
        string nama;
        int umur;

        Console.WriteLine("===Program Pendaftaran Penduduk===");
        Console.Write("Masukkan nama:");
        nama = Console.ReadLine();
        Console.Write("Masukkan umur:");
        umur = int.Parse(Console.ReadLine());
        Console.Write("Masukkan alamat:");
        var alamat = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data berikut :");
        Console.WriteLine($"Nama : {nama}");
        Console.WriteLine($"Umur : {umur}");
        Console.WriteLine($"Alamat : {alamat}");
        Console.WriteLine("SUDAH DISIMPAN!");

    }
}