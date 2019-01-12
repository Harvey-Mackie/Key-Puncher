namespace KeyPuncherFormsApp
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEventId = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblContainer = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.txtChoiceOne = new System.Windows.Forms.TextBox();
            this.lblChoiceOne = new System.Windows.Forms.Label();
            this.lblChoiceTwo = new System.Windows.Forms.Label();
            this.txtChoiceTwo = new System.Windows.Forms.TextBox();
            this.txtChoiceId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbDatabase = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgChoices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.tbDatabase.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEvents
            // 
            this.dgEvents.AllowUserToAddRows = false;
            this.dgEvents.AllowUserToDeleteRows = false;
            this.dgEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgEvents.BackgroundColor = System.Drawing.Color.Gray;
            this.dgEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Cursor = System.Windows.Forms.Cursors.No;
            this.dgEvents.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgEvents.Location = new System.Drawing.Point(6, 8);
            this.dgEvents.MultiSelect = false;
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.ReadOnly = true;
            this.dgEvents.Size = new System.Drawing.Size(754, 563);
            this.dgEvents.TabIndex = 0;
            this.dgEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEvents_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(290, 594);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(268, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEventId
            // 
            this.lblEventId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEventId.AutoSize = true;
            this.lblEventId.BackColor = System.Drawing.Color.Gray;
            this.lblEventId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventId.ForeColor = System.Drawing.Color.White;
            this.lblEventId.Location = new System.Drawing.Point(7, 125);
            this.lblEventId.Name = "lblEventId";
            this.lblEventId.Size = new System.Drawing.Size(108, 19);
            this.lblEventId.TabIndex = 2;
            this.lblEventId.Text = "Question Id";
            // 
            // txtEventId
            // 
            this.txtEventId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEventId.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventId.Location = new System.Drawing.Point(111, 125);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(451, 20);
            this.txtEventId.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(14, 594);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblContainer
            // 
            this.lblContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContainer.BackColor = System.Drawing.Color.Gray;
            this.lblContainer.Location = new System.Drawing.Point(7, 91);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(565, 575);
            this.lblContainer.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(111, 163);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(451, 118);
            this.txtText.TabIndex = 8;
            // 
            // lblText
            // 
            this.lblText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Gray;
            this.lblText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(12, 163);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(45, 19);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Text";
            // 
            // txtAdvice
            // 
            this.txtAdvice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvice.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(111, 302);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(451, 46);
            this.txtAdvice.TabIndex = 10;
            // 
            // lblAdvice
            // 
            this.lblAdvice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.BackColor = System.Drawing.Color.Gray;
            this.lblAdvice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.ForeColor = System.Drawing.Color.White;
            this.lblAdvice.Location = new System.Drawing.Point(12, 300);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(63, 19);
            this.lblAdvice.TabIndex = 9;
            this.lblAdvice.Text = "Advice";
            // 
            // txtChoiceOne
            // 
            this.txtChoiceOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChoiceOne.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceOne.Location = new System.Drawing.Point(112, 363);
            this.txtChoiceOne.Multiline = true;
            this.txtChoiceOne.Name = "txtChoiceOne";
            this.txtChoiceOne.Size = new System.Drawing.Size(451, 61);
            this.txtChoiceOne.TabIndex = 11;
            // 
            // lblChoiceOne
            // 
            this.lblChoiceOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoiceOne.AutoSize = true;
            this.lblChoiceOne.BackColor = System.Drawing.Color.Gray;
            this.lblChoiceOne.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoiceOne.ForeColor = System.Drawing.Color.White;
            this.lblChoiceOne.Location = new System.Drawing.Point(7, 361);
            this.lblChoiceOne.Name = "lblChoiceOne";
            this.lblChoiceOne.Size = new System.Drawing.Size(99, 19);
            this.lblChoiceOne.TabIndex = 12;
            this.lblChoiceOne.Text = "Choice One";
            // 
            // lblChoiceTwo
            // 
            this.lblChoiceTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoiceTwo.AutoSize = true;
            this.lblChoiceTwo.BackColor = System.Drawing.Color.Gray;
            this.lblChoiceTwo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoiceTwo.ForeColor = System.Drawing.Color.White;
            this.lblChoiceTwo.Location = new System.Drawing.Point(7, 439);
            this.lblChoiceTwo.Name = "lblChoiceTwo";
            this.lblChoiceTwo.Size = new System.Drawing.Size(99, 19);
            this.lblChoiceTwo.TabIndex = 13;
            this.lblChoiceTwo.Text = "Choice Two";
            // 
            // txtChoiceTwo
            // 
            this.txtChoiceTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChoiceTwo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceTwo.Location = new System.Drawing.Point(111, 441);
            this.txtChoiceTwo.Multiline = true;
            this.txtChoiceTwo.Name = "txtChoiceTwo";
            this.txtChoiceTwo.Size = new System.Drawing.Size(451, 66);
            this.txtChoiceTwo.TabIndex = 14;
            // 
            // txtChoiceId
            // 
            this.txtChoiceId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChoiceId.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceId.Location = new System.Drawing.Point(112, 520);
            this.txtChoiceId.Multiline = true;
            this.txtChoiceId.Name = "txtChoiceId";
            this.txtChoiceId.Size = new System.Drawing.Size(451, 22);
            this.txtChoiceId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Choice ID";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHelp.Location = new System.Drawing.Point(1292, 34);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(91, 29);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(-1, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 21);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<--";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDatabase.Controls.Add(this.tabPage1);
            this.tbDatabase.Controls.Add(this.tabPage2);
            this.tbDatabase.Location = new System.Drawing.Point(578, 69);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.SelectedIndex = 0;
            this.tbDatabase.Size = new System.Drawing.Size(793, 597);
            this.tbDatabase.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.dgEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Questions";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.dgChoices);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Choices";
            // 
            // dgChoices
            // 
            this.dgChoices.AllowUserToAddRows = false;
            this.dgChoices.AllowUserToDeleteRows = false;
            this.dgChoices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgChoices.BackgroundColor = System.Drawing.Color.Gray;
            this.dgChoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChoices.Cursor = System.Windows.Forms.Cursors.No;
            this.dgChoices.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgChoices.Location = new System.Drawing.Point(15, 4);
            this.dgChoices.MultiSelect = false;
            this.dgChoices.Name = "dgChoices";
            this.dgChoices.ReadOnly = true;
            this.dgChoices.Size = new System.Drawing.Size(754, 563);
            this.dgChoices.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 695);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtChoiceId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChoiceTwo);
            this.Controls.Add(this.lblChoiceTwo);
            this.Controls.Add(this.lblChoiceOne);
            this.Controls.Add(this.txtChoiceOne);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEventId);
            this.Controls.Add(this.lblEventId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.tbDatabase.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtAdvice;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.TextBox txtChoiceOne;
        private System.Windows.Forms.Label lblChoiceOne;
        private System.Windows.Forms.Label lblChoiceTwo;
        private System.Windows.Forms.TextBox txtChoiceTwo;
        private System.Windows.Forms.TextBox txtChoiceId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tbDatabase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgChoices;
    }
}