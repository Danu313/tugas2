using System;

namespace pertemuan1._1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("pilih menu calculator");
            Console.WriteLine("1. penjumlahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");
            Console.Write("\ninputkan nomor menu : ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                Console.Write("inputkan nilai a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (pilihan == "2")
            {
                Console.Write("inputkan nilai a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }

            else if (pilihan == "3")
            {
                Console.Write("inputkan nilai a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            }

            else if (pilihan == "4")
            {
                Console.Write("inputkan nilai a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            }
            else
            {
                Console.WriteLine("\nMaaf, menu yang anda pilih tidak ditemukan");
            }


            Console.WriteLine("\nTekan sembarang key untuk keluar ");
            Console.ReadKey();

        }




        static double Penambahan(double a, double b)
        {
            return a + b;
        }

        static double Pengurangan(double a, double b)
        {
            return a - b;
        }

        static double Perkalian(double a, double b)
        {
            return a * b;
        }

        static double Pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
