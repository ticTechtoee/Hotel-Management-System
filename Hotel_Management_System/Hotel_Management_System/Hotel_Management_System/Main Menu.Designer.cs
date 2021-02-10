namespace Hotel_Management_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnreception = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKitchen);
            this.panel1.Controls.Add(this.btnreception);
            this.panel1.ForeColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 501);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Moodyrock", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKitchen
            // 
            this.btnKitchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKitchen.BackColor = System.Drawing.Color.Maroon;
            this.btnKitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Moodyrock", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKitchen.Location = new System.Drawing.Point(0, 321);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(262, 69);
            this.btnKitchen.TabIndex = 0;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnreception
            // 
            this.btnreception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnreception.BackColor = System.Drawing.Color.Maroon;
            this.btnreception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreception.Font = new System.Drawing.Font("Moodyrock", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreception.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnreception.Location = new System.Drawing.Point(0, 161);
            this.btnreception.Name = "btnreception";
            this.btnreception.Size = new System.Drawing.Size(262, 69);
            this.btnreception.TabIndex = 0;
            this.btnreception.Text = "Reception";
            this.btnreception.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreception.UseVisualStyleBackColor = false;
            this.btnreception.Click += new System.EventHandler(this.btnreception_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(796, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnreception;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

