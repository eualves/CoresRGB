
namespace CoresRGB
{
    partial class CoresRGB
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblNumRed = new System.Windows.Forms.Label();
            this.lblNumGreen = new System.Windows.Forms.Label();
            this.lblNumBlue = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.lblPainel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paleta de Cores";
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(225, 128);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(60, 25);
            this.lblRed.TabIndex = 1;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(225, 170);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(60, 25);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(225, 213);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(60, 25);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNumRed
            // 
            this.lblNumRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumRed.Location = new System.Drawing.Point(304, 128);
            this.lblNumRed.Name = "lblNumRed";
            this.lblNumRed.Size = new System.Drawing.Size(60, 25);
            this.lblNumRed.TabIndex = 4;
            this.lblNumRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumRed.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNumGreen
            // 
            this.lblNumGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumGreen.Location = new System.Drawing.Point(304, 170);
            this.lblNumGreen.Name = "lblNumGreen";
            this.lblNumGreen.Size = new System.Drawing.Size(60, 25);
            this.lblNumGreen.TabIndex = 5;
            this.lblNumGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumGreen.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNumBlue
            // 
            this.lblNumBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumBlue.Location = new System.Drawing.Point(304, 213);
            this.lblNumBlue.Name = "lblNumBlue";
            this.lblNumBlue.Size = new System.Drawing.Size(60, 25);
            this.lblNumBlue.TabIndex = 6;
            this.lblNumBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumBlue.Click += new System.EventHandler(this.label7_Click);
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(398, 128);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Minimum = 1;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(175, 25);
            this.hScrollBarRed.TabIndex = 7;
            this.hScrollBarRed.Value = 1;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(398, 170);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Minimum = 1;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(175, 25);
            this.hScrollBarGreen.TabIndex = 8;
            this.hScrollBarGreen.Value = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(398, 213);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Minimum = 1;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(175, 25);
            this.hScrollBarBlue.TabIndex = 9;
            this.hScrollBarBlue.Value = 1;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // lblPainel
            // 
            this.lblPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPainel.Location = new System.Drawing.Point(225, 266);
            this.lblPainel.Name = "lblPainel";
            this.lblPainel.Size = new System.Drawing.Size(348, 81);
            this.lblPainel.TabIndex = 10;
            // 
            // CoresRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPainel);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lblNumBlue);
            this.Controls.Add(this.lblNumGreen);
            this.Controls.Add(this.lblNumRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoresRGB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores em RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblNumRed;
        private System.Windows.Forms.Label lblNumGreen;
        private System.Windows.Forms.Label lblNumBlue;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label lblPainel;
    }
}

