namespace php
{
    partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbWholeWord = new System.Windows.Forms.CheckBox();
            this.chbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chbRegexp = new System.Windows.Forms.CheckBox();
            this.chbUseWildcards = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(54, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(290, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(269, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chbWholeWord
            // 
            this.chbWholeWord.AutoSize = true;
            this.chbWholeWord.Location = new System.Drawing.Point(15, 41);
            this.chbWholeWord.Name = "chbWholeWord";
            this.chbWholeWord.Size = new System.Drawing.Size(113, 17);
            this.chbWholeWord.TabIndex = 3;
            this.chbWholeWord.Text = "Match whole word";
            this.chbWholeWord.UseVisualStyleBackColor = true;
            this.chbWholeWord.CheckedChanged += new System.EventHandler(this.chbWholeWord_CheckedChanged);
            // 
            // chbCaseSensitive
            // 
            this.chbCaseSensitive.AutoSize = true;
            this.chbCaseSensitive.Location = new System.Drawing.Point(134, 41);
            this.chbCaseSensitive.Name = "chbCaseSensitive";
            this.chbCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.chbCaseSensitive.TabIndex = 4;
            this.chbCaseSensitive.Text = "Case sensitive";
            this.chbCaseSensitive.UseVisualStyleBackColor = true;
            this.chbCaseSensitive.CheckedChanged += new System.EventHandler(this.chbCaseSensitive_CheckedChanged);
            // 
            // chbRegexp
            // 
            this.chbRegexp.AutoSize = true;
            this.chbRegexp.Location = new System.Drawing.Point(134, 60);
            this.chbRegexp.Name = "chbRegexp";
            this.chbRegexp.Size = new System.Drawing.Size(133, 17);
            this.chbRegexp.TabIndex = 6;
            this.chbRegexp.Text = "Use regular expression";
            this.chbRegexp.UseVisualStyleBackColor = true;
            this.chbRegexp.CheckedChanged += new System.EventHandler(this.chbRegexp_CheckedChanged);
            // 
            // chbUseWildcards
            // 
            this.chbUseWildcards.AutoSize = true;
            this.chbUseWildcards.Location = new System.Drawing.Point(15, 60);
            this.chbUseWildcards.Name = "chbUseWildcards";
            this.chbUseWildcards.Size = new System.Drawing.Size(92, 17);
            this.chbUseWildcards.TabIndex = 5;
            this.chbUseWildcards.Text = "Use wildcards";
            this.chbUseWildcards.UseVisualStyleBackColor = true;
            this.chbUseWildcards.CheckedChanged += new System.EventHandler(this.chbUseWildcards_CheckedChanged);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 84);
            this.Controls.Add(this.chbRegexp);
            this.Controls.Add(this.chbUseWildcards);
            this.Controls.Add(this.chbCaseSensitive);
            this.Controls.Add(this.chbWholeWord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.searchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbWholeWord;
        private System.Windows.Forms.CheckBox chbCaseSensitive;
        private System.Windows.Forms.CheckBox chbRegexp;
        private System.Windows.Forms.CheckBox chbUseWildcards;
    }
}