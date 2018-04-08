namespace App
{
    partial class SpeechToText
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
            this.Enablebtn = new System.Windows.Forms.Button();
            this.Diablebtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enablebtn
            // 
            this.Enablebtn.Location = new System.Drawing.Point(36, 32);
            this.Enablebtn.Name = "Enablebtn";
            this.Enablebtn.Size = new System.Drawing.Size(75, 23);
            this.Enablebtn.TabIndex = 0;
            this.Enablebtn.Text = "Enable";
            this.Enablebtn.UseVisualStyleBackColor = true;
            this.Enablebtn.Click += new System.EventHandler(this.Enablebtn_Click);
            // 
            // Diablebtn
            // 
            this.Diablebtn.Location = new System.Drawing.Point(224, 32);
            this.Diablebtn.Name = "Diablebtn";
            this.Diablebtn.Size = new System.Drawing.Size(75, 23);
            this.Diablebtn.TabIndex = 1;
            this.Diablebtn.Text = "Disable";
            this.Diablebtn.UseVisualStyleBackColor = true;
            this.Diablebtn.Click += new System.EventHandler(this.Diablebtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 138);
            this.textBox1.TabIndex = 2;
            // 
            // SpeechToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 297);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Diablebtn);
            this.Controls.Add(this.Enablebtn);
            this.Name = "SpeechToText";
            this.Text = "SpeechToText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeechToText_FormClosing);
            this.Load += new System.EventHandler(this.SpeechToText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enablebtn;
        private System.Windows.Forms.Button Diablebtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

