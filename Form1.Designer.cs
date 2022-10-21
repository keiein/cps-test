namespace cps_test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerCounter = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clickButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickButton.Location = new System.Drawing.Point(273, 188);
            this.clickButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(412, 360);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Clicks: 0 ";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(316, 85);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(323, 98);
            this.title.TabIndex = 1;
            this.title.Text = "CPS Test";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerCounter
            // 
            this.timerCounter.AutoSize = true;
            this.timerCounter.Location = new System.Drawing.Point(443, 163);
            this.timerCounter.Name = "timerCounter";
            this.timerCounter.Size = new System.Drawing.Size(65, 20);
            this.timerCounter.TabIndex = 2;
            this.timerCounter.Text = "Time: 10";
            this.timerCounter.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max CPS: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 668);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reset Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(951, 712);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timerCounter);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicks Per Second Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerCounter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

