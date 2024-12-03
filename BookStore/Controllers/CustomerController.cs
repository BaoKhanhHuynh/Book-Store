using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;
using BookStore.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Controllers
{
    internal class CustomerController : IController<Customer>
    {
        private List<Customer> items;
        private DataHelper db;

        public CustomerController()
        {
            items = new List<Customer>();
            db = new DataHelper();
        }

        public List<Customer> Items
        {
            get { return items; }
        }

        public bool Create(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Customer (id, name, phone, email, address) VALUES ('{model.Id}', '{model.Name}', '{model.Phone}', '{model.Email}', '{model.Address}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Customer WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, name, phone, email, address FROM Customer";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Customer cus = new Customer
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Phone = row["phone"]?.ToString() ?? string.Empty,
                    Email = row["email"]?.ToString() ?? string.Empty,
                    Address = row["address"]?.ToString() ?? string.Empty,
                };
                items.Add(cus);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Customer cus = new Customer
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Name = row["name"]?.ToString() ?? string.Empty,
                        Phone = row["phone"]?.ToString() ?? string.Empty,
                        Email = row["email"]?.ToString() ?? string.Empty,
                        Address = row["address"]?.ToString() ?? string.Empty,
                    };
                    items.Add(cus);
                }
                return true;
            }
            return false;
        }

        public Customer Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Customer cus = new Customer
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Phone = row["phone"]?.ToString() ?? string.Empty,
                    Email = row["email"]?.ToString() ?? string.Empty,
                    Address = row["address"]?.ToString() ?? string.Empty,
                };
                return cus;
            }
            return null;
        }

        public bool Update(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Customer SET name = '{model.Name}', phone = '{model.Phone}', email = '{model.Email}', address = '{model.Address}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
