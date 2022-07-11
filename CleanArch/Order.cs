using System;
using System.Collections.Generic;

namespace CleanArch
{
    public class Order
    {
        private readonly Cpf cpf;
        private readonly List<OrderItem> items;
        private readonly decimal freight;
        private Coupon coupon;

        public Order(string cpf)
        {
            this.cpf = new Cpf(cpf);
            this.items = new List<OrderItem>();
        }

        public void AddItem(string id, decimal price, int quantity)
        {
            this.items.Add(new OrderItem(id, price, quantity));
        }

        public void AddCoupon(Coupon coupon)
        {
            if (coupon.IsExpired())
            {
                this.coupon = coupon;
            }
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var orderItem in items)
            {
                total += orderItem.GetTotal();
            }

            if (this.coupon != null)
            {
                total -= (total * this.coupon.Percentage) / 100;
            }

            total += this.freight;

            return total;
        }
    }
}
