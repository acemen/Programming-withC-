namespace RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHuman = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.humanChoiceTxtBox = new System.Windows.Forms.Label();
            this.computerChoiceTxtBox = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.humanScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHuman
            // 
            this.labelHuman.AutoSize = true;
            this.labelHuman.BackColor = System.Drawing.Color.Transparent;
            this.labelHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuman.ForeColor = System.Drawing.Color.Green;
            this.labelHuman.Location = new System.Drawing.Point(51, 33);
            this.labelHuman.Name = "labelHuman";
            this.labelHuman.Size = new System.Drawing.Size(85, 25);
            this.labelHuman.TabIndex = 7;
            this.labelHuman.Text = "Human";
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.BackColor = System.Drawing.Color.Transparent;
            this.labelComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputer.ForeColor = System.Drawing.Color.Red;
            this.labelComputer.Location = new System.Drawing.Point(303, 33);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(113, 25);
            this.labelComputer.TabIndex = 8;
            this.labelComputer.Text = "Computer";
            // 
            // humanChoiceTxtBox
            // 
            this.humanChoiceTxtBox.AutoSize = true;
            this.humanChoiceTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.humanChoiceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanChoiceTxtBox.ForeColor = System.Drawing.Color.White;
            this.humanChoiceTxtBox.Location = new System.Drawing.Point(51, 138);
            this.humanChoiceTxtBox.Name = "humanChoiceTxtBox";
            this.humanChoiceTxtBox.Size = new System.Drawing.Size(142, 25);
            this.humanChoiceTxtBox.TabIndex = 9;
            this.humanChoiceTxtBox.Text = "Your Choice";
            // 
            // computerChoiceTxtBox
            // 
            this.computerChoiceTxtBox.AutoSize = true;
            this.computerChoiceTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.computerChoiceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceTxtBox.ForeColor = System.Drawing.Color.White;
            this.computerChoiceTxtBox.Location = new System.Drawing.Point(51, 294);
            this.computerChoiceTxtBox.Name = "computerChoiceTxtBox";
            this.computerChoiceTxtBox.Size = new System.Drawing.Size(193, 25);
            this.computerChoiceTxtBox.TabIndex = 10;
            this.computerChoiceTxtBox.Text = "Computer Choice";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // humanScoreLabel
            // 
            this.humanScoreLabel.AutoSize = true;
            this.humanScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanScoreLabel.Location = new System.Drawing.Point(185, 33);
            this.humanScoreLabel.Name = "humanScoreLabel";
            this.humanScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.humanScoreLabel.TabIndex = 12;
            this.humanScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.computerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLabel.Location = new System.Drawing.Point(473, 33);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.computerScoreLabel.TabIndex = 13;
            this.computerScoreLabel.Text = "0";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.BackColor = System.Drawing.Color.Transparent;
            this.labelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraw.ForeColor = System.Drawing.Color.White;
            this.labelDraw.Location = new System.Drawing.Point(586, 33);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(65, 25);
            this.labelDraw.TabIndex = 14;
            this.labelDraw.Text = "Draw";
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.Location = new System.Drawing.Point(709, 33);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(25, 25);
            this.drawLabel.TabIndex = 15;
            this.drawLabel.Text = "0";
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(553, 259);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(181, 110);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(553, 89);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(181, 110);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(330, 175);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(181, 110);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRock.UseMnemonic = false;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 446);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.humanScoreLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.computerChoiceTxtBox);
            this.Controls.Add(this.humanChoiceTxtBox);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.labelHuman);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Label labelHuman;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Label humanChoiceTxtBox;
        private System.Windows.Forms.Label computerChoiceTxtBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label humanScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label drawLabel;
    }
}

