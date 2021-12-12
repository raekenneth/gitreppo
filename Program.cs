using System;

namespace Tugas13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Search scroll");
            Console.WriteLine("4. Remove scroll");
            Console.Write("Choose what to do: ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            if (chooseMenu == 3)
                Console.Write("\nInsert scroll name: ");
            string searchScroll = Console.ReadLine();
            Console.WriteLine("Book not found");
            if (chooseMenu == 4)
                Console.WriteLine("Remove from list by scroll name? Y/N");
            string removeScroll = Console.ReadLine();
            Console.Write("Cari Lagi ? (y/n) : ");
            string lagi = Console.ReadLine();
            if (lagi.Equals("Y") || lagi.Equals("y"))
                Console.WriteLine("3. Search scroll");
            Console.WriteLine("4. Remove scroll");
            Console.Write("Choose what to do: ");
            int pilihMenu = Convert.ToInt32(Console.ReadLine());
            if (pilihMenu == 3)
                Console.Write("\nInsert scroll name: ");
            string cariScroll = Console.ReadLine();
            Console.WriteLine("Book not found");
            if (pilihMenu == 4)
                Console.WriteLine("Remove from list by scroll name? Y/N");
            string hapusScroll = Console.ReadLine();
            Console.Write("Cari Lagi ? (y/n) : ");
            string again = Console.ReadLine();
            if (lagi.Equals("N") || lagi.Equals("n"))
                    Console.Clear();
        }
    }
}