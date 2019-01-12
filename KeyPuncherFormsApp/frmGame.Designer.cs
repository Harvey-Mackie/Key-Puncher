namespace KeyPuncherFormsApp
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnGameBack = new System.Windows.Forms.Button();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblReputation = new System.Windows.Forms.Label();
            this.lblVirus = new System.Windows.Forms.Label();
            this.lblReputationTitle = new System.Windows.Forms.Label();
            this.lblVirusTitle = new System.Windows.Forms.Label();
            this.lblTurnTitle = new System.Windows.Forms.Label();
            this.btnFeeback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameBack
            // 
            this.btnGameBack.BackColor = System.Drawing.Color.Black;
            this.btnGameBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameBack.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameBack.ForeColor = System.Drawing.Color.Green;
            this.btnGameBack.Location = new System.Drawing.Point(2, -1);
            this.btnGameBack.Name = "btnGameBack";
            this.btnGameBack.Size = new System.Drawing.Size(46, 22);
            this.btnGameBack.TabIndex = 0;
            this.btnGameBack.Text = "<--";
            this.btnGameBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGameBack.UseVisualStyleBackColor = false;
            this.btnGameBack.Click += new System.EventHandler(this.btnGameBack_Click);
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptionOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionOne.ForeColor = System.Drawing.Color.White;
            this.btnOptionOne.Location = new System.Drawing.Point(192, 572);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(261, 131);
            this.btnOptionOne.TabIndex = 1;
            this.btnOptionOne.Text = "Option One";
            this.btnOptionOne.UseVisualStyleBackColor = false;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOptionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptionTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionTwo.ForeColor = System.Drawing.Color.White;
            this.btnOptionTwo.Location = new System.Drawing.Point(554, 572);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(261, 131);
            this.btnOptionTwo.TabIndex = 2;
            this.btnOptionTwo.Text = "Option Two";
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.BackColor = System.Drawing.Color.Black;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblQuestion.Location = new System.Drawing.Point(192, 224);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(623, 244);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurns
            // 
            this.lblTurns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTurns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTurns.Location = new System.Drawing.Point(489, 66);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(62, 71);
            this.lblTurns.TabIndex = 5;
            this.lblTurns.Text = "0";
            this.lblTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReputation
            // 
            this.lblReputation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReputation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReputation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblReputation.Location = new System.Drawing.Point(311, 66);
            this.lblReputation.Name = "lblReputation";
            this.lblReputation.Size = new System.Drawing.Size(62, 71);
            this.lblReputation.TabIndex = 6;
            this.lblReputation.Text = "0";
            this.lblReputation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVirus
            // 
            this.lblVirus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVirus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVirus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVirus.Location = new System.Drawing.Point(658, 66);
            this.lblVirus.Name = "lblVirus";
            this.lblVirus.Size = new System.Drawing.Size(62, 71);
            this.lblVirus.TabIndex = 7;
            this.lblVirus.Text = "0";
            this.lblVirus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReputationTitle
            // 
            this.lblReputationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReputationTitle.ForeColor = System.Drawing.Color.White;
            this.lblReputationTitle.Location = new System.Drawing.Point(243, 137);
            this.lblReputationTitle.Name = "lblReputationTitle";
            this.lblReputationTitle.Size = new System.Drawing.Size(191, 71);
            this.lblReputationTitle.TabIndex = 8;
            this.lblReputationTitle.Text = "Reputation";
            this.lblReputationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVirusTitle
            // 
            this.lblVirusTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVirusTitle.ForeColor = System.Drawing.Color.White;
            this.lblVirusTitle.Location = new System.Drawing.Point(595, 137);
            this.lblVirusTitle.Name = "lblVirusTitle";
            this.lblVirusTitle.Size = new System.Drawing.Size(191, 71);
            this.lblVirusTitle.TabIndex = 9;
            this.lblVirusTitle.Text = "Virus";
            this.lblVirusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurnTitle
            // 
            this.lblTurnTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTurnTitle.ForeColor = System.Drawing.Color.White;
            this.lblTurnTitle.Location = new System.Drawing.Point(420, 137);
            this.lblTurnTitle.Name = "lblTurnTitle";
            this.lblTurnTitle.Size = new System.Drawing.Size(191, 71);
            this.lblTurnTitle.TabIndex = 10;
            this.lblTurnTitle.Text = "Turn";
            this.lblTurnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFeeback
            // 
            this.btnFeeback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeeback.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFeeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeeback.ForeColor = System.Drawing.Color.White;
            this.btnFeeback.Location = new System.Drawing.Point(460, 496);
            this.btnFeeback.Name = "btnFeeback";
            this.btnFeeback.Size = new System.Drawing.Size(91, 31);
            this.btnFeeback.TabIndex = 11;
            this.btnFeeback.Text = "Advise";
            this.btnFeeback.UseVisualStyleBackColor = false;
            this.btnFeeback.Click += new System.EventHandler(this.btnFeeback_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1035, 749);
            this.Controls.Add(this.btnFeeback);
            this.Controls.Add(this.lblTurnTitle);
            this.Controls.Add(this.lblVirusTitle);
            this.Controls.Add(this.lblReputationTitle);
            this.Controls.Add(this.lblVirus);
            this.Controls.Add(this.lblReputation);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOptionTwo);
            this.Controls.Add(this.btnOptionOne);
            this.Controls.Add(this.btnGameBack);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameBack;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblReputation;
        private System.Windows.Forms.Label lblVirus;
        private System.Windows.Forms.Label lblReputationTitle;
        private System.Windows.Forms.Label lblVirusTitle;
        private System.Windows.Forms.Label lblTurnTitle;
        private System.Windows.Forms.Button btnFeeback;
    }
}