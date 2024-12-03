using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Controllers;
using BookStore;

namespace BookStore.Views
{
    public partial class DangNhap : Form
    {
        private readonly UsersController usersController = new UsersController();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy tên người dùng và mật khẩu từ TextBox
            string username = textBox2.Text;
            string password = textBox1.Text;

            // Tạo đối tượng UsersController và gọi phương thức DangNhap
            UsersController usersController = new UsersController();
            bool result = usersController.DangNhap(username, password);
            MainWindown main = new MainWindown();

            if (result) { main.ShowDialog(); Close(); }
            else
            {
                MessageBox.Show("Name and password incorrect!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
