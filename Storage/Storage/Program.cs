using System;
class Program
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public double price { get; set; }

    }
    public static void Menu()
    {
        bool op = false;
        
        while(op = true)
        {
            Console.WriteLine("=== Main Menu");
            Console.WriteLine("1-> Manage product");
            Console.WriteLine("0-> exit\n");
            Console.Write("Choose: ");

            if (int.TryParse(Console.ReadLine(), out int choose))
            {
                
            }
            else
            {

            }
        }

    }
    static void Main()
    {
        Menu();

        Product product = new Product();
    }
}