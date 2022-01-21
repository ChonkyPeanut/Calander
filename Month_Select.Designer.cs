
namespace Calander
{
    partial class Month_Select
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
            this.January = new System.Windows.Forms.Button();
            this.Febuary = new System.Windows.Forms.Button();
            this.March = new System.Windows.Forms.Button();
            this.April = new System.Windows.Forms.Button();
            this.May = new System.Windows.Forms.Button();
            this.June = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // January
            // 
            this.January.Location = new System.Drawing.Point(45, 15);
            this.January.Name = "January";
            this.January.Size = new System.Drawing.Size(159, 81);
            this.January.TabIndex = 0;
            this.January.Text = "January";
            this.January.UseVisualStyleBackColor = true;
            this.January.Click += new System.EventHandler(this.January_Click);
            // 
            // Febuary
            // 
            this.Febuary.Location = new System.Drawing.Point(242, 15);
            this.Febuary.Name = "Febuary";
            this.Febuary.Size = new System.Drawing.Size(159, 81);
            this.Febuary.TabIndex = 1;
            this.Febuary.Text = "Febuary";
            this.Febuary.UseVisualStyleBackColor = true;
            this.Febuary.Click += new System.EventHandler(this.Febuary_Click);
            // 
            // March
            // 
            this.March.Location = new System.Drawing.Point(45, 129);
            this.March.Name = "March";
            this.March.Size = new System.Drawing.Size(159, 81);
            this.March.TabIndex = 2;
            this.March.Text = "March";
            this.March.UseVisualStyleBackColor = true;
            this.March.Click += new System.EventHandler(this.March_Click);
            // 
            // April
            // 
            this.April.Location = new System.Drawing.Point(242, 129);
            this.April.Name = "April";
            this.April.Size = new System.Drawing.Size(159, 81);
            this.April.TabIndex = 3;
            this.April.Text = "April";
            this.April.UseVisualStyleBackColor = true;
            this.April.Click += new System.EventHandler(this.April_Click);
            // 
            // May
            // 
            this.May.Location = new System.Drawing.Point(45, 255);
            this.May.Name = "May";
            this.May.Size = new System.Drawing.Size(159, 81);
            this.May.TabIndex = 4;
            this.May.Text = "May";
            this.May.UseVisualStyleBackColor = true;
            this.May.Click += new System.EventHandler(this.May_Click);
            // 
            // June
            // 
            this.June.Location = new System.Drawing.Point(242, 255);
            this.June.Name = "June";
            this.June.Size = new System.Drawing.Size(159, 81);
            this.June.TabIndex = 5;
            this.June.Text = "June";
            this.June.UseVisualStyleBackColor = true;
            this.June.Click += new System.EventHandler(this.June_Click);
            // 
            // Month_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.June);
            this.Controls.Add(this.May);
            this.Controls.Add(this.April);
            this.Controls.Add(this.March);
            this.Controls.Add(this.Febuary);
            this.Controls.Add(this.January);
            this.Name = "Month_Select";
            this.Text = "Month_Select";
            this.Load += new System.EventHandler(this.Month_Select_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button January;
        private System.Windows.Forms.Button Febuary;
        private System.Windows.Forms.Button March;
        private System.Windows.Forms.Button April;
        private System.Windows.Forms.Button May;
        private System.Windows.Forms.Button June;
    }
}