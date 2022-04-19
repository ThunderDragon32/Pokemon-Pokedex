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

            CurrentUser = this.currentUser;
            ListView1 = this.listView1;
            SelectedLabel = this.selectedLabel;
            DescLabel = this.descLb;
            Type1PicBx = this.type1PicBx;
            Type2PicBx = this.type2PicBx;
            PokemonPic = this.pokemonPic;
            CurrentDBLabel = this.currentDBLabel;
            CaughtBox = this.caughtBox; 
            Dash = this;
        }
        //------------------------------------

        public static Label CurrentUser;
        public static ListView ListView1;
        public static Label SelectedLabel; //Selected Pokemon name and ID are labeled
        public static Label DescLabel; //Selected Pokemon Desc is labled
        public static Label CurrentDBLabel;
        public static PictureBox Type1PicBx, Type2PicBx, PokemonPic, CaughtBox;
        public static CustomCaughtButton cusCaughtButton = new CustomCaughtButton();
        public static CustomFavoriteButton cusFavoriteButton = new CustomFavoriteButton();
        public static CustomShowButton cusShowButton = new CustomShowButton();
        public static Dashboard Dash;
        Controller controller = new Controller();


        //------------------------------------

        private void dashboard_Load(object sender, EventArgs e)
        {
            var table = controller.showList("Pokemon"); //Loads Pokemon Database for user
            currentUser.Text = "Current User: " + FrmLogin.name;
            controller.listViewChange(table, "Pokemon", "Dashboard");
            Controller.databaseName = "Pokemon";
            currentDBLabel.Text = "Current Database: " + Controller.databaseName;
            Controller.subdataName = "";
            Controller.currentKey = "";
            Controller.currentKey2 = "";
           
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

        public void listView1_SelectedIndexChanged(object sender, EventArgs e) //Shows Selected Pokemon to User
        {
            controller.listViewSelectChange();
            

        }

        private void typeFilterBox_SelectedIndexChanged(object sender, EventArgs e) //Filter Pokemon by Type in List
        {
            string typeSearch = typeFilterBox.Text;
            Controller.databaseName = "Pokemon";
            currentDBLabel.Text = "Current Database: " + Controller.databaseName;
            listView1.Items.Clear();
            var table = controller.pokemonTypeFilter(typeSearch);
            controller.listViewChange(table, "Pokemon", "Dashboard");
            

        }



        private void searchBox_TextChanged(object sender, EventArgs e) //Search Pokemon Name
        {
            Controller.databaseName = "Pokemon";
            currentDBLabel.Text = "Current Database: " + Controller.databaseName;
            string keyword = searchBox.Text;
            listView1.Items.Clear();
            var table = controller.pokemonSearch(keyword);
            controller.listViewChange(table, "Pokemon", "Dashboard");
        }

        private void label1_Click(object sender, EventArgs e) //For Testing Purposes
        {
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FrmLogin.FrmLog.Show();
            listView1.Items.Clear();
            Controller.databaseName = "";
            Controller.subdataName = "";
            Controller.currentKey = "";
            Controller.currentKey2 = "";
            this.Close();
        }

        private void userPageButton_Click(object sender, EventArgs e)
        {
            new User_Homepage().Show();
            listView1.Items.Clear();
            this.Close();

        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            cusShowButton.ShowDialog();
            
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            controller.listViewColumnLock(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pokemonPic_Click(object sender, EventArgs e)
        {
            controller.playPokemonCry(Controller.currentKey);
        }
    }
}

