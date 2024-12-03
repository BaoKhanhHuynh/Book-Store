using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
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
    public partial class OrdersView : Form
    {
        private OrdersController controller;
        public OrdersView()
        {
            controller = new OrdersController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbok_TextChanged(object sender, EventArgs e)
        {

        }

        private void tquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void toder_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tcus.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbok.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tquantity.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tgia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            toder.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Name = tcus.Text ?? string.Empty;
            string Book_title = tbok.Text ?? string.Empty;
            int Quantity = !string.IsNullOrWhiteSpace(tquantity.Text) ? Convert.ToInt32(tquantity.Text) : 0;
            int Price = !string.IsNullOrWhiteSpace(tgia.Text) ? Convert.ToInt32(tgia.Text) : 0;
            DateTime Ordersdate = DateTime.TryParse(toder.Text, out DateTime tempOrdersdate) ? tempOrdersdate : DateTime.MinValue;

            // Tạo một đối tượng Orders mới
            var model = new Orders(Id, Name, Book_title, Quantity, Price, Ordersdate);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Orders added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Orders. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Report_Click(object sender, EventArgs e)
        {

        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Excel Report";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    controller.ExportOrdersToExcel(saveFileDialog.FileName);
                    MessageBox.Show("Excel Report generated successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }
    }
}
