namespace ForEachWithControlObjectsJoelle
{
    partial class frmForEachWithControlObjects
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.Button();
            this.nudNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chbCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(67, 43);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(211, 46);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Welcome!";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.Location = new System.Drawing.Point(541, 107);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(110, 32);
            this.btnButton.TabIndex = 2;
            this.btnButton.Text = "Click Me";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // nudNumericUpDown
            // 
            this.nudNumericUpDown.Location = new System.Drawing.Point(209, 153);
            this.nudNumericUpDown.Name = "nudNumericUpDown";
            this.nudNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nudNumericUpDown.TabIndex = 3;
            this.nudNumericUpDown.ValueChanged += new System.EventHandler(this.nudNumericUpDown_ValueChanged);
            // 
            // chbCheckBox
            // 
            this.chbCheckBox.AutoSize = true;
            this.chbCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCheckBox.Location = new System.Drawing.Point(185, 267);
            this.chbCheckBox.Name = "chbCheckBox";
            this.chbCheckBox.Size = new System.Drawing.Size(405, 83);
            this.chbCheckBox.TabIndex = 4;
            this.chbCheckBox.Text = "Check me!";
            this.chbCheckBox.UseVisualStyleBackColor = true;
            this.chbCheckBox.CheckedChanged += new System.EventHandler(this.chbCheckBox_CheckedChanged);
            // 
            // frmForEachWithControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbCheckBox);
            this.Controls.Add(this.nudNumericUpDown);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.lblLabel);
            this.Name = "frmForEachWithControlObjects";
            this.Text = "For... Each with Control Objects            by:  Joelle Ishimwe";
            this.Load += new System.EventHandler(this.frmForEachWithControlObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.NumericUpDown nudNumericUpDown;
        private System.Windows.Forms.CheckBox chbCheckBox;
    }
}

