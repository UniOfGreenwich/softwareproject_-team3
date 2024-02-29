namespace dataBASE
{
    partial class StaffHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmBook = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.ViewInfo = new System.Windows.Forms.Button();
            this.ManageBooks = new System.Windows.Forms.Button();
            this.ManageAccounts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Welcomelabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcomelabel.Location = new System.Drawing.Point(65, 38);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(545, 65);
            this.Welcomelabel.TabIndex = 1;
            this.Welcomelabel.Text = "Welcome, <your_name>";
            this.Welcomelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25600, 14400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfirmBook);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.ViewInfo);
            this.panel1.Controls.Add(this.ManageBooks);
            this.panel1.Controls.Add(this.ManageAccounts);
            this.panel1.Controls.Add(this.Welcomelabel);
            this.panel1.Location = new System.Drawing.Point(57, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 923);
            this.panel1.TabIndex = 3;
            // 
            // ConfirmBook
            // 
            this.ConfirmBook.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmBook.Location = new System.Drawing.Point(428, 270);
            this.ConfirmBook.Name = "ConfirmBook";
            this.ConfirmBook.Size = new System.Drawing.Size(290, 94);
            this.ConfirmBook.TabIndex = 6;
            this.ConfirmBook.Text = "Confirm Borrowing Book";
            this.ConfirmBook.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.Location = new System.Drawing.Point(1316, 270);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(290, 94);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // ViewInfo
            // 
            this.ViewInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewInfo.Location = new System.Drawing.Point(132, 270);
            this.ViewInfo.Name = "ViewInfo";
            this.ViewInfo.Size = new System.Drawing.Size(290, 94);
            this.ViewInfo.TabIndex = 4;
            this.ViewInfo.Text = "View Your Info";
            this.ViewInfo.UseVisualStyleBackColor = true;
            this.ViewInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageBooks
            // 
            this.ManageBooks.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageBooks.Location = new System.Drawing.Point(1020, 270);
            this.ManageBooks.Name = "ManageBooks";
            this.ManageBooks.Size = new System.Drawing.Size(290, 94);
            this.ManageBooks.TabIndex = 3;
            this.ManageBooks.Text = "Manage Books Data Base";
            this.ManageBooks.UseVisualStyleBackColor = true;
            this.ManageBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageAccounts
            // 
            this.ManageAccounts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageAccounts.Location = new System.Drawing.Point(724, 270);
            this.ManageAccounts.Name = "ManageAccounts";
            this.ManageAccounts.Size = new System.Drawing.Size(290, 94);
            this.ManageAccounts.TabIndex = 2;
            this.ManageAccounts.Text = "Manage Students Accounts";
            this.ManageAccounts.UseVisualStyleBackColor = true;
            this.ManageAccounts.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffHome";
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManageBooks;
        private System.Windows.Forms.Button ManageAccounts;
        private System.Windows.Forms.Button ViewInfo;
        private System.Windows.Forms.Button ConfirmBook;
        private System.Windows.Forms.Button LogOut;
    }
}