namespace BookStore.Views
{
    partial class CustomerView
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
            groupBox1 = new GroupBox();
            address = new Label();
            taddress = new TextBox();
            temail = new TextBox();
            tid = new TextBox();
            tname = new TextBox();
            tphone = new TextBox();
            email = new Label();
            phone = new Label();
            nametxt = new Label();
            categoryid = new Label();
            CustomerINFORMATION = new Label();
            buttondelete = new Button();
            buttonsave = new Button();
            buttonclose = new Button();
            buttonkhoitao = new Button();
            buttonedit = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(address);
            groupBox1.Controls.Add(taddress);
            groupBox1.Controls.Add(temail);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(tname);
            groupBox1.Controls.Add(tphone);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(phone);
            groupBox1.Controls.Add(nametxt);
            groupBox1.Controls.Add(categoryid);
            groupBox1.Location = new Point(125, 75);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(550, 174);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // address
            // 
            address.AutoSize = true;
            address.BackColor = Color.SteelBlue;
            address.Location = new Point(84, 139);
            address.Margin = new Padding(4, 0, 4, 0);
            address.Name = "address";
            address.Size = new Size(49, 15);
            address.TabIndex = 16;
            address.Text = "Address";
            // 
            // taddress
            // 
            taddress.Location = new Point(152, 136);
            taddress.Margin = new Padding(4, 3, 4, 3);
            taddress.Name = "taddress";
            taddress.Size = new Size(257, 23);
            taddress.TabIndex = 15;
            taddress.TextChanged += taddress_TextChanged;
            // 
            // temail
            // 
            temail.Location = new Point(151, 107);
            temail.Margin = new Padding(4, 3, 4, 3);
            temail.Name = "temail";
            temail.Size = new Size(257, 23);
            temail.TabIndex = 14;
            temail.TextChanged += temail_TextChanged;
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
            // tphone
            // 
            tphone.Location = new Point(152, 79);
            tphone.Margin = new Padding(4, 3, 4, 3);
            tphone.Name = "tphone";
            tphone.Size = new Size(257, 23);
            tphone.TabIndex = 6;
            tphone.TextChanged += tphone_TextChanged;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.SteelBlue;
            email.Location = new Point(97, 110);
            email.Margin = new Padding(4, 0, 4, 0);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.SteelBlue;
            phone.Location = new Point(92, 82);
            phone.Margin = new Padding(4, 0, 4, 0);
            phone.Name = "phone";
            phone.Size = new Size(41, 15);
            phone.TabIndex = 2;
            phone.Text = "Phone";
            // 
            // nametxt
            // 
            nametxt.AutoSize = true;
            nametxt.BackColor = Color.SteelBlue;
            nametxt.Location = new Point(94, 53);
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
            categoryid.Location = new Point(115, 24);
            categoryid.Margin = new Padding(4, 0, 4, 0);
            categoryid.Name = "categoryid";
            categoryid.Size = new Size(18, 15);
            categoryid.TabIndex = 0;
            categoryid.Text = "ID";
            // 
            // CustomerINFORMATION
            // 
            CustomerINFORMATION.AutoSize = true;
            CustomerINFORMATION.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerINFORMATION.Location = new Point(249, 32);
            CustomerINFORMATION.Name = "CustomerINFORMATION";
            CustomerINFORMATION.Size = new Size(335, 31);
            CustomerINFORMATION.TabIndex = 23;
            CustomerINFORMATION.Text = "Customer INFORMATION";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(312, 411);
            buttondelete.Margin = new Padding(4, 3, 4, 3);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(88, 27);
            buttondelete.TabIndex = 22;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Location = new Point(420, 411);
            buttonsave.Margin = new Padding(4, 3, 4, 3);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(88, 27);
            buttonsave.TabIndex = 21;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = SystemColors.ControlDarkDark;
            buttonclose.Location = new Point(531, 411);
            buttonclose.Margin = new Padding(4, 3, 4, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(88, 27);
            buttonclose.TabIndex = 20;
            buttonclose.Text = "Close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // buttonkhoitao
            // 
            buttonkhoitao.BackColor = Color.FromArgb(255, 192, 192);
            buttonkhoitao.Location = new Point(587, 347);
            buttonkhoitao.Margin = new Padding(4, 3, 4, 3);
            buttonkhoitao.Name = "buttonkhoitao";
            buttonkhoitao.Size = new Size(88, 27);
            buttonkhoitao.TabIndex = 19;
            buttonkhoitao.Text = "Resert";
            buttonkhoitao.UseVisualStyleBackColor = false;
            buttonkhoitao.Click += buttonkhoitao_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.FromArgb(255, 192, 192);
            buttonedit.Location = new Point(587, 289);
            buttonedit.Margin = new Padding(4, 3, 4, 3);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(88, 27);
            buttonedit.TabIndex = 18;
            buttonedit.Text = "Edit";
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += buttonedit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(455, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(CustomerINFORMATION);
            Controls.Add(buttondelete);
            Controls.Add(buttonsave);
            Controls.Add(buttonclose);
            Controls.Add(buttonkhoitao);
            Controls.Add(buttonedit);
            Controls.Add(dataGridView1);
            Name = "CustomerView";
            Text = "CustomerView";
            WindowState = FormWindowState.Maximized;
            Load += Customer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label address;
        private TextBox taddress;
        private TextBox temail;
        private TextBox tid;
        private TextBox tname;
        private TextBox tphone;
        private Label email;
        private Label phone;
        private Label nametxt;
        private Label categoryid;
        private Label CustomerINFORMATION;
        private Button buttondelete;
        private Button buttonsave;
        private Button buttonclose;
        private Button buttonkhoitao;
        private Button buttonedit;
        private DataGridView dataGridView1;
    }
}