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
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BookStore.Views
{
    public partial class SaleDetailView : Form
    {
        private SaleDetailController controller;
        public SaleDetailView()
        {
            controller = new SaleDetailController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void SaleDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saleDetailINFORMATION_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tcid.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tquantity.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            ttotal.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Book_id = tbid.Text ?? string.Empty;
            string Category_id = tcid.Text ?? string.Empty;
            int Quantity = !string.IsNullOrWhiteSpace(tquantity.Text) ? Convert.ToInt32(tquantity.Text) : 0;
            decimal Total_price = string.IsNullOrEmpty(ttotal.Text) ? 0m : Convert.ToDecimal(ttotal.Text);

            var model = new SaleDetail(Id, Book_id, Category_id, Quantity, Total_price);

            if (controller.Update(model))
            {
                MessageBox.Show("SaleDeatil updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update SaleDetail. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Book_id = tbid.Text ?? string.Empty;
            string Category_id = tcid.Text ?? string.Empty;
            int Quantity = !string.IsNullOrWhiteSpace(tquantity.Text) ? Convert.ToInt32(tquantity.Text) : 0;
            decimal Total_price = string.IsNullOrEmpty(ttotal.Text) ? 0m : Convert.ToDecimal(ttotal.Text);


            // Tạo một đối tượng Account mới
            var model = new SaleDetail(Id, Book_id, Category_id, Quantity, Total_price);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("SaleDetail added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add SaleDetail. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tbid.Text = "";
            tcid.Text = "";
            tquantity.Text = "";
            ttotal.Text = "";
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }
    }
}
