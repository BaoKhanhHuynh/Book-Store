using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public partial class Orders
    {
        public Orders() { }

        public Orders(string id, string customer_name, string book_title, int quantity, int price, DateTime order_date)
        {
            Id = id;
            Name = customer_name;
            Book_title = book_title;
            Quantity = quantity;
            Price = price;
            Order_date = order_date;
        }
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Book_title { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime Order_date { get; set; }
    }
}
