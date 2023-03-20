namespace EZStrongDesktop
{
    partial class Form1
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
            this.genButton = new System.Windows.Forms.Button();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.shortCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            this.randCheck = new System.Windows.Forms.CheckBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingEZStrongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherVersionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(216, 46);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(103, 36);
            this.genButton.TabIndex = 0;
            this.genButton.Text = "Generate!";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // wordBox
            // 
            this.wordBox.Location = new System.Drawing.Point(15, 62);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(150, 20);
            this.wordBox.TabIndex = 1;
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(15, 112);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(150, 20);
            this.numBox.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(216, 112);
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.Size = new System.Drawing.Size(156, 20);
            this.passBox.TabIndex = 3;
            // 
            // shortCheck
            // 
            this.shortCheck.AutoSize = true;
            this.shortCheck.Location = new System.Drawing.Point(15, 152);
            this.shortCheck.Name = "shortCheck";
            this.shortCheck.Size = new System.Drawing.Size(190, 17);
            this.shortCheck.TabIndex = 4;
            this.shortCheck.Text = "Short Passwords (8 character max)";
            this.shortCheck.UseVisualStyleBackColor = true;
            this.shortCheck.CheckedChanged += new System.EventHandler(this.shortCheck_CheckedChanged);
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Location = new System.Drawing.Point(15, 175);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(132, 17);
            this.specialCheck.TabIndex = 5;
            this.specialCheck.Text = "No Special Characters";
            this.specialCheck.UseVisualStyleBackColor = true;
            this.specialCheck.CheckedChanged += new System.EventHandler(this.specialCheck_CheckedChanged);
            // 
            // randCheck
            // 
            this.randCheck.AutoSize = true;
            this.randCheck.Location = new System.Drawing.Point(15, 198);
            this.randCheck.Name = "randCheck";
            this.randCheck.Size = new System.Drawing.Size(330, 17);
            this.randCheck.TabIndex = 6;
            this.randCheck.Text = "Full Random Generation (more secure, but cannot be recovered)";
            this.randCheck.UseVisualStyleBackColor = true;
            this.randCheck.CheckedChanged += new System.EventHandler(this.randCheck_CheckedChanged);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(12, 46);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(182, 13);
            this.wordLabel.TabIndex = 7;
            this.wordLabel.Text = "Enter Keyword (6 or more characters)";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(12, 96);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(102, 13);
            this.numLabel.TabIndex = 8;
            this.numLabel.Text = "Enter Number (0 - 9)";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(213, 96);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(106, 13);
            this.passLabel.TabIndex = 9;
            this.passLabel.Text = "Generated Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.supportUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingEZStrongToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usingEZStrongToolStripMenuItem
            // 
            this.usingEZStrongToolStripMenuItem.Name = "usingEZStrongToolStripMenuItem";
            this.usingEZStrongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usingEZStrongToolStripMenuItem.Text = "Using EZStrong";
            this.usingEZStrongToolStripMenuItem.Click += new System.EventHandler(this.usingEZStrongToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // supportUsToolStripMenuItem
            // 
            this.supportUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherVersionsToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.supportUsToolStripMenuItem.Name = "supportUsToolStripMenuItem";
            this.supportUsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.supportUsToolStripMenuItem.Text = "Support Us!";
            // 
            // otherVersionsToolStripMenuItem
            // 
            this.otherVersionsToolStripMenuItem.Name = "otherVersionsToolStripMenuItem";
            this.otherVersionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherVersionsToolStripMenuItem.Text = "Other Versions";
            this.otherVersionsToolStripMenuItem.Click += new System.EventHandler(this.otherVersionsToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.randCheck);
            this.Controls.Add(this.specialCheck);
            this.Controls.Add(this.shortCheck);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZStrong Password Generator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.CheckBox shortCheck;
        private System.Windows.Forms.CheckBox specialCheck;
        private System.Windows.Forms.CheckBox randCheck;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingEZStrongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherVersionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
    }
}

