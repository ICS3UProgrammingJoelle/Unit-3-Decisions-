namespace GuessNumberJoelle
{
    partial class frmGuessNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheckSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(531, 303);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(15, 13);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "hi";
            this.lblAnswer.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnCheckSize
            // 
            this.btnCheckSize.Location = new System.Drawing.Point(166, 303);
            this.btnCheckSize.Name = "btnCheckSize";
            this.btnCheckSize.Size = new System.Drawing.Size(75, 23);
            this.btnCheckSize.TabIndex = 4;
            this.btnCheckSize.Text = "Check Size";
            this.btnCheckSize.UseVisualStyleBackColor = true;
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.Name = "frmGuessNumber";
            this.Text = "Guess My Number     By: Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheckSize;
    }
}

