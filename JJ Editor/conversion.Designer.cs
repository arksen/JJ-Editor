namespace JJ_Editor
{
    partial class conversion
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
            this.decimalLabel = new System.Windows.Forms.Label();
            this.decText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hexText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Location = new System.Drawing.Point(13, 13);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(44, 13);
            this.decimalLabel.TabIndex = 0;
            this.decimalLabel.Text = "Item ID:";
            // 
            // decText
            // 
            this.decText.Location = new System.Drawing.Point(67, 10);
            this.decText.MaxLength = 4;
            this.decText.Name = "decText";
            this.decText.Size = new System.Drawing.Size(224, 20);
            this.decText.TabIndex = 1;
            this.decText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex:";
            // 
            // hexText
            // 
            this.hexText.Location = new System.Drawing.Point(67, 43);
            this.hexText.MaxLength = 4;
            this.hexText.Name = "hexText";
            this.hexText.Size = new System.Drawing.Size(224, 20);
            this.hexText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 103);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hexText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decText);
            this.Controls.Add(this.decimalLabel);
            this.MaximumSize = new System.Drawing.Size(319, 142);
            this.MinimumSize = new System.Drawing.Size(319, 142);
            this.Name = "conversion";
            this.ShowIcon = false;
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.TextBox decText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hexText;
        private System.Windows.Forms.Button button1;
    }
}