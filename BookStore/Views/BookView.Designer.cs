namespace BookStore.Views
{
    partial class BookView
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
            categoryid = new Label();
            Titletxt = new Label();
            Authortxt = new Label();
            Publisher = new Label();
            tauthor = new TextBox();
            ttitle = new TextBox();
            tid = new TextBox();
            tprice = new TextBox();
            tpublisher = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            price = new Label();
            tstock = new TextBox();
            dataGridView1 = new DataGridView();
            BookINFORMATION = new Label();
            buttonedit = new Button();
            buttonkhoitao = new Button();
            buttonclose = new Button();
            buttonsave = new Button();
            buttondelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // categoryid
            // 
            categoryid.AutoSize = true;
            categoryid.BackColor = Color.SteelBlue;
            categoryid.Location = new Point(28, 21);
            categoryid.Margin = new Padding(4, 0, 4, 0);
            categoryid.Name = "categoryid";
            categoryid.Size = new Size(18, 15);
            categoryid.TabIndex = 0;
            categoryid.Text = "ID";
            categoryid.Click += categoryid_Click;
            // 
            // Titletxt
            // 
            Titletxt.AutoSize = true;
            Titletxt.BackColor = Color.SteelBlue;
            Titletxt.Location = new Point(18, 50);
            Titletxt.Margin = new Padding(4, 0, 4, 0);
            Titletxt.Name = "Titletxt";
            Titletxt.Size = new Size(29, 15);
            Titletxt.TabIndex = 1;
            Titletxt.Text = "Title";
            Titletxt.Click += Titletxt_Click;
            // 
            // Authortxt
            // 
            Authortxt.AutoSize = true;
            Authortxt.BackColor = Color.SteelBlue;
            Authortxt.Location = new Point(3, 79);
            Authortxt.Margin = new Padding(4, 0, 4, 0);
            Authortxt.Name = "Authortxt";
            Authortxt.Size = new Size(44, 15);
            Authortxt.TabIndex = 2;
            Authortxt.Text = "Author";
            // 
            // Publisher
            // 
            Publisher.AutoSize = true;
            Publisher.BackColor = Color.SteelBlue;
            Publisher.Location = new Point(309, 26);
            Publisher.Margin = new Padding(4, 0, 4, 0);
            Publisher.Name = "Publisher";
            Publisher.Size = new Size(56, 15);
            Publisher.TabIndex = 3;
            Publisher.Text = "Publisher";
            Publisher.Click += Publisher_Click;
            // 
            // tauthor
            // 
            tauthor.Location = new Point(55, 74);
            tauthor.Margin = new Padding(4, 3, 4, 3);
            tauthor.Name = "tauthor";
            tauthor.Size = new Size(160, 23);
            tauthor.TabIndex = 6;
            tauthor.TextChanged += tauthor_TextChanged;
            // 
            // ttitle
            // 
            ttitle.Location = new Point(54, 47);
            ttitle.Margin = new Padding(4, 3, 4, 3);
            ttitle.Name = "ttitle";
            ttitle.Size = new Size(161, 23);
            ttitle.TabIndex = 10;
            ttitle.TextChanged += ttitle_TextChanged;
            // 
            // tid
            // 
            tid.Location = new Point(55, 18);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(160, 23);
            tid.TabIndex = 13;
            tid.TextChanged += tid_TextChanged;
            // 
            // tprice
            // 
            tprice.Location = new Point(373, 47);
            tprice.Margin = new Padding(4, 3, 4, 3);
            tprice.Name = "tprice";
            tprice.Size = new Size(161, 23);
            tprice.TabIndex = 14;
            tprice.TextChanged += tprice_TextChanged;
            // 
            // tpublisher
            // 
            tpublisher.Location = new Point(373, 18);
            tpublisher.Margin = new Padding(4, 3, 4, 3);
            tpublisher.Name = "tpublisher";
            tpublisher.Size = new Size(161, 23);
            tpublisher.TabIndex = 15;
            tpublisher.TextChanged += tpublisher_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(tstock);
            groupBox1.Controls.Add(tpublisher);
            groupBox1.Controls.Add(tprice);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(ttitle);
            groupBox1.Controls.Add(tauthor);
            groupBox1.Controls.Add(Publisher);
            groupBox1.Controls.Add(Authortxt);
            groupBox1.Controls.Add(Titletxt);
            groupBox1.Controls.Add(categoryid);
            groupBox1.Location = new Point(49, 48);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(570, 143);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Location = new Point(329, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Stock";
            label2.Click += label2_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.SteelBlue;
            price.Location = new Point(329, 50);
            price.Margin = new Padding(4, 0, 4, 0);
            price.Name = "price";
            price.Size = new Size(33, 15);
            price.TabIndex = 17;
            price.Text = "Price";
            price.Click += price_Click;
            // 
            // tstock
            // 
            tstock.Location = new Point(373, 76);
            tstock.Margin = new Padding(4, 3, 4, 3);
            tstock.Name = "tstock";
            tstock.Size = new Size(161, 23);
            tstock.TabIndex = 16;
            tstock.TextChanged += tstock_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 165);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookINFORMATION
            // 
            BookINFORMATION.AutoSize = true;
            BookINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookINFORMATION.Location = new Point(226, 9);
            BookINFORMATION.Name = "BookINFORMATION";
            BookINFORMATION.Size = new Size(281, 31);
            BookINFORMATION.TabIndex = 16;
            BookINFORMATION.Text = "Book INFORMATION";
            BookINFORMATION.Click += BookINFORMATION_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(580, 234);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 17;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(580, 283);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 18;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(517, 368);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 19;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(390, 368);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 20;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(259, 368);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 21;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondelete);
            Controls.Add(buttonsave);
            Controls.Add(buttonclose);
            Controls.Add(buttonkhoitao);
            Controls.Add(buttonedit);
            Controls.Add(BookINFORMATION);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "BookView";
            Text = "BookView";
            WindowState = FormWindowState.Maximized;
            Load += Book_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoryid;
        private Label Titletxt;
        private Label Authortxt;
        private Label Publisher;
        private TextBox tauthor;
        private TextBox ttitle;
        private TextBox tid;
        private TextBox tprice;
        private TextBox tpublisher;
        private GroupBox groupBox1;
        private Label label2;
        private Label price;
        private TextBox tstock;
        private DataGridView dataGridView1;
        private Label BookINFORMATION;
        private Button buttonedit;
        private Button buttonkhoitao;
        private Button buttonclose;
        private Button buttonsave;
        private Button buttondelete;
    }
}