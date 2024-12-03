using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Controllers;
using BookStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Views
{
    public partial class BookView : Form
    {
        private BookController controller;

        public BookView()
        {
            controller = new BookController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Book_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void categoryid_Click(object sender, EventArgs e)
        {

        }

        private void Titletxt_Click(object sender, EventArgs e)
        {

        }

        private void Publisher_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tauthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void tprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            ttitle.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tauthor.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tpublisher.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tprice.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tstock.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void BookINFORMATION_Click(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Title = ttitle.Text ?? string.Empty;
            string Author = tauthor.Text ?? string.Empty;
            string Publisher = tpublisher.Text ?? string.Empty;
            int Price = !string.IsNullOrWhiteSpace(tprice.Text) ? Convert.ToInt32(tprice.Text) : 0;
            int Stock = !string.IsNullOrWhiteSpace(tstock.Text) ? Convert.ToInt32(tstock.Text) : 0;

            // Tạo một đối tượng Book mới
            var model = new Book(Id, Title, Author, Publisher, Price, Stock);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Title = ttitle.Text ?? string.Empty;
            string Author = tauthor.Text ?? string.Empty;
            string Publisher = tpublisher.Text ?? string.Empty;
            int Price = !string.IsNullOrWhiteSpace(tprice.Text) ? Convert.ToInt32(tprice.Text) : 0;
            int Stock = !string.IsNullOrWhiteSpace(tstock.Text) ? Convert.ToInt32(tstock.Text) : 0;

            // Tạo một đối tượng Book mới
            var model = new Book(Id, Title, Author, Publisher, Price, Stock);

            if (controller.Update(model))
            {
                MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update Book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            ttitle.Text = "";
            tauthor.Text = "";
            tpublisher.Text = "";
            tprice.Text = "";
            tstock.Text = "";
        }
    }
}
