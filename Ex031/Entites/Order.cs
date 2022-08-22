using Ex031.Entites.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex031.Entites
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment}").AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.birthDate}) - {Client.Email}");

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, Quantity: {item.Quantity}, Subtotal: {item.SubTotal():N2}");
            }
            sb.AppendLine($"Total prince: {Total():N2}");
            return sb.ToString();
        }
    }
}
