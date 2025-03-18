using System;

namespace ConsoleApp9
{
    public class Product
    {
        public string Name;
        public string Description;
        public int Count;
        private double price;
        public double Price
        {
            get { return price; }
            set { if (value >= 0) price = value; }
        }

        public Product(string name, string description, int count, double price)
        {
            Name = name;
            Description = description;
            Count = count;
            Price = price;
        }

        public void Sale()
        {
            if (Count > 0)
            {
                Count--;
                Console.WriteLine("Satıldı.");
            }
            else
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
        }
    }

    public class MBO : Product
    {
        private byte ram;
        public byte RAM
        {
            get { return ram; }
            set { if (value > 0) ram = value; }
        }
        public int Storage;

        public MBO(string name, string description, int count, double price, byte ram, int storage)
            : base(name, description, count, price)
        {
            RAM = ram;
            Storage = storage;
        }

        public void ShowFullData()
        {
            Console.WriteLine("Product: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Count: " + Count);
            Console.WriteLine("Price: " + Price + "$");
            Console.WriteLine("RAM: " + RAM + "GB");
            Console.WriteLine("Storage: " + Storage + "GB");
        }
    }
}