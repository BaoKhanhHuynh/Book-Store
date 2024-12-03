namespace BookStore.Views
{
    partial class SaleView
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
            buttondelete = new Button();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            buttonedit = new Button();
            saleINFORMATION = new Label();
            total = new Label();
            saledate = new Label();
            ttotal = new TextBox();
            buttonsave = new Button();
            groupBox1 = new GroupBox();
            tbrand = new TextBox();
            tsdate = new TextBox();
            tid = new TextBox();
            tcus = new TextBox();
            tuid = new TextBox();
            brandid = new Label();
            userid = new Label();
            cusid = new Label();
            categoryid = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(322, 380);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 29;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(537, 380);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 27;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(611, 292);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 26;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(611, 250);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 25;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // saleINFORMATION
            // 
            saleINFORMATION.AutoSize = true;
            saleINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleINFORMATION.Location = new Point(268, 32);
            saleINFORMATION.Name = "saleINFORMATION";
            saleINFORMATION.Size = new Size(269, 31);
            saleINFORMATION.TabIndex = 24;
            saleINFORMATION.Text = "Sale INFORMATION";
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.SteelBlue;
            total.Location = new Point(289, 79);
            total.Margin = new Padding(4, 0, 4, 0);
            total.Name = "total";
            total.Size = new Size(79, 15);
            total.TabIndex = 18;
            total.Text = "Total Amount";
            // 
            // saledate
            // 
            saledate.AutoSize = true;
            saledate.BackColor = Color.SteelBlue;
            saledate.Location = new Point(313, 50);
            saledate.Margin = new Padding(4, 0, 4, 0);
            saledate.Name = "saledate";
            saledate.Size = new Size(55, 15);
            saledate.TabIndex = 17;
            saledate.Text = "Sale Date";
            // 
            // ttotal
            // 
            ttotal.Location = new Point(373, 76);
            ttotal.Margin = new Padding(4, 3, 4, 3);
            ttotal.Name = "ttotal";
            ttotal.Size = new Size(161, 23);
            ttotal.TabIndex = 16;
            ttotal.TextChanged += ttotal_TextChanged;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(434, 380);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 28;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(total);
            groupBox1.Controls.Add(saledate);
            groupBox1.Controls.Add(ttotal);
            groupBox1.Controls.Add(tbrand);
            groupBox1.Controls.Add(tsdate);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tcus);
            groupBox1.Controls.Add(tuid);
            groupBox1.Controls.Add(brandid);
            groupBox1.Controls.Add(userid);
            groupBox1.Controls.Add(cusid);
            groupBox1.Controls.Add(categoryid);
            groupBox1.Location = new Point(91, 71);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(570, 132);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbrand
            // 
            tbrand.Location = new Point(373, 18);
            tbrand.Margin = new Padding(4, 3, 4, 3);
            tbrand.Name = "tbrand";
            tbrand.Size = new Size(161, 23);
            tbrand.TabIndex = 15;
            tbrand.TextChanged += tbrand_TextChanged;
            // 
            // tsdate
            // 
            tsdate.Location = new Point(373, 47);
            tsdate.Margin = new Padding(4, 3, 4, 3);
            tsdate.Name = "tsdate";
            tsdate.Size = new Size(161, 23);
            tsdate.TabIndex = 14;
            tsdate.TextChanged += tsdate_TextChanged;
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
            // tcus
            // 
            tcus.Location = new Point(85, 47);
            tcus.Margin = new Padding(4, 3, 4, 3);
            tcus.Name = "tcus";
            tcus.Size = new Size(161, 23);
            tcus.TabIndex = 10;
            tcus.TextChanged += tcus_TextChanged;
            // 
            // tuid
            // 
            tuid.Location = new Point(85, 79);
            tuid.Margin = new Padding(4, 3, 4, 3);
            tuid.Name = "tuid";
            tuid.Size = new Size(160, 23);
            tuid.TabIndex = 6;
            tuid.TextChanged += tuid_TextChanged;
            // 
            // brandid
            // 
            brandid.AutoSize = true;
            brandid.BackColor = Color.SteelBlue;
            brandid.Location = new Point(310, 26);
            brandid.Margin = new Padding(4, 0, 4, 0);
            brandid.Name = "brandid";
            brandid.Size = new Size(58, 15);
            brandid.TabIndex = 3;
            brandid.Text = "Branch ID";
            // 
            // userid
            // 
            userid.AutoSize = true;
            userid.BackColor = Color.SteelBlue;
            userid.Location = new Point(32, 82);
            userid.Margin = new Padding(4, 0, 4, 0);
            userid.Name = "userid";
            userid.Size = new Size(49, 15);
            userid.TabIndex = 2;
            userid.Text = "Users ID";
            // 
            // cusid
            // 
            cusid.AutoSize = true;
            cusid.BackColor = Color.SteelBlue;
            cusid.Location = new Point(8, 50);
            cusid.Margin = new Padding(4, 0, 4, 0);
            cusid.Name = "cusid";
            cusid.Size = new Size(73, 15);
            cusid.TabIndex = 1;
            cusid.Text = "Customer ID";
            cusid.Click += cusid_Click;
            // 
            // categoryid
            // 
            categoryid.AutoSize = true;
            categoryid.BackColor = Color.SteelBlue;
            categoryid.Location = new Point(60, 26);
            categoryid.Margin = new Padding(4, 0, 4, 0);
            categoryid.Name = "categoryid";
            categoryid.Size = new Size(18, 15);
            categoryid.TabIndex = 0;
            categoryid.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 165);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // SaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttondelete);
            Controls.Add(buttonclose);
            Controls.Add(buttonkhoitao);
            Controls.Add(buttonedit);
            Controls.Add(saleINFORMATION);
            Controls.Add(buttonsave);
            Controls.Add(groupBox1);
            Name = "SaleView";
            Text = "SaleView";
            WindowState = FormWindowState.Maximized;
            Load += Sale_Load2;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttondelete;
        private Button buttonclose;
        private Button buttonkhoitao;
        private Button buttonedit;
        private Label saleINFORMATION;
        private Label total;
        private Label saledate;
        private TextBox ttotal;
        private Button buttonsave;
        private GroupBox groupBox1;
        private TextBox tbrand;
        private TextBox tsdate;
        private TextBox tid;
        private TextBox tcus;
        private TextBox tuid;
        private Label brandid;
        private Label userid;
        private Label cusid;
        private Label categoryid;
        private DataGridView dataGridView1;
    }
}