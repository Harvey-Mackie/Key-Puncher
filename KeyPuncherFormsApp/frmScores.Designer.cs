namespace KeyPuncherFormsApp
{
    partial class frmScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScores));
            this.btnScoresBack = new System.Windows.Forms.Button();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblScoreId = new System.Windows.Forms.Label();
            this.lblScoreUsername = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScoresBack
            // 
            this.btnScoresBack.BackColor = System.Drawing.Color.Black;
            this.btnScoresBack.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoresBack.ForeColor = System.Drawing.Color.Green;
            this.btnScoresBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScoresBack.Location = new System.Drawing.Point(0, -1);
            this.btnScoresBack.Name = "btnScoresBack";
            this.btnScoresBack.Size = new System.Drawing.Size(53, 22);
            this.btnScoresBack.TabIndex = 1;
            this.btnScoresBack.Text = "<--";
            this.btnScoresBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScoresBack.UseVisualStyleBackColor = false;
            this.btnScoresBack.Click += new System.EventHandler(this.btnScoresBack_Click);
            // 
            // lblHighScores
            // 
            this.lblHighScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHighScores.BackColor = System.Drawing.Color.Black;
            this.lblHighScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighScores.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHighScores.Location = new System.Drawing.Point(151, 198);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(718, 559);
            this.lblHighScores.TabIndex = 3;
            this.lblHighScores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreId
            // 
            this.lblScoreId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScoreId.BackColor = System.Drawing.Color.Black;
            this.lblScoreId.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScoreId.Location = new System.Drawing.Point(152, 207);
            this.lblScoreId.Name = "lblScoreId";
            this.lblScoreId.Size = new System.Drawing.Size(232, 546);
            this.lblScoreId.TabIndex = 4;
            this.lblScoreId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreUsername
            // 
            this.lblScoreUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScoreUsername.BackColor = System.Drawing.Color.Black;
            this.lblScoreUsername.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScoreUsername.Location = new System.Drawing.Point(390, 207);
            this.lblScoreUsername.Name = "lblScoreUsername";
            this.lblScoreUsername.Size = new System.Drawing.Size(263, 546);
            this.lblScoreUsername.TabIndex = 5;
            this.lblScoreUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScoreValue.BackColor = System.Drawing.Color.Black;
            this.lblScoreValue.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScoreValue.Location = new System.Drawing.Point(654, 207);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(210, 546);
            this.lblScoreValue.TabIndex = 6;
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1035, 856);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScoreUsername);
            this.Controls.Add(this.lblScoreId);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.btnScoresBack);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmScores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScoresBack;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblScoreId;
        private System.Windows.Forms.Label lblScoreUsername;
        private System.Windows.Forms.Label lblScoreValue;
    }
}