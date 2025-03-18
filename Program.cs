using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            MBO mbo = new MBO("Asus", "Yenova", 5000, 4000, 8, 2000);
            mbo.Sale();
            mbo.ShowFullData();

            Console.WriteLine("Enter düyməsini basın...");
            Console.ReadLine();
        }
    }
}