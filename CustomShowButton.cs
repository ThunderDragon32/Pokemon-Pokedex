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

        private void CustomShowButton_Load(object sender, EventArgs e)
        {

        }
        private void showCaughtButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.ListView1.Items.Clear();
                var table = controller.showList("User_Caught", FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "Dashboard");
                Controller.databaseName = "User_Caught";
                Dashboard.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            else
            {

                User_Homepage.ListView1.Items.Clear();
                var table = controller.showList("User_Caught", FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "User_Homepage");
                Controller.databaseName = "User_Caught";
                User_Homepage.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;

            }
            controller.clearText();
            this.Close();


        }

        private void showFavoriteButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.ListView1.Items.Clear();
                var table = controller.showList("User_Favorite", FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "Dashboard");
                Controller.databaseName = "User_Favorite";
                Dashboard.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            else
            {

                User_Homepage.ListView1.Items.Clear();
                var table = controller.showList("User_Favorite", FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "User_Homepage");
                Controller.databaseName = "User_Favorite";
                User_Homepage.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            controller.clearText();
            this.Close();
        }

        

        private void closeDialog_Click(object sender, EventArgs e)
        {
            controller.clearText();
            this.Close();
        }

        private void uncaughtListButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {

                Dashboard.ListView1.Items.Clear();
                var table = controller.showUnCaughtList(FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "Dashboard");
                Controller.databaseName = "User_UnCaught";
                Dashboard.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            else
            {
                User_Homepage.ListView1.Items.Clear();
                var table = controller.showUnCaughtList(FrmLogin.name);
                controller.listViewChange(table, "Pokemon", "User_Homepage");
                Controller.databaseName = "User_UnCaught";
                User_Homepage.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            controller.clearText();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Dashboard"] != null)
            {

                Dashboard.ListView1.Items.Clear();
                var table = controller.showList("Pokemon");
                controller.listViewChange(table, "Pokemon", "Dashboard");
                Controller.databaseName = "Pokemon";
                Dashboard.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            else
            {
                User_Homepage.ListView1.Items.Clear();
                var table = controller.showList("Pokemon");
                controller.listViewChange(table, "Pokemon", "User_Homepage");
                Controller.databaseName = "Pokemon";
                User_Homepage.CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            }
            controller.clearText();
            this.Close();
        }

    }
}
