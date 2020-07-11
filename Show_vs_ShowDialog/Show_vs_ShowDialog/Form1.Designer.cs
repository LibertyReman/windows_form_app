namespace Show_vs_ShowDialog
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.AAAFormButton = new System.Windows.Forms.Button();
            this.BBBFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AAAFormButton
            // 
            this.AAAFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AAAFormButton.Location = new System.Drawing.Point(0, 0);
            this.AAAFormButton.Name = "AAAFormButton";
            this.AAAFormButton.Size = new System.Drawing.Size(384, 58);
            this.AAAFormButton.TabIndex = 0;
            this.AAAFormButton.Text = "AAAForm";
            this.AAAFormButton.UseVisualStyleBackColor = true;
            this.AAAFormButton.Click += new System.EventHandler(this.AAAFormButton_Click);
            // 
            // BBBFormButton
            // 
            this.BBBFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BBBFormButton.Location = new System.Drawing.Point(0, 58);
            this.BBBFormButton.Name = "BBBFormButton";
            this.BBBFormButton.Size = new System.Drawing.Size(384, 58);
            this.BBBFormButton.TabIndex = 1;
            this.BBBFormButton.Text = "BBBForm";
            this.BBBFormButton.UseVisualStyleBackColor = true;
            this.BBBFormButton.Click += new System.EventHandler(this.BBBFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BBBFormButton);
            this.Controls.Add(this.AAAFormButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AAAFormButton;
        private System.Windows.Forms.Button BBBFormButton;
    }
}

