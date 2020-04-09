namespace PerfectSquareWithWhileLoop
{
    partial class frmPerfectSquareWithWhileLoop
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPerfectSquare = new System.Windows.Forms.ListBox();
            this.nudEndValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(335, 84);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstPerfectSquare
            // 
            this.lstPerfectSquare.FormattingEnabled = true;
            this.lstPerfectSquare.Location = new System.Drawing.Point(232, 161);
            this.lstPerfectSquare.Name = "lstPerfectSquare";
            this.lstPerfectSquare.Size = new System.Drawing.Size(310, 147);
            this.lstPerfectSquare.TabIndex = 1;
            // 
            // nudEndValue
            // 
            this.nudEndValue.Location = new System.Drawing.Point(323, 135);
            this.nudEndValue.Name = "nudEndValue";
            this.nudEndValue.Size = new System.Drawing.Size(120, 20);
            this.nudEndValue.TabIndex = 2;
            // 
            // frmPerfectSquareWithWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudEndValue);
            this.Controls.Add(this.lstPerfectSquare);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPerfectSquareWithWhileLoop";
            this.Text = "Perfect Square With While Loop          by:  Joelle Ishimwe";
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPerfectSquare;
        private System.Windows.Forms.NumericUpDown nudEndValue;
    }
}

