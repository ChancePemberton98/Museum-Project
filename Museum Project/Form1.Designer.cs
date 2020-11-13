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
            this.uxResults = new System.Windows.Forms.TextBox();
            this.uxTransactionsLabel = new System.Windows.Forms.Label();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxLookup = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.labelMember = new System.Windows.Forms.Label();
            this.uxActivityLabel = new System.Windows.Forms.Label();
            this.uxActivityName = new System.Windows.Forms.TextBox();
            this.uxActivityDate = new System.Windows.Forms.DateTimePicker();
            this.uxActivityFee = new System.Windows.Forms.NumericUpDown();
            this.uxActivityNameLabel = new System.Windows.Forms.Label();
            this.uxActivityDateLabel = new System.Windows.Forms.Label();
            this.uxFeeLabel = new System.Windows.Forms.Label();
            this.uxLookUpActivityBtn = new System.Windows.Forms.Button();
            this.uxAddActivityBtn = new System.Windows.Forms.Button();
            this.uxRegisterBtn = new System.Windows.Forms.Button();
            this.uxShowAttendees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxActivityFee)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFirstNameLabel
            // 
            this.uxFirstNameLabel.AutoSize = true;
            this.uxFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstNameLabel.Location = new System.Drawing.Point(11, 36);
            this.uxFirstNameLabel.Name = "uxFirstNameLabel";
            this.uxFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxFirstNameLabel.TabIndex = 0;
            this.uxFirstNameLabel.Text = "First Name:";
            this.uxFirstNameLabel.Click += new System.EventHandler(this.uxNameLabel_Click);
            // 
            // uxMemberIDLabel
            // 
            this.uxMemberIDLabel.AutoSize = true;
            this.uxMemberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMemberIDLabel.Location = new System.Drawing.Point(12, 68);
            this.uxMemberIDLabel.Name = "uxMemberIDLabel";
            this.uxMemberIDLabel.Size = new System.Drawing.Size(88, 20);
            this.uxMemberIDLabel.TabIndex = 1;
            this.uxMemberIDLabel.Text = "MemberID:";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmailLabel.Location = new System.Drawing.Point(12, 103);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(52, 20);
            this.uxEmailLabel.TabIndex = 2;
            this.uxEmailLabel.Text = "Email:";
            this.uxEmailLabel.Click += new System.EventHandler(this.uxEmailLabel_Click);
            // 
            // uxDoBLabel
            // 
            this.uxDoBLabel.AutoSize = true;
            this.uxDoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDoBLabel.Location = new System.Drawing.Point(12, 132);
            this.uxDoBLabel.Name = "uxDoBLabel";
            this.uxDoBLabel.Size = new System.Drawing.Size(103, 20);
            this.uxDoBLabel.TabIndex = 3;
            this.uxDoBLabel.Text = "Date of Birth:";
            // 
            // uxDoBPick
            // 
            this.uxDoBPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDoBPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxDoBPick.Location = new System.Drawing.Point(117, 132);
            this.uxDoBPick.Name = "uxDoBPick";
            this.uxDoBPick.Size = new System.Drawing.Size(278, 26);
            this.uxDoBPick.TabIndex = 8;
            this.uxDoBPick.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // uxEmailAddress
            // 
            this.uxEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmailAddress.Location = new System.Drawing.Point(117, 100);
            this.uxEmailAddress.Name = "uxEmailAddress";
            this.uxEmailAddress.Size = new System.Drawing.Size(278, 26);
            this.uxEmailAddress.TabIndex = 9;
            // 
            // uxMemberID
            // 
            this.uxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMemberID.Location = new System.Drawing.Point(117, 68);
            this.uxMemberID.Name = "uxMemberID";
            this.uxMemberID.Size = new System.Drawing.Size(278, 26);
            this.uxMemberID.TabIndex = 10;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstName.Location = new System.Drawing.Point(117, 36);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(93, 26);
            this.uxFirstName.TabIndex = 11;
            this.uxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.uxFirstName_Validating);
            // 
            // uxLastNameLabel
            // 
            this.uxLastNameLabel.AutoSize = true;
            this.uxLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLastNameLabel.Location = new System.Drawing.Point(216, 39);
            this.uxLastNameLabel.Name = "uxLastNameLabel";
            this.uxLastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxLastNameLabel.TabIndex = 12;
            this.uxLastNameLabel.Text = "Last Name:";
            // 
            // uxLastName
            // 
            this.uxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLastName.Location = new System.Drawing.Point(303, 36);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(92, 26);
            this.uxLastName.TabIndex = 13;
            this.uxLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.uxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.uxLastName_Validating);
            // 
            // uxZipCodeLabel
            // 
            this.uxZipCodeLabel.AutoSize = true;
            this.uxZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZipCodeLabel.Location = new System.Drawing.Point(12, 164);
            this.uxZipCodeLabel.Name = "uxZipCodeLabel";
            this.uxZipCodeLabel.Size = new System.Drawing.Size(77, 20);
            this.uxZipCodeLabel.TabIndex = 14;
            this.uxZipCodeLabel.Text = "Zip Code:";
            // 
            // uxZipCode
            // 
            this.uxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZipCode.Location = new System.Drawing.Point(117, 164);
            this.uxZipCode.Name = "uxZipCode";
            this.uxZipCode.Size = new System.Drawing.Size(278, 26);
            this.uxZipCode.TabIndex = 15;
            // 
            // uxResults
            // 
            this.uxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResults.Location = new System.Drawing.Point(624, 32);
            this.uxResults.Multiline = true;
            this.uxResults.Name = "uxResults";
            this.uxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResults.Size = new System.Drawing.Size(404, 447);
            this.uxResults.TabIndex = 16;
            this.uxResults.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // uxTransactionsLabel
            // 
            this.uxTransactionsLabel.AutoSize = true;
            this.uxTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTransactionsLabel.Location = new System.Drawing.Point(620, 9);
            this.uxTransactionsLabel.Name = "uxTransactionsLabel";
            this.uxTransactionsLabel.Size = new System.Drawing.Size(67, 20);
            this.uxTransactionsLabel.TabIndex = 17;
            this.uxTransactionsLabel.Text = "Results:";
            // 
            // uxAdd
            // 
            this.uxAdd.Enabled = false;
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(117, 196);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(141, 46);
            this.uxAdd.TabIndex = 18;
            this.uxAdd.Text = "Add";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxLookup
            // 
            this.uxLookup.Enabled = false;
            this.uxLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLookup.Location = new System.Drawing.Point(264, 196);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(131, 46);
            this.uxLookup.TabIndex = 19;
            this.uxLookup.Text = "Lookup";
            this.uxLookup.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(822, 488);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 23;
            this.passwordTxt.Text = "PASSWORD";
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(716, 488);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 22;
            this.usernameTxt.Text = "USERNAME";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(928, 485);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(100, 23);
            this.connectBtn.TabIndex = 21;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.Location = new System.Drawing.Point(12, 9);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(67, 20);
            this.labelMember.TabIndex = 24;
            this.labelMember.Text = "Member";
            // 
            // uxActivityLabel
            // 
            this.uxActivityLabel.AutoSize = true;
            this.uxActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityLabel.Location = new System.Drawing.Point(3, 251);
            this.uxActivityLabel.Name = "uxActivityLabel";
            this.uxActivityLabel.Size = new System.Drawing.Size(58, 20);
            this.uxActivityLabel.TabIndex = 25;
            this.uxActivityLabel.Text = "Activity";
            // 
            // uxActivityName
            // 
            this.uxActivityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityName.Location = new System.Drawing.Point(117, 277);
            this.uxActivityName.Name = "uxActivityName";
            this.uxActivityName.Size = new System.Drawing.Size(278, 26);
            this.uxActivityName.TabIndex = 26;
            // 
            // uxActivityDate
            // 
            this.uxActivityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxActivityDate.Location = new System.Drawing.Point(117, 309);
            this.uxActivityDate.Name = "uxActivityDate";
            this.uxActivityDate.Size = new System.Drawing.Size(278, 26);
            this.uxActivityDate.TabIndex = 27;
            // 
            // uxActivityFee
            // 
            this.uxActivityFee.DecimalPlaces = 2;
            this.uxActivityFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityFee.Location = new System.Drawing.Point(117, 341);
            this.uxActivityFee.Name = "uxActivityFee";
            this.uxActivityFee.Size = new System.Drawing.Size(120, 26);
            this.uxActivityFee.TabIndex = 28;
            // 
            // uxActivityNameLabel
            // 
            this.uxActivityNameLabel.AutoSize = true;
            this.uxActivityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityNameLabel.Location = new System.Drawing.Point(3, 280);
            this.uxActivityNameLabel.Name = "uxActivityNameLabel";
            this.uxActivityNameLabel.Size = new System.Drawing.Size(108, 20);
            this.uxActivityNameLabel.TabIndex = 29;
            this.uxActivityNameLabel.Text = "Activity Name:";
            // 
            // uxActivityDateLabel
            // 
            this.uxActivityDateLabel.AutoSize = true;
            this.uxActivityDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityDateLabel.Location = new System.Drawing.Point(3, 314);
            this.uxActivityDateLabel.Name = "uxActivityDateLabel";
            this.uxActivityDateLabel.Size = new System.Drawing.Size(101, 20);
            this.uxActivityDateLabel.TabIndex = 30;
            this.uxActivityDateLabel.Text = "Activity Date:";
            // 
            // uxFeeLabel
            // 
            this.uxFeeLabel.AutoSize = true;
            this.uxFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFeeLabel.Location = new System.Drawing.Point(3, 343);
            this.uxFeeLabel.Name = "uxFeeLabel";
            this.uxFeeLabel.Size = new System.Drawing.Size(41, 20);
            this.uxFeeLabel.TabIndex = 31;
            this.uxFeeLabel.Text = "Fee:";
            // 
            // uxLookUpActivityBtn
            // 
            this.uxLookUpActivityBtn.Enabled = false;
            this.uxLookUpActivityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLookUpActivityBtn.Location = new System.Drawing.Point(264, 373);
            this.uxLookUpActivityBtn.Name = "uxLookUpActivityBtn";
            this.uxLookUpActivityBtn.Size = new System.Drawing.Size(141, 46);
            this.uxLookUpActivityBtn.TabIndex = 33;
            this.uxLookUpActivityBtn.Text = "Lookup";
            this.uxLookUpActivityBtn.UseVisualStyleBackColor = true;
            // 
            // uxAddActivityBtn
            // 
            this.uxAddActivityBtn.Enabled = false;
            this.uxAddActivityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddActivityBtn.Location = new System.Drawing.Point(117, 373);
            this.uxAddActivityBtn.Name = "uxAddActivityBtn";
            this.uxAddActivityBtn.Size = new System.Drawing.Size(141, 46);
            this.uxAddActivityBtn.TabIndex = 32;
            this.uxAddActivityBtn.Text = "Add";
            this.uxAddActivityBtn.UseVisualStyleBackColor = true;
            // 
            // uxRegisterBtn
            // 
            this.uxRegisterBtn.Enabled = false;
            this.uxRegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRegisterBtn.Location = new System.Drawing.Point(117, 425);
            this.uxRegisterBtn.Name = "uxRegisterBtn";
            this.uxRegisterBtn.Size = new System.Drawing.Size(141, 46);
            this.uxRegisterBtn.TabIndex = 34;
            this.uxRegisterBtn.Text = "Register";
            this.uxRegisterBtn.UseVisualStyleBackColor = true;
            // 
            // uxShowAttendees
            // 
            this.uxShowAttendees.Enabled = false;
            this.uxShowAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowAttendees.Location = new System.Drawing.Point(264, 425);
            this.uxShowAttendees.Name = "uxShowAttendees";
            this.uxShowAttendees.Size = new System.Drawing.Size(141, 46);
            this.uxShowAttendees.TabIndex = 35;
            this.uxShowAttendees.Text = "Show Attendees";
            this.uxShowAttendees.UseVisualStyleBackColor = true;
            // 
            // MuseumApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 520);
            this.Controls.Add(this.uxShowAttendees);
            this.Controls.Add(this.uxRegisterBtn);
            this.Controls.Add(this.uxLookUpActivityBtn);
            this.Controls.Add(this.uxAddActivityBtn);
            this.Controls.Add(this.uxFeeLabel);
            this.Controls.Add(this.uxActivityDateLabel);
            this.Controls.Add(this.uxActivityNameLabel);
            this.Controls.Add(this.uxActivityFee);
            this.Controls.Add(this.uxActivityDate);
            this.Controls.Add(this.uxActivityName);
            this.Controls.Add(this.uxActivityLabel);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxTransactionsLabel);
            this.Controls.Add(this.uxResults);
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
            this.Load += new System.EventHandler(this.MuseumApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxActivityFee)).EndInit();
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
        private System.Windows.Forms.TextBox uxResults;
        private System.Windows.Forms.Label uxTransactionsLabel;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxLookup;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label uxActivityLabel;
        private System.Windows.Forms.TextBox uxActivityName;
        private System.Windows.Forms.DateTimePicker uxActivityDate;
        private System.Windows.Forms.NumericUpDown uxActivityFee;
        private System.Windows.Forms.Label uxActivityNameLabel;
        private System.Windows.Forms.Label uxActivityDateLabel;
        private System.Windows.Forms.Label uxFeeLabel;
        private System.Windows.Forms.Button uxLookUpActivityBtn;
        private System.Windows.Forms.Button uxAddActivityBtn;
        private System.Windows.Forms.Button uxRegisterBtn;
        private System.Windows.Forms.Button uxShowAttendees;
    }
}

