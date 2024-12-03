using System.Security.Cryptography;
using System.Text;
using BookStore.Controllers;
using BookStore.Models;
using BookStore.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BranchStore.Controllers
{
    internal class BranchController : IController<BookStore.Models.Branch>
    {
        private List<BookStore.Models.Branch> items;
        private DataHelper db;

        public BranchController()
        {
            items = new List<BookStore.Models.Branch>();
            db = new DataHelper();
        }

        public List<BookStore.Models.Branch> Items
        {
            get { return items; }
        }

        public bool Create(BookStore.Models.Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Branch (id, name, address, city) VALUES ('{model.Id}', '{model.Name}', '{model.Address}', '{model.City}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Branch WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(BookStore.Models.Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, name, address, city FROM Branch";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                BookStore.Models.Branch Branch = new BookStore.Models.Branch
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Address = row["address"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty,
                };
                items.Add(Branch);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    BookStore.Models.Branch Branch = new BookStore.Models.Branch
                    {

                        Id = row["id"]?.ToString() ?? string.Empty,
                        Name = row["name"]?.ToString() ?? string.Empty,
                        Address = row["address"]?.ToString() ?? string.Empty,
                        City = row["city"]?.ToString() ?? string.Empty,
                    };
                    items.Add(Branch);
                }
                return true;
            }
            return false;
        }

        public BookStore.Models.Branch Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                BookStore.Models.Branch Branch = new BookStore.Models.Branch
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Address = row["address"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty,
                };
                return Branch;
            }
            return null;
        }

        public bool Update(BookStore.Models.Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Branch SET name = '{model.Name}', address = '{model.Address}', city = '{model.City}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
