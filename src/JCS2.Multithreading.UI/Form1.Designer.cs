namespace JCS2.Multithreading.UI
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoThreadsBtn = new System.Windows.Forms.Button();
            this.WithThreadsBtn = new System.Windows.Forms.Button();
            this.ResposiveCheckTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoThreadsBtn
            // 
            this.NoThreadsBtn.Location = new System.Drawing.Point(184, 156);
            this.NoThreadsBtn.Name = "NoThreadsBtn";
            this.NoThreadsBtn.Size = new System.Drawing.Size(101, 49);
            this.NoThreadsBtn.TabIndex = 0;
            this.NoThreadsBtn.Text = "No Threads";
            this.NoThreadsBtn.UseVisualStyleBackColor = true;
            this.NoThreadsBtn.Click += new System.EventHandler(this.WithThreadsBtn_Click);
            // 
            // WithThreadsBtn
            // 
            this.WithThreadsBtn.Location = new System.Drawing.Point(486, 156);
            this.WithThreadsBtn.Name = "WithThreadsBtn";
            this.WithThreadsBtn.Size = new System.Drawing.Size(101, 49);
            this.WithThreadsBtn.TabIndex = 1;
            this.WithThreadsBtn.Text = "With Threads";
            this.WithThreadsBtn.UseVisualStyleBackColor = true;
            this.WithThreadsBtn.Click += new System.EventHandler(this.NoThreadsBtn_Click);
            // 
            // ResposiveCheckTextBox
            // 
            this.ResposiveCheckTextBox.Location = new System.Drawing.Point(284, 71);
            this.ResposiveCheckTextBox.Name = "ResposiveCheckTextBox";
            this.ResposiveCheckTextBox.Size = new System.Drawing.Size(200, 23);
            this.ResposiveCheckTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 285);
            this.Controls.Add(this.ResposiveCheckTextBox);
            this.Controls.Add(this.WithThreadsBtn);
            this.Controls.Add(this.NoThreadsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoThreadsBtn;
        private System.Windows.Forms.Button WithThreadsBtn;
        private System.Windows.Forms.TextBox ResposiveCheckTextBox;
    }
}
