namespace Software_Project
{
    partial class Dashboard
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentUser = new System.Windows.Forms.Label();
            this.caughtButton = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeFilterBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userPageButton = new System.Windows.Forms.Button();
            this.showListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.type1Label = new System.Windows.Forms.Label();
            this.type2Label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 376);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 233);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type1";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type2";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 0;
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Location = new System.Drawing.Point(608, 45);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(0, 23);
            this.currentUser.TabIndex = 1;
            this.currentUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // caughtButton
            // 
            this.caughtButton.Location = new System.Drawing.Point(542, 394);
            this.caughtButton.Name = "caughtButton";
            this.caughtButton.Size = new System.Drawing.Size(108, 42);
            this.caughtButton.TabIndex = 2;
            this.caughtButton.Text = "Caught";
            this.caughtButton.UseVisualStyleBackColor = true;
            this.caughtButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectedLabel.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.selectedLabel.Location = new System.Drawing.Point(416, 76);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(95, 32);
            this.selectedLabel.TabIndex = 3;
            this.selectedLabel.Text = "Name";
            this.selectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // typeFilterBox
            // 
            this.typeFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeFilterBox.FormattingEnabled = true;
            this.typeFilterBox.Items.AddRange(new object[] {
            "ALL TYPES",
            "Water",
            "Fire",
            "Grass"});
            this.typeFilterBox.Location = new System.Drawing.Point(28, 310);
            this.typeFilterBox.Name = "typeFilterBox";
            this.typeFilterBox.Size = new System.Drawing.Size(121, 31);
            this.typeFilterBox.TabIndex = 5;
            this.typeFilterBox.SelectedIndexChanged += new System.EventHandler(this.typeFilterBox_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchBox.Location = new System.Drawing.Point(225, 310);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(400, 30);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Location = new System.Drawing.Point(656, 394);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(108, 42);
            this.favoriteButton.TabIndex = 10;
            this.favoriteButton.Text = "Favorite";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(725, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 34);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userPageButton
            // 
            this.userPageButton.Location = new System.Drawing.Point(604, 0);
            this.userPageButton.Name = "userPageButton";
            this.userPageButton.Size = new System.Drawing.Size(108, 34);
            this.userPageButton.TabIndex = 13;
            this.userPageButton.Text = "User Page";
            this.userPageButton.UseVisualStyleBackColor = true;
            this.userPageButton.Click += new System.EventHandler(this.userPageButton_Click);
            // 
            // showListButton
            // 
            this.showListButton.Location = new System.Drawing.Point(658, 330);
            this.showListButton.Name = "showListButton";
            this.showListButton.Size = new System.Drawing.Size(106, 31);
            this.showListButton.TabIndex = 15;
            this.showListButton.Text = "Show List";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search Bar";
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descLabel.ForeColor = System.Drawing.Color.White;
            this.descLabel.Location = new System.Drawing.Point(225, 221);
            this.descLabel.MaximumSize = new System.Drawing.Size(400, 50);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(400, 50);
            this.descLabel.TabIndex = 18;
            this.descLabel.Text = "Desc";
            // 
            // type1Label
            // 
            this.type1Label.AutoSize = true;
            this.type1Label.Location = new System.Drawing.Point(558, 469);
            this.type1Label.Name = "type1Label";
            this.type1Label.Size = new System.Drawing.Size(58, 23);
            this.type1Label.TabIndex = 20;
            this.type1Label.Text = "Type1";
            // 
            // type2Label
            // 
            this.type2Label.AutoSize = true;
            this.type2Label.Location = new System.Drawing.Point(634, 469);
            this.type2Label.Name = "type2Label";
            this.type2Label.Size = new System.Drawing.Size(58, 23);
            this.type2Label.TabIndex = 21;
            this.type2Label.Text = "Type2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Software_Project.Properties.Resources.fireType;
            this.pictureBox3.Location = new System.Drawing.Point(416, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Software_Project.Properties.Resources.flyingType;
            this.pictureBox1.Location = new System.Drawing.Point(517, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Project.Properties.Resources.charizard1;
            this.pictureBox2.Location = new System.Drawing.Point(225, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 647);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.type2Label);
            this.Controls.Add(this.type1Label);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showListButton);
            this.Controls.Add(this.userPageButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.typeFilterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.caughtButton);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Button caughtButton;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox typeFilterBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button userPageButton;
        private System.Windows.Forms.Button showListButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label type1Label;
        private System.Windows.Forms.Label type2Label;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}