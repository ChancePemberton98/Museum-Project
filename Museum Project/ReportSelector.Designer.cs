namespace Museum_Project
{
    partial class ReportSelector
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
            this.uxReportSelectComboBox = new System.Windows.Forms.ComboBox();
            this.uxReportDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxRunReportBtn = new System.Windows.Forms.Button();
            this.uxCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxReportSelectComboBox
            // 
            this.uxReportSelectComboBox.FormattingEnabled = true;
            this.uxReportSelectComboBox.Location = new System.Drawing.Point(13, 13);
            this.uxReportSelectComboBox.Name = "uxReportSelectComboBox";
            this.uxReportSelectComboBox.Size = new System.Drawing.Size(303, 21);
            this.uxReportSelectComboBox.TabIndex = 0;
            // 
            // uxReportDescriptionBox
            // 
            this.uxReportDescriptionBox.Location = new System.Drawing.Point(12, 40);
            this.uxReportDescriptionBox.Multiline = true;
            this.uxReportDescriptionBox.Name = "uxReportDescriptionBox";
            this.uxReportDescriptionBox.Size = new System.Drawing.Size(304, 160);
            this.uxReportDescriptionBox.TabIndex = 2;
            // 
            // uxRunReportBtn
            // 
            this.uxRunReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunReportBtn.Location = new System.Drawing.Point(13, 207);
            this.uxRunReportBtn.Name = "uxRunReportBtn";
            this.uxRunReportBtn.Size = new System.Drawing.Size(146, 32);
            this.uxRunReportBtn.TabIndex = 3;
            this.uxRunReportBtn.Text = "Run";
            this.uxRunReportBtn.UseVisualStyleBackColor = true;
            // 
            // uxCancelBtn
            // 
            this.uxCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelBtn.Location = new System.Drawing.Point(165, 207);
            this.uxCancelBtn.Name = "uxCancelBtn";
            this.uxCancelBtn.Size = new System.Drawing.Size(151, 32);
            this.uxCancelBtn.TabIndex = 4;
            this.uxCancelBtn.Text = "Cancel";
            this.uxCancelBtn.UseVisualStyleBackColor = true;
            // 
            // ReportSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 251);
            this.Controls.Add(this.uxCancelBtn);
            this.Controls.Add(this.uxRunReportBtn);
            this.Controls.Add(this.uxReportDescriptionBox);
            this.Controls.Add(this.uxReportSelectComboBox);
            this.Name = "ReportSelector";
            this.Text = "Report Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxReportSelectComboBox;
        private System.Windows.Forms.TextBox uxReportDescriptionBox;
        private System.Windows.Forms.Button uxRunReportBtn;
        private System.Windows.Forms.Button uxCancelBtn;
    }
}