using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
    public partial class CustomerView : Form
    {
        private CustomerController controller;
        public CustomerView()
        {
            controller = new CustomerController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tphone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            temail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            taddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void temail_TextChanged(object sender, EventArgs e)
        {

        }

        private void taddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Name = tname.Text ?? string.Empty;
            string Phone = tphone.Text ?? string.Empty;
            string Email = temail.Text ?? string.Empty;
            string Address = taddress.Text ?? string.Empty;

            // Tạo một đối tượng Account mới
            var model = new Customer(Id, Name, Phone, Email, Address);

            if (controller.Update(model))
            {
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update Customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tname.Text = "";
            tphone.Text = "";
            temail.Text = "";
            taddress.Text = "";
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
            string Name = tname.Text ?? string.Empty;
            string Phone = tphone.Text ?? string.Empty;
            string Email = temail.Text ?? string.Empty;
            string Address = taddress.Text ?? string.Empty;

            // Tạo một đối tượng Account mới
            var model = new Customer(Id, Name, Phone, Email, Address);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
