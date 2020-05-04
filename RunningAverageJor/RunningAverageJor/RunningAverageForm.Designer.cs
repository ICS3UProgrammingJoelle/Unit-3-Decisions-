namespace RunningAverageJor
{
    partial class frmRunningAverage
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
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAverage.Location = new System.Drawing.Point(108, 215);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(176, 30);
            this.btnCalculateAverage.TabIndex = 0;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(518, 113);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(61, 93);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(374, 52);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Enter an average between 1 - 100\r\n(enter -1 to say goodbye)";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(534, 254);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(35, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "label1";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnCalculateAverage);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average                      by: Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAverage;
    }
}

