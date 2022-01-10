
namespace Calander
{
    partial class Menu
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
            this.Login_Button = new System.Windows.Forms.Button();
            this.CreateAccount_Button = new System.Windows.Forms.Button();
            this.Password_login = new System.Windows.Forms.TextBox();
            this.Username_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(72, 272);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(116, 57);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // CreateAccount_Button
            // 
            this.CreateAccount_Button.Location = new System.Drawing.Point(194, 272);
            this.CreateAccount_Button.Name = "CreateAccount_Button";
            this.CreateAccount_Button.Size = new System.Drawing.Size(116, 57);
            this.CreateAccount_Button.TabIndex = 1;
            this.CreateAccount_Button.Text = "Create Account";
            this.CreateAccount_Button.UseVisualStyleBackColor = true;
            // 
            // Password_login
            // 
            this.Password_login.Location = new System.Drawing.Point(72, 243);
            this.Password_login.Name = "Password_login";
            this.Password_login.Size = new System.Drawing.Size(237, 23);
            this.Password_login.TabIndex = 2;
            // 
            // Username_login
            // 
            this.Username_login.Location = new System.Drawing.Point(72, 199);
            this.Username_login.Name = "Username_login";
            this.Username_login.Size = new System.Drawing.Size(237, 23);
            this.Username_login.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 42.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(74, 87);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(252, 76);
            this.Title.TabIndex = 6;
            this.Title.Text = "Planner ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username_login);
            this.Controls.Add(this.Password_login);
            this.Controls.Add(this.CreateAccount_Button);
            this.Controls.Add(this.Login_Button);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button CreateAccount_Button;
        private System.Windows.Forms.TextBox Password_login;
        private System.Windows.Forms.TextBox Username_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
    }
}