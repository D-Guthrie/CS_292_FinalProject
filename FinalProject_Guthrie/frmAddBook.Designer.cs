﻿namespace FinalProject_Guthrie
{
    partial class frmAddBook
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
            this.grpSeachOnline = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSearchBooksAPI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBNSearchAPI = new System.Windows.Forms.TextBox();
            this.radSearchOnline = new System.Windows.Forms.RadioButton();
            this.radEnterInfoManual = new System.Windows.Forms.RadioButton();
            this.grpEnterManually = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.lstSubCategories = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpTypeOfBook = new System.Windows.Forms.GroupBox();
            this.radEbook = new System.Windows.Forms.RadioButton();
            this.radPhysicalBook = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSeachOnline.SuspendLayout();
            this.grpEnterManually.SuspendLayout();
            this.grpTypeOfBook.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeachOnline
            // 
            this.grpSeachOnline.Controls.Add(this.linkLabel1);
            this.grpSeachOnline.Controls.Add(this.btnSearchBooksAPI);
            this.grpSeachOnline.Controls.Add(this.label1);
            this.grpSeachOnline.Controls.Add(this.txtISBNSearchAPI);
            this.grpSeachOnline.Location = new System.Drawing.Point(4, 35);
            this.grpSeachOnline.Name = "grpSeachOnline";
            this.grpSeachOnline.Size = new System.Drawing.Size(501, 108);
            this.grpSeachOnline.TabIndex = 0;
            this.grpSeachOnline.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(348, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "This search uses the Google Books API. For more information, click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(195, 444);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(87, 39);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSearchBooksAPI
            // 
            this.btnSearchBooksAPI.Location = new System.Drawing.Point(213, 21);
            this.btnSearchBooksAPI.Name = "btnSearchBooksAPI";
            this.btnSearchBooksAPI.Size = new System.Drawing.Size(82, 39);
            this.btnSearchBooksAPI.TabIndex = 3;
            this.btnSearchBooksAPI.Text = "Search";
            this.btnSearchBooksAPI.UseVisualStyleBackColor = true;
            this.btnSearchBooksAPI.Click += new System.EventHandler(this.btnSearchBooksAPI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN:";
            // 
            // txtISBNSearchAPI
            // 
            this.txtISBNSearchAPI.Location = new System.Drawing.Point(9, 40);
            this.txtISBNSearchAPI.Name = "txtISBNSearchAPI";
            this.txtISBNSearchAPI.Size = new System.Drawing.Size(161, 20);
            this.txtISBNSearchAPI.TabIndex = 0;
            // 
            // radSearchOnline
            // 
            this.radSearchOnline.AutoSize = true;
            this.radSearchOnline.Checked = true;
            this.radSearchOnline.Location = new System.Drawing.Point(4, 12);
            this.radSearchOnline.Name = "radSearchOnline";
            this.radSearchOnline.Size = new System.Drawing.Size(186, 17);
            this.radSearchOnline.TabIndex = 1;
            this.radSearchOnline.TabStop = true;
            this.radSearchOnline.Text = "Search for book information online";
            this.radSearchOnline.UseVisualStyleBackColor = true;
            this.radSearchOnline.CheckedChanged += new System.EventHandler(this.radSearchOnline_CheckedChanged);
            // 
            // radEnterInfoManual
            // 
            this.radEnterInfoManual.AutoSize = true;
            this.radEnterInfoManual.Location = new System.Drawing.Point(4, 161);
            this.radEnterInfoManual.Name = "radEnterInfoManual";
            this.radEnterInfoManual.Size = new System.Drawing.Size(175, 17);
            this.radEnterInfoManual.TabIndex = 2;
            this.radEnterInfoManual.Text = "Enter book information manually";
            this.radEnterInfoManual.UseVisualStyleBackColor = true;
            this.radEnterInfoManual.CheckedChanged += new System.EventHandler(this.radEnterInfoManual_CheckedChanged);
            // 
            // grpEnterManually
            // 
            this.grpEnterManually.Controls.Add(this.cboCategory);
            this.grpEnterManually.Controls.Add(this.cboLocation);
            this.grpEnterManually.Controls.Add(this.label8);
            this.grpEnterManually.Controls.Add(this.label7);
            this.grpEnterManually.Controls.Add(this.dtpDatePublished);
            this.grpEnterManually.Controls.Add(this.lstSubCategories);
            this.grpEnterManually.Controls.Add(this.label6);
            this.grpEnterManually.Controls.Add(this.grpTypeOfBook);
            this.grpEnterManually.Controls.Add(this.label5);
            this.grpEnterManually.Controls.Add(this.txtISBN);
            this.grpEnterManually.Controls.Add(this.txtAuthor);
            this.grpEnterManually.Controls.Add(this.txtTitle);
            this.grpEnterManually.Controls.Add(this.label4);
            this.grpEnterManually.Controls.Add(this.label3);
            this.grpEnterManually.Controls.Add(this.label2);
            this.grpEnterManually.Enabled = false;
            this.grpEnterManually.Location = new System.Drawing.Point(4, 184);
            this.grpEnterManually.Name = "grpEnterManually";
            this.grpEnterManually.Size = new System.Drawing.Size(483, 239);
            this.grpEnterManually.TabIndex = 3;
            this.grpEnterManually.TabStop = false;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(276, 26);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 15;
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(233, 193);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 21);
            this.cboLocation.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Published:";
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Location = new System.Drawing.Point(233, 154);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePublished.TabIndex = 11;
            // 
            // lstSubCategories
            // 
            this.lstSubCategories.FormattingEnabled = true;
            this.lstSubCategories.Location = new System.Drawing.Point(275, 69);
            this.lstSubCategories.Name = "lstSubCategories";
            this.lstSubCategories.Size = new System.Drawing.Size(120, 69);
            this.lstSubCategories.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sub-categories:";
            // 
            // grpTypeOfBook
            // 
            this.grpTypeOfBook.Controls.Add(this.radEbook);
            this.grpTypeOfBook.Controls.Add(this.radPhysicalBook);
            this.grpTypeOfBook.Location = new System.Drawing.Point(13, 132);
            this.grpTypeOfBook.Name = "grpTypeOfBook";
            this.grpTypeOfBook.Size = new System.Drawing.Size(111, 73);
            this.grpTypeOfBook.TabIndex = 8;
            this.grpTypeOfBook.TabStop = false;
            this.grpTypeOfBook.Text = "This book is a:";
            // 
            // radEbook
            // 
            this.radEbook.AutoSize = true;
            this.radEbook.Location = new System.Drawing.Point(6, 42);
            this.radEbook.Name = "radEbook";
            this.radEbook.Size = new System.Drawing.Size(56, 17);
            this.radEbook.TabIndex = 1;
            this.radEbook.TabStop = true;
            this.radEbook.Text = "Ebook";
            this.radEbook.UseVisualStyleBackColor = true;
            // 
            // radPhysicalBook
            // 
            this.radPhysicalBook.AutoSize = true;
            this.radPhysicalBook.Location = new System.Drawing.Point(6, 19);
            this.radPhysicalBook.Name = "radPhysicalBook";
            this.radPhysicalBook.Size = new System.Drawing.Size(92, 17);
            this.radPhysicalBook.TabIndex = 0;
            this.radPhysicalBook.TabStop = true;
            this.radPhysicalBook.Text = "Physical Book";
            this.radPhysicalBook.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(52, 83);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(58, 51);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(44, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(133, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.grpEnterManually);
            this.Controls.Add(this.radEnterInfoManual);
            this.Controls.Add(this.radSearchOnline);
            this.Controls.Add(this.grpSeachOnline);
            this.Name = "frmAddBook";
            this.Text = "Add a book";
            this.grpSeachOnline.ResumeLayout(false);
            this.grpSeachOnline.PerformLayout();
            this.grpEnterManually.ResumeLayout(false);
            this.grpEnterManually.PerformLayout();
            this.grpTypeOfBook.ResumeLayout(false);
            this.grpTypeOfBook.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeachOnline;
        private System.Windows.Forms.TextBox txtISBNSearchAPI;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSearchBooksAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radSearchOnline;
        private System.Windows.Forms.RadioButton radEnterInfoManual;
        private System.Windows.Forms.GroupBox grpEnterManually;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.ListBox lstSubCategories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpTypeOfBook;
        private System.Windows.Forms.RadioButton radEbook;
        private System.Windows.Forms.RadioButton radPhysicalBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
    }
}