using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double angkaPertama = 0;
                double angkaKedua = 0;
                double hasil = 0;

                Console.WriteLine("----------------------------");
                Console.WriteLine("=== Kalkulator Sederhana ===");
                Console.WriteLine("----------------------------");

                Console.Write("Masukkan angka pertama : ");
                angkaPertama = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka kedua : ");
                angkaKedua = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih salah satu operasi aritmatika : ");
                Console.WriteLine("\t+ : Tambah");
                Console.WriteLine("\t- : Kurang");
                Console.WriteLine("\t* : Kali");
                Console.WriteLine("\t/ : Bagi");
                Console.Write("Pilihan anda : ");

                switch (Console.ReadLine())
                {
                    case "+":
                        hasil = angkaPertama + angkaKedua;
                        Console.WriteLine($"Hasil dari: {angkaPertama} + {angkaKedua} = " + hasil);
                        break;
                    case "-":
                        hasil = angkaPertama - angkaKedua;
                        Console.WriteLine($"Hasil dari: {angkaPertama} - {angkaKedua} = " + hasil);
                        break;
                    case "*":
                        hasil = angkaPertama * angkaKedua;
                        Console.WriteLine($"Hasil dari: {angkaPertama} * {angkaKedua} = " + hasil);
                        break;
                    case "/":
                        hasil = angkaPertama / angkaKedua;
                        Console.WriteLine($"Hasil dari: {angkaPertama} / {angkaKedua} = " + hasil);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Apakah anda ingin menggunakan Kalkulator lagi? (Y = Iya, T = Tidak): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Terimakasih telah menggunakan kalkulator sederhana!");
            Console.WriteLine("=== by: Puteri Citra Dewi ===");
            Console.ReadKey();
        }
    }
}