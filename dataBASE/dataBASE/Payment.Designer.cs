﻿namespace dataBASE
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CardNumText = new System.Windows.Forms.TextBox();
            this.CardNumLabel = new System.Windows.Forms.Label();
            this.ExpiryDatelabel = new System.Windows.Forms.Label();
            this.ExpiryDateText = new System.Windows.Forms.TextBox();
            this.CvvLabel = new System.Windows.Forms.Label();
            this.CVVText = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardNameText = new System.Windows.Forms.TextBox();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dataBASE.Properties.Resources.bkgim;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3016, 1720);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CardNumText
            // 
            this.CardNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumText.Location = new System.Drawing.Point(614, 89);
            this.CardNumText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardNumText.Name = "CardNumText";
            this.CardNumText.Size = new System.Drawing.Size(524, 43);
            this.CardNumText.TabIndex = 10;
            // 
            // CardNumLabel
            // 
            this.CardNumLabel.AutoSize = true;
            this.CardNumLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CardNumLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumLabel.Location = new System.Drawing.Point(273, 89);
            this.CardNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNumLabel.Name = "CardNumLabel";
            this.CardNumLabel.Size = new System.Drawing.Size(219, 45);
            this.CardNumLabel.TabIndex = 11;
            this.CardNumLabel.Text = "Card Number:";
            // 
            // ExpiryDatelabel
            // 
            this.ExpiryDatelabel.AutoSize = true;
            this.ExpiryDatelabel.BackColor = System.Drawing.SystemColors.Control;
            this.ExpiryDatelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpiryDatelabel.Location = new System.Drawing.Point(304, 265);
            this.ExpiryDatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpiryDatelabel.Name = "ExpiryDatelabel";
            this.ExpiryDatelabel.Size = new System.Drawing.Size(186, 45);
            this.ExpiryDatelabel.TabIndex = 12;
            this.ExpiryDatelabel.Text = "Expiry Date:";
            // 
            // ExpiryDateText
            // 
            this.ExpiryDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpiryDateText.Location = new System.Drawing.Point(614, 269);
            this.ExpiryDateText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpiryDateText.Name = "ExpiryDateText";
            this.ExpiryDateText.Size = new System.Drawing.Size(170, 43);
            this.ExpiryDateText.TabIndex = 13;
            // 
            // CvvLabel
            // 
            this.CvvLabel.AutoSize = true;
            this.CvvLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CvvLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CvvLabel.Location = new System.Drawing.Point(403, 360);
            this.CvvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CvvLabel.Name = "CvvLabel";
            this.CvvLabel.Size = new System.Drawing.Size(87, 45);
            this.CvvLabel.TabIndex = 14;
            this.CvvLabel.Text = "CVV:";
            // 
            // CVVText
            // 
            this.CVVText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CVVText.Location = new System.Drawing.Point(614, 360);
            this.CVVText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CVVText.Name = "CVVText";
            this.CVVText.Size = new System.Drawing.Size(170, 43);
            this.CVVText.TabIndex = 15;
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(454, 526);
            this.PayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(408, 58);
            this.PayButton.TabIndex = 16;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CardNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameLabel.Location = new System.Drawing.Point(205, 177);
            this.CardNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(288, 45);
            this.CardNameLabel.TabIndex = 17;
            this.CardNameLabel.Text = "Name on the Card:";
            // 
            // CardNameText
            // 
            this.CardNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameText.Location = new System.Drawing.Point(614, 177);
            this.CardNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardNameText.Name = "CardNameText";
            this.CardNameText.Size = new System.Drawing.Size(524, 43);
            this.CardNameText.TabIndex = 18;
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(53, 21);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(102, 97);
            this.HomeButton.TabIndex = 41;
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 1028);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.CardNameText);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CVVText);
            this.Controls.Add(this.CvvLabel);
            this.Controls.Add(this.ExpiryDateText);
            this.Controls.Add(this.ExpiryDatelabel);
            this.Controls.Add(this.CardNumLabel);
            this.Controls.Add(this.CardNumText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CardNumText;
        private System.Windows.Forms.Label CardNumLabel;
        private System.Windows.Forms.Label ExpiryDatelabel;
        private System.Windows.Forms.TextBox ExpiryDateText;
        private System.Windows.Forms.Label CvvLabel;
        private System.Windows.Forms.TextBox CVVText;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.TextBox CardNameText;
        private System.Windows.Forms.Button HomeButton;
    }
}