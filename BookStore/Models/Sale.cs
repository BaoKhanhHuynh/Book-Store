using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public partial class Sale
    {
        public Sale() { }

        
        public Sale(string id, string customer_id, string users_id, string branch_id, string sale_date, decimal total_amount)
        { 
            Id = id;
            Customer_id = customer_id;
            Users_id = users_id;
            Branch_id = branch_id;
            Sale_date = sale_date;
            Total_amount = total_amount;
        }
        public string Id { get; set; } = string.Empty;
        public string Customer_id { get; set; } = string.Empty;
        public string Users_id { get; set; } = string.Empty;
        public string Branch_id { get; set; } = string.Empty;
        public string Sale_date { get; set; } = string.Empty;
        public decimal Total_amount { get; set; }
    }
}
