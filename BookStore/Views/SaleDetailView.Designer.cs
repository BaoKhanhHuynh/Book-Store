namespace BookStore.Views
{
    partial class SaleDetailView
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
            tquantity = new TextBox();
            tid = new TextBox();
            tbid = new TextBox();
            tcid = new TextBox();
            quantity = new Label();
            cidtxt = new Label();
            cid = new Label();
            saleid = new Label();
            buttondelete = new Button();
            groupBox1 = new GroupBox();
            total = new Label();
            ttotal = new TextBox();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            buttonedit = new Button();
            saleDetailINFORMATION = new Label();
            dataGridView1 = new DataGridView();
            buttonsave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            tid.Location = new Point(86, 18);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(160, 23);
            tid.TabIndex = 13;
            tid.TextChanged += tid_TextChanged;
            // 
            // tbid
            // 
            tbid.Location = new Point(85, 47);
            tbid.Margin = new Padding(4, 3, 4, 3);
            tbid.Name = "tbid";
            tbid.Size = new Size(161, 23);
            tbid.TabIndex = 10;
            tbid.TextChanged += tbid_TextChanged;
            // 
            // tcid
            // 
            tcid.Location = new Point(85, 79);
            tcid.Margin = new Padding(4, 3, 4, 3);
            tcid.Name = "tcid";
            tcid.Size = new Size(160, 23);
            tcid.TabIndex = 6;
            tcid.TextChanged += tcid_TextChanged;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.SteelBlue;
            quantity.Location = new Point(311, 26);
            quantity.Margin = new Padding(4, 0, 4, 0);
            quantity.Name = "quantity";
            quantity.Size = new Size(53, 15);
            quantity.TabIndex = 3;
            quantity.Text = "Quantity";
            // 
            // cidtxt
            // 
            cidtxt.AutoSize = true;
            cidtxt.BackColor = Color.SteelBlue;
            cidtxt.Location = new Point(8, 84);
            cidtxt.Margin = new Padding(4, 0, 4, 0);
            cidtxt.Name = "cidtxt";
            cidtxt.Size = new Size(69, 15);
            cidtxt.TabIndex = 2;
            cidtxt.Text = "Category ID";
            // 
            // cid
            // 
            cid.AutoSize = true;
            cid.BackColor = Color.SteelBlue;
            cid.Location = new Point(27, 50);
            cid.Margin = new Padding(4, 0, 4, 0);
            cid.Name = "cid";
            cid.Size = new Size(48, 21);
            cid.TabIndex = 1;
            cid.Text = "Book ID";
            cid.UseCompatibleTextRendering = true;
            // 
            // saleid
            // 
            saleid.AutoSize = true;
            saleid.BackColor = Color.SteelBlue;
            saleid.Location = new Point(57, 21);
            saleid.Margin = new Padding(4, 0, 4, 0);
            saleid.Name = "saleid";
            saleid.Size = new Size(18, 15);
            saleid.TabIndex = 0;
            saleid.Text = "ID";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(327, 386);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 37;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(total);
            groupBox1.Controls.Add(ttotal);
            groupBox1.Controls.Add(tquantity);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tbid);
            groupBox1.Controls.Add(tcid);
            groupBox1.Controls.Add(quantity);
            groupBox1.Controls.Add(cidtxt);
            groupBox1.Controls.Add(cid);
            groupBox1.Controls.Add(saleid);
            groupBox1.Location = new Point(96, 77);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(570, 132);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.SteelBlue;
            total.Location = new Point(304, 50);
            total.Margin = new Padding(4, 0, 4, 0);
            total.Name = "total";
            total.Size = new Size(61, 15);
            total.TabIndex = 18;
            total.Text = "Total Price";
            total.Click += total_Click;
            // 
            // ttotal
            // 
            ttotal.Location = new Point(373, 47);
            ttotal.Margin = new Padding(4, 3, 4, 3);
            ttotal.Name = "ttotal";
            ttotal.Size = new Size(161, 23);
            ttotal.TabIndex = 16;
            ttotal.TextChanged += ttotal_TextChanged;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(519, 386);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 35;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(616, 298);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 34;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(616, 256);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 33;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // saleDetailINFORMATION
            // 
            saleDetailINFORMATION.AutoSize = true;
            saleDetailINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleDetailINFORMATION.Location = new Point(240, 30);
            saleDetailINFORMATION.Name = "saleDetailINFORMATION";
            saleDetailINFORMATION.Size = new Size(340, 31);
            saleDetailINFORMATION.TabIndex = 32;
            saleDetailINFORMATION.Text = "SaleDetail INFORMATION";
            saleDetailINFORMATION.Click += saleDetailINFORMATION_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 165);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(423, 386);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 36;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // SaleDetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondelete);
            Controls.Add(groupBox1);
            Controls.Add(buttonclose);
            Controls.Add(buttonkhoitao);
            Controls.Add(buttonedit);
            Controls.Add(saleDetailINFORMATION);
            Controls.Add(dataGridView1);
            Controls.Add(buttonsave);
            Name = "SaleDetailView";
            Text = "SaleDetailView";
            WindowState = FormWindowState.Maximized;
            Load += SaleDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tquantity;
        private TextBox tid;
        private TextBox tbid;
        private TextBox tcid;
        private Label quantity;
        private Label cidtxt;
        private Label cid;
        private Label saleid;
        private Button buttondelete;
        private GroupBox groupBox1;
        private Label total;
        private TextBox ttotal;
        private Button buttonclose;
        private Button buttonkhoitao;
        private Button buttonedit;
        private Label saleDetailINFORMATION;
        private DataGridView dataGridView1;
        private Button buttonsave;
    }
}