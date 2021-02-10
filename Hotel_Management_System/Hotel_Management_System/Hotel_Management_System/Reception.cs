using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;


namespace Hotel_Management_System
{
    public partial class Reception : Form
    {

        public Reception()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=FARHANB;Initial Catalog=HotelManagementSystem;Integrated Security=True");

        SqlDataAdapter Da = new SqlDataAdapter();

        private void button3_Click(object sender, EventArgs e) => Close();

        string[] Floor = { "Ground", "First", "Second" };
        string[] RoomType = { "Master", "Three Bed", "Four Bed" };
        string[] RoomNumberGround = { "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112" };
        string[] RoomNumberFirst = { "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216" };
        string[] RoomNumberSecond = { "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315" };

        int MasterRoomPrice = 500;
        int FourBedRoomPrice = 600;
        int ThreeBedRoomPrice = 400;





        public void Rooms()
        {


            foreach (string FloorName in Floor)
            {
                cbRoomFloor.Items.Add(FloorName);
            }

            foreach (string RoomTypeName in RoomType)
            {
                cbRoomType.Items.Add(RoomTypeName);
            }

        }





        private void Reception_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
            txtDateofArrival.Text = DateTime.Now.ToLongDateString();
            txtdateofdepar.Text = DateTime.Now.ToLongDateString();
            Rooms();
            label10.Visible = false;
            txtdateofdepar.Visible = false;
            txtdateofdepar.Enabled = false;
chkdepart.Text = "Uncheck it for CheckOut";

            cbmrf.Visible = false;
            cbmrn.Visible = false;
            cbmrt.Visible = false;   

            try
            {
                con.Open();
                string selectSQL = "SELECT MAX(Reservation_ID),Max(Customer_ID) FROM Reservation";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int MaxRID, MaxCID;

                    MaxRID = int.Parse(rd.GetString(0));
                    MaxCID = int.Parse(rd.GetString(0));
                    txtSerialNo.Text = (MaxRID + 1).ToString();
                    txtCustomerID.Text = (MaxCID + 1).ToString();
                }
                rd.Close();

                SqlDataAdapter adapt = new SqlDataAdapter("select * from V_InformationI", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;




                SqlDataAdapter adaptT = new SqlDataAdapter("select Reservation_ID,Customer_ID,Room_Floor,Room_Type,Room_Number from Reservation", con);
                DataTable dtT = new DataTable();
                adaptT.Fill(dtT);
                dataGridView2.DataSource = dtT;


                con.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error Is : " + ex);
                Close();

            }
            
        }






        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void btnAdmit_Click_1(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Reservation (Reservation_ID,Customer_ID,Exact_Arrival,Exact_Departure,Male,Vehicle_Number,Number_of_Persons,Room_Number,Room_Floor,Room_Type) VALUES ('" + txtSerialNo.Text + "','" + txtCustomerID.Text + "','" + txtDateofArrival.Text + "','" + txtdateofdepar.Text + "','"+txtMale.Text +"','" + txtnumberofVehi.Text + "','" + txtnumberofPresons.Text + "','" + cbRoomNumber.Text + "','" + cbRoomFloor.Text + "','" + cbRoomType.Text + "')";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "INSERT INTO CustomersDetails (Customer_ID,Customer_Full_Name,Customer_Phone_Number,Customer_CNIC,Customer_Address,Reservation_ID) VALUES ('" + txtCustomerID.Text + "','" + txtnameofperson.Text + "','" + txtphoneNumber.Text + "','" + txtfatherCNIC.Text + "','" + txtaddress.Text + "','" + txtSerialNo.Text + "')";
            cmd1.ExecuteNonQuery();



            con.Close();
            MessageBox.Show("Record has been inserted into database Successfully");
            int MaxRID;
            int MaxCID;

            MaxRID = int.Parse(txtSerialNo.Text);
            MaxCID = int.Parse(txtCustomerID.Text);

            MaxRID = MaxRID + 1;
            MaxCID = MaxCID + 1;
            txtSerialNo.Text = MaxRID.ToString();
            txtCustomerID.Text = MaxCID.ToString();

            txtnameofperson.Text = "";
            txtaddress.Text = "";
            txtphoneNumber.Text = "";
            txtfatherCNIC.Text = "";
            txtnumberofPresons.Text = "";
            txtnumberofVehi.Text = "";
            cbRoomFloor.Text = "";
            cbRoomType.Text = "";
            cbRoomNumber.Text = "";
            txtMale.Text = "";

        }

        private void cbRoomFloor_TextChanged_1(object sender, EventArgs e)
        {

           


        }

        private void cbRoomType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberGround[i]);
                }
            }

            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }
            else if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();

                cbRoomNumber.Items.Add(RoomNumberGround[6]);

            }
            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 6; i < 8; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 8; i < RoomNumberSecond.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }
            else if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 7; i < RoomNumberGround.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberGround[i]);
                }
            }

            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 8; i < RoomNumberFirst.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 6; i < 8; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }


            con.Open();

            string selectSQLR = "SELECT Room_Number FROM Reservation where Reservation_ID > 0";

            SqlCommand cmdR = new SqlCommand(selectSQLR, con);
            SqlDataReader rdR;
            rdR = cmdR.ExecuteReader();

            while (rdR.Read())
            {
                string RoomNumber = rdR.GetString(0);

                cbRoomNumber.Items.Remove(RoomNumber);
            }

            rdR.Close();
            con.Close();

        }

        private void chkdepart_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkdepart.Checked == true)
            {
                label10.Visible = false;
                txtdateofdepar.Visible = false;
                txtdateofdepar.Enabled = false;
                chkdepart.Text = "Uncheck it for CheckOut";
            }
            else if (chkdepart.Checked != true)
            {
                label10.Visible = true;
                txtdateofdepar.Visible = true;
                txtdateofdepar.Enabled = true;
                chkdepart.Text = "Check it for CheckIn";
            }
        }

    private void btnupdate_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Reservation SET Male = '"+txtMale.Text +"',Vehicle_Number = '" + txtnumberofVehi.Text + "',Number_of_Persons = '" + txtnumberofPresons.Text + "',Room_Number = '" + cbRoomNumber.Text + "',Room_Floor='" + cbRoomFloor.Text + "',Room_Type='" + cbRoomType.Text + "' WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
            cmd.ExecuteNonQuery();

            SqlCommand cmdC = con.CreateCommand();
            cmdC.CommandType = CommandType.Text;
            cmdC.CommandText = "UPDATE CustomersDetails SET Customer_Full_Name = '" + txtnameofperson.Text + "',Customer_Phone_Number = '" + txtphoneNumber.Text + "',Customer_CNIC = '" + txtfatherCNIC.Text + "',Customer_Address ='" + txtaddress.Text + "' WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
            cmdC.ExecuteNonQuery();

            con.Close();

            cbmrf.Visible = false;
            cbmrn.Visible = false;
            cbmrt.Visible = false;

            txtnameofperson.Text = "";
            txtaddress.Text = "";
            txtphoneNumber.Text = "";
            txtfatherCNIC.Text = "";
            txtnumberofPresons.Text = "";
            txtnumberofVehi.Text = "";
            cbRoomFloor.Text = "";
            cbRoomType.Text = "";
            cbRoomNumber.Text = "";

            MessageBox.Show(" Data Has been Updated ");
        }



    private void button1_Click(object sender, EventArgs e)
        {
            cbmrf.Visible = true;
            cbmrn.Visible = true;
            cbmrt.Visible = true;

            try
            {
                con.Open();
                string selectSQL = "SELECT Exact_Arrival,Customer_ID,Male,Vehicle_Number,Number_of_Persons,Room_Number,Room_Floor,Room_Type from Reservation where Reservation_ID='" + txtSerialNo.Text + "'";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    txtDateofArrival.Text = rd.GetString(0);
                    txtCustomerID.Text = rd.GetString(1);
                    
                    txtMale.Text = rd.GetString(2);
                    txtnumberofVehi.Text = rd.GetString(3);
                    txtnumberofPresons.Text = rd.GetString(4);
                   cbmrn.Text = rd.GetString(5);
                    cbmrf.Text = rd.GetString(6);
                    cbmrt.Text = rd.GetString(7);
                }

                con.Close();


                con.Open();
                string selectSQLC = "SELECT Customer_Full_Name,Customer_Phone_Number,Customer_CNIC,Customer_Address from CustomersDetails where Reservation_ID='" + txtSerialNo.Text + "'";

                SqlCommand cmdC = new SqlCommand(selectSQLC, con);
                SqlDataReader rdC;
                rdC = cmdC.ExecuteReader();

                while (rdC.Read())
                {

                    txtnameofperson.Text = rdC.GetString(0);
                    txtphoneNumber.Text = rdC.GetString(1);
                    txtfatherCNIC.Text = rdC.GetString(2);
                    txtaddress.Text = rdC.GetString(3);

                }
                con.Close();
                rdC.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is : " + ex);
                Close();
            }


        }


        string dateofarrival;
        string RoomTypeC;
        double TotalAmount;
        Int32 KitchenBill;
        int OrderBill;
        string DaysAmount;

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string selectSQL = "SELECT Exact_Arrival,Room_Type from Reservation where Reservation_ID='" + txtSerialNo.Text + "'";

                SqlCommand cmdC = new SqlCommand(selectSQL, con);
                SqlDataReader rdC;
                rdC = cmdC.ExecuteReader();



                while (rdC.Read())
                {
                    dateofarrival = rdC.GetString(0);
                    RoomTypeC = rdC.GetString(1);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Is : " + ex);

            }
            TimeSpan difference = DateTime.Now - DateTime.Parse(dateofarrival);
            double days = difference.TotalDays;


            DaysAmount = string.Format("{0:0.0}", days);

            if (RoomTypeC == "Master")
            {
                TotalAmount = MasterRoomPrice * days;
            }
            else if (RoomTypeC == "Three Bed")
            {
                TotalAmount = ThreeBedRoomPrice * days;
            }
            else if (RoomTypeC == "Four Bed")
            {
                TotalAmount = FourBedRoomPrice * days;
            }

            
            try
            {
                con.Open();
                string selectSQLC = "select SUM(Charges) from Kitchen where Customer_ID='" + txtCustomerID.Text + "'";

                SqlCommand cmdCC = new SqlCommand(selectSQLC, con);
                SqlDataReader rdCC;
                rdCC = cmdCC.ExecuteReader();


                while (rdCC.Read())
                {
                    KitchenBill = rdCC.GetInt32(0);

                }
                con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Kitchen Data" + ex);
                con.Close();
            }

            TotalAmount = KitchenBill + TotalAmount;


            try
            {
                con.Open(); 
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Departed_Data(Customer_ID,Reservation_ID,Customer_Full_Name,DateofArrival,DateofDepart,Room_Number) VALUES ('" + txtCustomerID.Text + "','" + txtSerialNo.Text + "','" + txtnameofperson.Text + "','" + txtDateofArrival.Text + "','" + txtdateofdepar.Text + "','"+ cbmrn.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Is" + ex);
                con.Close();
            }

            try {
                con.Open();
                SqlCommand cmdChkO = con.CreateCommand();
                cmdChkO.CommandType = CommandType.Text;
                cmdChkO.CommandText = "Delete from Reservation WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
                cmdChkO.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is" + ex);
                con.Close();
            }


            try
            {
                con.Open();
                SqlCommand cmdChkO = con.CreateCommand();
                cmdChkO.CommandType = CommandType.Text;
                cmdChkO.CommandText = "Delete from CustomersDetails WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
                cmdChkO.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is" + ex);
                con.Close();
            }

            try
            {
                con.Open();
                SqlCommand cmdCO = con.CreateCommand();
                cmdCO.CommandType = CommandType.Text;
                cmdCO.CommandText = "Delete from Order_List WHERE Customer_ID = '" + txtCustomerID.Text + "'";
                cmdCO.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is : " + ex);
                con.Close();  
            }

            try
            {
                con.Open();
                SqlCommand cmdCO = con.CreateCommand();
                cmdCO.CommandType = CommandType.Text;
                cmdCO.CommandText = "Delete from Kitchen WHERE Customer_ID = '" + txtCustomerID.Text + "'";
                cmdCO.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Is : " + ex);
                con.Close();
            }

            CreateSpreadSheet();
            MessageBox.Show("Your Total Days Are : " + DaysAmount + " And Your Total Amount is : " + String.Format("{0:0}", TotalAmount) + " \n View Your Bill At Root Directory As " + txtCustomerID.Text + txtnameofperson.Text);
            txtnameofperson.Text = "";
            txtaddress.Text = "";
            txtphoneNumber.Text = "";
            txtfatherCNIC.Text = "";
            txtnumberofPresons.Text = "";
            txtnumberofVehi.Text = "";
            cbRoomFloor.Text = "";
            cbRoomType.Text = "";
            cbRoomNumber.Text = "";
            txtMale.Text = ""; 
           


        }


        public void CreateSpreadSheet()
        {
            string spreadsheetPath = txtCustomerID.Text + " " + txtnameofperson.Text + ".xlsx";
            File.Delete(spreadsheetPath);
            FileInfo spreadsheetInfo = new FileInfo(spreadsheetPath);

            ExcelPackage pck = new ExcelPackage(spreadsheetInfo);
            var activitiesWorksheet = pck.Workbook.Worksheets.Add("Activities");

            activitiesWorksheet.Cells["A1"].Value = "Invoice";

            activitiesWorksheet.Cells["A3"].Value = "Name";
            activitiesWorksheet.Cells["A5"].Value = "Reservation ID";
            activitiesWorksheet.Cells["A7"].Value = "Cusomer ID";
            activitiesWorksheet.Cells["A9"].Value = "Date Of Arrival";
            activitiesWorksheet.Cells["A11"].Value = "Date Of Departure";
            activitiesWorksheet.Cells["A13"].Value = "Stay (Number Of Days)";
            activitiesWorksheet.Cells["A15"].Value = "Services Bill";
            activitiesWorksheet.Cells["A17"].Value = "Room Rent";
           
            activitiesWorksheet.Cells["A21"].Value = "Total Bill";

            activitiesWorksheet.Cells["D3"].Value = txtnameofperson.Text;
            activitiesWorksheet.Cells["D5"].Value = txtSerialNo.Text;
            activitiesWorksheet.Cells["D7"].Value = txtCustomerID.Text;
            activitiesWorksheet.Cells["D9"].Value = txtDateofArrival.Text;
            activitiesWorksheet.Cells["D11"].Value = txtdateofdepar.Text;
            activitiesWorksheet.Cells["D13"].Value = DaysAmount;
            activitiesWorksheet.Cells["D15"].Value = KitchenBill;

            if (RoomTypeC == "Master")
            {
                activitiesWorksheet.Cells["D17"].Value = MasterRoomPrice;
            }
            else if (RoomTypeC == "Three Bed")
            {
                activitiesWorksheet.Cells["D17"].Value = ThreeBedRoomPrice;
            }
            else if (RoomTypeC == "Four Bed")
            {
                activitiesWorksheet.Cells["D17"].Value = FourBedRoomPrice;
            }
            


            activitiesWorksheet.Cells["D21"].Value = TotalAmount;



            activitiesWorksheet.Cells["A1"].Style.Font.Bold = true;
            activitiesWorksheet.Cells["A21:D21"].Style.Font.Bold = true;
            activitiesWorksheet.Cells["A1"].Style.Font.Name = "Abraham Lincoln";
            activitiesWorksheet.Cells["A1"].Style.Font.Size = 28; 
            activitiesWorksheet.Cells["A1"].Text.PadLeft(22) ;        
            // populate spreadsheet with data
            int currentRow = 2;



            activitiesWorksheet.Cells["A1" + (currentRow).ToString()].Style.Font.Bold = true;

            activitiesWorksheet.Cells["A1" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

            activitiesWorksheet.Cells["A21" + (currentRow).ToString()].Style.Font.Bold = true;

            activitiesWorksheet.Cells["A21" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

            activitiesWorksheet.Cells["D21" + (currentRow).ToString()].Style.Font.Bold = true;

            activitiesWorksheet.Cells["D21" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

            

            pck.Save();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from V_InformationI where Customer_Full_Name like '" + txt_Search.Text + "%' or Reservation_ID like '" + txt_Search.Text + "%' or Exact_Arrival like '"+txt_Search.Text +"%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }



        private void btnDelete_Click_2(object sender, EventArgs e)
        {
            con.Open(); 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Reservation WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmdCR = con.CreateCommand();
            cmdCR.CommandType = CommandType.Text;
            cmdCR.CommandText = "Delete from CustomersDetails WHERE Reservation_ID = '" + txtSerialNo.Text + "'";
            cmdCR.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmdCO = con.CreateCommand();
            cmdCO.CommandType = CommandType.Text;
            cmdCO.CommandText = "Delete from Order_List WHERE Customer_ID = '" + txtCustomerID.Text + "'";
            cmdCO.ExecuteNonQuery();
            con.Close();

            txtnameofperson.Text = "";
            txtaddress.Text = "";
            txtphoneNumber.Text = "";
            txtfatherCNIC.Text = "";
            txtnumberofPresons.Text = "";
            txtnumberofVehi.Text = "";
            cbRoomFloor.Text = "";
            cbRoomType.Text = "";
            cbRoomNumber.Text = "";

            MessageBox.Show(" Data Has been Deleted ");
        }

        private void cbRoomFloor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberGround[i]);
                }
            }

            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Master")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 0; i < 6; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }
            else if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();

                cbRoomNumber.Items.Add(RoomNumberGround[6]);

            }
            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 6; i < 8; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Three Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 8; i < RoomNumberSecond.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }
            else if (cbRoomFloor.Text == "Ground" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 7; i < RoomNumberGround.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberGround[i]);
                }
            }

            else if (cbRoomFloor.Text == "First" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 8; i < RoomNumberFirst.Length; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberFirst[i]);
                }
            }
            else if (cbRoomFloor.Text == "Second" && cbRoomType.Text == "Four Bed")
            {
                cbRoomNumber.Items.Clear();
                for (int i = 6; i < 8; i++)

                {
                    cbRoomNumber.Items.Add(RoomNumberSecond[i]);
                }
            }

            con.Open();

            string selectSQLR = "SELECT Room_Number FROM Reservation where Reservation_ID > 0";

            SqlCommand cmdR = new SqlCommand(selectSQLR, con);
            SqlDataReader rdR;
            rdR = cmdR.ExecuteReader();

            while (rdR.Read())
            {
                string RoomNumber = rdR.GetString(0);

                cbRoomNumber.Items.Remove(RoomNumber);
            }

            rdR.Close();
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.Open(); 
            SqlDataAdapter adaptT = new SqlDataAdapter("select Reservation_ID,Customer_ID,Room_Floor,Room_Type,Room_Number,Customer_Full_Name,Customer_Phone_Number from V_InformationI", con);
            DataTable dtT = new DataTable();
            adaptT.Fill(dtT);
            dataGridView2.DataSource = dtT;


            con.Close();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Mainmenu = new mainForm();
            
            Mainmenu.ShowDialog();
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kitchen = new Kitchen();
            kitchen.ShowDialog();  
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adaptT = new SqlDataAdapter("select Reservation_ID,Customer_ID,Room_Floor,Room_Type,Room_Number,Customer_Full_Name,Customer_Phone_Number from V_InformationI", con);
            DataTable dtT = new DataTable();
            adaptT.Fill(dtT);
            dataGridView2.DataSource = dtT;
                        con.Close();
        }

        private void OldData_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adaptT = new SqlDataAdapter("select Customer_ID,Reservation_ID,Customer_Full_Name,DateofArrival,DateofDepart,Room_Number from Departed_Data", con);
            DataTable dtT = new DataTable();
            adaptT.Fill(dtT);
            dataGridView3.DataSource = dtT;


            con.Close();
        }

     

        private void tabPage3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adaptT = new SqlDataAdapter("select Reservation_ID,Customer_ID,Room_Floor,Room_Type,Room_Number,Customer_Full_Name,Customer_Phone_Number from V_InformationI", con);
            DataTable dtT = new DataTable();
            adaptT.Fill(dtT);
            dataGridView2.DataSource = dtT;
            
            con.Close();
        }

        private void Reservation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reservation_Selected(object sender, TabControlEventArgs e)
        {
            con.Open();
            SqlDataAdapter adaptT = new SqlDataAdapter("select Reservation_ID,Customer_ID,Room_Floor,Room_Type,Room_Number,Customer_Full_Name,Customer_Phone_Number from V_InformationI", con);
            DataTable dtT = new DataTable();
            adaptT.Fill(dtT);
            dataGridView2.DataSource = dtT;

            con.Close();
        }
    }
}
    


