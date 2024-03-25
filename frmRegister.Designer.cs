namespace Assignment_Project
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.username = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.usernameChk = new System.Windows.Forms.Label();
            this.passwordChk = new System.Windows.Forms.Label();
            this.ckbPassShow = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confPass = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Rubik", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DarkGray;
            this.username.Location = new System.Drawing.Point(131, 165);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(323, 35);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(211)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(131, 459);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(323, 45);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usernameChk
            // 
            this.usernameChk.AutoSize = true;
            this.usernameChk.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameChk.Location = new System.Drawing.Point(127, 202);
            this.usernameChk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameChk.Name = "usernameChk";
            this.usernameChk.Size = new System.Drawing.Size(285, 21);
            this.usernameChk.TabIndex = 3;
            this.usernameChk.Text = "Only contain character and number";
            this.usernameChk.Visible = false;
            // 
            // passwordChk
            // 
            this.passwordChk.AutoSize = true;
            this.passwordChk.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordChk.Location = new System.Drawing.Point(127, 285);
            this.passwordChk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordChk.Name = "passwordChk";
            this.passwordChk.Size = new System.Drawing.Size(91, 21);
            this.passwordChk.TabIndex = 4;
            this.passwordChk.Text = "Test Label";
            this.passwordChk.Visible = false;
            // 
            // ckbPassShow
            // 
            this.ckbPassShow.AutoSize = true;
            this.ckbPassShow.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPassShow.Location = new System.Drawing.Point(131, 399);
            this.ckbPassShow.Name = "ckbPassShow";
            this.ckbPassShow.Size = new System.Drawing.Size(164, 27);
            this.ckbPassShow.TabIndex = 5;
            this.ckbPassShow.Text = "Show Password";
            this.ckbPassShow.UseVisualStyleBackColor = true;
            this.ckbPassShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Rubik", 13.8F);
            this.password.ForeColor = System.Drawing.Color.DarkGray;
            this.password.Location = new System.Drawing.Point(131, 247);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(323, 35);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // confPass
            // 
            this.confPass.Font = new System.Drawing.Font("Rubik", 13.8F);
            this.confPass.ForeColor = System.Drawing.Color.DarkGray;
            this.confPass.Location = new System.Drawing.Point(131, 358);
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(323, 35);
            this.confPass.TabIndex = 2;
            this.confPass.Text = "Confirm Password";
            this.confPass.Enter += new System.EventHandler(this.confPass_Enter);
            this.confPass.Leave += new System.EventHandler(this.confPass_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(348, 525);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 19);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login Now";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Already have an account?";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ckbPassShow);
            this.Controls.Add(this.passwordChk);
            this.Controls.Add(this.usernameChk);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label usernameChk;
        private System.Windows.Forms.Label passwordChk;
        private System.Windows.Forms.CheckBox ckbPassShow;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

