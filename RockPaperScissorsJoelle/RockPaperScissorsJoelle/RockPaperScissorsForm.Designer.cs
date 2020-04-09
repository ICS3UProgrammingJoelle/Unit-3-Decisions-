namespace RockPaperScissorsJoelle
{
    partial class frmRockPaperScissors
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
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblWinLoseTieStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPlayerRock.Location = new System.Drawing.Point(517, 70);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(62, 25);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPlayerPaper.Location = new System.Drawing.Point(517, 123);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(68, 25);
            this.radPlayerPaper.TabIndex = 1;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPlayerScissors.Location = new System.Drawing.Point(517, 176);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(84, 25);
            this.radPlayerScissors.TabIndex = 2;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayGame.Location = new System.Drawing.Point(239, 270);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(252, 73);
            this.btnPlayGame.TabIndex = 3;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sitka Banner", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(362, 53);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to the Game :)";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChoose.Location = new System.Drawing.Point(469, 31);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(168, 23);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Choose one of the options";
            this.lblChoose.Click += new System.EventHandler(this.lblChoose_Click);
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(142, 129);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 19);
            this.radComputerRock.TabIndex = 6;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(142, 181);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(55, 19);
            this.radComputerPaper.TabIndex = 6;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(142, 229);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(66, 19);
            this.radComputerScissors.TabIndex = 6;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerChoice.Location = new System.Drawing.Point(90, 88);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(189, 23);
            this.lblComputerChoice.TabIndex = 7;
            this.lblComputerChoice.Text = "This is the computer\'s choice";
            // 
            // lblWinLoseTieStatement
            // 
            this.lblWinLoseTieStatement.AutoSize = true;
            this.lblWinLoseTieStatement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWinLoseTieStatement.Location = new System.Drawing.Point(295, 366);
            this.lblWinLoseTieStatement.Name = "lblWinLoseTieStatement";
            this.lblWinLoseTieStatement.Size = new System.Drawing.Size(0, 30);
            this.lblWinLoseTieStatement.TabIndex = 8;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWinLoseTieStatement);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.radComputerPaper);
            this.Controls.Add(this.radComputerRock);
            this.Controls.Add(this.radComputerScissors);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.radPlayerScissors);
            this.Controls.Add(this.radPlayerPaper);
            this.Controls.Add(this.radPlayerRock);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors     by: Joelle Ishimwe";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblWinLoseTieStatement;
    }
}

