using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class CustomShowButton : Form
    {
        public CustomShowButton()
        {
            InitializeComponent();
        }
        Controller controller = new Controller();
        private void showCaughtButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.ListView1.Items.Clear();
                var table = controller.showList("User_Caught");
                controller.listViewChange(table, "Dashboard");
            }
            else
            {

                User_Homepage.ListView1.Items.Clear();
                var table = controller.showList("User_Caught");
                controller.listViewChange(table, "User_Homepage");

            }
            this.Close();


        }

        private void showFavoriteButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.ListView1.Items.Clear();
                var table = controller.showList("User_Favorite");
                controller.listViewChange(table, "Dashboard");
            }
            else
            {

                User_Homepage.ListView1.Items.Clear();
                var table = controller.showList("User_Favorite");
                controller.listViewChange(table, "User_Homepage");

            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomShowButton_Load(object sender, EventArgs e)
        {

        }

        private void closeDialog_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.SelectedLabel.Text = "";
                Dashboard.SelectedLabelID.Text = "";
            }
            else
            {

                User_Homepage.SelectedLabel.Text = "";
                User_Homepage.SelectedLabelID.Text = "";

            }
            this.Close();
        }
    }
}
