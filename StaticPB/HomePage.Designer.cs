namespace StaticPB
{
    partial class HomePage
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
            this.Title = new System.Windows.Forms.Panel();
            this.lblMinimise = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.LoginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.paneUserName = new System.Windows.Forms.Panel();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title.SuspendLayout();
            this.LoginLayout.SuspendLayout();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.paneUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Title.Controls.Add(this.lblMinimise);
            this.Title.Controls.Add(this.lblClose);
            this.Title.Location = new System.Drawing.Point(0, -1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1087, 121);
            this.Title.TabIndex = 0;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // lblMinimise
            // 
            this.lblMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimise.AutoSize = true;
            this.lblMinimise.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimise.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinimise.Location = new System.Drawing.Point(654, 0);
            this.lblMinimise.Name = "lblMinimise";
            this.lblMinimise.Size = new System.Drawing.Size(24, 35);
            this.lblMinimise.TabIndex = 0;
            this.lblMinimise.Text = "-";
            this.lblMinimise.Click += new System.EventHandler(this.lblMinimise_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClose.Location = new System.Drawing.Point(704, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 22);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // LoginLayout
            // 
            this.LoginLayout.ColumnCount = 2;
            this.LoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginLayout.Controls.Add(this.checkBox1, 1, 3);
            this.LoginLayout.Controls.Add(this.lblPassword, 0, 1);
            this.LoginLayout.Controls.Add(this.lblType, 0, 2);
            this.LoginLayout.Controls.Add(this.lblUserName, 0, 0);
            this.LoginLayout.Controls.Add(this.panelPassword, 1, 1);
            this.LoginLayout.Controls.Add(this.txtType, 1, 2);
            this.LoginLayout.Controls.Add(this.paneUserName, 1, 0);
            this.LoginLayout.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLayout.Location = new System.Drawing.Point(220, 208);
            this.LoginLayout.Name = "LoginLayout";
            this.LoginLayout.RowCount = 4;
            this.LoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginLayout.Size = new System.Drawing.Size(539, 192);
            this.LoginLayout.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkBox1.Location = new System.Drawing.Point(272, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(264, 34);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(3, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(263, 57);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblType.Location = new System.Drawing.Point(3, 114);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(263, 38);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type :";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(3, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(263, 57);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name :";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.picShow);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPassword.Location = new System.Drawing.Point(272, 60);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(264, 51);
            this.panelPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassword.Location = new System.Drawing.Point(0, 18);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 16);
            this.txtPassword.TabIndex = 0;
            // 
            // picShow
            // 
            this.picShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picShow.Image = global::StaticPB.Properties.Resources.show;
            this.picShow.Location = new System.Drawing.Point(201, 18);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(32, 15);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 6;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txtType.Location = new System.Drawing.Point(272, 123);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(121, 20);
            this.txtType.Sorted = true;
            this.txtType.TabIndex = 7;
            this.txtType.MouseLeave += new System.EventHandler(this.txtType_MouseLeave);
            // 
            // paneUserName
            // 
            this.paneUserName.Controls.Add(this.picAvailable);
            this.paneUserName.Controls.Add(this.txtUsername);
            this.paneUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneUserName.Location = new System.Drawing.Point(272, 3);
            this.paneUserName.Name = "paneUserName";
            this.paneUserName.Size = new System.Drawing.Size(264, 51);
            this.paneUserName.TabIndex = 3;
            // 
            // picAvailable
            // 
            this.picAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picAvailable.Image = global::StaticPB.Properties.Resources.show;
            this.picAvailable.Location = new System.Drawing.Point(204, 13);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(32, 15);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvailable.TabIndex = 8;
            this.picAvailable.TabStop = false;
            this.picAvailable.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsername.Location = new System.Drawing.Point(3, 12);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 16);
            this.txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(531, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 55);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(642, 426);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 55);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(414, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaticPB.Properties.Resources.pbf;
            this.pictureBox1.Location = new System.Drawing.Point(44, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(771, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LoginLayout);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.LoginLayout.ResumeLayout(false);
            this.LoginLayout.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.paneUserName.ResumeLayout(false);
            this.paneUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.TableLayoutPanel LoginLayout;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel paneUserName;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.Label lblMinimise;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox txtType;
    }
}

