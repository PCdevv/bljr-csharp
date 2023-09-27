using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class LuasBAngunDatar
{
    public static void Main(string[] args)  {
        Console.WriteLine("=== Program Penghitung Luas Bangun Datar ===");
        Console.WriteLine("Pilih salah satu bangun datar :");
        Console.WriteLine("\t1. Persegi");
        Console.WriteLine("\t2. Persegi Panjang");
        Console.WriteLine("\t3. Segitiga");
        Console.WriteLine("\t4. Trapesium");
        Console.WriteLine("\t5. Belah Ketupat");
        Console.WriteLine("\t6. Jajar Genjang");
        Console.WriteLine("\t7. Layang Layang");
        Console.WriteLine("\t8. Segi Enam");
        Console.WriteLine("\t9. Segi Delapan");
        Console.WriteLine("\t10. Lingkaran");
        Console.Write("\t> ");

        switch (Console.ReadLine())
        {
        case "1":
            // Persegi
            Console.WriteLine("Masukkan sisi :");
            Console.Write("\t> ");
            int inputSisi = int.Parse(Console.ReadLine());
            int luasPersegi = inputSisi * inputSisi;
            Console.WriteLine($"Luas Persegi tersebut adalah : {luasPersegi}");
            break;
        case "2":
            // Persegi Panjang
            Console.WriteLine("Masukkan panjang :");
            Console.Write("\t> ");
            int inputPanjang = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan lebar :");
            Console.Write("\t> ");
            int inputLebar = int.Parse(Console.ReadLine());
            int luasPersegiPanjang = inputPanjang * inputLebar;
            Console.WriteLine($"Luas Persegi Panjang tersebut adalah : {luasPersegiPanjang}");
            break;
        case "3":
            // Segitiga
            Console.WriteLine("Masukkan alas :");
            Console.Write("\t> ");
            int inputAlas = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi :");
            Console.Write("\t> ");
            int inputTinggi = int.Parse(Console.ReadLine());
            int luasSegitiga = inputAlas * inputTinggi / 2;
            Console.WriteLine($"Luas Segitiga tersebut adalah : {luasSegitiga}");
            break;
        case "4":
        // Trapesium
            Console.WriteLine("Masukkan sisi atas :");
            Console.Write("\t> ");
            int inputAtas = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan sisi alas :");
            Console.Write("\t> ");
            int inputAlasT = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi :");
            Console.Write("\t> ");
            int inputTinggiT = int.Parse(Console.ReadLine());
            int panjangSejajar = inputAtas + inputAlasT;
            int luasTrapesium = panjangSejajar  * inputTinggiT / 2;
            Console.WriteLine($"Luas Trapesium tersebut adalah : {luasTrapesium}");
            break;
        case "5":
        // Belah Ketupat
            Console.WriteLine("Masukkan Diagonal 1 :");
            Console.Write("\t> ");
            int inputD1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Diagonal 2 :");
            Console.Write("\t> ");
            int inputD2 = int.Parse(Console.ReadLine());
            int luasBelahKetupat = inputD1 * inputD2 / 2;
            Console.WriteLine($"Luas Belah Ketupat tersebut adalah : {luasBelahKetupat}");
            break;
        case "6":
        // Jajar Genjang
            Console.WriteLine("Masukkan alas :");
            Console.Write("\t> ");
            int inputAlasJG = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi :");
            Console.Write("\t> ");
            int inputTinggiJG = int.Parse(Console.ReadLine());
            int luasJajarGenjang = inputAlasJG * inputTinggiJG;
            Console.WriteLine($"Luas Jajar Genjang tersebut adalah : {luasJajarGenjang}");
            break;
        case "7":
        // Layang Layang
            Console.WriteLine("Masukkan Diagonal 1 :");
            Console.Write("\t> ");
            int inputD1L = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Diagonal 2 :");
            Console.Write("\t> ");
            int inputD2L = int.Parse(Console.ReadLine());
            int luasLayang = inputD1L * inputD2L / 2;
            Console.WriteLine($"Luas Layang Layang tersebut adalah : {luasLayang}");
            break;
        case "8":
        // Segi Enam
            Console.WriteLine("Masukkan sisi :");
            Console.Write("\t> ");
            int inputSisiSE = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan apotem :");
            Console.Write("\t> ");
            double inputApotem = double.Parse(Console.ReadLine());
            double luasSegiEnam = inputSisiSE * inputApotem / 2;
            Console.WriteLine($"Luas Layang Layang tersebut adalah : {luasSegiEnam}");
            break;
        case "9":
        // Segi Delapan
            Console.WriteLine("Masukkan sisi :");
            Console.Write("\t> ");
            int inputSisiSD = int.Parse(Console.ReadLine());
            int luasSegiDelapan = inputSisiSD * inputSisiSD * 2;
            Console.WriteLine($"Luas Segi Enam tersebut adalah : {luasSegiDelapan}");
            break;
        case "10":
        // Lingkaran
            Console.WriteLine("Masukkan jari-jari :");
            Console.Write("\t> ");
            int inputJari = int.Parse(Console.ReadLine());
            double luasLingkaran = inputJari * inputJari * 3.14;
            Console.WriteLine($"Luas Segi Enam tersebut adalah : {luasLingkaran}");
            break;
        default:
            Console.WriteLine("Pilihan Anda bukan input yang valid.");
            break;
        }
        
    }
}
