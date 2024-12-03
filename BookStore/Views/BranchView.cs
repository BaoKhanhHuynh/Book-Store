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
    public partial class BranchView : Form
    {
        private BranchStore.Controllers.BranchController controller;
        public BranchView()
        {
            controller = new BranchStore.Controllers.BranchController();
            InitializeComponent();
        }
        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }
        private void Branch_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void address_Click(object sender, EventArgs e)
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
            tadd.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tcity.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Name = tname.Text ?? string.Empty;
            string Address = tadd.Text ?? string.Empty;
            string City = tcity.Text ?? string.Empty;
            // Tạo một đối tượng Book mới
            var model = new BookStore.Models.Branch(Id, Name, Address, City);

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
            tname.Text = "";
            tadd.Text = "";
            tcity.Text = "";
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string Id = tid.Text ?? string.Empty;
            string Name = tname.Text ?? string.Empty;
            string Address = tadd.Text ?? string.Empty;
            string City = tcity.Text ?? string.Empty;
            // Tạo một đối tượng Branch mới
            var model = new BookStore.Models.Branch(Id, Name, Address, City);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Branch added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Branch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
