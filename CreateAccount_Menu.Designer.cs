
namespace Calander
{
    partial class CreateAccount_Menu
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
            this.Create_Account_Submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Account_Submit
            // 
            this.Create_Account_Submit.Location = new System.Drawing.Point(112, 281);
            this.Create_Account_Submit.Name = "Create_Account_Submit";
            this.Create_Account_Submit.Size = new System.Drawing.Size(178, 73);
            this.Create_Account_Submit.TabIndex = 0;
            this.Create_Account_Submit.Text = "Create Account";
            this.Create_Account_Submit.UseVisualStyleBackColor = true;
            this.Create_Account_Submit.Click += new System.EventHandler(this.Create_Account_Submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(112, 190);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(63, 15);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(112, 234);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(60, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(300, 378);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(118, 60);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CreateAccount_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Create_Account_Submit);
            this.Name = "CreateAccount_Menu";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Account_Submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close;
    }
}