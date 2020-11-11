namespace Museum_Project
{
    partial class MuseumApp
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
            this.uxFirstNameLabel = new System.Windows.Forms.Label();
            this.uxMemberIDLabel = new System.Windows.Forms.Label();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxDoBLabel = new System.Windows.Forms.Label();
            this.uxDoBPick = new System.Windows.Forms.DateTimePicker();
            this.uxEmailAddress = new System.Windows.Forms.TextBox();
            this.uxMemberID = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastNameLabel = new System.Windows.Forms.Label();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxZipCodeLabel = new System.Windows.Forms.Label();
            this.uxZipCode = new System.Windows.Forms.TextBox();
            this.uxTrasactions = new System.Windows.Forms.TextBox();
            this.uxTransactionsLabel = new System.Windows.Forms.Label();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxLookup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxFirstNameLabel
            // 
            this.uxFirstNameLabel.AutoSize = true;
            this.uxFirstNameLabel.Location = new System.Drawing.Point(12, 73);
            this.uxFirstNameLabel.Name = "uxFirstNameLabel";
            this.uxFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.uxFirstNameLabel.TabIndex = 0;
            this.uxFirstNameLabel.Text = "First Name:";
            this.uxFirstNameLabel.Click += new System.EventHandler(this.uxNameLabel_Click);
            // 
            // uxMemberIDLabel
            // 
            this.uxMemberIDLabel.AutoSize = true;
            this.uxMemberIDLabel.Location = new System.Drawing.Point(12, 104);
            this.uxMemberIDLabel.Name = "uxMemberIDLabel";
            this.uxMemberIDLabel.Size = new System.Drawing.Size(59, 13);
            this.uxMemberIDLabel.TabIndex = 1;
            this.uxMemberIDLabel.Text = "MemberID:";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Location = new System.Drawing.Point(12, 129);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(76, 13);
            this.uxEmailLabel.TabIndex = 2;
            this.uxEmailLabel.Text = "Email Address:";
            // 
            // uxDoBLabel
            // 
            this.uxDoBLabel.AutoSize = true;
            this.uxDoBLabel.Location = new System.Drawing.Point(12, 154);
            this.uxDoBLabel.Name = "uxDoBLabel";
            this.uxDoBLabel.Size = new System.Drawing.Size(69, 13);
            this.uxDoBLabel.TabIndex = 3;
            this.uxDoBLabel.Text = "Date of Birth:";
            // 
            // uxDoBPick
            // 
            this.uxDoBPick.Location = new System.Drawing.Point(100, 151);
            this.uxDoBPick.Name = "uxDoBPick";
            this.uxDoBPick.Size = new System.Drawing.Size(228, 20);
            this.uxDoBPick.TabIndex = 8;
            this.uxDoBPick.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // uxEmailAddress
            // 
            this.uxEmailAddress.Location = new System.Drawing.Point(100, 122);
            this.uxEmailAddress.Name = "uxEmailAddress";
            this.uxEmailAddress.Size = new System.Drawing.Size(228, 20);
            this.uxEmailAddress.TabIndex = 9;
            // 
            // uxMemberID
            // 
            this.uxMemberID.Location = new System.Drawing.Point(100, 96);
            this.uxMemberID.Name = "uxMemberID";
            this.uxMemberID.Size = new System.Drawing.Size(228, 20);
            this.uxMemberID.TabIndex = 10;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(100, 70);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(72, 20);
            this.uxFirstName.TabIndex = 11;
            this.uxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.uxFirstName_Validating);
            // 
            // uxLastNameLabel
            // 
            this.uxLastNameLabel.AutoSize = true;
            this.uxLastNameLabel.Location = new System.Drawing.Point(178, 73);
            this.uxLastNameLabel.Name = "uxLastNameLabel";
            this.uxLastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.uxLastNameLabel.TabIndex = 12;
            this.uxLastNameLabel.Text = "Last Name:";
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(245, 70);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(83, 20);
            this.uxLastName.TabIndex = 13;
            this.uxLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.uxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.uxLastName_Validating);
            // 
            // uxZipCodeLabel
            // 
            this.uxZipCodeLabel.AutoSize = true;
            this.uxZipCodeLabel.Location = new System.Drawing.Point(12, 181);
            this.uxZipCodeLabel.Name = "uxZipCodeLabel";
            this.uxZipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.uxZipCodeLabel.TabIndex = 14;
            this.uxZipCodeLabel.Text = "Zip Code:";
            // 
            // uxZipCode
            // 
            this.uxZipCode.Location = new System.Drawing.Point(100, 179);
            this.uxZipCode.Name = "uxZipCode";
            this.uxZipCode.Size = new System.Drawing.Size(228, 20);
            this.uxZipCode.TabIndex = 15;
            // 
            // uxTrasactions
            // 
            this.uxTrasactions.Location = new System.Drawing.Point(459, 96);
            this.uxTrasactions.Multiline = true;
            this.uxTrasactions.Name = "uxTrasactions";
            this.uxTrasactions.Size = new System.Drawing.Size(277, 155);
            this.uxTrasactions.TabIndex = 16;
            this.uxTrasactions.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // uxTransactionsLabel
            // 
            this.uxTransactionsLabel.AutoSize = true;
            this.uxTransactionsLabel.Location = new System.Drawing.Point(456, 73);
            this.uxTransactionsLabel.Name = "uxTransactionsLabel";
            this.uxTransactionsLabel.Size = new System.Drawing.Size(71, 13);
            this.uxTransactionsLabel.TabIndex = 17;
            this.uxTransactionsLabel.Text = "Transactions:";
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(100, 205);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(110, 46);
            this.uxAdd.TabIndex = 18;
            this.uxAdd.Text = "Add";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxLookup
            // 
            this.uxLookup.Location = new System.Drawing.Point(216, 205);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(112, 46);
            this.uxLookup.TabIndex = 19;
            this.uxLookup.Text = "Lookup";
            this.uxLookup.UseVisualStyleBackColor = true;
            // 
            // MuseumApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxTransactionsLabel);
            this.Controls.Add(this.uxTrasactions);
            this.Controls.Add(this.uxZipCode);
            this.Controls.Add(this.uxZipCodeLabel);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxLastNameLabel);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxMemberID);
            this.Controls.Add(this.uxEmailAddress);
            this.Controls.Add(this.uxDoBPick);
            this.Controls.Add(this.uxDoBLabel);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxMemberIDLabel);
            this.Controls.Add(this.uxFirstNameLabel);
            this.Name = "MuseumApp";
            this.Text = "Museum Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxFirstNameLabel;
        private System.Windows.Forms.Label uxMemberIDLabel;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxDoBLabel;
        private System.Windows.Forms.DateTimePicker uxDoBPick;
        private System.Windows.Forms.TextBox uxEmailAddress;
        private System.Windows.Forms.TextBox uxMemberID;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.Label uxLastNameLabel;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Label uxZipCodeLabel;
        private System.Windows.Forms.TextBox uxZipCode;
        private System.Windows.Forms.TextBox uxTrasactions;
        private System.Windows.Forms.Label uxTransactionsLabel;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxLookup;
    }
}

