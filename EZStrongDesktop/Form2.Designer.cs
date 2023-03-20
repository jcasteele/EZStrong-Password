namespace EZStrongDesktop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.f2CloseButton = new System.Windows.Forms.Button();
            this.instructionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // f2CloseButton
            // 
            this.f2CloseButton.Location = new System.Drawing.Point(190, 280);
            this.f2CloseButton.Name = "f2CloseButton";
            this.f2CloseButton.Size = new System.Drawing.Size(75, 23);
            this.f2CloseButton.TabIndex = 0;
            this.f2CloseButton.Text = "Close";
            this.f2CloseButton.UseVisualStyleBackColor = true;
            this.f2CloseButton.Click += new System.EventHandler(this.f2CloseButton_Click);
            // 
            // instructionBox
            // 
            this.instructionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.instructionBox.Location = new System.Drawing.Point(13, 13);
            this.instructionBox.Name = "instructionBox";
            this.instructionBox.Size = new System.Drawing.Size(431, 261);
            this.instructionBox.TabIndex = 1;
            this.instructionBox.Text = resources.GetString("instructionBox.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 315);
            this.ControlBox = false;
            this.Controls.Add(this.instructionBox);
            this.Controls.Add(this.f2CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using EZStrong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button f2CloseButton;
        private System.Windows.Forms.RichTextBox instructionBox;
    }
}