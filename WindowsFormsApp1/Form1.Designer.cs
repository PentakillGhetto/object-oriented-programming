namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDrawLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawTriangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDrawPine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOuterColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInnerColor = new System.Windows.Forms.ToolStripButton();
            this.panelDrawingArea = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButtonDrawLine,
            this.toolStripButtonDrawCircle,
            this.toolStripButtonDrawRectangle,
            this.toolStripButtonDrawTriangle,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripButtonDrawPine,
            this.toolStripSeparator5,
            this.toolStripButtonOuterColor,
            this.toolStripButtonInnerColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Figures";
            // 
            // toolStripButtonDrawLine
            // 
            this.toolStripButtonDrawLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawLine.Image")));
            this.toolStripButtonDrawLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawLine.Name = "toolStripButtonDrawLine";
            this.toolStripButtonDrawLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDrawLine.Text = "toolStripButtonDrawLine";
            this.toolStripButtonDrawLine.Click += new System.EventHandler(this.ToolStripButtonDrawLine_Click);
            // 
            // toolStripButtonDrawCircle
            // 
            this.toolStripButtonDrawCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawCircle.Image")));
            this.toolStripButtonDrawCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawCircle.Name = "toolStripButtonDrawCircle";
            this.toolStripButtonDrawCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDrawCircle.Text = "toolStripButtonDrawCircle";
            this.toolStripButtonDrawCircle.Click += new System.EventHandler(this.ToolStripButtonDrawCircle_Click);
            // 
            // toolStripButtonDrawRectangle
            // 
            this.toolStripButtonDrawRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawRectangle.Image")));
            this.toolStripButtonDrawRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawRectangle.Name = "toolStripButtonDrawRectangle";
            this.toolStripButtonDrawRectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDrawRectangle.Text = "toolStripButton1";
            this.toolStripButtonDrawRectangle.Click += new System.EventHandler(this.ToolStripButtonDrawRectangle_Click);
            // 
            // toolStripButtonDrawTriangle
            // 
            this.toolStripButtonDrawTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawTriangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawTriangle.Image")));
            this.toolStripButtonDrawTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawTriangle.Name = "toolStripButtonDrawTriangle";
            this.toolStripButtonDrawTriangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDrawTriangle.Text = "toolStripButton1";
            this.toolStripButtonDrawTriangle.ToolTipText = "toolStripButtonDrawTriangle";
            this.toolStripButtonDrawTriangle.Click += new System.EventHandler(this.ToolStripButtonDrawTriangle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel3.Text = "Complex";
            // 
            // toolStripButtonDrawPine
            // 
            this.toolStripButtonDrawPine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawPine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawPine.Image")));
            this.toolStripButtonDrawPine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawPine.Name = "toolStripButtonDrawPine";
            this.toolStripButtonDrawPine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDrawPine.Text = "toolStripButton1";
            this.toolStripButtonDrawPine.Click += new System.EventHandler(this.ToolStripButtonDrawPine_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOuterColor
            // 
            this.toolStripButtonOuterColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOuterColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOuterColor.Image")));
            this.toolStripButtonOuterColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOuterColor.Name = "toolStripButtonOuterColor";
            this.toolStripButtonOuterColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOuterColor.Click += new System.EventHandler(this.ToolStripButtonOuterColor_Click);
            // 
            // toolStripButtonInnerColor
            // 
            this.toolStripButtonInnerColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInnerColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInnerColor.Image")));
            this.toolStripButtonInnerColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInnerColor.Name = "toolStripButtonInnerColor";
            this.toolStripButtonInnerColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInnerColor.Click += new System.EventHandler(this.ToolStripButtonInnerColor_Click);
            // 
            // panelDrawingArea
            // 
            this.panelDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawingArea.Location = new System.Drawing.Point(0, 25);
            this.panelDrawingArea.Name = "panelDrawingArea";
            this.panelDrawingArea.Size = new System.Drawing.Size(765, 465);
            this.panelDrawingArea.TabIndex = 15;
            this.panelDrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrawingArea_MouseDown);
            this.panelDrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrawingArea_MouseMove);
            this.panelDrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDrawingArea_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 490);
            this.Controls.Add(this.panelDrawingArea);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawRectangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panelDrawingArea;
        private System.Windows.Forms.ToolStripButton toolStripButtonOuterColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonInnerColor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawTriangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawPine;
    }
}

