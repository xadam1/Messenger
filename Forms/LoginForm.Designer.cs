﻿namespace Messenger.Forms
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.lblUsername.Location = new System.Drawing.Point(29, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.lblPass.Location = new System.Drawing.Point(29, 153);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(108, 24);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.textUsername.Location = new System.Drawing.Point(185, 105);
            this.textUsername.MaxLength = 50;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(291, 32);
            this.textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.textPassword.Location = new System.Drawing.Point(185, 150);
            this.textPassword.MaxLength = 50;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(291, 32);
            this.textPassword.TabIndex = 5;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.loginBtn.Location = new System.Drawing.Point(185, 205);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(79, 41);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // registerUserBtn
            // 
            this.registerUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerUserBtn.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.registerUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.registerUserBtn.Location = new System.Drawing.Point(185, 370);
            this.registerUserBtn.Name = "registerUserBtn";
            this.registerUserBtn.Size = new System.Drawing.Size(101, 41);
            this.registerUserBtn.TabIndex = 9;
            this.registerUserBtn.Text = "Register";
            this.registerUserBtn.UseVisualStyleBackColor = true;
            this.registerUserBtn.Click += new System.EventHandler(this.RegisterUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(181, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "You don\'t have account yet?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Log in to your account...";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(574, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerUserBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerUserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}