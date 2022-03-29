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
    
    public partial class Dashboard : Form
    {                     
        
        
        public Dashboard()
        {
            InitializeComponent();
     
            Label1 = this.currentUser;
            ListView1 = this.listView1;
            SelectedLabel = this.selectedLabel;
            SelectedLabelID = this.selectedLabelID;
            Dash = this;
        }
        //------------------------------------
        
        public static Label Label1;
        public static ListView ListView1;
        public static string selectedID = ""; //When user selects Pokemon the ID is saved
        public static string selectedName = ""; //When user selects Pokemon the name is saved
        public static Label SelectedLabelID;
        public static Label SelectedLabel;
        public static CustomCaughtButton cusCaughtButton = new CustomCaughtButton();
        public static CustomFavoriteButton cusFavoriteButton = new CustomFavoriteButton();
        public static Dashboard Dash;
        Controller controller = new Controller();
        private string name;
        private string type;

        //------------------------------------

        private void dashboard_Load(object sender, EventArgs e) 
        {
            
            var table = controller.pokemonTypeFilter("ALL TYPES"); //Loads Pokemon Database for user
            Label1.Text = "Current User: " + FrmLogin.name;
            controller.listViewChange(table, "Dashboard");
        }
        //-----------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            cusCaughtButton.ShowDialog();

        }
        private void favoriteButton_Click(object sender, EventArgs e)
        {
           cusFavoriteButton.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //Shows Selected Pokemon to User
        {
            controller.dashListViewSelectChange();
        }

        private void typeFilterBox_SelectedIndexChanged(object sender, EventArgs e) //Filter Pokemon by Type in List
        {
            type = typeFilterBox.Text;
            controller.clearText(2);
            listView1.Items.Clear();
            var table = controller.pokemonTypeFilter(type);
            controller.listViewChange(table, "Dashboard");

        }



        private void searchBox_TextChanged(object sender, EventArgs e) //Search Pokemon Name
        {
            
            name = searchBox.Text;
            controller.clearText(2);
            listView1.Items.Clear();
            var table = controller.pokemonSearch(name);
            controller.listViewChange(table, "Dashboard");
        }

        private void label1_Click(object sender, EventArgs e) //For Testing Purposes
        {
        }

        //private void caughtListButton_Click(object sender, EventArgs e)
        //{
        //    listView1.Items.Clear();
        //    var table = controller.showList("User_Caught");
        //    controller.listViewChange(table);
        //}

        //private void UnCaughtButton_Click(object sender, EventArgs e)
        //{
        //    listView1.Items.Clear();
        //    var table = controller.showUnCaughtList();
        //    controller.listViewChange(table);
        //}

        //private void showFavoriteButton_Click(object sender, EventArgs e)
        //{
        //    listView1.Items.Clear();
        //    var table = controller.showList("User_Favorite");
        //    controller.listViewChange(table);
        //}

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            listView1.Items.Clear();
            this.Close();
        }

        private void userPageButton_Click(object sender, EventArgs e)
        {
            new User_Homepage().Show();
            listView1.Items.Clear();
            this.Close();
            
        }
    }
}

