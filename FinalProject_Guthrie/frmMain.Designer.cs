namespace FinalProject_Guthrie
{
    partial class frmMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSeachMain = new System.Windows.Forms.Button();
            this.btnAddBookMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfBooks = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 169);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(491, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSeachMain
            // 
            this.btnSeachMain.Location = new System.Drawing.Point(13, 13);
            this.btnSeachMain.Name = "btnSeachMain";
            this.btnSeachMain.Size = new System.Drawing.Size(94, 129);
            this.btnSeachMain.TabIndex = 1;
            this.btnSeachMain.Text = "Search";
            this.btnSeachMain.UseVisualStyleBackColor = true;
            this.btnSeachMain.Click += new System.EventHandler(this.btnSeachMain_Click);
            // 
            // btnAddBookMain
            // 
            this.btnAddBookMain.Location = new System.Drawing.Point(113, 13);
            this.btnAddBookMain.Name = "btnAddBookMain";
            this.btnAddBookMain.Size = new System.Drawing.Size(94, 129);
            this.btnAddBookMain.TabIndex = 2;
            this.btnAddBookMain.Text = "Add Book";
            this.btnAddBookMain.UseVisualStyleBackColor = true;
            this.btnAddBookMain.Click += new System.EventHandler(this.btnAddBookMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of books:";
            // 
            // lblNumberOfBooks
            // 
            this.lblNumberOfBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfBooks.Location = new System.Drawing.Point(332, 41);
            this.lblNumberOfBooks.Name = "lblNumberOfBooks";
            this.lblNumberOfBooks.Size = new System.Drawing.Size(100, 23);
            this.lblNumberOfBooks.TabIndex = 4;
            this.lblNumberOfBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 191);
            this.Controls.Add(this.lblNumberOfBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBookMain);
            this.Controls.Add(this.btnSeachMain);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Book Catalog";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
        private System.Windows.Forms.Button btnSeachMain;
        private System.Windows.Forms.Button btnAddBookMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfBooks;
    }
}

