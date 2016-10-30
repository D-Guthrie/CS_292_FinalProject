namespace FinalProject_Guthrie
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBooksAPI = new System.Windows.Forms.Button();
            this.radSearchOnline = new System.Windows.Forms.RadioButton();
            this.radEnterInfoManual = new System.Windows.Forms.RadioButton();
            this.btnAddBookFromAPI = new System.Windows.Forms.Button();
            this.grpEnterManually = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSeachOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEnterManually.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeachOnline
            // 
            this.grpSeachOnline.Controls.Add(this.btnAddBookFromAPI);
            this.grpSeachOnline.Controls.Add(this.btnSearchBooksAPI);
            this.grpSeachOnline.Controls.Add(this.label1);
            this.grpSeachOnline.Controls.Add(this.dataGridView1);
            this.grpSeachOnline.Controls.Add(this.textBox1);
            this.grpSeachOnline.Location = new System.Drawing.Point(4, 35);
            this.grpSeachOnline.Name = "grpSeachOnline";
            this.grpSeachOnline.Size = new System.Drawing.Size(501, 142);
            this.grpSeachOnline.TabIndex = 0;
            this.grpSeachOnline.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 57);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN:";
            // 
            // btnSearchBooksAPI
            // 
            this.btnSearchBooksAPI.Location = new System.Drawing.Point(199, 27);
            this.btnSearchBooksAPI.Name = "btnSearchBooksAPI";
            this.btnSearchBooksAPI.Size = new System.Drawing.Size(82, 39);
            this.btnSearchBooksAPI.TabIndex = 3;
            this.btnSearchBooksAPI.Text = "Search";
            this.btnSearchBooksAPI.UseVisualStyleBackColor = true;
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
            this.radEnterInfoManual.Location = new System.Drawing.Point(4, 196);
            this.radEnterInfoManual.Name = "radEnterInfoManual";
            this.radEnterInfoManual.Size = new System.Drawing.Size(175, 17);
            this.radEnterInfoManual.TabIndex = 2;
            this.radEnterInfoManual.Text = "Enter book information manually";
            this.radEnterInfoManual.UseVisualStyleBackColor = true;
            this.radEnterInfoManual.CheckedChanged += new System.EventHandler(this.radEnterInfoManual_CheckedChanged);
            // 
            // btnAddBookFromAPI
            // 
            this.btnAddBookFromAPI.Location = new System.Drawing.Point(405, 27);
            this.btnAddBookFromAPI.Name = "btnAddBookFromAPI";
            this.btnAddBookFromAPI.Size = new System.Drawing.Size(87, 39);
            this.btnAddBookFromAPI.TabIndex = 4;
            this.btnAddBookFromAPI.Text = "Add book";
            this.btnAddBookFromAPI.UseVisualStyleBackColor = true;
            // 
            // grpEnterManually
            // 
            this.grpEnterManually.Controls.Add(this.label4);
            this.grpEnterManually.Controls.Add(this.label3);
            this.grpEnterManually.Controls.Add(this.label2);
            this.grpEnterManually.Location = new System.Drawing.Point(13, 220);
            this.grpEnterManually.Name = "grpEnterManually";
            this.grpEnterManually.Size = new System.Drawing.Size(483, 301);
            this.grpEnterManually.TabIndex = 3;
            this.grpEnterManually.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author:";
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
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 533);
            this.Controls.Add(this.grpEnterManually);
            this.Controls.Add(this.radEnterInfoManual);
            this.Controls.Add(this.radSearchOnline);
            this.Controls.Add(this.grpSeachOnline);
            this.Name = "frmAddBook";
            this.Text = "Add a book";
            this.grpSeachOnline.ResumeLayout(false);
            this.grpSeachOnline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEnterManually.ResumeLayout(false);
            this.grpEnterManually.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeachOnline;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddBookFromAPI;
        private System.Windows.Forms.Button btnSearchBooksAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radSearchOnline;
        private System.Windows.Forms.RadioButton radEnterInfoManual;
        private System.Windows.Forms.GroupBox grpEnterManually;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}