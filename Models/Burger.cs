using System;

namespace burgershackapi.Models
{
    public class Burger
    {
        public Burger() { }
        public Burger(string name, string description, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}