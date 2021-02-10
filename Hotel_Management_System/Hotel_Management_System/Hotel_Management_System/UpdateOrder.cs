using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hotel_Management_System
{
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=FARHANB;Initial Catalog=HotelManagementSystem;Integrated Security=True");

        int[] MenuItemsPrice = {0, 210 , 0 ,300 ,  350 ,  320 ,  400 ,  340 ,  250 ,  250 ,  210 , 0 , 60 ,  50 ,  60 ,  60 ,  80 ,  50 ,  30 ,  40 ,  08 ,  80 ,  80 ,  30 ,  25 ,  60 ,  80 ,  50
                   , 0 ,  700 ,  250 ,  250 ,  350 ,  350 , 800 , 450 , 800 , 450 , 650 , 375 , 160
                    , 1200 , 650 , 100 , 100 , 180 , 10 , 15 ,0, 200 , 500 , 170 , 150 , 400 ,0, 150 , 50 , 60 , 60 , 130 ,0,180 , 250 , 250 , 200 , 250 , 180 , 100 , 0,60 , 100 , 150 , 160 ,0, 250 , 250 ,0,70,100,50,20,50 };

        int quantity;
        int fprice;
        int totalprice = 0;
        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            string[] MenuItems = {"AMERICAN BREAKFAST","2 Eggs 2 Toasts, Buttermilk or Jam, Juice,Tea,Coffie,Milk","CHINESE FOOD","Chicken Shashlik","Chicken Chowermnen","Chicken Chilli", "Chicken Half with Vegitable",
                "Chicken Fry Rice", "Vegitable Fry Rice","Egg fry Rice","CONTINENTAL BREAKFAST",
            "Egg Omelete","Egg Fry","Egg Boiled","Egg Scambled","Chicken Omelete","Channa Plate"
                ,"Butter Jam","Paratha","Butter Pratha","Toast","Corn Flax","Poridge","Tea set","Green Tea Set"
            ,"Coffee","Lassi sweet/Salt","Milk Glass","PAKISTANI FOOD"

            ,"Chicken Karahi Full","Chicken Qourma","Chicken Masala","Chicken Ginger 2 Pce","Chicken Jalfrazi 2 Pce","Chicken Handi Boneless","Chicken Handi Half"
            ,"Chicken Achar Handi Full","Chicken Achar Handi Half","Chicken Steam Roast Full+Chips","Chicken Steam Roast Half+Chips","Chicken Tikka","Mutton Karahi Full","Mutton Karahi Half"
            ,"Mix Vegetable","Dall Mash","Dall Chana two plates","Roti","Nan"

            ,"RICE","Chicken Pullao", "Chicken Biryani Two plates", "Simple Pullao", "Rice White", "Mutter Pullao Two Plates"

            ,"SALAD","Rassian Salad", "Fresh Salad", "Kuchumer Salad", "Raita", "Yogurt Daba",

           "SANACKES","Chicken Burger+Chips","Chicken Chese Burger+Chips","Club Sandwich+Chips","Chicken Sandwich","Chicken Cheese Sandwich"
            ,"Egg Sandwich","Chips",

            "SOUP","Yakhni", "Chicken Corn Soup", "Hot & Sour Soup", "Tomato Cream Soup",
            "SWEET","Kheer 3 Plates", "Fruit Custard 3 Plates", "Egg Halwa 1 plate","Other Services","Cleaning", "Laundary", "Towel", "Soap" };




            for (int i = 0; i < MenuItems.Length; i++)
            {
                chkOrder.Items.Add(MenuItems[i]);
            }

            CurrentTime.Start();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrderList.Text = "";  
                con.Open();
                string selectSQL = "SELECT Customer_Name,Order_ID,Order_Name from V_OrderList where Customer_ID='" + txtOrderID.Text + "'";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {

                    txtCustomerName.Text = rd.GetString(0);
                    txtOrderID.Text = rd.GetString(1);
                    txtOrderList.Text += string.Format("{0}" + Environment.NewLine, rd[2]);   
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is :" + ex);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            

            Form Kitchen = new Kitchen();


            



            con.Open();
            SqlCommand cmdD = con.CreateCommand();

            cmdD.CommandType = CommandType.Text;
            cmdD.CommandText = "Delete from Order_List where Order_ID='" + txtOrderID.Text + "'";

            cmdD.ExecuteNonQuery();


            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Kitchen set Charges ='"+ totalprice + "' where Order_ID='"+txtOrderID.Text +"'";

            cmd.ExecuteNonQuery();



            foreach (object item in chkOrder.CheckedItems)
            {
                string selectedItems = item.ToString();

                SqlCommand cmdT = con.CreateCommand();

                cmdT.CommandType = CommandType.Text;
                cmdT.CommandText = "INSERT INTO Order_List (Order_ID,Customer_ID,Order_Name,Date,Time) VALUES ('" + txtOrderID.Text + "','" + txtCustomerID.Text + "',@Order_Name,'" + lbldate.Text + "','" + lbltime.Text + "')";
                cmdT.Parameters.AddWithValue("@Order_Name", selectedItems);
                cmdT.ExecuteNonQuery();
            }

            con.Close();
            txtOrderList.Text = "";

            MessageBox.Show("Your Total Amount is " + totalprice + " Rupees");


        }

        private void CurrentTime_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void chkOrder_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            txtQuantity.Text = "";

            MessageBox.Show("Enter The Quantity");
            txtQuantity.Focus();
            this.AcceptButton = this.btnQuantity;
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(txtQuantity.Text);
            foreach (Object item in chkOrder.CheckedItems)
            {
                int index = chkOrder.Items.IndexOf(item);
                int price = MenuItemsPrice[index];
                fprice = price * quantity;

            }
            totalprice += fprice;

            MessageBox.Show("The price is " + fprice + "\n And total Price is " + totalprice);
        }
    }
}
