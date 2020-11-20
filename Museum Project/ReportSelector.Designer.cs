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
            this.uxRunReportBtn = new System.Windows.Forms.Button();
            this.uxCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxReportSelectComboBox
            // 
            this.uxReportSelectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReportSelectComboBox.FormattingEnabled = true;
            this.uxReportSelectComboBox.Location = new System.Drawing.Point(13, 12);
            this.uxReportSelectComboBox.Name = "uxReportSelectComboBox";
            this.uxReportSelectComboBox.Size = new System.Drawing.Size(303, 28);
            this.uxReportSelectComboBox.TabIndex = 0;
            // 
            // uxRunReportBtn
            // 
            this.uxRunReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunReportBtn.Location = new System.Drawing.Point(13, 46);
            this.uxRunReportBtn.Name = "uxRunReportBtn";
            this.uxRunReportBtn.Size = new System.Drawing.Size(146, 51);
            this.uxRunReportBtn.TabIndex = 3;
            this.uxRunReportBtn.Text = "Run";
            this.uxRunReportBtn.UseVisualStyleBackColor = true;
            // 
            // uxCancelBtn
            // 
            this.uxCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelBtn.Location = new System.Drawing.Point(165, 46);
            this.uxCancelBtn.Name = "uxCancelBtn";
            this.uxCancelBtn.Size = new System.Drawing.Size(151, 51);
            this.uxCancelBtn.TabIndex = 4;
            this.uxCancelBtn.Text = "Cancel";
            this.uxCancelBtn.UseVisualStyleBackColor = true;
            // 
            // ReportSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 108);
            this.Controls.Add(this.uxCancelBtn);
            this.Controls.Add(this.uxRunReportBtn);
            this.Controls.Add(this.uxReportSelectComboBox);
            this.Name = "ReportSelector";
            this.Text = "Report Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uxReportSelectComboBox;
        private System.Windows.Forms.Button uxRunReportBtn;
        private System.Windows.Forms.Button uxCancelBtn;
    }
}