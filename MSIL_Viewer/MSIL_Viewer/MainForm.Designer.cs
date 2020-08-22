namespace MSIL_Viewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startTextBox = new System.Windows.Forms.RichTextBox();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(12, 29);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(281, 342);
            this.startTextBox.TabIndex = 0;
            this.startTextBox.Text = "";
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.Location = new System.Drawing.Point(299, 29);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(281, 342);
            this.resultBox.TabIndex = 1;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(213, 377);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(167, 31);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "CONVERT";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(597, 414);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.startTextBox);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MSIL-Converter";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button convertBtn;

        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.RichTextBox startTextBox;

        #endregion
    }
}