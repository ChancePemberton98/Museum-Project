namespace Museum_Project
{
    partial class DataGridView
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
            this.uxDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGridView
            // 
            this.uxDataGridView.AllowUserToAddRows = false;
            this.uxDataGridView.AllowUserToDeleteRows = false;
            this.uxDataGridView.AllowUserToOrderColumns = true;
            this.uxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridView.Location = new System.Drawing.Point(13, 13);
            this.uxDataGridView.Name = "uxDataGridView";
            this.uxDataGridView.ReadOnly = true;
            this.uxDataGridView.Size = new System.Drawing.Size(775, 425);
            this.uxDataGridView.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDataGridView);
            this.Name = "DataGridView";
            this.Text = "Report Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGridView;
    }
}