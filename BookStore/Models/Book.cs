using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public partial class Book
    {
        public Book() { }

        public Book(string id, string title, string author, string publisher, int price, int stock)
        {
            Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
            Stock = stock;
        }
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
