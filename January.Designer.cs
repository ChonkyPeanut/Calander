
namespace Calander
{
    partial class January
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
            this.Close = new System.Windows.Forms.Button();
            this.Impor_Jan = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.Button();
            this.Open_File = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(403, 24);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 55);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Impor_Jan
            // 
            this.Impor_Jan.Location = new System.Drawing.Point(0, 0);
            this.Impor_Jan.Name = "Impor_Jan";
            this.Impor_Jan.Size = new System.Drawing.Size(100, 23);
            this.Impor_Jan.TabIndex = 7;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(48, 146);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(477, 28);
            this.Import.TabIndex = 5;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click_1);
            // 
            // Open_File
            // 
            this.Open_File.Location = new System.Drawing.Point(48, 112);
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(477, 28);
            this.Open_File.TabIndex = 6;
            this.Open_File.Text = "Open File";
            this.Open_File.UseVisualStyleBackColor = true;
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(479, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // January
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.Open_File);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Impor_Jan);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "January";
            this.Text = "January";
            this.Load += new System.EventHandler(this.January_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Impor_Jan;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Open_File;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}