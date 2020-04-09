namespace ChocolateBoxesJoelle
{
    partial class frmChocolateBoxes
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
            this.lblRewardStatement = new System.Windows.Forms.Label();
            this.numNumberOfSoldBoxes = new System.Windows.Forms.NumericUpDown();
            this.btnClaimReward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSoldBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRewardStatement
            // 
            this.lblRewardStatement.AutoSize = true;
            this.lblRewardStatement.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRewardStatement.Location = new System.Drawing.Point(286, 274);
            this.lblRewardStatement.Name = "lblRewardStatement";
            this.lblRewardStatement.Size = new System.Drawing.Size(69, 35);
            this.lblRewardStatement.TabIndex = 0;
            this.lblRewardStatement.Text = "label1";
            // 
            // numNumberOfSoldBoxes
            // 
            this.numNumberOfSoldBoxes.Location = new System.Drawing.Point(536, 125);
            this.numNumberOfSoldBoxes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfSoldBoxes.Name = "numNumberOfSoldBoxes";
            this.numNumberOfSoldBoxes.Size = new System.Drawing.Size(120, 23);
            this.numNumberOfSoldBoxes.TabIndex = 1;
            this.numNumberOfSoldBoxes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClaimReward
            // 
            this.btnClaimReward.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClaimReward.Location = new System.Drawing.Point(99, 110);
            this.btnClaimReward.Name = "btnClaimReward";
            this.btnClaimReward.Size = new System.Drawing.Size(183, 40);
            this.btnClaimReward.TabIndex = 2;
            this.btnClaimReward.Text = "Claim Reward";
            this.btnClaimReward.UseVisualStyleBackColor = true;
            this.btnClaimReward.Click += new System.EventHandler(this.btnClaimReward_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRewardStatement);
            this.Controls.Add(this.numNumberOfSoldBoxes);
            this.Controls.Add(this.btnClaimReward);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes    by:  Joelle Ishimwe";
            this.Load += new System.EventHandler(this.ChocolateBoxeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSoldBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRewardStatement;
        private System.Windows.Forms.NumericUpDown numNumberOfSoldBoxes;
        private System.Windows.Forms.Button btnClaimReward;
    }
}

