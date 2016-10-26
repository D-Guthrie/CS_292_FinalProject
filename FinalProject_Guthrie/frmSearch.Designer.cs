namespace FinalProject_Guthrie
{
    partial class frmSearch
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
            this.grpSearchCatagory = new System.Windows.Forms.GroupBox();
            this.radSearchTitle = new System.Windows.Forms.RadioButton();
            this.radSearchAuthor = new System.Windows.Forms.RadioButton();
            this.radSearchISBN = new System.Windows.Forms.RadioButton();
            this.grpSearchCatagory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchCatagory
            // 
            this.grpSearchCatagory.Controls.Add(this.radSearchISBN);
            this.grpSearchCatagory.Controls.Add(this.radSearchAuthor);
            this.grpSearchCatagory.Controls.Add(this.radSearchTitle);
            this.grpSearchCatagory.Location = new System.Drawing.Point(13, 13);
            this.grpSearchCatagory.Name = "grpSearchCatagory";
            this.grpSearchCatagory.Size = new System.Drawing.Size(206, 50);
            this.grpSearchCatagory.TabIndex = 0;
            this.grpSearchCatagory.TabStop = false;
            this.grpSearchCatagory.Text = "Search for:";
            // 
            // radSearchTitle
            // 
            this.radSearchTitle.AutoSize = true;
            this.radSearchTitle.Location = new System.Drawing.Point(12, 20);
            this.radSearchTitle.Name = "radSearchTitle";
            this.radSearchTitle.Size = new System.Drawing.Size(45, 17);
            this.radSearchTitle.TabIndex = 0;
            this.radSearchTitle.TabStop = true;
            this.radSearchTitle.Text = "Title";
            this.radSearchTitle.UseVisualStyleBackColor = true;
            // 
            // radSearchAuthor
            // 
            this.radSearchAuthor.AutoSize = true;
            this.radSearchAuthor.Location = new System.Drawing.Point(64, 20);
            this.radSearchAuthor.Name = "radSearchAuthor";
            this.radSearchAuthor.Size = new System.Drawing.Size(56, 17);
            this.radSearchAuthor.TabIndex = 1;
            this.radSearchAuthor.TabStop = true;
            this.radSearchAuthor.Text = "Author";
            this.radSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // radSearchISBN
            // 
            this.radSearchISBN.AutoSize = true;
            this.radSearchISBN.Location = new System.Drawing.Point(127, 20);
            this.radSearchISBN.Name = "radSearchISBN";
            this.radSearchISBN.Size = new System.Drawing.Size(50, 17);
            this.radSearchISBN.TabIndex = 2;
            this.radSearchISBN.TabStop = true;
            this.radSearchISBN.Text = "ISBN";
            this.radSearchISBN.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 460);
            this.Controls.Add(this.grpSearchCatagory);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.grpSearchCatagory.ResumeLayout(false);
            this.grpSearchCatagory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchCatagory;
        private System.Windows.Forms.RadioButton radSearchISBN;
        private System.Windows.Forms.RadioButton radSearchAuthor;
        private System.Windows.Forms.RadioButton radSearchTitle;
    }
}