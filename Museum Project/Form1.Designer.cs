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
            this.uxLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.uxDoBPick.Size = new System.Drawing.Size(200, 20);
            this.uxDoBPick.TabIndex = 8;
            this.uxDoBPick.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // uxEmailAddress
            // 
            this.uxEmailAddress.Location = new System.Drawing.Point(100, 122);
            this.uxEmailAddress.Name = "uxEmailAddress";
            this.uxEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.uxEmailAddress.TabIndex = 9;
            // 
            // uxMemberID
            // 
            this.uxMemberID.Location = new System.Drawing.Point(100, 96);
            this.uxMemberID.Name = "uxMemberID";
            this.uxMemberID.Size = new System.Drawing.Size(200, 20);
            this.uxMemberID.TabIndex = 10;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(100, 70);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(60, 20);
            this.uxFirstName.TabIndex = 11;
            // 
            // uxLastName
            // 
            this.uxLastName.AutoSize = true;
            this.uxLastName.Location = new System.Drawing.Point(166, 73);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(61, 13);
            this.uxLastName.TabIndex = 12;
            this.uxLastName.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 13;
            // 
            // MuseumApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxLastName);
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
        private System.Windows.Forms.Label uxLastName;
        private System.Windows.Forms.TextBox textBox1;
    }
}

