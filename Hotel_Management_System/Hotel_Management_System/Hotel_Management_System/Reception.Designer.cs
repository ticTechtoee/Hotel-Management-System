namespace Hotel_Management_System
{
    partial class Reception
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reservation = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMale = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkdepart = new System.Windows.Forms.CheckBox();
            this.cbmrn = new System.Windows.Forms.ComboBox();
            this.cbRoomNumber = new System.Windows.Forms.ComboBox();
            this.txtnumberofPresons = new System.Windows.Forms.TextBox();
            this.txtdateofdepar = new System.Windows.Forms.TextBox();
            this.txtDateofArrival = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.cbmrt = new System.Windows.Forms.ComboBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbmrf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoomFloor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnumberofVehi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfatherCNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtnameofperson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OldData = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Reservation.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.OldData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Reservation
            // 
            this.Reservation.Controls.Add(this.tabpage1);
            this.Reservation.Controls.Add(this.tabPage2);
            this.Reservation.Controls.Add(this.tabPage3);
            this.Reservation.Controls.Add(this.OldData);
            this.Reservation.Location = new System.Drawing.Point(1, 3);
            this.Reservation.Name = "Reservation";
            this.Reservation.SelectedIndex = 0;
            this.Reservation.Size = new System.Drawing.Size(1039, 591);
            this.Reservation.TabIndex = 0;
            this.Reservation.SelectedIndexChanged += new System.EventHandler(this.Reservation_SelectedIndexChanged);
            this.Reservation.Selected += new System.Windows.Forms.TabControlEventHandler(this.Reservation_Selected);
            this.Reservation.Click += new System.EventHandler(this.OldData_Click);
            // 
            // tabpage1
            // 
            this.tabpage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabpage1.Controls.Add(this.panel3);
            this.tabpage1.Controls.Add(this.panel2);
            this.tabpage1.Controls.Add(this.panel1);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(1031, 565);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Reception";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnAdmit);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Location = new System.Drawing.Point(796, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 559);
            this.panel3.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(85, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_2);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AutoSize = true;
            this.btnCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Maroon;
            this.btnCheckOut.Location = new System.Drawing.Point(68, 356);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(105, 36);
            this.btnCheckOut.TabIndex = 18;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(81, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Moodyrock", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(83, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.AutoSize = true;
            this.btnAdmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmit.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdmit.Location = new System.Drawing.Point(73, 115);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(94, 36);
            this.btnAdmit.TabIndex = 13;
            this.btnAdmit.Text = "Check In";
            this.btnAdmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmit.UseVisualStyleBackColor = false;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Maroon;
            this.btnupdate.Location = new System.Drawing.Point(59, 176);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 36);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update Data";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.txtMale);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.chkdepart);
            this.panel2.Controls.Add(this.cbmrn);
            this.panel2.Controls.Add(this.cbRoomNumber);
            this.panel2.Controls.Add(this.txtnumberofPresons);
            this.panel2.Controls.Add(this.txtdateofdepar);
            this.panel2.Controls.Add(this.txtDateofArrival);
            this.panel2.Controls.Add(this.txtSerialNo);
            this.panel2.Controls.Add(this.cbmrt);
            this.panel2.Controls.Add(this.cbRoomType);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbmrf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbRoomFloor);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtnumberofVehi);
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 559);
            this.panel2.TabIndex = 5;
            // 
            // txtMale
            // 
            this.txtMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMale.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMale.ForeColor = System.Drawing.Color.Maroon;
            this.txtMale.Location = new System.Drawing.Point(253, 264);
            this.txtMale.Multiline = true;
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(143, 39);
            this.txtMale.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Maroon;
            this.label14.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(29, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Male";
            // 
            // chkdepart
            // 
            this.chkdepart.AutoSize = true;
            this.chkdepart.Checked = true;
            this.chkdepart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdepart.ForeColor = System.Drawing.Color.Yellow;
            this.chkdepart.Location = new System.Drawing.Point(230, 413);
            this.chkdepart.Name = "chkdepart";
            this.chkdepart.Size = new System.Drawing.Size(15, 14);
            this.chkdepart.TabIndex = 20;
            this.chkdepart.UseVisualStyleBackColor = true;
            this.chkdepart.CheckStateChanged += new System.EventHandler(this.chkdepart_CheckStateChanged);
            // 
            // cbmrn
            // 
            this.cbmrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbmrn.ForeColor = System.Drawing.Color.Maroon;
            this.cbmrn.FormattingEnabled = true;
            this.cbmrn.Location = new System.Drawing.Point(322, 523);
            this.cbmrn.Name = "cbmrn";
            this.cbmrn.Size = new System.Drawing.Size(105, 21);
            this.cbmrn.TabIndex = 12;
            // 
            // cbRoomNumber
            // 
            this.cbRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbRoomNumber.ForeColor = System.Drawing.Color.Maroon;
            this.cbRoomNumber.FormattingEnabled = true;
            this.cbRoomNumber.Location = new System.Drawing.Point(322, 482);
            this.cbRoomNumber.Name = "cbRoomNumber";
            this.cbRoomNumber.Size = new System.Drawing.Size(105, 21);
            this.cbRoomNumber.TabIndex = 12;
            // 
            // txtnumberofPresons
            // 
            this.txtnumberofPresons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnumberofPresons.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofPresons.ForeColor = System.Drawing.Color.Maroon;
            this.txtnumberofPresons.Location = new System.Drawing.Point(253, 201);
            this.txtnumberofPresons.Multiline = true;
            this.txtnumberofPresons.Name = "txtnumberofPresons";
            this.txtnumberofPresons.Size = new System.Drawing.Size(143, 39);
            this.txtnumberofPresons.TabIndex = 7;
            // 
            // txtdateofdepar
            // 
            this.txtdateofdepar.BackColor = System.Drawing.Color.White;
            this.txtdateofdepar.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateofdepar.ForeColor = System.Drawing.Color.Maroon;
            this.txtdateofdepar.Location = new System.Drawing.Point(253, 384);
            this.txtdateofdepar.Multiline = true;
            this.txtdateofdepar.Name = "txtdateofdepar";
            this.txtdateofdepar.Size = new System.Drawing.Size(143, 20);
            this.txtdateofdepar.TabIndex = 5;
            // 
            // txtDateofArrival
            // 
            this.txtDateofArrival.BackColor = System.Drawing.Color.White;
            this.txtDateofArrival.Font = new System.Drawing.Font("SF UI Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateofArrival.ForeColor = System.Drawing.Color.Maroon;
            this.txtDateofArrival.Location = new System.Drawing.Point(253, 142);
            this.txtDateofArrival.Multiline = true;
            this.txtDateofArrival.Name = "txtDateofArrival";
            this.txtDateofArrival.Size = new System.Drawing.Size(143, 20);
            this.txtDateofArrival.TabIndex = 5;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BackColor = System.Drawing.Color.White;
            this.txtSerialNo.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.ForeColor = System.Drawing.Color.Maroon;
            this.txtSerialNo.Location = new System.Drawing.Point(253, 78);
            this.txtSerialNo.Multiline = true;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(143, 39);
            this.txtSerialNo.TabIndex = 5;
            // 
            // cbmrt
            // 
            this.cbmrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbmrt.ForeColor = System.Drawing.Color.Maroon;
            this.cbmrt.FormattingEnabled = true;
            this.cbmrt.Location = new System.Drawing.Point(184, 523);
            this.cbmrt.Name = "cbmrt";
            this.cbmrt.Size = new System.Drawing.Size(105, 21);
            this.cbmrt.TabIndex = 11;
            this.cbmrt.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged_1);
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbRoomType.ForeColor = System.Drawing.Color.Maroon;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(184, 482);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(105, 21);
            this.cbRoomType.TabIndex = 11;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(29, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Children/Adults";
            // 
            // cbmrf
            // 
            this.cbmrf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbmrf.ForeColor = System.Drawing.Color.Maroon;
            this.cbmrf.FormattingEnabled = true;
            this.cbmrf.Location = new System.Drawing.Point(37, 523);
            this.cbmrf.Name = "cbmrf";
            this.cbmrf.Size = new System.Drawing.Size(105, 21);
            this.cbmrf.TabIndex = 10;
            this.cbmrf.TextChanged += new System.EventHandler(this.cbRoomFloor_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation ID";
            // 
            // cbRoomFloor
            // 
            this.cbRoomFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbRoomFloor.ForeColor = System.Drawing.Color.Maroon;
            this.cbRoomFloor.FormattingEnabled = true;
            this.cbRoomFloor.Location = new System.Drawing.Point(37, 482);
            this.cbRoomFloor.Name = "cbRoomFloor";
            this.cbRoomFloor.Size = new System.Drawing.Size(105, 21);
            this.cbRoomFloor.TabIndex = 10;
            this.cbRoomFloor.SelectedIndexChanged += new System.EventHandler(this.cbRoomFloor_SelectedIndexChanged);
            this.cbRoomFloor.TextChanged += new System.EventHandler(this.cbRoomFloor_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Maroon;
            this.label13.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(318, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Room Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(180, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Room Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(26, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date Of Arrival";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(33, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room Floor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(26, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vehicle Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(29, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Date Of Departure";
            // 
            // txtnumberofVehi
            // 
            this.txtnumberofVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnumberofVehi.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofVehi.ForeColor = System.Drawing.Color.Maroon;
            this.txtnumberofVehi.Location = new System.Drawing.Point(253, 327);
            this.txtnumberofVehi.Multiline = true;
            this.txtnumberofVehi.Name = "txtnumberofVehi";
            this.txtnumberofVehi.Size = new System.Drawing.Size(143, 39);
            this.txtnumberofVehi.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txtfatherCNIC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtphoneNumber);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.txtnameofperson);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 559);
            this.panel1.TabIndex = 4;
            // 
            // txtfatherCNIC
            // 
            this.txtfatherCNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtfatherCNIC.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfatherCNIC.ForeColor = System.Drawing.Color.Maroon;
            this.txtfatherCNIC.Location = new System.Drawing.Point(181, 266);
            this.txtfatherCNIC.Multiline = true;
            this.txtfatherCNIC.Name = "txtfatherCNIC";
            this.txtfatherCNIC.Size = new System.Drawing.Size(143, 39);
            this.txtfatherCNIC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer CNIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer\'s ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtphoneNumber.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.ForeColor = System.Drawing.Color.Maroon;
            this.txtphoneNumber.Location = new System.Drawing.Point(181, 202);
            this.txtphoneNumber.Multiline = true;
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(143, 39);
            this.txtphoneNumber.TabIndex = 2;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtaddress.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.Maroon;
            this.txtaddress.Location = new System.Drawing.Point(181, 330);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(143, 144);
            this.txtaddress.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.Maroon;
            this.txtCustomerID.Location = new System.Drawing.Point(181, 75);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(143, 39);
            this.txtCustomerID.TabIndex = 0;
            // 
            // txtnameofperson
            // 
            this.txtnameofperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnameofperson.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameofperson.ForeColor = System.Drawing.Color.Maroon;
            this.txtnameofperson.Location = new System.Drawing.Point(181, 139);
            this.txtnameofperson.Multiline = true;
            this.txtnameofperson.Name = "txtnameofperson";
            this.txtnameofperson.Size = new System.Drawing.Size(143, 38);
            this.txtnameofperson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txt_Search);
            this.panel4.Location = new System.Drawing.Point(7, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 364);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(425, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Universal Search";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Search.Location = new System.Drawing.Point(387, 57);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(214, 20);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1031, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservation View";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // OldData
            // 
            this.OldData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OldData.Controls.Add(this.dataGridView3);
            this.OldData.Location = new System.Drawing.Point(4, 22);
            this.OldData.Name = "OldData";
            this.OldData.Size = new System.Drawing.Size(1031, 565);
            this.OldData.TabIndex = 3;
            this.OldData.Text = "Old Data";
            this.OldData.Click += new System.EventHandler(this.OldData_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView3.Location = new System.Drawing.Point(0, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1028, 535);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1012, 443);
            this.dataGridView2.TabIndex = 4;
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1047, 597);
            this.Controls.Add(this.Reservation);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reception";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception";
            this.Load += new System.EventHandler(this.Reception_Load);
            this.Reservation.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.OldData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Reservation;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbRoomNumber;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ComboBox cbRoomFloor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtnumberofVehi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnumberofPresons;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfatherCNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtnameofperson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkdepart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtdateofdepar;
        private System.Windows.Forms.TextBox txtDateofArrival;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbmrn;
        private System.Windows.Forms.ComboBox cbmrt;
        private System.Windows.Forms.ComboBox cbmrf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage OldData;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}