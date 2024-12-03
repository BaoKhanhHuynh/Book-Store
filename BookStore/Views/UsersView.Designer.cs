namespace BookStore
{
    partial class UsersView
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tid = new TextBox();
            Admin = new RadioButton();
            User = new RadioButton();
            tBoxName = new TextBox();
            textBoxPassWord = new TextBox();
            Right = new Label();
            Password = new Label();
            Nametxt = new Label();
            Employeeid = new Label();
            dataGridView1 = new DataGridView();
            buttondelete = new Button();
            buttonsave = new Button();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            buttonedit = new Button();
            bankSystemDataSet3BindingSource = new BindingSource(components);
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankSystemDataSet3BindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(Admin);
            groupBox1.Controls.Add(User);
            groupBox1.Controls.Add(tBoxName);
            groupBox1.Controls.Add(textBoxPassWord);
            groupBox1.Controls.Add(Right);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(Nametxt);
            groupBox1.Controls.Add(Employeeid);
            groupBox1.Location = new Point(121, 50);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(550, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.BackColor = Color.FromArgb(192, 192, 255);
            Admin.Location = new Point(316, 110);
            Admin.Margin = new Padding(4, 3, 4, 3);
            Admin.Name = "Admin";
            Admin.Size = new Size(61, 19);
            Admin.TabIndex = 12;
            Admin.TabStop = true;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.AutoSize = true;
            User.BackColor = Color.IndianRed;
            User.Location = new Point(215, 110);
            User.Margin = new Padding(4, 3, 4, 3);
            User.Name = "User";
            User.Size = new Size(48, 19);
            User.TabIndex = 11;
            User.TabStop = true;
            User.Text = "User";
            User.UseVisualStyleBackColor = false;
            // 
            // tBoxName
            // 
            tBoxName.Location = new Point(151, 50);
            tBoxName.Margin = new Padding(4, 3, 4, 3);
            tBoxName.Name = "tBoxName";
            tBoxName.Size = new Size(258, 23);
            tBoxName.TabIndex = 10;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(152, 79);
            textBoxPassWord.Margin = new Padding(4, 3, 4, 3);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(257, 23);
            textBoxPassWord.TabIndex = 6;
            // 
            // Right
            // 
            Right.AutoSize = true;
            Right.BackColor = Color.SteelBlue;
            Right.Location = new Point(48, 110);
            Right.Margin = new Padding(4, 0, 4, 0);
            Right.Name = "Right";
            Right.Size = new Size(35, 15);
            Right.TabIndex = 3;
            Right.Text = "Right";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.SteelBlue;
            Password.Location = new Point(48, 82);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // Nametxt
            // 
            Nametxt.AutoSize = true;
            Nametxt.BackColor = Color.SteelBlue;
            Nametxt.Location = new Point(48, 53);
            Nametxt.Margin = new Padding(4, 0, 4, 0);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(65, 15);
            Nametxt.TabIndex = 1;
            Nametxt.Text = "User Name";
            Nametxt.Click += Nametxt_Click;
            // 
            // Employeeid
            // 
            Employeeid.AutoSize = true;
            Employeeid.BackColor = Color.SteelBlue;
            Employeeid.Location = new Point(48, 24);
            Employeeid.Margin = new Padding(4, 0, 4, 0);
            Employeeid.Name = "Employeeid";
            Employeeid.Size = new Size(18, 15);
            Employeeid.TabIndex = 0;
            Employeeid.Text = "ID";
            Employeeid.Click += Employeeid_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 199);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(204, 365);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 5;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(336, 365);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 6;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(476, 365);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 7;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(595, 302);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 8;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(595, 244);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 9;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 10;
            label1.Text = "Users INFORMATION";
            label1.Click += label1_Click;
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Controls.Add(buttonedit);
            Controls.Add(buttonkhoitao);
            Controls.Add(buttonclose);
            Controls.Add(buttonsave);
            Controls.Add(buttondelete);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UsersView";
            Text = "Users";
            WindowState = FormWindowState.Maximized;
            Load += User_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankSystemDataSet3BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Employeeid;
        private System.Windows.Forms.Label Nametxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Right;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button buttonkhoitao;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.BindingSource bankSystemDataSet3BindingSource;
        private System.Windows.Forms.TextBox tid;
        private Label label1;
    }
}