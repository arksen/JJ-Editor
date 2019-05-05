namespace JJ_Editor
{
    partial class Player
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.appearanceGroup = new System.Windows.Forms.GroupBox();
            this.checkBoxFancy = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.feetText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.legsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chestText = new System.Windows.Forms.TextBox();
            this.helmText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.characteristicsBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toneBox = new System.Windows.Forms.ComboBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.healthBox = new System.Windows.Forms.NumericUpDown();
            this.NaN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hexBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.appearanceGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.characteristicsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem2});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Close";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveToolStripMenuItem2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 264);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.appearanceGroup);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(491, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // appearanceGroup
            // 
            this.appearanceGroup.Controls.Add(this.checkBoxFancy);
            this.appearanceGroup.Controls.Add(this.label6);
            this.appearanceGroup.Controls.Add(this.feetText);
            this.appearanceGroup.Controls.Add(this.label5);
            this.appearanceGroup.Controls.Add(this.legsText);
            this.appearanceGroup.Controls.Add(this.label4);
            this.appearanceGroup.Controls.Add(this.chestText);
            this.appearanceGroup.Controls.Add(this.helmText);
            this.appearanceGroup.Controls.Add(this.label3);
            this.appearanceGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.appearanceGroup.Location = new System.Drawing.Point(251, 3);
            this.appearanceGroup.Name = "appearanceGroup";
            this.appearanceGroup.Size = new System.Drawing.Size(237, 232);
            this.appearanceGroup.TabIndex = 1;
            this.appearanceGroup.TabStop = false;
            this.appearanceGroup.Text = "Equipment";
            // 
            // checkBoxFancy
            // 
            this.checkBoxFancy.AutoSize = true;
            this.checkBoxFancy.Location = new System.Drawing.Point(55, 125);
            this.checkBoxFancy.Name = "checkBoxFancy";
            this.checkBoxFancy.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFancy.TabIndex = 13;
            this.checkBoxFancy.Text = "Fancy Armor";
            this.checkBoxFancy.UseVisualStyleBackColor = true;
            this.checkBoxFancy.CheckedChanged += new System.EventHandler(this.checkBoxFancy_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Feet:";
            // 
            // feetText
            // 
            this.feetText.Location = new System.Drawing.Point(55, 99);
            this.feetText.MaxLength = 25;
            this.feetText.Name = "feetText";
            this.feetText.Size = new System.Drawing.Size(160, 20);
            this.feetText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Legs:";
            // 
            // legsText
            // 
            this.legsText.Location = new System.Drawing.Point(55, 72);
            this.legsText.MaxLength = 25;
            this.legsText.Name = "legsText";
            this.legsText.Size = new System.Drawing.Size(160, 20);
            this.legsText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chest:";
            // 
            // chestText
            // 
            this.chestText.Location = new System.Drawing.Point(55, 45);
            this.chestText.MaxLength = 25;
            this.chestText.Name = "chestText";
            this.chestText.Size = new System.Drawing.Size(160, 20);
            this.chestText.TabIndex = 6;
            // 
            // helmText
            // 
            this.helmText.Location = new System.Drawing.Point(55, 19);
            this.helmText.MaxLength = 25;
            this.helmText.Name = "helmText";
            this.helmText.Size = new System.Drawing.Size(160, 20);
            this.helmText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Helmet:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.characteristicsBox);
            this.groupBox1.Controls.Add(this.healthBox);
            this.groupBox1.Controls.Add(this.NaN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // characteristicsBox
            // 
            this.characteristicsBox.Controls.Add(this.label12);
            this.characteristicsBox.Controls.Add(this.toneBox);
            this.characteristicsBox.Controls.Add(this.colorBox);
            this.characteristicsBox.Controls.Add(this.styleBox);
            this.characteristicsBox.Controls.Add(this.label11);
            this.characteristicsBox.Controls.Add(this.label10);
            this.characteristicsBox.Controls.Add(this.label9);
            this.characteristicsBox.Controls.Add(this.genderBox);
            this.characteristicsBox.Location = new System.Drawing.Point(9, 94);
            this.characteristicsBox.Name = "characteristicsBox";
            this.characteristicsBox.Size = new System.Drawing.Size(226, 132);
            this.characteristicsBox.TabIndex = 7;
            this.characteristicsBox.TabStop = false;
            this.characteristicsBox.Text = "Characteristics";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Skin tone:";
            // 
            // toneBox
            // 
            this.toneBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneBox.FormattingEnabled = true;
            this.toneBox.Location = new System.Drawing.Point(67, 46);
            this.toneBox.Name = "toneBox";
            this.toneBox.Size = new System.Drawing.Size(121, 21);
            this.toneBox.TabIndex = 15;
            // 
            // colorBox
            // 
            this.colorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(67, 100);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 21);
            this.colorBox.TabIndex = 14;
            // 
            // styleBox
            // 
            this.styleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Location = new System.Drawing.Point(67, 73);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 21);
            this.styleBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Hair color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hair style:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender:";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(67, 19);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 21);
            this.genderBox.TabIndex = 0;
            // 
            // healthBox
            // 
            this.healthBox.Location = new System.Drawing.Point(47, 47);
            this.healthBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(160, 20);
            this.healthBox.TabIndex = 6;
            // 
            // NaN
            // 
            this.NaN.AutoSize = true;
            this.NaN.Location = new System.Drawing.Point(47, 71);
            this.NaN.Name = "NaN";
            this.NaN.Size = new System.Drawing.Size(71, 17);
            this.NaN.TabIndex = 4;
            this.NaN.Text = "Invincible";
            this.NaN.UseVisualStyleBackColor = true;
            this.NaN.CheckedChanged += new System.EventHandler(this.NaN_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Health:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(47, 19);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(160, 20);
            this.nameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Controls.Add(this.itemList);
            this.groupBox3.Controls.Add(this.itemBox);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 232);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(374, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(306, 44);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(172, 95);
            this.itemList.TabIndex = 7;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // itemBox
            // 
            this.itemBox.Enabled = false;
            this.itemBox.Location = new System.Drawing.Point(306, 17);
            this.itemBox.MaxLength = 25;
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(172, 20);
            this.itemBox.TabIndex = 6;
            this.itemBox.TextChanged += new System.EventHandler(this.itemBox_TextChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(321, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Max";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Amount:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(321, 147);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(157, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item:";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(259, 213);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hexBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(491, 238);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raw Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hexBox
            // 
            this.hexBox.BackColor = System.Drawing.SystemColors.Window;
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hexBox.Location = new System.Drawing.Point(0, 0);
            this.hexBox.Name = "hexBox";
            this.hexBox.ReadOnly = true;
            this.hexBox.Size = new System.Drawing.Size(491, 238);
            this.hexBox.TabIndex = 0;
            this.hexBox.Text = "hawefbkqawefyobqefbhfuyewrbyhqegby";
            this.hexBox.WordWrap = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 288);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(515, 600);
            this.MinimumSize = new System.Drawing.Size(515, 308);
            this.Name = "Player";
            this.ShowIcon = false;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_FormClosing);
            this.Load += new System.EventHandler(this.Player_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.appearanceGroup.ResumeLayout(false);
            this.appearanceGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.characteristicsBox.ResumeLayout(false);
            this.characteristicsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox appearanceGroup;
        private System.Windows.Forms.CheckBox checkBoxFancy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox feetText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox legsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chestText;
        private System.Windows.Forms.TextBox helmText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox NaN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NumericUpDown healthBox;
        private System.Windows.Forms.GroupBox characteristicsBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox toneBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox hexBox;
    }
}