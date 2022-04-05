using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Software_Project
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
            ADMINFrm = this;
        }
        public static AdminFrm ADMINFrm;
        string adminRequest = "";

        private void AdminFrm_Load(object sender, EventArgs e)
        {

        }

        private void adminBar_TextChanged(object sender, EventArgs e)
        {
            adminRequest = adminBar.Text; 
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            adminRequest = Regex.Replace(adminRequest, @"\s+", " ");
            string[] words = adminRequest.Split(' ');
            string word = words[0];
            if (words[0] == "CREATE" && words[1] == "USER")
            {
            
            }
            else if (words[0] == "READ" && words[1] == "USER")
            {

            }
            else if (word == "UPDATE" && words[1] == "USER")
            {

            }
            else if (word == "DELETE" && words[1] == "USER")
            {

            }
            else
            {
                MessageBox.Show("Not Valid Request!");
            }



            



        }
    }
}
