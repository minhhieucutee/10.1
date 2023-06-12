using System;
using Customer;
using Order;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Customer.Name customerName = new Customer.Name();
            customerName.AcceptName(name);

            Console.WriteLine("Please choose an option (1 for grocery, 2 for bakery):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Order.Grocery grocery = new Order.Grocery();
                grocery.SelectProduct();
            }
            else if (choice == 2)
            {
                Order.Bakery bakery = new Order.Bakery();
                bakery.SelectProduct();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
