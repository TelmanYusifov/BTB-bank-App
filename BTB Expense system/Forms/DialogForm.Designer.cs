﻿namespace BTB_Expense_system.Forms
{
    partial class DialogForm
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
            this.lbl_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errors.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errors.Location = new System.Drawing.Point(13, 13);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(86, 29);
            this.lbl_errors.TabIndex = 0;
            this.lbl_errors.Text = "label1";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.lbl_errors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_errors;
    }
}