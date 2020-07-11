namespace Show_vs_ShowDialog
{
    partial class BBBForm
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
            this.BBBTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BBBTextBox
            // 
            this.BBBTextBox.Location = new System.Drawing.Point(36, 36);
            this.BBBTextBox.Name = "BBBTextBox";
            this.BBBTextBox.Size = new System.Drawing.Size(100, 19);
            this.BBBTextBox.TabIndex = 0;
            // 
            // BBBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BBBTextBox);
            this.Name = "BBBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBBForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BBBTextBox;
    }
}