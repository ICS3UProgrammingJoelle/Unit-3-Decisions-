namespace SumOfNumbersJoelleI
{
    partial class frmSumOfNumbers
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstAddingNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(132, 89);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(143, 23);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a number";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(159, 335);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(15, 13);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "hi";
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Location = new System.Drawing.Point(327, 94);
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNumber.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(581, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstAddingNumber
            // 
            this.lstAddingNumber.FormattingEnabled = true;
            this.lstAddingNumber.Location = new System.Drawing.Point(213, 152);
            this.lstAddingNumber.Name = "lstAddingNumber";
            this.lstAddingNumber.Size = new System.Drawing.Size(286, 134);
            this.lstAddingNumber.TabIndex = 4;
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAddingNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMaxNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblEnterNumber);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum Of Numbers         by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAddingNumber;
    }
}

