using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;

namespace BookStore.Controllers
{
    internal class UsersController : IController<Users>
    {
        private List<Users> items;
        private DataHelper db;

        public UsersController()
        {
            items = new List<Users>();
            db = new DataHelper();
        }

        public List<Users> Items
        {
            get { return items; }
        }

        public bool Create(Users model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(model.Password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                model.Password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            string query = $"INSERT INTO Users (id, username, password, role) VALUES ('{model.Id}', '{model.UserName}', '{model.Password}', '{model.Role}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Users WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Users WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Users model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, username, password, role FROM Users";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Users employee = new Users
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    UserName= row["username"]?.ToString() ?? string.Empty,
                    Password = row["password"]?.ToString() ?? string.Empty,
                    Role = row["role"]?.ToString() ?? string.Empty,
                };
                items.Add(employee);
            }
            return true;
        }


        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Users WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Users user = new Users
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        UserName = row["username"]?.ToString() ?? string.Empty,
                        Password = row["password"]?.ToString() ?? string.Empty,
                        Role = row["role"]?.ToString() ?? string.Empty,
                    };
                    items.Add(user);
                }
                return true;
            }
            return false;
        }

        public Users Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Users WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Users employee = new Users
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    UserName = row["username"]?.ToString() ?? string.Empty,
                    Password = row["password"]?.ToString() ?? string.Empty,
                    Role = row["role"]?.ToString() ?? string.Empty,
                };
                return employee;
            }
            return null;
        }

        public bool Update(Users model)
        {
            if (!string.IsNullOrEmpty(model.Password))
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(model.Password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    model.Password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }

            string query = $"UPDATE Employee SET username = '{model.UserName}', " +
                           (string.IsNullOrEmpty(model.Password) ? "" : $"password = '{model.Password}', ") +
                           $"role = '{model.Role}' WHERE id = '{model.Id}'";

            query = query.Replace(", WHERE", " WHERE");
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool DangNhap(string username, string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            string query = $"SELECT * FROM  Users WHERE username = '{username}' AND password = '{password}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 ? true : false;
        }
    }
}
