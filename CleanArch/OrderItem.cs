using System;

namespace CleanArch
{
    public class OrderItem
    {
        private readonly string id;
        private readonly decimal price;
        private readonly int quantity;

        public OrderItem(string id, decimal price, int quantity)
        {
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal GetTotal()
        {
            return this.price * this.quantity;
        }
    }
}