using System.Net.NetworkInformation;

namespace BookShopApp
{
    internal class Program
    {
        static (string Title, string Author, float Price, int Quantity) inventory;
        static (string Customer_name, string book, int Quantity_purchased, float Amount) sales;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("====== BOOK SHOP MENU ======");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sell Book");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. View Sales Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case (1):
                        add_book();
                        break;

                    case (2):
                        sell_book();
                        break;

                    case (3):
                        view_books();
                        break;

                    case (4):
                        view_sales();
                        break;

                    case (5):
                        Console.WriteLine();
                        Console.WriteLine("Thanks for using Book Shop Management!");
                        break;
                }

            }

        }

        static void add_book() //add a book
        {
            Console.WriteLine();
            Console.Write("Enter book title: ");
            inventory.Title = Console.ReadLine();

            Console.Write("Enter author name: ");
            inventory.Author = Console.ReadLine();

            Console.Write("Enter price: ");
            inventory.Price = float.Parse(Console.ReadLine());

            Console.Write("Enter book quantity: ");
            inventory.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Book added successfully.");

        }

        static void sell_book() //sell a book
        {
            Console.WriteLine();
            Console.Write("Enter book title to sell: ");
            sales.book = Console.ReadLine();

            Console.Write("Enter quantity to sell: ");
            sales.Quantity_purchased = Convert.ToInt32(Console.ReadLine());
            inventory.Quantity -= sales.Quantity_purchased;

            Console.Write("Enter Customer Name: ");
            sales.Customer_name = Console.ReadLine();

            Console.WriteLine("Sold "+ sales.Quantity_purchased + "copies of 'C# Basics' to "+ sales.Customer_name);

        }

        static void view_books() //view the books
        {
            Console.WriteLine();
            Console.WriteLine("--- Book Inventory ---");
            Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-5}", "Title", "Author", "Price", "Quantity");
            Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-5}", inventory.Title, inventory.Author, inventory.Price, inventory.Quantity);
        }

        static void view_sales() //view the sales
        {
            Console.WriteLine();
            Console.WriteLine("---Sale Report---");
            Console.WriteLine("{0,-15} {1,-15} {2,-5} {3,-10}", "Customer Name", "Book", "Quantity Purchased", "Amount");
            Console.WriteLine("{0,-15} {1,-15} {2,-5} {3,-10}", sales.Customer_name, sales.book, sales.Quantity_purchased, sales.Amount);
        }
    }
}
