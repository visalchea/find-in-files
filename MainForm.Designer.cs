namespace Find_in_Files
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnFindAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.CboFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkMatchCase = new System.Windows.Forms.CheckBox();
            this.ChkMatchWord = new System.Windows.Forms.CheckBox();
            this.ChkSubFolder = new System.Windows.Forms.CheckBox();
            this.TxtFolders = new System.Windows.Forms.TextBox();
            this.LblAddFolder = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.LvwResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtFile = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ChkExcludeHidden = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFindAll
            // 
            this.BtnFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFindAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindAll.Image")));
            this.BtnFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFindAll.Location = new System.Drawing.Point(402, 259);
            this.BtnFindAll.Name = "BtnFindAll";
            this.BtnFindAll.Size = new System.Drawing.Size(75, 23);
            this.BtnFindAll.TabIndex = 0;
            this.BtnFindAll.Text = "Find";
            this.BtnFindAll.UseVisualStyleBackColor = true;
            this.BtnFindAll.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Containing &text";
            // 
            // TxtFind
            // 
            this.TxtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFind.Location = new System.Drawing.Point(11, 27);
            this.TxtFind.Multiline = true;
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(466, 67);
            this.TxtFind.TabIndex = 4;
            this.TxtFind.Text = "substr";
            // 
            // CboFilter
            // 
            this.CboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboFilter.FormattingEnabled = true;
            this.CboFilter.Items.AddRange(new object[] {
            "*.*",
            "*.sql",
            "*.jrxml"});
            this.CboFilter.Location = new System.Drawing.Point(11, 229);
            this.CboFilter.Name = "CboFilter";
            this.CboFilter.Size = new System.Drawing.Size(466, 21);
            this.CboFilter.TabIndex = 2;
            this.CboFilter.Text = "*.jrxml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filters (separated by comma)";
            // 
            // ChkMatchCase
            // 
            this.ChkMatchCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkMatchCase.AutoSize = true;
            this.ChkMatchCase.Location = new System.Drawing.Point(345, 7);
            this.ChkMatchCase.Name = "ChkMatchCase";
            this.ChkMatchCase.Size = new System.Drawing.Size(80, 17);
            this.ChkMatchCase.TabIndex = 5;
            this.ChkMatchCase.Text = "Match case";
            this.ChkMatchCase.UseVisualStyleBackColor = true;
            // 
            // ChkMatchWord
            // 
            this.ChkMatchWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkMatchWord.AutoSize = true;
            this.ChkMatchWord.Enabled = false;
            this.ChkMatchWord.Location = new System.Drawing.Point(431, 7);
            this.ChkMatchWord.Name = "ChkMatchWord";
            this.ChkMatchWord.Size = new System.Drawing.Size(52, 17);
            this.ChkMatchWord.TabIndex = 5;
            this.ChkMatchWord.Text = "Word";
            this.ChkMatchWord.UseVisualStyleBackColor = true;
            // 
            // ChkSubFolder
            // 
            this.ChkSubFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkSubFolder.AutoSize = true;
            this.ChkSubFolder.Checked = true;
            this.ChkSubFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSubFolder.Location = new System.Drawing.Point(157, 108);
            this.ChkSubFolder.Name = "ChkSubFolder";
            this.ChkSubFolder.Size = new System.Drawing.Size(106, 17);
            this.ChkSubFolder.TabIndex = 5;
            this.ChkSubFolder.Text = "In all sub-folders";
            this.ChkSubFolder.UseVisualStyleBackColor = true;
            // 
            // TxtFolders
            // 
            this.TxtFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFolders.Location = new System.Drawing.Point(11, 128);
            this.TxtFolders.Multiline = true;
            this.TxtFolders.Name = "TxtFolders";
            this.TxtFolders.Size = new System.Drawing.Size(466, 67);
            this.TxtFolders.TabIndex = 4;
            this.TxtFolders.Text = "D:\\Code\\report-jasper";
            // 
            // LblAddFolder
            // 
            this.LblAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddFolder.AutoSize = true;
            this.LblAddFolder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LblAddFolder.Location = new System.Drawing.Point(411, 109);
            this.LblAddFolder.Name = "LblAddFolder";
            this.LblAddFolder.Size = new System.Drawing.Size(71, 13);
            this.LblAddFolder.TabIndex = 6;
            this.LblAddFolder.TabStop = true;
            this.LblAddFolder.Text = "Add Folder...";
            this.LblAddFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAddFolder_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Results";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1355, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblMsg
            // 
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(42, 17);
            this.LblMsg.Text = "Ready.";
            // 
            // LvwResult
            // 
            this.LvwResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LvwResult.FullRowSelect = true;
            this.LvwResult.Location = new System.Drawing.Point(11, 307);
            this.LvwResult.Name = "LvwResult";
            this.LvwResult.Size = new System.Drawing.Size(466, 350);
            this.LvwResult.TabIndex = 8;
            this.LvwResult.UseCompatibleStateImageBehavior = false;
            this.LvwResult.View = System.Windows.Forms.View.Details;
            this.LvwResult.SelectedIndexChanged += new System.EventHandler(this.LvwResult_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder";
            this.columnHeader2.Width = 268;
            // 
            // TxtFile
            // 
            this.TxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFile.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TxtFile.AutoIndentCharsPatterns = "";
            this.TxtFile.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.TxtFile.BackBrush = null;
            this.TxtFile.CharHeight = 15;
            this.TxtFile.CharWidth = 7;
            this.TxtFile.CommentPrefix = null;
            this.TxtFile.CurrentLineColor = System.Drawing.Color.PaleGreen;
            this.TxtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFile.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TxtFile.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.TxtFile.IsReplaceMode = false;
            this.TxtFile.Language = FastColoredTextBoxNS.Language.XML;
            this.TxtFile.LeftBracket = '<';
            this.TxtFile.LeftBracket2 = '(';
            this.TxtFile.Location = new System.Drawing.Point(3, 11);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.Paddings = new System.Windows.Forms.Padding(0);
            this.TxtFile.ReadOnly = true;
            this.TxtFile.RightBracket = '>';
            this.TxtFile.RightBracket2 = ')';
            this.TxtFile.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TxtFile.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TxtFile.ServiceColors")));
            this.TxtFile.Size = new System.Drawing.Size(846, 646);
            this.TxtFile.SourceTextBox = this.TxtFile;
            this.TxtFile.TabIndex = 10;
            this.TxtFile.TabLength = 2;
            this.TxtFile.Zoom = 100;
            this.TxtFile.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.TxtFile_TextChanged);
            // 
            // ChkExcludeHidden
            // 
            this.ChkExcludeHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkExcludeHidden.AutoSize = true;
            this.ChkExcludeHidden.Checked = true;
            this.ChkExcludeHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkExcludeHidden.Location = new System.Drawing.Point(269, 108);
            this.ChkExcludeHidden.Name = "ChkExcludeHidden";
            this.ChkExcludeHidden.Size = new System.Drawing.Size(136, 17);
            this.ChkExcludeHidden.TabIndex = 5;
            this.ChkExcludeHidden.Text = "Exclude hidden objects";
            this.ChkExcludeHidden.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnFindAll);
            this.splitContainer1.Panel1.Controls.Add(this.LvwResult);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.LblAddFolder);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ChkExcludeHidden);
            this.splitContainer1.Panel1.Controls.Add(this.CboFilter);
            this.splitContainer1.Panel1.Controls.Add(this.ChkSubFolder);
            this.splitContainer1.Panel1.Controls.Add(this.TxtFind);
            this.splitContainer1.Panel1.Controls.Add(this.ChkMatchWord);
            this.splitContainer1.Panel1.Controls.Add(this.TxtFolders);
            this.splitContainer1.Panel1.Controls.Add(this.ChkMatchCase);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtFile);
            this.splitContainer1.Size = new System.Drawing.Size(1355, 668);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 15;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Find in Files";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFile)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFindAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.ComboBox CboFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkMatchCase;
        private System.Windows.Forms.CheckBox ChkMatchWord;
        private System.Windows.Forms.CheckBox ChkSubFolder;
        private System.Windows.Forms.TextBox TxtFolders;
        private System.Windows.Forms.LinkLabel LblAddFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblMsg;
        private System.Windows.Forms.ListView LvwResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private FastColoredTextBoxNS.FastColoredTextBox TxtFile;
        private System.Windows.Forms.CheckBox ChkExcludeHidden;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

