namespace FactorialJoelle
{
    partial class frmFactorial
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
            this.prbProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblFactorialAnwer = new System.Windows.Forms.Label();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblClickStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prbProgressBar
            // 
            this.prbProgressBar.Location = new System.Drawing.Point(245, 302);
            this.prbProgressBar.Name = "prbProgressBar";
            this.prbProgressBar.Size = new System.Drawing.Size(266, 39);
            this.prbProgressBar.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(476, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.ItemHeight = 15;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(57, 49);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(235, 139);
            this.lstFactorialNumbers.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(461, 94);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 23);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // lblFactorialAnwer
            // 
            this.lblFactorialAnwer.AutoSize = true;
            this.lblFactorialAnwer.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFactorialAnwer.Location = new System.Drawing.Point(312, 359);
            this.lblFactorialAnwer.Name = "lblFactorialAnwer";
            this.lblFactorialAnwer.Size = new System.Drawing.Size(43, 17);
            this.lblFactorialAnwer.TabIndex = 5;
            this.lblFactorialAnwer.Text = "label2";
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterNumber.Location = new System.Drawing.Point(384, 49);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(269, 35);
            this.lblEnterNumber.TabIndex = 6;
            this.lblEnterNumber.Text = "Please, enter any number ";
            // 
            // lblClickStart
            // 
            this.lblClickStart.AutoSize = true;
            this.lblClickStart.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClickStart.Location = new System.Drawing.Point(356, 142);
            this.lblClickStart.Name = "lblClickStart";
            this.lblClickStart.Size = new System.Drawing.Size(324, 21);
            this.lblClickStart.TabIndex = 7;
            this.lblClickStart.Text = "Click \"Start\" to have that number in a factorial form";
            // 
            // frmFactorial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.lblFactorialAnwer);
            this.Controls.Add(this.prbProgressBar);
            this.Controls.Add(this.lblClickStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Name = "frmFactorial";
            this.Text = "Factorial       by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgressBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblFactorialAnwer;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblClickStart;
    }
}

