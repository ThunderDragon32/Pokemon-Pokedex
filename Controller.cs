using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Media;


namespace Software_Project

{   
    internal class Controller
    {
        public static string selectedName; //Selected Pokemon's name is saved stored
        public static string selectedID; //Selected Pokemon's ID is stored
        SoundPlayer sound = new SoundPlayer();


        public static Model model = new Model();
        public void verifyUserAndPass() //FrmLogin calls this method to read database for User and Pass Verification
        {
            model.openController();

            string login = "SELECT * FROM tbl_users WHERE username= '" + FrmLogin.TxtUsername.Text + "' and password= '" + FrmLogin.TxtPassword.Text + "'";
            OleDbDataReader dr = model.executeReaderCommand(model.databaseCommand(login, model.getCon()));
            if ((dr.Read() == true) && (dr.GetString(0) == FrmLogin.TxtUsername.Text) && (dr.GetString(1) == FrmLogin.TxtPassword.Text)) //Checks Case Senstivity of login
            {
                //The Form which will appear after loggin in
                FrmLogin.name = FrmLogin.TxtUsername.Text;
                model.closeController();
                clearText();
                new Dashboard().Show();
                FrmLogin.FrmLog.Hide();
            }
            else //User and Pass were not correct
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearText();
                model.closeController();

            }
        }


        public void checkbxShowPas() //Check Box on/off 
        {
            if (Application.OpenForms["FrmRegister"] != null)
            {
                if (FrmRegister.CkbxShowPas.Checked)
                {
                    FrmRegister.TxtPassword.PasswordChar = '\0';
                    FrmRegister.TxtComPassword.PasswordChar = '\0';
                }
                else
                {
                    FrmRegister.TxtPassword.PasswordChar = '•';
                    FrmRegister.TxtComPassword.PasswordChar = '•';
                }
            }
            else
            {
                if (FrmLogin.CkbxShowPas.Checked)
                {
                    FrmLogin.TxtPassword.PasswordChar = '\0';
                }
                else
                {
                    FrmLogin.TxtPassword.PasswordChar = '•';
                }
            }
        }

        public void clearText() //Resets and Focuses Text
        {
            if (Application.OpenForms["FrmRegister"] != null)
            {
                FrmRegister.TxtUsername.Text = "";
                FrmRegister.TxtPassword.Text = "";
                FrmRegister.TxtComPassword.Text = "";
                FrmRegister.TxtUsername.Focus();
            }
            else if(Application.OpenForms["Dashboard"] != null)
            {
                Dashboard.SelectedLabel.Text = "";
                Dashboard.DescLabel.Text = "";
                Dashboard.DescLabel.Visible = false;
             
            }
            else if(Application.OpenForms["User_Homepage"] != null)
            {
                User_Homepage.SelectedLabel.Text = "";
                User_Homepage.SelectedLabelID.Text = "";
                
            }
            else
            {
                FrmLogin.TxtUsername.Text = "";
                FrmLogin.TxtPassword.Text = "";
                FrmLogin.TxtUsername.Focus();
            }
            selectedName = "";
            selectedID = "";
        }


        public void Registration()
        {
            if (FrmRegister.TxtUsername.Text == "" && FrmRegister.TxtPassword.Text == "" && FrmRegister.TxtComPassword.Text == "") //Blank Fields
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (FrmRegister.TxtPassword.Text == FrmRegister.TxtComPassword.Text) //Condition checks to see if user is Unqiue before creating
            {
                model.openController();
                string unqiueUserCheck = "SELECT * FROM tbl_users WHERE username= '" + FrmRegister.TxtUsername.Text + "'";
                if (model.executeReaderCommand(model.databaseCommand(unqiueUserCheck, model.getCon())).Read() == true)
                {
                    //User has already been created
                    MessageBox.Show("User not Unquie!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearText();
                    model.closeController();
                    
                }
                else if(FrmRegister.TxtUsername.Text.ToUpper() == "UPDATE" || FrmRegister.TxtUsername.Text.ToUpper() == "DELETE")
                {
                    //Key word names
                    MessageBox.Show("Not Allowed Username!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearText();
                    model.closeController();
                }
                else  ///Creates User
                {
                    string register = "INSERT INTO tbl_users VALUES ('" + FrmRegister.TxtUsername.Text + "','" + FrmRegister.TxtPassword.Text + "')";

                    
                    model.executeNonQueryCommand(model.databaseCommand(register, model.getCon()));
                    model.closeController();
                    clearText();
                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else  //Passwords do not match
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearText();
            }
        }
        public void listViewSelectChange() //Changes selection when user interacts with display
        {
            sound.Stop();
            if (Application.OpenForms["Dashboard"] != null)
            {
                if (Dashboard.ListView1.SelectedItems.Count > 0)
                {
                    selectedName = Dashboard.ListView1.SelectedItems[0].SubItems[1].Text; 
                    selectedID = Dashboard.ListView1.SelectedItems[0].SubItems[0].Text;
                    Dashboard.DescLabel.Text = Dashboard.ListView1.SelectedItems[0].SubItems[4].Text;
                    Dashboard.SelectedLabel.Text = "No." + selectedID + " " + selectedName;
                    Dashboard.DescLabel.Visible = true;
                    imageTypeUpdate();
                    playPokemonCry();
                    //PlayMp3FromUrl("https://play.pokemonshowdown.com/audio/cries/" + selectedName.ToLower() + ".mp3");
                }
            }
            else { 
                if (User_Homepage.ListView1.SelectedItems.Count > 0)
                {
                    User_Homepage.SelectedLabel.Text = User_Homepage.ListView1.SelectedItems[0].SubItems[1].Text;
                    User_Homepage.SelectedLabelID.Text = User_Homepage.ListView1.SelectedItems[0].SubItems[0].Text;
                }
            }
        }

        public DataTable tableSet(OleDbDataAdapter dat)  //Fills Table Data Set
        {
            var ds = new DataSet();
            dat.Fill(ds);
            DataTable table = ds.Tables[0];
            bool hasRows = table.Rows.GetEnumerator().MoveNext();
            if (hasRows)
            {
                dat.Dispose();
                model.closeController();
                return table;
            }
            dat.Dispose();
            model.closeController();
            return null;
        }
        public void listViewChange(DataTable table, string view) //Used to Update List View changes for Filter
        {
            if (table != null)
            {
                try
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var items = new string[]
                        {
                            row[0].ToString(),
                            row[1].ToString(),
                            row[2].ToString(),
                            row[3].ToString(),
                            row[4].ToString()
                        };
                        var value = new ListViewItem(items);
                        if (view == "Dashboard")
                        {
                            Dashboard.ListView1.Items.Add(value);
                        }
                        else
                        {
                            User_Homepage.ListView1.Items.Add(value);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void addPokemon(string database) //Adds Pokemon into a database
        {
            model.openController();  
            string unqiueIDCheck = "SELECT * FROM " + database + " WHERE ID= '" + selectedID + "' and username= '" + FrmLogin.name + "'";
            if (model.executeReaderCommand(model.databaseCommand(unqiueIDCheck, model.getCon())).Read() == true)
            {
                //Pokemon is already in list
                MessageBox.Show("Pokemon already in list!");
                //clearText();
                model.closeController();

            }
            else  ///Places Pokemon in List
            {
                if (selectedID != "")
                {
                    string amountCheck = "SELECT Count(*) FROM User_Favorite WHERE username= '" + FrmLogin.name + "'";
                    if ((database == "User_Favorite") && (Convert.ToInt16(model.databaseCommand(amountCheck, model.getCon()).ExecuteScalar()) < 6))
                    {
                        insertPokemon(database);
                    }
                    else if(database == "User_Caught") insertPokemon(database);
                    
                    else
                    {
                        //clearText();
                        model.closeController();
                        MessageBox.Show("Only 6 Pokemon can be your favorite!");
                    }
                }
                else
                {
                    model.closeController();
                    //clearText();
                    MessageBox.Show("No Pokemon Selected!");
                }
            }
        }
        public void insertPokemon(string database) //Inserts Pokemon into a specific database (Used along side AddPokemon() )
        {
            string insertPokemon = "INSERT INTO " + database + " VALUES ('" + FrmLogin.name + "','" + selectedID + "')";
            model.executeNonQueryCommand(model.databaseCommand(insertPokemon, model.getCon()));
            model.closeController();
            //clearText();
            MessageBox.Show("Pokemon has been added to list!");
        }
        public void removePokemon(string database) //Remove Pokemon from a database
        {
                model.openController();
                string unqiueIDCheck = "SELECT * FROM " + database + " WHERE ID= '" + selectedID + "' and username= '" + FrmLogin.name + "'";
                if (model.executeReaderCommand(model.databaseCommand(unqiueIDCheck, model.getCon())).Read() == true) //Pokemon is in list
                {
                    string deletePokemon = "DELETE FROM " + database + " WHERE ID= '" + selectedID + "' and username= '" + FrmLogin.name + "'";
                    model.executeNonQueryCommand(model.databaseCommand(deletePokemon, model.getCon()));
                    model.closeController();
                    //clearText();
                    MessageBox.Show("Pokemon has been removed from list!");
                }

                else  ///Pokemon not in list
                {
                    MessageBox.Show("Pokemon not in list!");
                    //clearText();
                    model.closeController();
                }
                
        }
        public DataTable pokemonSearch(string keyword) //Searches Pokemon by string keyword
        {
            try
            {
                model.openController();
                return tableSet(model.databaseAdapter("select * from Pokemon where Name like '%" + keyword + "%'", model.getCon()));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable pokemonTypeFilter(string type) //Filters the List view by type filter
        {
            try
            {
                model.openController();
                if (type == "Water" || type == "Fire" || type == "Grass" || type == "Bug" || 
                    type == "Dark" || type == "Dragon" || type == "Electric" || type == "Fairy" 
                    || type == "Fighting" || type == "Flying" || type == "Ghost" || type == "Ground"
                    || type == "Ice" || type == "Normal" || type == "Poison" || type == "Psychic" 
                    || type == "Rock" || type == "Steel")
                {
                    return tableSet(model.databaseAdapter("select * from Pokemon where type1='" + type + "' or type2= '" + type + "'", model.getCon()));
                }
                else
                {
                    return tableSet(model.databaseAdapter("select * from Pokemon", model.getCon()));

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable showList(string database)
        {
            model.openController();
            DataTable table = tableSet(model.databaseAdapter("SELECT Pokemon.ID, Pokemon.name, Pokemon.Type1, Pokemon.Type2, Pokemon.Desc FROM Pokemon, " +
                database +" WHERE Pokemon.ID = " + database + ".ID AND " + database + ".username = '" + FrmLogin.name + "'", model.getCon()));
            return table;

        }
        public DataTable showUnCaughtList()
        {
            model.openController();
            DataTable table = tableSet(model.databaseAdapter("SELECT * FROM Pokemon left outer join User_Caught " +
                "on (Pokemon.ID = User_Caught.ID and username = '" + FrmLogin.name + "') WHERE User_Caught.ID is NULL"
                , model.getCon()));
            return table;
        }

        
        public void listViewColumnLock(ColumnWidthChangingEventArgs e)
        {
            if (Dashboard.ListView1.Columns[e.ColumnIndex].ToString() == "ColumnHeader: Text: ")
            {
                e.Cancel = true;
                e.NewWidth = Dashboard.ListView1.Columns[e.ColumnIndex].Width;
            }
        }
        public void imageTypeUpdate() //Updates Type and Pokemon Images
        {
            String[] types = new string[2];
            string type1 = Dashboard.ListView1.SelectedItems[0].SubItems[2].Text;
            string type2 = Dashboard.ListView1.SelectedItems[0].SubItems[3].Text;
            types[0] = type1;
            types[1] = type2;
            Dashboard.PokemonPic.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + selectedID+".png";
            for (int i = 0; i < types.Length; i++)
            { 
                if (types[i] == "Water")
                {
                    if(i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.waterType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.waterType;
                }
                else if(types[i] == "Fire")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.fireType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.fireType;
                }
                else if(types[i] == "Grass")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.grassType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.grassType;
                }
                else if (types[i] == "Flying")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.flyingType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.flyingType;
                }
                else if (types[i] == "Poison")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.poisonType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.poisonType;
                }
                else if (types[i] == "Steel")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.steelType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.steelType;
                }
                else if (types[i] == "Bug")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.bugType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.bugType;
                }
                else if (types[i] == "Dark")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.darkType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.darkType;
                }
                else if (types[i] == "Electric")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.electricType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.electricType;
                }
                else if (types[i] == "Dragon")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.dragonType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.dragonType;
                }
                else if (types[i] == "Fairy")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.fairyType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.fairyType;
                }
                else if (types[i] == "Fighting")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.fightingType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.fightingType;
                }
                else if (types[i] == "Ghost")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.ghostType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.ghostType;
                }
                else if (types[i] == "Ground")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.groundType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.groundType;
                }
                else if (types[i] == "Ice")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.iceType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.iceType;
                }
                else if (types[i] == "Normal")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.normal;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.normal;
                }
                else if (types[i] == "Psychic")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.psychicType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.psychicType;
                }
                else if (types[i] == "Rock")
                {
                    if (i == 0) Dashboard.Type1PicBx.Image = Software_Project.Properties.Resources.rockType;
                    else Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.rockType;
                }
                else
                {
                    Dashboard.Type2PicBx.Image = Software_Project.Properties.Resources.Type;
                }

            }

        }
       
        public void playPokemonCry()
        {
            try
            {
                sound.Stop();
                sound = new SoundPlayer(selectedID + ".wav");
                sound.Play();
            }
            catch (Exception ex) { }
        }

        public void adminVerify()
        {
            if (FrmLogin.name == "admin") User_Homepage.AdminButton.Visible = true;
        }
    }
}
