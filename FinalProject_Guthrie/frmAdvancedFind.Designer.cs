namespace FinalProject_Guthrie
{
    partial class frmAdvancedFind
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
            this.lstFirstFindOp = new System.Windows.Forms.ListBox();
            this.txtFirstSearchTerm = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.lstSecondFindOp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFirstFindOp
            // 
            this.lstFirstFindOp.FormattingEnabled = true;
            this.lstFirstFindOp.Location = new System.Drawing.Point(232, 15);
            this.lstFirstFindOp.Name = "lstFirstFindOp";
            this.lstFirstFindOp.Size = new System.Drawing.Size(120, 17);
            this.lstFirstFindOp.TabIndex = 0;
            // 
            // txtFirstSearchTerm
            // 
            this.txtFirstSearchTerm.Location = new System.Drawing.Point(13, 13);
            this.txtFirstSearchTerm.Name = "txtFirstSearchTerm";
            this.txtFirstSearchTerm.Size = new System.Drawing.Size(201, 20);
            this.txtFirstSearchTerm.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(301, 139);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdvSearch.TabIndex = 3;
            this.btnAdvSearch.Text = "Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            // 
            // lstSecondFindOp
            // 
            this.lstSecondFindOp.FormattingEnabled = true;
            this.lstSecondFindOp.Location = new System.Drawing.Point(232, 49);
            this.lstSecondFindOp.Name = "lstSecondFindOp";
            this.lstSecondFindOp.Size = new System.Drawing.Size(120, 17);
            this.lstSecondFindOp.TabIndex = 4;
            // 
            // frmAdvancedFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 302);
            this.Controls.Add(this.lstSecondFindOp);
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFirstSearchTerm);
            this.Controls.Add(this.lstFirstFindOp);
            this.Name = "frmAdvancedFind";
            this.Text = "Advanced Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirstFindOp;
        private System.Windows.Forms.TextBox txtFirstSearchTerm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.ListBox lstSecondFindOp;
    }
}