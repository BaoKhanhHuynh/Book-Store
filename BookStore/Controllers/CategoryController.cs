using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;
using BookStore.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Controllers
{
    internal class CategoryController : IController<Category>
    {
        private List<Category> items;
        private DataHelper db;

        public CategoryController()
        {
            items = new List<Category>();
            db = new DataHelper();
        }

        public List<Category> Items
        {
            get { return items; }
        }

        public bool Create(Category model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Category (id, CategoryName, Established_year, Description) VALUES ('{model.id}', '{model.Categoryname}', '{model.Establishedyear}', '{model.Description}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Category WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Category WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Category model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.id);
        }

        public bool Load()
        {
            string query = "SELECT id,CategoryName, Established_year, Description FROM Category";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                 Category cat = new Category
                {
                    id = row["id"]?.ToString() ?? string.Empty,
                    Categoryname = row["CategoryName"]?.ToString() ?? string.Empty,
                    Establishedyear = row["Established_year"] != null ? Convert.ToInt32(row["Established_year"]) : 0,
                    Description = row["Description"]?.ToString() ?? string.Empty,
                };
                items.Add(cat);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Category WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Category category = new Category
                    {
                        id = row["id"]?.ToString() ?? string.Empty,
                        Categoryname = row["CategoryName"]?.ToString() ?? string.Empty,
                        Establishedyear = row["Established_year"] != null ? Convert.ToInt32(row["Established_year"]) : 0,
                        Description = row["Description"]?.ToString() ?? string.Empty,
                    };
                    items.Add(category);
                }
                return true;
            }
            return false;
        }

        public Category Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Category WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Category category = new Category
                {
                    id = row["id"]?.ToString() ?? string.Empty,
                    Categoryname = row["CategoryName"]?.ToString() ?? string.Empty,
                    Establishedyear = row["Established_year"] != null ? Convert.ToInt32(row["Established_year"]) : 0,
                    Description = row["Description"]?.ToString() ?? string.Empty,
                };
                return category;
            }
            return null;
        }

        public bool Update(Category model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Category SET CategoryName = '{model.Categoryname}', Established_year = '{model.Establishedyear}', Description = '{model.Description}' WHERE id = '{model.id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
