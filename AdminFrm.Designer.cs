namespace Software_Project
{
    partial class AdminFrm
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
            this.adminBar = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBar
            // 
            this.adminBar.Location = new System.Drawing.Point(186, 144);
            this.adminBar.Name = "adminBar";
            this.adminBar.Size = new System.Drawing.Size(360, 22);
            this.adminBar.TabIndex = 0;
            this.adminBar.TextChanged += new System.EventHandler(this.adminBar_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(553, 142);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.adminBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminFrm";
            this.Text = "AdminFrm";
            this.Load += new System.EventHandler(this.AdminFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminBar;
        private System.Windows.Forms.Button runButton;
    }
}