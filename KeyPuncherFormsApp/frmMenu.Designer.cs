namespace KeyPuncherFormsApp
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnMenuPlay = new System.Windows.Forms.Button();
            this.btnMenuScores = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblOffline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenuPlay
            // 
            this.btnMenuPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuPlay.BackColor = System.Drawing.Color.Black;
            this.btnMenuPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPlay.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPlay.Location = new System.Drawing.Point(201, 191);
            this.btnMenuPlay.Name = "btnMenuPlay";
            this.btnMenuPlay.Size = new System.Drawing.Size(438, 109);
            this.btnMenuPlay.TabIndex = 1;
            this.btnMenuPlay.Text = "Play";
            this.btnMenuPlay.UseVisualStyleBackColor = false;
            this.btnMenuPlay.Click += new System.EventHandler(this.btnMenuPlay_Click);
            // 
            // btnMenuScores
            // 
            this.btnMenuScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuScores.BackColor = System.Drawing.Color.Black;
            this.btnMenuScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuScores.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuScores.Location = new System.Drawing.Point(201, 306);
            this.btnMenuScores.Name = "btnMenuScores";
            this.btnMenuScores.Size = new System.Drawing.Size(438, 109);
            this.btnMenuScores.TabIndex = 2;
            this.btnMenuScores.Text = "Scores";
            this.btnMenuScores.UseVisualStyleBackColor = false;
            this.btnMenuScores.Click += new System.EventHandler(this.btnMenuScores_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(201, 421);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(438, 109);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log-out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(201, 72);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(438, 113);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin Page";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblOffline
            // 
            this.lblOffline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffline.Location = new System.Drawing.Point(326, 95);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(195, 32);
            this.lblOffline.TabIndex = 5;
            this.lblOffline.Text = "Offline Mode";
            this.lblOffline.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuScores);
            this.Controls.Add(this.btnMenuPlay);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenuPlay;
        private System.Windows.Forms.Button btnMenuScores;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblOffline;
    }
}