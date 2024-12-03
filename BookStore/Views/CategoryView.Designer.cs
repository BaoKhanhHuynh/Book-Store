namespace BookStore.Views
{
    partial class CategoryView
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
            dataGridView1 = new DataGridView();
            tdes = new TextBox();
            tid = new TextBox();
            tname = new TextBox();
            teyear = new TextBox();
            Description = new Label();
            buttondelete = new Button();
            buttonsave = new Button();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            Establishedyear = new Label();
            nametxt = new Label();
            categoryid = new Label();
            groupBox1 = new GroupBox();
            CategoryINFORMATION = new Label();
            buttonedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(455, 150);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tdes
            // 
            tdes.Location = new Point(151, 107);
            tdes.Margin = new Padding(4, 3, 4, 3);
            tdes.Name = "tdes";
            tdes.Size = new Size(257, 23);
            tdes.TabIndex = 14;
            tdes.TextChanged += tdes_TextChanged;
            // 
            // tid
            // 
            tid.Location = new Point(152, 21);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(257, 23);
            tid.TabIndex = 13;
            tid.TextChanged += tid_TextChanged;
            // 
            // tname
            // 
            tname.Location = new Point(151, 50);
            tname.Margin = new Padding(4, 3, 4, 3);
            tname.Name = "tname";
            tname.Size = new Size(258, 23);
            tname.TabIndex = 10;
            tname.TextChanged += tname_TextChanged;
            // 
            // teyear
            // 
            teyear.Location = new Point(152, 79);
            teyear.Margin = new Padding(4, 3, 4, 3);
            teyear.Name = "teyear";
            teyear.Size = new Size(257, 23);
            teyear.TabIndex = 6;
            teyear.TextChanged += teyear_TextChanged;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.SteelBlue;
            Description.Location = new Point(67, 110);
            Description.Margin = new Padding(4, 0, 4, 0);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 3;
            Description.Text = "Description";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(313, 381);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 30;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(409, 381);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 29;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(505, 381);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 28;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(587, 304);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 27;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // Establishedyear
            // 
            Establishedyear.AutoSize = true;
            Establishedyear.BackColor = Color.SteelBlue;
            Establishedyear.Location = new Point(43, 82);
            Establishedyear.Margin = new Padding(4, 0, 4, 0);
            Establishedyear.Name = "Establishedyear";
            Establishedyear.Size = new Size(91, 15);
            Establishedyear.TabIndex = 2;
            Establishedyear.Text = "Established Year";
            // 
            // nametxt
            // 
            nametxt.AutoSize = true;
            nametxt.BackColor = Color.SteelBlue;
            nametxt.Location = new Point(44, 53);
            nametxt.Margin = new Padding(4, 0, 4, 0);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(90, 15);
            nametxt.TabIndex = 1;
            nametxt.Text = "Category Name";
            // 
            // categoryid
            // 
            categoryid.AutoSize = true;
            categoryid.BackColor = Color.SteelBlue;
            categoryid.Location = new Point(116, 24);
            categoryid.Margin = new Padding(4, 0, 4, 0);
            categoryid.Name = "categoryid";
            categoryid.Size = new Size(18, 15);
            categoryid.TabIndex = 0;
            categoryid.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(tdes);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tname);
            groupBox1.Controls.Add(teyear);
            groupBox1.Controls.Add(Description);
            groupBox1.Controls.Add(Establishedyear);
            groupBox1.Controls.Add(nametxt);
            groupBox1.Controls.Add(categoryid);
            groupBox1.Location = new Point(125, 65);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(550, 154);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CategoryINFORMATION
            // 
            CategoryINFORMATION.AutoSize = true;
            CategoryINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryINFORMATION.Location = new Point(249, 22);
            CategoryINFORMATION.Name = "CategoryINFORMATION";
            CategoryINFORMATION.Size = new Size(327, 31);
            CategoryINFORMATION.TabIndex = 31;
            CategoryINFORMATION.Text = "Category INFORMATION";
            CategoryINFORMATION.Click += CategoryINFORMATION_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(587, 261);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 26;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttondelete);
            Controls.Add(buttonsave);
            Controls.Add(buttonclose);
            Controls.Add(buttonkhoitao);
            Controls.Add(groupBox1);
            Controls.Add(CategoryINFORMATION);
            Controls.Add(buttonedit);
            Name = "CategoryView";
            Text = "CategoryView";
            WindowState = FormWindowState.Maximized;
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tdes;
        private TextBox tid;
        private TextBox tname;
        private TextBox teyear;
        private Label Description;
        private Button buttondelete;
        private Button buttonsave;
        private Button buttonclose;
        private Button buttonkhoitao;
        private Label Establishedyear;
        private Label nametxt;
        private Label categoryid;
        private GroupBox groupBox1;
        private Label CategoryINFORMATION;
        private Button buttonedit;
    }
}