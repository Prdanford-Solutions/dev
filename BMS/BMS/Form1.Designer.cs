﻿namespace BMS
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
            this.txtTextToSpeak = new System.Windows.Forms.TextBox();
            this.btnSayIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextToSpeak
            // 
            this.txtTextToSpeak.Location = new System.Drawing.Point(241, 103);
            this.txtTextToSpeak.Name = "txtTextToSpeak";
            this.txtTextToSpeak.Size = new System.Drawing.Size(293, 20);
            this.txtTextToSpeak.TabIndex = 1;
            // 
            // btnSayIt
            // 
            this.btnSayIt.Location = new System.Drawing.Point(241, 166);
            this.btnSayIt.Name = "btnSayIt";
            this.btnSayIt.Size = new System.Drawing.Size(75, 23);
            this.btnSayIt.TabIndex = 2;
            this.btnSayIt.Text = "Say It!";
            this.btnSayIt.UseVisualStyleBackColor = true;
            this.btnSayIt.Click += new System.EventHandler(this.btnSayIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayIt);
            this.Controls.Add(this.txtTextToSpeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToSpeak;
        private System.Windows.Forms.Button btnSayIt;
    }
}

