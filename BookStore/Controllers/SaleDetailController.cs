using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;
using BookStore.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace BookStore.Controllers
{
    internal class SaleDetailController : IController<SaleDetail>
    {
        private List<SaleDetail> items;
        private DataHelper db;

        public SaleDetailController()
        {
            items = new List<SaleDetail>();
            db = new DataHelper();
        }

        public List<SaleDetail> Items
        {
            get { return items; }
        }

        public bool Create(SaleDetail model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO SaleDetail (sale_id, book_id, category_id, quantity, total_price) VALUES ('{model.Id}', '{model.Book_id}', '{model.Category_id}', '{model.Quantity}', '{model.Total_price}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM SaleDetail WHERE sale_id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM SaleDetail WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(SaleDetail model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT sale_id, book_id, category_id, quantity, total_price FROM SaleDetail";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                SaleDetail sd = new SaleDetail
                {
                    Id = row["sale_id"]?.ToString() ?? string.Empty,
                    Book_id = row["book_id"]?.ToString() ?? string.Empty,
                    Category_id = row["category_id"]?.ToString() ?? string.Empty,
                    Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                    Total_price = row["total_price"] != null ? Convert.ToDecimal(row["total_price"]) : 0m,
                };
                items.Add(sd);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM SaleDetail WHERE sale_id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    SaleDetail sd = new SaleDetail
                    {
                        Id = row["sale_id"]?.ToString() ?? string.Empty,
                        Book_id = row["book_id"]?.ToString() ?? string.Empty,
                        Category_id = row["category_id"]?.ToString() ?? string.Empty,
                        Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                        Total_price = row["total_price"] != null ? Convert.ToDecimal(row["total_price"]) : 0m,
                    };
                    items.Add(sd);
                }
                return true;
            }
            return false;
        }

        public SaleDetail Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM SaleDetail WHERE sale_id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                SaleDetail sd = new SaleDetail
                {
                    Id = row["sale_id"]?.ToString() ?? string.Empty,
                    Book_id = row["book_id"]?.ToString() ?? string.Empty,
                    Category_id = row["category_id"]?.ToString() ?? string.Empty,
                    Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                    Total_price = row["total_price"] != null ? Convert.ToDecimal(row["total_price"]) : 0m,
                };
                return sd;
            }
            return null;
        }

        public bool Update(SaleDetail model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE SaleDetail SET book_id = '{model.Book_id}', category_id = '{model.Category_id}', quantity = '{model.Quantity}' WHERE sale_id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
