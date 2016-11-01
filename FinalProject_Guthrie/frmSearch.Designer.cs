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
            this.radSearchISBN = new System.Windows.Forms.RadioButton();
            this.radSearchAuthor = new System.Windows.Forms.RadioButton();
            this.radSearchTitle = new System.Windows.Forms.RadioButton();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdvancedFind = new System.Windows.Forms.Button();
            this.grpSearchCatagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchCatagory
            // 
            this.grpSearchCatagory.Controls.Add(this.radSearchISBN);
            this.grpSearchCatagory.Controls.Add(this.radSearchAuthor);
            this.grpSearchCatagory.Controls.Add(this.radSearchTitle);
            this.grpSearchCatagory.Location = new System.Drawing.Point(295, 12);
            this.grpSearchCatagory.Name = "grpSearchCatagory";
            this.grpSearchCatagory.Size = new System.Drawing.Size(206, 50);
            this.grpSearchCatagory.TabIndex = 0;
            this.grpSearchCatagory.TabStop = false;
            this.grpSearchCatagory.Text = "Search for:";
            // 
            // radSearchISBN
            // 
            this.radSearchISBN.AutoSize = true;
            this.radSearchISBN.Location = new System.Drawing.Point(127, 20);
            this.radSearchISBN.Name = "radSearchISBN";
            this.radSearchISBN.Size = new System.Drawing.Size(50, 17);
            this.radSearchISBN.TabIndex = 2;
            this.radSearchISBN.Text = "ISBN";
            this.radSearchISBN.UseVisualStyleBackColor = true;
            // 
            // radSearchAuthor
            // 
            this.radSearchAuthor.AutoSize = true;
            this.radSearchAuthor.Location = new System.Drawing.Point(64, 20);
            this.radSearchAuthor.Name = "radSearchAuthor";
            this.radSearchAuthor.Size = new System.Drawing.Size(56, 17);
            this.radSearchAuthor.TabIndex = 1;
            this.radSearchAuthor.Text = "Author";
            this.radSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // radSearchTitle
            // 
            this.radSearchTitle.AutoSize = true;
            this.radSearchTitle.Checked = true;
            this.radSearchTitle.Location = new System.Drawing.Point(12, 20);
            this.radSearchTitle.Name = "radSearchTitle";
            this.radSearchTitle.Size = new System.Drawing.Size(45, 17);
            this.radSearchTitle.TabIndex = 0;
            this.radSearchTitle.TabStop = true;
            this.radSearchTitle.Text = "Title";
            this.radSearchTitle.UseVisualStyleBackColor = true;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(66, 26);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(200, 20);
            this.txtSearchTerm.TabIndex = 1;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(512, 25);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(111, 23);
            this.btnSeach.TabIndex = 2;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // btnAdvancedFind
            // 
            this.btnAdvancedFind.Location = new System.Drawing.Point(518, 462);
            this.btnAdvancedFind.Name = "btnAdvancedFind";
            this.btnAdvancedFind.Size = new System.Drawing.Size(111, 23);
            this.btnAdvancedFind.TabIndex = 5;
            this.btnAdvancedFind.Text = "Advanced Search...";
            this.btnAdvancedFind.UseVisualStyleBackColor = true;
            this.btnAdvancedFind.Click += new System.EventHandler(this.btnAdvancedFind_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 495);
            this.Controls.Add(this.btnAdvancedFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.grpSearchCatagory);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.grpSearchCatagory.ResumeLayout(false);
            this.grpSearchCatagory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchCatagory;
        private System.Windows.Forms.RadioButton radSearchISBN;
        private System.Windows.Forms.RadioButton radSearchAuthor;
        private System.Windows.Forms.RadioButton radSearchTitle;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdvancedFind;
    }
}