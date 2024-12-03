using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Controllers
{
    internal class BookController : IController<Book>
    {
        private List<Book> items;
        private DataHelper db;

        public BookController()
        {
            items = new List<Book>();
            db = new DataHelper();
        }

        public List<Book> Items
        {
            get { return items; }
        }

        public bool Create(Book model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Book (id, title, author, publisher, price, stock) VALUES ('{model.Id}', '{model.Title}', '{model.Author}', '{model.Publisher}', '{model.Price}', '{model.Stock}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Book WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Book WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Book model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, title, author, publisher, price, stock FROM Book";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Book book = new Book
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Title = row["title"]?.ToString() ?? string.Empty,
                    Author = row["author"]?.ToString() ?? string.Empty,
                    Publisher = row["publisher"]?.ToString() ?? string.Empty,
                    Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                    Stock = row["stock"] != null ? Convert.ToInt32(row["stock"]) : 0,
                };
                items.Add(book);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Book WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Book book = new Book
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Title = row["title"]?.ToString() ?? string.Empty,
                        Author = row["author"]?.ToString() ?? string.Empty,
                        Publisher = row["Publisher"]?.ToString() ?? string.Empty,
                        Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                        Stock = row["Stock"] != null ? Convert.ToInt32(row["stock"]) : 0,
                    };
                    items.Add(book);
                }
                return true;
            }
            return false;
        }

        public Book Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Book WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Book book = new Book
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Title = row["title"]?.ToString() ?? string.Empty,
                    Author = row["author"]?.ToString() ?? string.Empty,
                    Publisher = row["Publisher"]?.ToString() ?? string.Empty,
                    Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                    Stock = row["Stock"] != null ? Convert.ToInt32(row["stock"]) : 0,
                };
                return book;
            }
            return null;
        }

        public bool Update(Book model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Book SET title = '{model.Title}', author = '{model.Author}', publisher = '{model.Publisher}', price = '{model.Price}', stock = '{model.Stock}' WHERE Id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}

