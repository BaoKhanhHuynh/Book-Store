using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Views
{
    public partial class MainWindown : Form
    {
        public MainWindown()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersView usersView = new UsersView();
            usersView.ShowDialog();
        }

        //private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CategoriesView categoriesView = new CategoriesView();
        //    categoriesView.ShowDialog();
        //}

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookView bookView = new BookView();
            bookView.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            categoryView.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranchView branchView = new BranchView();
            branchView.ShowDialog();
        }

        private void saleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaleView saleView = new SaleView();
            saleView.ShowDialog();
        }

        private void saleDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleDetailView saleView = new SaleDetailView();
            saleView.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersView ordersView = new OrdersView();
            ordersView.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void orderPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersView ordersView = new OrdersView();
            ordersView.ShowDialog();
        }

        private void reportPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersView ordersView = new OrdersView();
            ordersView.ShowDialog();
        }
    }
}
