namespace WindowsFormsApp2
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
            this.textBoxF1Num = new System.Windows.Forms.TextBox();
            this.textBoxF1Denum = new System.Windows.Forms.TextBox();
            this.textBoxF2Num = new System.Windows.Forms.TextBox();
            this.textBoxF2Denum = new System.Windows.Forms.TextBox();
            this.textBoxF3 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1Num
            // 
            this.textBoxF1Num.Location = new System.Drawing.Point(12, 12);
            this.textBoxF1Num.Name = "textBoxF1Num";
            this.textBoxF1Num.Size = new System.Drawing.Size(64, 20);
            this.textBoxF1Num.TabIndex = 0;
            // 
            // textBoxF1Denum
            // 
            this.textBoxF1Denum.Location = new System.Drawing.Point(12, 41);
            this.textBoxF1Denum.Name = "textBoxF1Denum";
            this.textBoxF1Denum.Size = new System.Drawing.Size(64, 20);
            this.textBoxF1Denum.TabIndex = 1;
            // 
            // textBoxF2Num
            // 
            this.textBoxF2Num.Location = new System.Drawing.Point(163, 12);
            this.textBoxF2Num.Name = "textBoxF2Num";
            this.textBoxF2Num.Size = new System.Drawing.Size(64, 20);
            this.textBoxF2Num.TabIndex = 2;
            // 
            // textBoxF2Denum
            // 
            this.textBoxF2Denum.Location = new System.Drawing.Point(163, 44);
            this.textBoxF2Denum.Name = "textBoxF2Denum";
            this.textBoxF2Denum.Size = new System.Drawing.Size(64, 20);
            this.textBoxF2Denum.TabIndex = 3;
            // 
            // textBoxF3
            // 
            this.textBoxF3.Location = new System.Drawing.Point(82, 157);
            this.textBoxF3.Name = "textBoxF3";
            this.textBoxF3.Size = new System.Drawing.Size(75, 20);
            this.textBoxF3.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(82, 41);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstract.TabIndex = 7;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(82, 70);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(82, 99);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 23);
            this.buttonDivide.TabIndex = 9;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(82, 128);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 10;
            this.buttonMax.Text = "<>";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 188);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxF3);
            this.Controls.Add(this.textBoxF2Denum);
            this.Controls.Add(this.textBoxF2Num);
            this.Controls.Add(this.textBoxF1Denum);
            this.Controls.Add(this.textBoxF1Num);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1Num;
        private System.Windows.Forms.TextBox textBoxF1Denum;
        private System.Windows.Forms.TextBox textBoxF2Num;
        private System.Windows.Forms.TextBox textBoxF2Denum;
        private System.Windows.Forms.TextBox textBoxF3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMax;
    }
}