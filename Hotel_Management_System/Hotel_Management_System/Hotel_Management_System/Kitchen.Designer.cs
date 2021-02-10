namespace Hotel_Management_System
{
    partial class Kitchen
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblEditorder = new System.Windows.Forms.LinkLabel();
            this.chkOrder = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 484);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Controls.Add(this.lbltime);
            this.tabPage1.Controls.Add(this.lbldate);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1279, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitchen Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 24);
            this.menuStrip1.TabIndex = 80;
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
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click_1);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kitchenToolStripMenuItem.Text = "Reception";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(429, 63);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(45, 16);
            this.lbltime.TabIndex = 79;
            this.lbltime.Text = "label2";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(96, 63);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(45, 16);
            this.lbldate.TabIndex = 79;
            this.lbldate.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnPlaceorder);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(868, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 287);
            this.panel2.TabIndex = 78;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(93, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.AutoSize = true;
            this.btnPlaceorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlaceorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceorder.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceorder.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlaceorder.Location = new System.Drawing.Point(72, 119);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(119, 36);
            this.btnPlaceorder.TabIndex = 77;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceorder.UseVisualStyleBackColor = false;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(92, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 36);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnQuantity);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblEditorder);
            this.panel1.Controls.Add(this.chkOrder);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(432, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 306);
            this.panel1.TabIndex = 78;
            // 
            // btnQuantity
            // 
            this.btnQuantity.AutoSize = true;
            this.btnQuantity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantity.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantity.ForeColor = System.Drawing.Color.Maroon;
            this.btnQuantity.Location = new System.Drawing.Point(300, 269);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(8, 8);
            this.btnQuantity.TabIndex = 79;
            this.btnQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantity.UseVisualStyleBackColor = false;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(194, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 80;
            // 
            // lblEditorder
            // 
            this.lblEditorder.AutoSize = true;
            this.lblEditorder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorder.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblEditorder.LinkColor = System.Drawing.Color.Yellow;
            this.lblEditorder.Location = new System.Drawing.Point(202, 238);
            this.lblEditorder.Name = "lblEditorder";
            this.lblEditorder.Size = new System.Drawing.Size(77, 16);
            this.lblEditorder.TabIndex = 78;
            this.lblEditorder.TabStop = true;
            this.lblEditorder.Text = "Edit Order.";
            this.lblEditorder.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEditorder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditorder_LinkClicked);
            // 
            // chkOrder
            // 
            this.chkOrder.CheckOnClick = true;
            this.chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder.FormattingEnabled = true;
            this.chkOrder.HorizontalScrollbar = true;
            this.chkOrder.Location = new System.Drawing.Point(96, 21);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.ScrollAlwaysVisible = true;
            this.chkOrder.Size = new System.Drawing.Size(317, 214);
            this.chkOrder.TabIndex = 77;
            this.chkOrder.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkOrder_ItemCheck);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Services";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.txtCustomerID);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtOrderID);
            this.panel4.Controls.Add(this.txtCustomerName);
            this.panel4.Controls.Add(this.txtRoomNumber);
            this.panel4.Controls.Add(this.txtReservationID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(99, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 287);
            this.panel4.TabIndex = 78;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.ForeColor = System.Drawing.Color.Maroon;
            this.txtCustomerID.Location = new System.Drawing.Point(170, 43);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(142, 20);
            this.txtCustomerID.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Customer\'s ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOrderID.ForeColor = System.Drawing.Color.Maroon;
            this.txtOrderID.Location = new System.Drawing.Point(170, 119);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(142, 20);
            this.txtOrderID.TabIndex = 66;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Maroon;
            this.txtCustomerName.Location = new System.Drawing.Point(170, 157);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(142, 20);
            this.txtCustomerName.TabIndex = 66;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Maroon;
            this.txtRoomNumber.Location = new System.Drawing.Point(170, 233);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(142, 20);
            this.txtRoomNumber.TabIndex = 65;
            // 
            // txtReservationID
            // 
            this.txtReservationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReservationID.ForeColor = System.Drawing.Color.Maroon;
            this.txtReservationID.Location = new System.Drawing.Point(170, 195);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(142, 20);
            this.txtReservationID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Customer\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Reservation ID";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Interval = 1000;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTime_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 452);
            this.panel5.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(119, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(980, 390);
            this.dataGridView2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1279, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitchen Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1263, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kitchen
            // 
            this.AcceptButton = this.btnQuantity;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1293, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox chkOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblEditorder;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}