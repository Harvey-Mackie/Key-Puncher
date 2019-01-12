namespace KeyPuncherFormsApp
{
    partial class Inital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inital));
            this.btnOnline = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnOffline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnline
            // 
            this.btnOnline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnline.BackColor = System.Drawing.Color.Green;
            this.btnOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.White;
            this.btnOnline.Location = new System.Drawing.Point(165, 263);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(178, 74);
            this.btnOnline.TabIndex = 0;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(121, 93);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(600, 135);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // btnOffline
            // 
            this.btnOffline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOffline.BackColor = System.Drawing.Color.Maroon;
            this.btnOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffline.ForeColor = System.Drawing.Color.White;
            this.btnOffline.Location = new System.Drawing.Point(479, 263);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(178, 74);
            this.btnOffline.TabIndex = 3;
            this.btnOffline.Text = "Offline";
            this.btnOffline.UseVisualStyleBackColor = false;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // Inital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOffline);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnOnline);
            this.Name = "Inital";
            this.Text = "Welcome ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnOffline;
    }
}