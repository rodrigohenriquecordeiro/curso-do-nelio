using Ex031.Entites;
using Ex031.Entites.Enuns;
using System;

namespace Ex031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: "); string name = Console.ReadLine().Trim();
            Console.Write("Email: "); string email = Console.ReadLine().Trim();
            Console.Write("Birth Date (DD/MM/YYYY): "); DateTime dateBirth = DateTime.Parse(Console.ReadLine().Trim());
            Client client = new Client(name, email, dateBirth);

            Console.WriteLine("\nEnter order data");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  [0] Pending Payment");
            Console.WriteLine("  [1] Processing");
            Console.WriteLine("  [2] Shipped");
            Console.WriteLine("  [3] Delivered");
            Console.WriteLine("-----------------------");
            Console.Write("Your chose: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine().Trim());
            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("\nHow many items to this order? "); int num = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();

            OrderItem orderItem;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: "); string productName = Console.ReadLine().Trim();
                Console.Write("Product Price: "); double productPrice = double.Parse(Console.ReadLine().Trim());
                Console.Write("Quantity: "); int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
                Console.WriteLine();
            }
            
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}
