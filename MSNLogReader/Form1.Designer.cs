namespace MSNLogReader
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(13, 13);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(364, 232);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(13, 270);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(364, 149);
            this.debugBox.TabIndex = 1;
            this.debugBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox debugBox;
        private System.Windows.Forms.Button button1;
    }
}

