using System;

class ProgramInput
{
    static void Main(String[] args)
    {
        Console.WriteLine("=== PROGRAM BIODATA ===");
        Console.Write("Tuliskan nama kamu : ");
        string nama = Console.ReadLine();
        Console.Write("Alamat : ");
        string alamat = Console.ReadLine();
        Console.Write("Jurusan : ");
        string jurusan = Console.ReadLine();
        Console.Write("Cita-cita saya : ");
        string cita = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Biodata Saya");
        Console.WriteLine("Nama saya        : " + nama);
        Console.WriteLine("Alamatnya di     : " + alamat);
        Console.WriteLine("Jurusanku adalah : " + jurusan);
        Console.WriteLine("Cita-cita saya   : " + cita);
    }
}