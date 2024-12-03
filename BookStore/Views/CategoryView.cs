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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace BookStore.Views
{
    public partial class CategoryView : Form
    {
        private CategoryController controller;
        public CategoryView()
        {
            controller = new CategoryController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Category_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CategoryINFORMATION_Click(object sender, EventArgs e)
        {

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
            teyear.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tdes.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void teyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Categoryname = tname.Text ?? string.Empty;
            int Establishedyear = !string.IsNullOrWhiteSpace(teyear.Text) ? Convert.ToInt32(teyear.Text) : 0;
            string Description = tdes.Text ?? string.Empty;
            var model = new Category(Id, Categoryname, Establishedyear, Description);

            if (controller.Update(model))
            {
                MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Categoryname = tname.Text ?? string.Empty;
            int Establishedyear = !string.IsNullOrWhiteSpace(teyear.Text) ? Convert.ToInt32(teyear.Text) : 0;
            string Description = tdes.Text ?? string.Empty;
            // Khởi tạo model với constructor
            var model = new Category(Id, Categoryname, Establishedyear, Description);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tname.Text = "";
            teyear.Text = "";
            tdes.Text = "";    
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
