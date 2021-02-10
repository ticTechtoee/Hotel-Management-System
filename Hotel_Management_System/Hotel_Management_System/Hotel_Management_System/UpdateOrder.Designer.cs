namespace Hotel_Management_System
{
    partial class UpdateOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.chkOrder = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.btnQuantity = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnQuantity);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.btnUpdateOrder);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtOrderList);
            this.panel1.Controls.Add(this.chkOrder);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(335, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 344);
            this.panel1.TabIndex = 79;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(422, 47);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(45, 16);
            this.lbltime.TabIndex = 82;
            this.lbltime.Text = "label2";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(89, 47);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(45, 16);
            this.lbldate.TabIndex = 83;
            this.lbldate.Text = "label2";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.AutoSize = true;
            this.btnUpdateOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Moodyrock", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateOrder.Location = new System.Drawing.Point(673, 142);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(133, 36);
            this.btnUpdateOrder.TabIndex = 80;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(693, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 36);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(416, 78);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.Size = new System.Drawing.Size(231, 214);
            this.txtOrderList.TabIndex = 79;
            // 
            // chkOrder
            // 
            this.chkOrder.CheckOnClick = true;
            this.chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder.FormattingEnabled = true;
            this.chkOrder.HorizontalScrollbar = true;
            this.chkOrder.Location = new System.Drawing.Point(92, 78);
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
            this.label9.Location = new System.Drawing.Point(3, 161);
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 344);
            this.panel4.TabIndex = 80;
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
            this.txtOrderID.Location = new System.Drawing.Point(170, 150);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(142, 20);
            this.txtOrderID.TabIndex = 66;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Maroon;
            this.txtCustomerName.Location = new System.Drawing.Point(170, 188);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(142, 20);
            this.txtCustomerName.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Order ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Customer\'s Name";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Interval = 1000;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTime_Tick);
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
            this.btnQuantity.Location = new System.Drawing.Point(327, 313);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(8, 8);
            this.btnQuantity.TabIndex = 84;
            this.btnQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantity.UseVisualStyleBackColor = false;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(221, 311);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 85;
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Order";
            this.Load += new System.EventHandler(this.UpdateOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.CheckedListBox chkOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}