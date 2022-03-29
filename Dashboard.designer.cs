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
            this.currentUser = new System.Windows.Forms.Label();
            this.caughtButton = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeFilterBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.selectedLabelID = new System.Windows.Forms.Label();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userPageButton = new System.Windows.Forms.Button();
            this.showCaught = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
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
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Location = new System.Drawing.Point(332, 9);
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
            this.selectedLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedLabel.ForeColor = System.Drawing.Color.Red;
            this.selectedLabel.Location = new System.Drawing.Point(605, 439);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(0, 23);
            this.selectedLabel.TabIndex = 3;
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
            this.searchBox.Location = new System.Drawing.Point(219, 310);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(317, 30);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // selectedLabelID
            // 
            this.selectedLabelID.AutoSize = true;
            this.selectedLabelID.Location = new System.Drawing.Point(652, 310);
            this.selectedLabelID.Name = "selectedLabelID";
            this.selectedLabelID.Size = new System.Drawing.Size(0, 23);
            this.selectedLabelID.TabIndex = 7;
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
            this.logoutButton.Location = new System.Drawing.Point(702, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 34);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userPageButton
            // 
            this.userPageButton.Location = new System.Drawing.Point(658, 310);
            this.userPageButton.Name = "userPageButton";
            this.userPageButton.Size = new System.Drawing.Size(108, 31);
            this.userPageButton.TabIndex = 13;
            this.userPageButton.Text = "User Page";
            this.userPageButton.UseVisualStyleBackColor = true;
            this.userPageButton.Click += new System.EventHandler(this.userPageButton_Click);
            // 
            // showCaught
            // 
            this.showCaught.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCaught.Location = new System.Drawing.Point(546, 309);
            this.showCaught.Name = "showCaught";
            this.showCaught.Size = new System.Drawing.Size(106, 31);
            this.showCaught.TabIndex = 14;
            this.showCaught.Text = "Show Caught";
            this.showCaught.UseVisualStyleBackColor = true;
            this.showCaught.Click += new System.EventHandler(this.showCaught_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 647);
            this.Controls.Add(this.showCaught);
            this.Controls.Add(this.userPageButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.selectedLabelID);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.typeFilterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.caughtButton);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dashboard_Load);
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
        public System.Windows.Forms.Label selectedLabelID;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button userPageButton;
        private System.Windows.Forms.Button showCaught;
    }
}