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

namespace BookStore
{
    public partial class UsersView : Form
    {
        private UsersController controller;

        public UsersView()
        {
            controller = new UsersController();
            InitializeComponent();
        }

        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Handle group box enter event if needed.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không có hàng nào được chọn hoặc CurrentRow là null
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("No row is selected. Please select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = dataGridView1.CurrentRow.Index;

            // Kiểm tra và gán dữ liệu từ các ô trong hàng hiện tại
            tid.Text = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? string.Empty;
            tBoxName.Text = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? string.Empty;
            textBoxPassWord.Text = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? string.Empty;

            var role = dataGridView1.Rows[i].Cells[3].Value?.ToString();
            if (role == "admin")
            {
                Admin.Checked = true;
                User.Checked = false;
            }
            else
            {
                Admin.Checked = false;
                User.Checked = true;
            }
        }


        private void User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string role = Admin.Checked ? "admin" : "user"; // Sử dụng toán tử điều kiện cho ngắn gọn
            var model = new Users
            {
                Id = tid.Text,
                UserName = tBoxName.Text, // Lấy giá trị từ TextBox tBoxName
                Password = textBoxPassWord.Text,
                Role = role
            };

            // Gọi phương thức Create để thêm mới nhân viên
            if (controller.Create(model))
            {
                MessageBox.Show("Users added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add Users. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData(); // Tải lại dữ liệu sau khi thêm mới

        }

        private void buttonkhoitao_Click(object sender, EventArgs e)
        {

            tid.Text = "";
            tBoxName.Text = "";
            textBoxPassWord.Text = "";
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string role = "";
            if (Admin.Checked) { role = "admin"; } else if (User.Checked) { role = "user"; }
            var model = new Users
            {
                Id = tid.Text,
                Password = textBoxPassWord.Text,
                UserName = tBoxName.Text,
                Role = role
            };

            if (controller.Update(model)) // Thực hiện cập nhật thông tin
            {
                LoadData(); // Tải lại dữ liệu sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Employeeid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_Click(object sender, EventArgs e)
        {

        }
    }
}
