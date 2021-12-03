using System;

namespace CobaGitBaru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cek input apakah bilangan prima atau tidak
            Console.WriteLine("Cek bilangan prima atau bukan\n");
            Console.Write("Input sebuah bilangan : ");
            int bilangan = Convert.ToInt16(Console.ReadLine());
            if (bilangan % 2 == 0)
                Console.Write("Bukan Bilangan Prima");
            if (bilangan % 2 != 0)
                Console.Write("Bilangan Prima");
        }
    }
}