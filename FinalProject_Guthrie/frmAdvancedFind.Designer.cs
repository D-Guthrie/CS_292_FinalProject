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
            this.txtFirstSearchTerm = new System.Windows.Forms.TextBox();
            this.txtSecondSearchTerm = new System.Windows.Forms.TextBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.dgvAdvancedFind = new System.Windows.Forms.DataGridView();
            this.txtThirdSearchTerm = new System.Windows.Forms.TextBox();
            this.cboFirstSearchOp = new System.Windows.Forms.ComboBox();
            this.cboSecondSearchOp = new System.Windows.Forms.ComboBox();
            this.cboThirdSearchOp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedFind)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstSearchTerm
            // 
            this.txtFirstSearchTerm.Location = new System.Drawing.Point(13, 13);
            this.txtFirstSearchTerm.Name = "txtFirstSearchTerm";
            this.txtFirstSearchTerm.Size = new System.Drawing.Size(201, 20);
            this.txtFirstSearchTerm.TabIndex = 1;
            // 
            // txtSecondSearchTerm
            // 
            this.txtSecondSearchTerm.Location = new System.Drawing.Point(13, 47);
            this.txtSecondSearchTerm.Name = "txtSecondSearchTerm";
            this.txtSecondSearchTerm.Size = new System.Drawing.Size(201, 20);
            this.txtSecondSearchTerm.TabIndex = 2;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(375, 27);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(116, 58);
            this.btnAdvSearch.TabIndex = 3;
            this.btnAdvSearch.Text = "Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            // 
            // dgvAdvancedFind
            // 
            this.dgvAdvancedFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvancedFind.Location = new System.Drawing.Point(12, 140);
            this.dgvAdvancedFind.Name = "dgvAdvancedFind";
            this.dgvAdvancedFind.Size = new System.Drawing.Size(514, 198);
            this.dgvAdvancedFind.TabIndex = 5;
            // 
            // txtThirdSearchTerm
            // 
            this.txtThirdSearchTerm.Location = new System.Drawing.Point(13, 81);
            this.txtThirdSearchTerm.Name = "txtThirdSearchTerm";
            this.txtThirdSearchTerm.Size = new System.Drawing.Size(201, 20);
            this.txtThirdSearchTerm.TabIndex = 6;
            // 
            // cboFirstSearchOp
            // 
            this.cboFirstSearchOp.FormattingEnabled = true;
            this.cboFirstSearchOp.Location = new System.Drawing.Point(221, 13);
            this.cboFirstSearchOp.Name = "cboFirstSearchOp";
            this.cboFirstSearchOp.Size = new System.Drawing.Size(121, 21);
            this.cboFirstSearchOp.TabIndex = 7;
            // 
            // cboSecondSearchOp
            // 
            this.cboSecondSearchOp.FormattingEnabled = true;
            this.cboSecondSearchOp.Location = new System.Drawing.Point(221, 47);
            this.cboSecondSearchOp.Name = "cboSecondSearchOp";
            this.cboSecondSearchOp.Size = new System.Drawing.Size(121, 21);
            this.cboSecondSearchOp.TabIndex = 8;
            // 
            // cboThirdSearchOp
            // 
            this.cboThirdSearchOp.FormattingEnabled = true;
            this.cboThirdSearchOp.Location = new System.Drawing.Point(221, 81);
            this.cboThirdSearchOp.Name = "cboThirdSearchOp";
            this.cboThirdSearchOp.Size = new System.Drawing.Size(121, 21);
            this.cboThirdSearchOp.TabIndex = 9;
            // 
            // frmAdvancedFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 350);
            this.Controls.Add(this.cboThirdSearchOp);
            this.Controls.Add(this.cboSecondSearchOp);
            this.Controls.Add(this.cboFirstSearchOp);
            this.Controls.Add(this.txtThirdSearchTerm);
            this.Controls.Add(this.dgvAdvancedFind);
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.txtSecondSearchTerm);
            this.Controls.Add(this.txtFirstSearchTerm);
            this.Name = "frmAdvancedFind";
            this.Text = "Advanced Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstSearchTerm;
        private System.Windows.Forms.TextBox txtSecondSearchTerm;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.DataGridView dgvAdvancedFind;
        private System.Windows.Forms.TextBox txtThirdSearchTerm;
        private System.Windows.Forms.ComboBox cboFirstSearchOp;
        private System.Windows.Forms.ComboBox cboSecondSearchOp;
        private System.Windows.Forms.ComboBox cboThirdSearchOp;
    }
}