﻿namespace Curs_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnDIJKSTRA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 661);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Location = new System.Drawing.Point(924, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 229);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(924, 277);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 264);
            this.listBox2.TabIndex = 2;
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(1197, 277);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(102, 43);
            this.btnBFS.TabIndex = 3;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(1317, 277);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(102, 43);
            this.btnDFS.TabIndex = 4;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnDIJKSTRA
            // 
            this.btnDIJKSTRA.Location = new System.Drawing.Point(1456, 277);
            this.btnDIJKSTRA.Name = "btnDIJKSTRA";
            this.btnDIJKSTRA.Size = new System.Drawing.Size(96, 43);
            this.btnDIJKSTRA.TabIndex = 5;
            this.btnDIJKSTRA.Text = "DIJKSTRA";
            this.btnDIJKSTRA.UseVisualStyleBackColor = true;
            this.btnDIJKSTRA.Click += new System.EventHandler(this.btnDIJKSTRA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 685);
            this.Controls.Add(this.btnDIJKSTRA);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnBFS;
        private Button btnDFS;
        private Button btnDIJKSTRA;
    }
}