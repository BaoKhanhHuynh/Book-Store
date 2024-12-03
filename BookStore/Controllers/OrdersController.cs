using System.Security.Cryptography;
using System.Text;
using BookStore.Models;
using BookStore.Util;
using BookStore.Views;
using OfficeOpenXml;
using System.IO;
using ClosedXML.Excel;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
//using iText.Layout.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Controllers
{
    internal class OrdersController : IController<Orders>
    {
        private List<Orders> items;
        private DataHelper db;

        public OrdersController()
        {
            items = new List<Orders>();
            db = new DataHelper();
        }

        public List<Orders> Items
        {
            get { return items; }
        }

        public bool Create(Orders model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Orders (id, customer_name, book_title, quantity, price, order_date) VALUES ('{model.Id}', '{model.Name}', '{model.Book_title}', '{model.Quantity}', '{model.Price}', '{model.Order_date}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Orders WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Orders WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Orders model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, customer_name, book_title, quantity, price, order_date FROM Orders";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Orders od = new Orders
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["customer_name"]?.ToString() ?? string.Empty,
                    Book_title = row["book_title"]?.ToString() ?? string.Empty,
                    Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                    Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                    Order_date = row["order_date"] != null ? Convert.ToDateTime(row["order_date"]) : DateTime.MinValue,
                };
                items.Add(od);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Orders WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                  Orders od = new Orders
                    {
                      Id = row["id"]?.ToString() ?? string.Empty,
                      Name = row["customer_name"]?.ToString() ?? string.Empty,
                      Book_title = row["book_title"]?.ToString() ?? string.Empty,
                      Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                      Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                      Order_date = row["order_date"] != null ? Convert.ToDateTime(row["order_date"]) : DateTime.MinValue,
                    };
                    items.Add(od);
                }
                return true;
            }
            return false;
        }

        public Orders Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Orders WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Orders od = new Orders
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["customer_name"]?.ToString() ?? string.Empty,
                    Book_title = row["book_title"]?.ToString() ?? string.Empty,
                    Quantity = row["quantity"] != null ? Convert.ToInt32(row["quantity"]) : 0,
                    Price = row["price"] != null ? Convert.ToInt32(row["price"]) : 0,
                    Order_date = row["order_date"] != null ? Convert.ToDateTime(row["order_date"]) : DateTime.MinValue,
                };
                items.Add(od);
                return od;
            }
            return null;
        }

        public bool Update(Orders model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Orders SET customer_name = '{model.Name}', book_title = '{model.Book_title}', quantity = '{model.Quantity}', price = '{model.Price}', order_date = '{model.Order_date}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public void ExportOrdersToExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");

                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Customer Name";
                worksheet.Cell(1, 3).Value = "Book Title";
                worksheet.Cell(1, 4).Value = "Quantity";
                worksheet.Cell(1, 5).Value = "Price";
                worksheet.Cell(1, 6).Value = "Order Date";

                for (int i = 0; i < Items.Count; i++)
                {
                    var order = Items[i];
                    worksheet.Cell(i + 2, 1).Value = order.Id;
                    worksheet.Cell(i + 2, 2).Value = order.Name;
                    worksheet.Cell(i + 2, 3).Value = order.Book_title;
                    worksheet.Cell(i + 2, 4).Value = order.Quantity;
                    worksheet.Cell(i + 2, 5).Value = order.Price;
                    worksheet.Cell(i + 2, 6).Value = order.Order_date.ToString("MM/dd/yyyy");
                }

                workbook.SaveAs(filePath);
            }
        }
        //public void ExportOrdersToPdf(string filePath)
        //{
        //    using (var writer = new PdfWriter(filePath))
        //    {
        //        var pdf = new PdfDocument(writer);
        //        var document = new Document(pdf);

        //        document.Add(new Paragraph("Order Report").SetFontSize(18));

        //        Table table = new Table(6);
        //        table.AddCell("ID");
        //        table.AddCell("Customer Name");
        //        table.AddCell("Book Title");
        //        table.AddCell("Quantity");
        //        table.AddCell("Price");
        //        table.AddCell("Order Date");

        //        foreach (var order in Items)
        //        {
        //            table.AddCell(order.Id);
        //            table.AddCell(order.Name);
        //            table.AddCell(order.Book_title);
        //            table.AddCell(order.Quantity.ToString());
        //            table.AddCell(order.Price.ToString());
        //            table.AddCell(order.Order_date.ToString("MM/dd/yyyy"));
        //        }

        //        document.Add(table);
        //        document.Close();
        //    }
        //}



    }
}
