﻿namespace WinForm
{
    partial class UserSaveForm
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox = new System.Windows.Forms.CheckBox();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BusinessRadioButton = new System.Windows.Forms.RadioButton();
            this.FreeRadioButton = new System.Windows.Forms.RadioButton();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.EnableComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(22, 19);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 12);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            this.IdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(62, 16);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 19);
            this.IdTextBox.TabIndex = 1;
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Location = new System.Drawing.Point(24, 53);
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Size = new System.Drawing.Size(104, 16);
            this.MailCheckBox.TabIndex = 2;
            this.MailCheckBox.Text = "メールを送信する";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.MailCheckBox_CheckedChanged);
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(97, 75);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(100, 19);
            this.MailAddressTextBox.TabIndex = 4;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(22, 78);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 3;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusinessRadioButton);
            this.groupBox1.Controls.Add(this.FreeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "プラン";
            // 
            // BusinessRadioButton
            // 
            this.BusinessRadioButton.AutoSize = true;
            this.BusinessRadioButton.Location = new System.Drawing.Point(101, 29);
            this.BusinessRadioButton.Name = "BusinessRadioButton";
            this.BusinessRadioButton.Size = new System.Drawing.Size(60, 16);
            this.BusinessRadioButton.TabIndex = 1;
            this.BusinessRadioButton.TabStop = true;
            this.BusinessRadioButton.Text = "ビジネス";
            this.BusinessRadioButton.UseVisualStyleBackColor = true;
            this.BusinessRadioButton.CheckedChanged += new System.EventHandler(this.BusinessRadioButton_CheckedChanged);
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(7, 29);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "無料";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(31, 189);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(91, 12);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "無制限で使えます";
            // 
            // EnableComboBox
            // 
            this.EnableComboBox.FormattingEnabled = true;
            this.EnableComboBox.Location = new System.Drawing.Point(24, 216);
            this.EnableComboBox.Name = "EnableComboBox";
            this.EnableComboBox.Size = new System.Drawing.Size(121, 20);
            this.EnableComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 36);
            this.panel1.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 36);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseButton.Location = new System.Drawing.Point(75, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 36);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(433, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // UserSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EnableComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Name = "UserSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザ登録";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BusinessRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox EnableComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

