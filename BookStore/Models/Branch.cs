using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookStore.Controllers;

namespace BookStore.Models
{
    public partial class Branch
    {
        public Branch() { }

        public Branch(string id, string name, string address, string city)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
        }
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}




