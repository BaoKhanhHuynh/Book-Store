using System.Security.Cryptography;
using System.Text;
using BookStore.Controllers;
using BookStore.Models;
using BookStore.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Controllers
{
    internal class SaleController : IController<Sale>
    {
        private List<Sale> items;
        private DataHelper db;

        public SaleController()
        {
            items = new List<Sale>();
            db = new DataHelper();
        }

        public List<Sale> Items
        {
            get { return items; }
        }

        public bool Create(Sale model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Sale (id, customer_id, users_id, branch_id, sale_date, total_amount) VALUES ('{model.Id}', '{model.Customer_id}', '{model.Users_id}', '{model.Branch_id}', '{model.Sale_date}', '{model.Total_amount}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Sale WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Sale WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Sale model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, customer_id, users_id, branch_id, sale_date, total_amount FROM Sale";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Sale Sale = new Sale
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Customer_id = row["customer_id"]?.ToString() ?? string.Empty,
                    Users_id = row["users_id"]?.ToString() ?? string.Empty,
                    Branch_id = row["branch_id"]?.ToString() ?? string.Empty,
                    Sale_date = row["sale_date"]?.ToString() ?? string.Empty,
                    Total_amount = row["total_amount"] != null ? Convert.ToDecimal(row["total_amount"]) : 0m,
                };
                items.Add(Sale);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Sale WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Sale Sale = new Sale
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Customer_id = row["customer_id"]?.ToString() ?? string.Empty,
                        Users_id = row["users_id"]?.ToString() ?? string.Empty,
                        Branch_id = row["branch_id"]?.ToString() ?? string.Empty,
                        Sale_date = row["sale_date"]?.ToString() ?? string.Empty,
                        Total_amount = row["total_amount"] != null ? Convert.ToDecimal(row["total_amount"]) : 0m,
                    };
                    items.Add(Sale);
                }
                return true;
            }
            return false;
        }

        public Sale Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Sale WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Sale Sale = new Sale
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Customer_id = row["customer_id"]?.ToString() ?? string.Empty,
                    Users_id = row["users_id"]?.ToString() ?? string.Empty,
                    Branch_id = row["branch_id"]?.ToString() ?? string.Empty,
                    Sale_date = row["sale_date"]?.ToString() ?? string.Empty,
                    Total_amount = row["total_amount"] != null ? Convert.ToDecimal(row["total_amount"]) : 0m,
                };
                return Sale;
            }
            return null;
        }

        public bool Update(Sale model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Sale SET customer_id = '{model.Customer_id}', users_id = '{model.Users_id}', branch_id = '{model.Branch_id}', sale_date = '{model.Sale_date}', total_amount = '{model.Total_amount}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
