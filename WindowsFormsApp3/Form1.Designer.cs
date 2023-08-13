namespace WindowsFormsApp3
{
    partial class Form1
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
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonSetDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.Location = new System.Drawing.Point(14, 38);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(100, 18);
            this.labelCurrentDate.TabIndex = 0;
            this.labelCurrentDate.Text = "label1";
            this.labelCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Location = new System.Drawing.Point(12, 12);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(102, 23);
            this.buttonNextDay.TabIndex = 1;
            this.buttonNextDay.Text = "Next day";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 59);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(30, 20);
            this.textBoxDay.TabIndex = 2;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(48, 59);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(30, 20);
            this.textBoxMonth.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(84, 59);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(30, 20);
            this.textBoxYear.TabIndex = 4;
            // 
            // buttonSetDate
            // 
            this.buttonSetDate.Location = new System.Drawing.Point(12, 85);
            this.buttonSetDate.Name = "buttonSetDate";
            this.buttonSetDate.Size = new System.Drawing.Size(102, 23);
            this.buttonSetDate.TabIndex = 5;
            this.buttonSetDate.Text = "Set date";
            this.buttonSetDate.UseVisualStyleBackColor = true;
            this.buttonSetDate.Click += new System.EventHandler(this.buttonSetDate_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 118);
            this.Controls.Add(this.buttonSetDate);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.buttonNextDay);
            this.Controls.Add(this.labelCurrentDate);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonSetDate;
    }
}