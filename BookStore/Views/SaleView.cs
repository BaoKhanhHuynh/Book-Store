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
    public partial class SaleView : Form
    {
        private SaleController controller;
        public SaleView()
        {
            controller = new SaleController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Sale_Load2(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cusid_Click(object sender, EventArgs e)
        {

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

        private void tuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Customer_id = tcus.Text ?? string.Empty;
            string Users_id = tuid.Text ?? string.Empty;
            string Branch_id = tbrand.Text ?? string.Empty;
            string Sale_date = tsdate.Text ?? string.Empty;
            decimal Total_amount = string.IsNullOrEmpty(ttotal.Text) ? 0m : Convert.ToDecimal(ttotal.Text);


            // Tạo một đối tượng Sale mới
            var model = new Sale(Id, Customer_id, Users_id, Branch_id, Sale_date, Total_amount);

            if (controller.Update(model))
            {
                MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update Sale. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tcus.Text = "";
            tuid.Text = "";
            tbrand.Text = "";
            tsdate.Text = "";
            ttotal.Text = "";
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Customer_id = tcus.Text ?? string.Empty;
            string Users_id = tuid.Text ?? string.Empty;
            string Branch_id = tbrand.Text ?? string.Empty;
            string Sale_date = tsdate.Text ?? string.Empty;
            decimal Total_amount = string.IsNullOrEmpty(ttotal.Text) ? 0m : Convert.ToDecimal(ttotal.Text);


            // Tạo một đối tượng Account mới
            var model = new Sale(Id, Customer_id, Users_id, Branch_id, Sale_date, Total_amount);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Sale added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Sale. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tcus.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tuid.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbrand.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tsdate.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ttotal.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
