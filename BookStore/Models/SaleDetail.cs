using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public partial class SaleDetail
    {
        public SaleDetail() { }

        public SaleDetail(string sale_id, string book_id, string category_id, int quantity, decimal total_price)
        {
            Id = sale_id;
            Book_id = book_id;
            Category_id = category_id;
            Quantity = quantity;
            Total_price = total_price;
        }
        public string Id { get; set; } = string.Empty;
        public string Book_id { get; set; } = string.Empty;
        public string Category_id { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Total_price { get; set; }
    }
}
