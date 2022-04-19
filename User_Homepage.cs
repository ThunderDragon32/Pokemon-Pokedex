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
            AdminButton = this.adminButton;
            PictureBox1 = this.pictureBox1;
            PictureBox2 = this.pictureBox2;
            PictureBox3 = this.pictureBox3;
            PictureBox4 = this.pictureBox4;
            PictureBox5 = this.pictureBox5;
            PictureBox6 = this.pictureBox6;
            CurrentDBLabel = this.currentDBLabel;
            controller.adminVerify();
        }
        //----------------
        public static PictureBox PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6;
        public static ListView ListView1;
        public static CustomCaughtButton cusCaughtButton = new CustomCaughtButton();
        public static CustomFavoriteButton cusFavoriteButton = new CustomFavoriteButton();
        public static CustomShowButton cusShowButton = new CustomShowButton();
        public static AdminFrm ADMINFrm = new AdminFrm();
        public static Label SelectedLabelID, SelectedLabel, CurrentDBLabel;
        public static Button AdminButton;
        Controller controller = new Controller();
        //----------------
        private void User_Homepage_Load(object sender, EventArgs e)
        {
            Controller.databaseName = "User_Favorite";
            CurrentDBLabel.Text = "Current Database: " + Controller.databaseName;
            Controller.subdataName = "";
            Controller.currentKey = "";
            Controller.currentKey2 = "";
            controller.refreshUserFavoriteBoxes();
            var table = controller.showList("User_Favorite", FrmLogin.name);
            controller.listViewChange(table, "Pokemon", "User_Homepage");

        }
        private void favoriteButton_Click(object sender, EventArgs e)
        {
            
            
            cusFavoriteButton.ShowDialog();
            controller.refreshUserFavoriteBoxes();
        }

        private void showCaughtList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var table = controller.showList("User_Caught");
            controller.listViewChange(table, "User", "User_Caught");
            controller.refreshUserFavoriteBoxes();
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

        private void showListButton_Click(object sender, EventArgs e)
        {
            cusShowButton.ShowDialog();
        }
        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            FrmLogin.FrmLog.Show();
            listView1.Items.Clear();
            this.Close();
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            ADMINFrm.ShowDialog();

        }
        private void selectedPokemon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox2);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(PictureBox6);
        }
    }
}
