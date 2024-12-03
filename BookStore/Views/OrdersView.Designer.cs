namespace BookStore.Views
{
    partial class OrdersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonclose = new Button();
            OrdersINFORMATION = new Label();
            price = new Label();
            tgia = new TextBox();
            groupBox1 = new GroupBox();
            toder = new TextBox();
            order_date = new Label();
            tquantity = new TextBox();
            tid = new TextBox();
            tcus = new TextBox();
            tbok = new TextBox();
            quantity = new Label();
            book_title = new Label();
            cid = new Label();
            id = new Label();
            dataGridView1 = new DataGridView();
            buttonsave = new Button();
            btnExportExcel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(357, 390);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 43;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // OrdersINFORMATION
            // 
            OrdersINFORMATION.AutoSize = true;
            OrdersINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersINFORMATION.Location = new Point(240, 34);
            OrdersINFORMATION.Name = "OrdersINFORMATION";
            OrdersINFORMATION.Size = new Size(303, 31);
            OrdersINFORMATION.TabIndex = 40;
            OrdersINFORMATION.Text = "Orders INFORMATION";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.SteelBlue;
            price.Location = new Point(332, 55);
            price.Margin = new Padding(4, 0, 4, 0);
            price.Name = "price";
            price.Size = new Size(33, 15);
            price.TabIndex = 18;
            price.Text = "Price";
            // 
            // tgia
            // 
            tgia.Location = new Point(373, 47);
            tgia.Margin = new Padding(4, 3, 4, 3);
            tgia.Name = "tgia";
            tgia.Size = new Size(161, 23);
            tgia.TabIndex = 16;
            tgia.TextChanged += tgia_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(toder);
            groupBox1.Controls.Add(order_date);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(tgia);
            groupBox1.Controls.Add(tquantity);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tcus);
            groupBox1.Controls.Add(tbok);
            groupBox1.Controls.Add(quantity);
            groupBox1.Controls.Add(book_title);
            groupBox1.Controls.Add(cid);
            groupBox1.Controls.Add(id);
            groupBox1.Location = new Point(96, 81);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(570, 132);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // toder
            // 
            toder.Location = new Point(373, 76);
            toder.Margin = new Padding(4, 3, 4, 3);
            toder.Name = "toder";
            toder.Size = new Size(161, 23);
            toder.TabIndex = 20;
            toder.TextChanged += toder_TextChanged;
            // 
            // order_date
            // 
            order_date.AutoSize = true;
            order_date.BackColor = Color.SteelBlue;
            order_date.Location = new Point(301, 79);
            order_date.Margin = new Padding(4, 0, 4, 0);
            order_date.Name = "order_date";
            order_date.Size = new Size(64, 15);
            order_date.TabIndex = 19;
            order_date.Text = "Order Date";
            // 
            // tquantity
            // 
            tquantity.Location = new Point(373, 18);
            tquantity.Margin = new Padding(4, 3, 4, 3);
            tquantity.Name = "tquantity";
            tquantity.Size = new Size(161, 23);
            tquantity.TabIndex = 15;
            tquantity.TextChanged += tquantity_TextChanged;
            // 
            // tid
            // 
            tid.Location = new Point(109, 22);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(160, 23);
            tid.TabIndex = 13;
            tid.TextChanged += tid_TextChanged;
            // 
            // tcus
            // 
            tcus.Location = new Point(108, 50);
            tcus.Margin = new Padding(4, 3, 4, 3);
            tcus.Name = "tcus";
            tcus.Size = new Size(161, 23);
            tcus.TabIndex = 10;
            tcus.TextChanged += tcus_TextChanged;
            // 
            // tbok
            // 
            tbok.Location = new Point(109, 76);
            tbok.Margin = new Padding(4, 3, 4, 3);
            tbok.Name = "tbok";
            tbok.Size = new Size(160, 23);
            tbok.TabIndex = 6;
            tbok.TextChanged += tbok_TextChanged;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.SteelBlue;
            quantity.Location = new Point(312, 26);
            quantity.Margin = new Padding(4, 0, 4, 0);
            quantity.Name = "quantity";
            quantity.Size = new Size(53, 15);
            quantity.TabIndex = 3;
            quantity.Text = "Quantity";
            // 
            // book_title
            // 
            book_title.AutoSize = true;
            book_title.BackColor = Color.SteelBlue;
            book_title.Location = new Point(42, 79);
            book_title.Margin = new Padding(4, 0, 4, 0);
            book_title.Name = "book_title";
            book_title.Size = new Size(59, 15);
            book_title.TabIndex = 2;
            book_title.Text = "Book Title";
            // 
            // cid
            // 
            cid.AutoSize = true;
            cid.BackColor = Color.SteelBlue;
            cid.Location = new Point(8, 50);
            cid.Margin = new Padding(4, 0, 4, 0);
            cid.Name = "cid";
            cid.Size = new Size(93, 21);
            cid.TabIndex = 1;
            cid.Text = "Customer Name";
            cid.UseCompatibleTextRendering = true;
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.SteelBlue;
            id.Location = new Point(83, 25);
            id.Margin = new Padding(4, 0, 4, 0);
            id.Name = "id";
            id.Size = new Size(18, 15);
            id.TabIndex = 0;
            id.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(570, 165);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(205, 390);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 44;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Chartreuse;
            btnExportExcel.Location = new Point(502, 390);
            btnExportExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(88, 27);
            btnExportExcel.TabIndex = 45;
            btnExportExcel.Text = "Report";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportExcel);
            Controls.Add(buttonclose);
            Controls.Add(OrdersINFORMATION);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonsave);
            Name = "OrdersView";
            Text = "OrdersView";
            WindowState = FormWindowState.Maximized;
            Load += Orders_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonclose;
        private Label OrdersINFORMATION;
        private Label price;
        private TextBox tgia;
        private GroupBox groupBox1;
        private TextBox tquantity;
        private TextBox tid;
        private TextBox tcus;
        private TextBox tbok;
        private Label quantity;
        private Label book_title;
        private Label cid;
        private Label id;
        private DataGridView dataGridView1;
        private Button buttonsave;
        private TextBox toder;
        private Label order_date;
        private Button btnExportExcel;
    }
}