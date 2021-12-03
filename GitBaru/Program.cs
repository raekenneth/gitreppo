using System;

namespace GitBaru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cek apakah bilangan prima atau bukan
            int angka, ulang, bilangan, sisa;
            Console.WriteLine("Cek apakah bilangan prima atau bukan\n");
            Console.Write("Input sebuah bilangan : ");
            angka = Convert.ToInt16(Console.ReadLine());
            bilangan = 0;
            for (ulang = 1; ulang <= angka; ulang++)
            {
                sisa = angka % ulang;
                if (sisa == 0)
                    bilangan = bilangan + 1;
                else
                    bilangan = bilangan;
            }
            if (bilangan > 2)
                Console.Write("Bukan bilangan prima");
            else
                Console.Write("Bilangan prima");
        }
    }
}