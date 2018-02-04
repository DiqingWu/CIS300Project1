namespace CIS300Project1
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxOpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.uxSaveTounamentButton = new System.Windows.Forms.ToolStripButton();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "uxOpenFileDialog";
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFileButton,
            this.uxSaveTounamentButton});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(284, 25);
            this.uxToolStrip.TabIndex = 0;
            this.uxToolStrip.Text = "toolStrip1";
            // 
            // uxOpenFileButton
            // 
            this.uxOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("uxOpenFileButton.Image")));
            this.uxOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpenFileButton.Name = "uxOpenFileButton";
            this.uxOpenFileButton.Size = new System.Drawing.Size(61, 22);
            this.uxOpenFileButton.Text = "Open File";
            this.uxOpenFileButton.Click += new System.EventHandler(this.uxOpenFileButton_Click);
            // 
            // uxSaveTounamentButton
            // 
            this.uxSaveTounamentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxSaveTounamentButton.Enabled = false;
            this.uxSaveTounamentButton.Image = ((System.Drawing.Image)(resources.GetObject("uxSaveTounamentButton.Image")));
            this.uxSaveTounamentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxSaveTounamentButton.Name = "uxSaveTounamentButton";
            this.uxSaveTounamentButton.Size = new System.Drawing.Size(103, 22);
            this.uxSaveTounamentButton.Text = "Save Tournament";
            this.uxSaveTounamentButton.Click += new System.EventHandler(this.uxSaveTounamentButton_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox.Location = new System.Drawing.Point(12, 28);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ReadOnly = true;
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(260, 246);
            this.uxTextBox.TabIndex = 1;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxToolStrip);
            this.Name = "UserInterface";
            this.Text = "Tournament Generator";
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripButton uxOpenFileButton;
        private System.Windows.Forms.ToolStripButton uxSaveTounamentButton;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

