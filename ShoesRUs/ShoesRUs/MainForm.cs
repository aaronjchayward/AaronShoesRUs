using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoesRUs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Startup su = new Startup();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            grpContact.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            grpProfile.Visible = true;
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            grpBasket.Visible = true;
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            //checks to see if any item has been selected
            //deletes the slected item from the basket
            int selectedIndex = lstBasket.SelectedIndex;
            if (selectedIndex >= 0)
                lstBasket.Items.RemoveAt(selectedIndex);
        }

        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            //clears all the items in the list box
            DialogResult clearAll = MessageBox.Show("Are you sure you want to clear your basket", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (clearAll == DialogResult.Yes)
            {
                lstBasket.Items.Clear();
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //clears all the items in the list box
            DialogResult checkOUt = MessageBox.Show("proceeds to checkout", "Warning!", MessageBoxButtons.OKCancel);

        }
        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            //this is for the product view and not the basket
            // this adds a shoe size to the database
            //Check if any of the input boxes are empty or not selected
            if (cmbShoeSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a shoe size.");
            }
            else {
                //Insert shoe size into database 
                /*
                OleDbConnection dbCon = new OleDbConnection(DatabaseConnection.dbconnect);

                dbCon.ConnectionString = DatabaseConnection.dbconnect;
                OleDbCommand dbCmd = dbCon.CreateCommand();

                dbCmd.CommandText = "INSERT INTO Shoe(ShoeSize) VALUES (@ShoeSize)";

                dbCmd.Parameters.AddWithValue("CustomerTitle", cmbShoeSize.SelectedItem);

                dbCon.Open();
                int rowsChanged = dbCmd.ExecuteNonQuery();
                dbCon.Close();
                */

                //adding the informationn stored in the text boxes 
                // display the information in the basket 
                // users should not be able to change information 
                

                lstBasket.Items.Add(this.txtName.Text + this.txtPrice.Text);
             }
        }

        // load listView with items according to query 
        public void Populate(string queryString)
        {
            try
            {

                clearFields();
                using (OleDbConnection dbCon = new OleDbConnection(DatabaseConnection.dbconnect))
                {

                    OleDbCommand command = new OleDbCommand(queryString, dbCon);
                    dbCon.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TxtName.Text = (reader["Name"].ToString());
                        TxtBrand.Text = (reader["Brand"].ToString());
                        TxtSize.Text = (reader["Size"].ToString());
                        TxtMaterial.Text = (reader["Material"].ToString());
                        TxtPrice.Text = (reader["Price"].ToString());
                        listViewDisplay.Items.Add("string", reader.GetInt32(0));
                        

                    }
                    reader.Close();
                    dbCon.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
        }

        private void clearFields()
        {
            
            txtName.Clear();
            txtBrand.Clear();
            txtSize.Clear();
            txtmaterial.Clear();
            txtPhoneNo.Clear();
            txtAddNo.Clear();
            txtAddStreet.Clear();
            txtAddCity.Clear();
            txtAddCountry.Clear();
            listViewDisplay.Clear();

        }

    }
}

        
    
