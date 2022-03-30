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
    public partial class User_Homepage : Form
    {
        public User_Homepage()
        {
            InitializeComponent();
            ListView1 = this.listView1;
            SelectedLabel = this.selectedPokemon;
            SelectedLabelID = this.selectedPokemonID;
        }
        //----------------
        public static ListView ListView1;
        public static CustomCaughtButton cusCaughtButton = new CustomCaughtButton();
        public static CustomFavoriteButton cusFavoriteButton = new CustomFavoriteButton();
        public static CustomShowButton cusShowButton = new CustomShowButton();
        public static string selectedID = ""; //When user selects Pokemon the ID is saved
        public static string selectedName = ""; //When user selects Pokemon the name is saved
        public static Label SelectedLabelID;
        public static Label SelectedLabel;
        Controller controller = new Controller();
        //----------------
        private void logoutButton_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            listView1.Items.Clear();
            this.Close();
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            cusFavoriteButton.ShowDialog();
        }

        private void showCaughtList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var table = controller.showList("User_Caught");
            controller.listViewChange(table, "User_Caught");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            controller.listViewSelectChange();
            
        }

        private void searchPageButton_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            listView1.Items.Clear();
            this.Close();
        }

        private void favoriteListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var table = controller.showList("User_Favorite");
            controller.listViewChange(table, "User_Homepage");
        }

        private void User_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + "1.png";
        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            cusShowButton.ShowDialog();
        }
    }
}
