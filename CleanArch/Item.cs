using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch
{
    public class Item
    {
        private readonly string id;
        private readonly string description;
        private readonly decimal price;
        private readonly int width;
        private readonly int height;
        private readonly int length;
        private readonly int weight;

        public Item(string id, string description, decimal price, int width, int height, int length, int weight)
        {
            this.id = id;
            this.description = description;
            this.price = price;
            this.width = width;
            this.height = height;
            this.length = length;
            this.weight = weight;
        }

        public decimal GetVolume()
        {
            return this.width / 100 * this.height / 100 * this.length / 100;
        }

        public decimal GetDensity()
        {
            return this.width / this.GetVolume();
        }
    }
}
