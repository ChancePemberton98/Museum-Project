namespace Museum_Project
{
    partial class QueryForm
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.nameSearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(224, 483);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(12, 485);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Text = "USERNAME";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(118, 485);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Text = "PASSWORD";
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // nameSearchBtn
            // 
            this.nameSearchBtn.Location = new System.Drawing.Point(224, 454);
            this.nameSearchBtn.Name = "nameSearchBtn";
            this.nameSearchBtn.Size = new System.Drawing.Size(123, 23);
            this.nameSearchBtn.TabIndex = 3;
            this.nameSearchBtn.Text = "Name Search";
            this.nameSearchBtn.UseVisualStyleBackColor = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 514);
            this.Controls.Add(this.nameSearchBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.connectBtn);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button nameSearchBtn;
    }
}