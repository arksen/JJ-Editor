namespace JJ_Editor
{
    partial class hex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hex));
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.findOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.optionsDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.stringViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.playerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.subsets = new System.Windows.Forms.ToolStripStatusLabel();
            this.offsetText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.searchDrop,
            this.optionsDrop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchDrop
            // 
            this.searchDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchDrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findOffsetToolStripMenuItem});
            this.searchDrop.Image = ((System.Drawing.Image)(resources.GetObject("searchDrop.Image")));
            this.searchDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchDrop.Name = "searchDrop";
            this.searchDrop.Size = new System.Drawing.Size(55, 22);
            this.searchDrop.Text = "Search";
            // 
            // findOffsetToolStripMenuItem
            // 
            this.findOffsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetTextBox});
            this.findOffsetToolStripMenuItem.Name = "findOffsetToolStripMenuItem";
            this.findOffsetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findOffsetToolStripMenuItem.Text = "Find Offset";
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(100, 23);
            this.offsetTextBox.TextChanged += new System.EventHandler(this.offsetTextBox_TextChanged);
            // 
            // optionsDrop
            // 
            this.optionsDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsDrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringViewToolStripMenuItem});
            this.optionsDrop.Image = ((System.Drawing.Image)(resources.GetObject("optionsDrop.Image")));
            this.optionsDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optionsDrop.Name = "optionsDrop";
            this.optionsDrop.Size = new System.Drawing.Size(62, 22);
            this.optionsDrop.Text = "Options";
            // 
            // stringViewToolStripMenuItem
            // 
            this.stringViewToolStripMenuItem.Checked = true;
            this.stringViewToolStripMenuItem.CheckOnClick = true;
            this.stringViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stringViewToolStripMenuItem.Name = "stringViewToolStripMenuItem";
            this.stringViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringViewToolStripMenuItem.Text = "String View";
            this.stringViewToolStripMenuItem.Click += new System.EventHandler(this.stringViewToolStripMenuItem_Click);
            // 
            // hexBox
            // 
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexBox.BytesPerLine = 24;
            this.hexBox.ColumnInfoVisible = true;
            this.hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hexBox.GroupSeparatorVisible = true;
            this.hexBox.GroupSize = 2;
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(0, 25);
            this.hexBox.Name = "hexBox";
            this.hexBox.SelectionBackColor = System.Drawing.Color.Red;
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(685, 569);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 4;
            this.hexBox.UseFixedBytesPerLine = true;
            this.hexBox.VScrollBarVisible = true;
            this.hexBox.SelectionStartChanged += new System.EventHandler(this.hexBox_SelectionStartChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerName,
            this.fileSize,
            this.subsets,
            this.offsetText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // playerName
            // 
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(118, 17);
            this.playerName.Text = "toolStripStatusLabel1";
            // 
            // fileSize
            // 
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(118, 17);
            this.fileSize.Text = "toolStripStatusLabel1";
            // 
            // subsets
            // 
            this.subsets.Name = "subsets";
            this.subsets.Size = new System.Drawing.Size(118, 17);
            this.subsets.Text = "toolStripStatusLabel1";
            // 
            // offsetText
            // 
            this.offsetText.Name = "offsetText";
            this.offsetText.Size = new System.Drawing.Size(0, 17);
            // 
            // hex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "hex";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "hex";
            this.Load += new System.EventHandler(this.hex_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Be.Windows.Forms.HexBox hexBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel playerName;
        private System.Windows.Forms.ToolStripStatusLabel fileSize;
        private System.Windows.Forms.ToolStripStatusLabel subsets;
        private System.Windows.Forms.ToolStripDropDownButton searchDrop;
        private System.Windows.Forms.ToolStripDropDownButton optionsDrop;
        private System.Windows.Forms.ToolStripMenuItem stringViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel offsetText;
        private System.Windows.Forms.ToolStripTextBox offsetTextBox;
    }
}