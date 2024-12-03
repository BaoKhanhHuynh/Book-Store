namespace BookStore.Views
{
    partial class BranchView
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
            tcity = new TextBox();
            tid = new TextBox();
            tname = new TextBox();
            tadd = new TextBox();
            city = new Label();
            buttondelete = new Button();
            buttonsave = new Button();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            address = new Label();
            nametxt = new Label();
            categoryid = new Label();
            groupBox1 = new GroupBox();
            branchINFORMATION = new Label();
            buttonedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(455, 150);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tcity
            // 
            tcity.Location = new Point(151, 107);
            tcity.Margin = new Padding(4, 3, 4, 3);
            tcity.Name = "tcity";
            tcity.Size = new Size(257, 23);
            tcity.TabIndex = 14;
            tcity.TextChanged += tcity_TextChanged;
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
            // tadd
            // 
            tadd.Location = new Point(152, 79);
            tadd.Margin = new Padding(4, 3, 4, 3);
            tadd.Name = "tadd";
            tadd.Size = new Size(257, 23);
            tadd.TabIndex = 6;
            tadd.TextChanged += tadd_TextChanged;
            // 
            // city
            // 
            city.AutoSize = true;
            city.BackColor = Color.SteelBlue;
            city.Location = new Point(107, 110);
            city.Margin = new Padding(4, 0, 4, 0);
            city.Name = "city";
            city.Size = new Size(28, 15);
            city.TabIndex = 3;
            city.Text = "City";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(313, 391);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 38;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(409, 391);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 37;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(505, 391);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 36;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(587, 314);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 35;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // address
            // 
            address.AutoSize = true;
            address.BackColor = Color.SteelBlue;
            address.Location = new Point(86, 82);
            address.Margin = new Padding(4, 0, 4, 0);
            address.Name = "address";
            address.Size = new Size(49, 15);
            address.TabIndex = 2;
            address.Text = "Address";
            address.Click += address_Click;
            // 
            // nametxt
            // 
            nametxt.AutoSize = true;
            nametxt.BackColor = Color.SteelBlue;
            nametxt.Location = new Point(96, 53);
            nametxt.Margin = new Padding(4, 0, 4, 0);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(39, 15);
            nametxt.TabIndex = 1;
            nametxt.Text = "Name";
            // 
            // categoryid
            // 
            categoryid.AutoSize = true;
            categoryid.BackColor = Color.SteelBlue;
            categoryid.Location = new Point(117, 24);
            categoryid.Margin = new Padding(4, 0, 4, 0);
            categoryid.Name = "categoryid";
            categoryid.Size = new Size(18, 15);
            categoryid.TabIndex = 0;
            categoryid.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(tcity);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tname);
            groupBox1.Controls.Add(tadd);
            groupBox1.Controls.Add(city);
            groupBox1.Controls.Add(address);
            groupBox1.Controls.Add(nametxt);
            groupBox1.Controls.Add(categoryid);
            groupBox1.Location = new Point(125, 75);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(550, 154);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // branchINFORMATION
            // 
            branchINFORMATION.AutoSize = true;
            branchINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            branchINFORMATION.Location = new Point(249, 32);
            branchINFORMATION.Name = "branchINFORMATION";
            branchINFORMATION.Size = new Size(306, 31);
            branchINFORMATION.TabIndex = 39;
            branchINFORMATION.Text = "Branch INFORMATION";
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(587, 271);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 34;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // BranchView
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
            Controls.Add(branchINFORMATION);
            Controls.Add(buttonedit);
            Name = "BranchView";
            Text = "BranchView";
            WindowState = FormWindowState.Maximized;
            Load += Branch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tcity;
        private TextBox tid;
        private TextBox tname;
        private TextBox tadd;
        private Label city;
        private Button buttondelete;
        private Button buttonsave;
        private Button buttonclose;
        private Button buttonkhoitao;
        private Label address;
        private Label nametxt;
        private Label categoryid;
        private GroupBox groupBox1;
        private Label branchINFORMATION;
        private Button buttonedit;
    }
}