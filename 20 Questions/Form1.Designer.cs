namespace _20_Questions
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
            this.startButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.introLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(80, 316);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(187, 77);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(19, 60);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionLabel.Size = new System.Drawing.Size(750, 200);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "I will try to guess your person.";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(523, 316);
            this.quitButton.Margin = new System.Windows.Forms.Padding(0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(187, 77);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(196, 193);
            this.yesButton.Margin = new System.Windows.Forms.Padding(0);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(154, 70);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(438, 193);
            this.noButton.Margin = new System.Windows.Forms.Padding(0);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(154, 70);
            this.noButton.TabIndex = 4;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(102, 47);
            this.introLabel.Margin = new System.Windows.Forms.Padding(0);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(578, 52);
            this.introLabel.TabIndex = 5;
            this.introLabel.Text = "LET\'S PLAY 20 QUESTIONS";
            this.introLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(271, 233);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.answerTextBox.MaxLength = 23;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(254, 29);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(361, 274);
            this.OKButton.Margin = new System.Windows.Forms.Padding(0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 31);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(99, 210);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(590, 23);
            this.promptLabel.TabIndex = 8;
            this.promptLabel.Text = "Think of someone, living or dead, and then press the start button.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "20 Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label promptLabel;
    }
}

